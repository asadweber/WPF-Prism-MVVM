namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class FtpServerSetting
	{
        public string uploadftpurl { get; set; }
        public string readfileurl { get; set; }
        public string ftpuser { get; set; }
		public string ftpuserpassword { get; set; }
		public bool IsSSL { get; set; }

	}



}
