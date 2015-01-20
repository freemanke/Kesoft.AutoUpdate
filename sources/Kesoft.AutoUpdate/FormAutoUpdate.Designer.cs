namespace Kesoft.AutoUpdate
{
    partial class FormAutoUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoUpdate));
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.wp1 = new AeroWizard.WizardPage();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pbrCheck = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelButtonText = "取消";
            this.wizardControl1.FinishButtonText = "完成";
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextButtonText = "下一步";
            this.wizardControl1.Pages.Add(this.wp1);
            this.wizardControl1.Size = new System.Drawing.Size(584, 361);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "自动更新";
            this.wizardControl1.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("wizardControl1.TitleIcon")));
            // 
            // wp1
            // 
            this.wp1.Controls.Add(this.btnDownload);
            this.wp1.Controls.Add(this.btnCheck);
            this.wp1.Controls.Add(this.pbrCheck);
            this.wp1.Controls.Add(this.lblMessage);
            this.wp1.Controls.Add(this.pbxImage);
            this.wp1.Name = "wp1";
            this.wp1.Size = new System.Drawing.Size(537, 208);
            this.wp1.TabIndex = 0;
            this.wp1.Text = "检查更新";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(180, 8);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 27);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "下载更新";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(74, 8);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 27);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "检查更新";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // pbrCheck
            // 
            this.pbrCheck.Location = new System.Drawing.Point(4, 183);
            this.pbrCheck.Name = "pbrCheck";
            this.pbrCheck.Size = new System.Drawing.Size(528, 22);
            this.pbrCheck.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbrCheck.TabIndex = 1;
            this.pbrCheck.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(75, 43);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(163, 15);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "请点击检查按钮检查新版本";
            // 
            // pbxImage
            // 
            this.pbxImage.BackgroundImage = global::Kesoft.AutoUpdate.Properties.Resources.Update;
            this.pbxImage.Location = new System.Drawing.Point(4, 4);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(64, 64);
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // FormAutoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.wizardControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutoUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动更新";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wp1.ResumeLayout(false);
            this.wp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage wp1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar pbrCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnDownload;

    }
}

