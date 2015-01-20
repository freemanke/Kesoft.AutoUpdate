using System;

namespace Kesoft.AutoUpdate
{
    /// <summary>
    /// 软件信息类。
    /// </summary>
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Decription { get; set; }
        public string DownloadUrl { get; set; }
        public string FileName { get; set; }
        public DateTime PublishTime { get; set; }
        public bool IsForcedUpdated { get; set; }
    }
}