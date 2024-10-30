using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;


namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class HostingDomainSettings
    {

        public bool? IsSSLRequired { get; set; } = false;
        public string Domain { get; set; } = "localhost";
        public string SubDomain { get; set; } = "";
        public string Slug { get; set; } = "";
        public bool IsPortRequired { get; set; } = false;
        public string SSLPort { get; set; } = "443";
        public string Port { get; set; } = "80";


        public string SignalRContextName { get; set; } = "";
        public string SignalRContextNameQR { get; set; } = "";
        public string SignalRContextNameCivil { get; set; } = "";

        public string UploadFolderRoot { get; set; }

        public string NoImageLocation { get; set; }

        private string _CompleteDomainURL;
		private string _knsFrontAddress;

		public string CompleteDomainURL { get => _CompleteDomainURL; set => _CompleteDomainURL = value; }
		//public string CompleteDomainURL
		//{
		//    get
		//    {
		//        var port = string.Empty;
		//        var protocol = string.Empty;
		//        var subDomain = string.Empty;
		//        var slug = string.Empty;
		//        protocol = IsSSLRequired.GetValueOrDefault(false) == true ? "https://" : "http://";
		//        subDomain = SubDomain == "" ? string.Empty : SubDomain + ".";
		//        port = IsPortRequired == true ? ":" + (IsSSLRequired == true ? SSLPort : Port) : string.Empty;
		//        slug = Slug == "" ? "/" : "/" + Slug + "/";
		//        _CompleteDomainURL = protocol + subDomain + Domain + port + slug;
		//        return _CompleteDomainURL;
		//    }
		//}
		public string KnsFrontAddress { get => _knsFrontAddress; set => _knsFrontAddress = value; }

	}
}
