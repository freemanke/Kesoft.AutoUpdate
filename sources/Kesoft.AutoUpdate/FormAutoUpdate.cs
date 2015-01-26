using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace Kesoft.AutoUpdate
{
    public partial class FormAutoUpdate : Form
    {
        private readonly string name;
        private Software[] infoes;
        private readonly string currentVersion;

        /// <summary>
        /// 构造方法。
        /// </summary>
        /// <param name="name">软件名称。</param>
        /// <param name="currentVersion">当前软件版本。</param>
        public FormAutoUpdate(string name, string currentVersion)
        {
            InitializeComponent();

            this.name = name;
            this.currentVersion = currentVersion;
            btnCheck.Click += btnCheck_Click;
            wizardControl1.Finished += (a, b) => Close();
            wizardControl1.Cancelling += (a, b) => Close();
            btnDownload.Click += btnDownload_Click;
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            pbrCheck.Visible = true;
            btnCheck.Enabled = false;
            btnDownload.Visible = false;
            lblMessage.Text = "正在检查更新信息...";
            try
            {
                var client = new RestClient("http://kesoft.net/Software/GetUpdates?name="+name);
                client.DefaultParameters[0] = new Parameter {Name = "Accept", Value = "application/json"};
                var request = new RestRequest(Method.GET);
                var response = await Task.Run(() => client.Execute(request));
                infoes = JsonConvert.DeserializeObject<Software[]>(response.Content);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    lblMessage.Text = string.Format("获取更新信息失败，请检查网络！");
                    btnCheck.Enabled = true;
                }
                var info = infoes.First();
                if (info.Version.ToLower() == currentVersion.ToLower())
                {
                    lblMessage.Text = string.Format("当前 {0} 已经是最新版本，无需更新！", currentVersion);
                }
                else
                {
                    btnDownload.Visible = true;
                    btnDownload.Focus();
                    lblMessage.Text = string.Format("有新版本 {0}，请点击“下载更新”按钮开始下载！", info.Version);
                }

                btnCheck.Enabled = true;
            }
            catch (Exception)
            {
                lblMessage.Text = string.Format("检查更新文件信息失败，请稍后重试！");
                btnCheck.Visible = true;
            }
            finally
            {
                btnCheck.Enabled = true;
                pbrCheck.Visible = false;
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "正在下载更新文件，请耐心等待...";
            btnDownload.Enabled = false;
            btnCheck.Enabled = false;
            pbrCheck.Visible = true;
            try
            {
                var info = infoes.First();
                var fileName = info.DownloadUrl.Substring(info.DownloadUrl.LastIndexOf("/", StringComparison.Ordinal) + 1);
                var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var filePath = Path.Combine(path, fileName);
                if (!File.Exists(filePath))
                {
                    var dlClient = new RestClient(info.DownloadUrl);
                    dlClient.DefaultParameters[0] = new Parameter {Name = "Accept", Value = "application/octet-stream"};

                    var r = (await Task.Run(() => dlClient.Execute(new RestRequest(Method.GET))));
                    if (r.StatusCode != HttpStatusCode.OK)
                    {
                        lblMessage.Text = "下载更新文件失败，请稍后重试。";
                        return;
                    }

                    File.WriteAllBytes(filePath, r.RawBytes);
                }

                lblMessage.Text = "下载更新文件完成。";
                Process.Start(new ProcessStartInfo {FileName = filePath,});
                Close();
            }
            catch (Exception)
            {
                lblMessage.Text = "下载更新文件失败，请稍后重试。";
            }
            finally
            {
                btnCheck.Enabled = true;
                btnDownload.Enabled = true;
                pbrCheck.Visible = false;
            }
        }
    }
}