using PostSharp.Patterns.Contracts;

namespace ReadMyHosts.Core.Models

{
    public class Host
    {
        #region Public Properties
        public byte[] FullIp { get; set; } = new byte[4];

        [Required]
        public string FullIpText { get; set; }

        [Required]
        public int HostId { get; set; }

        [Required]
        public string HostName { get; set; }

        [Required]
        public bool IsEnabled { get; set; }

        #endregion Public Properties
    }
}
