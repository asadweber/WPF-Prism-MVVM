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



        private string _CompleteDomainURL;

//#if DEBUG
        public string CompleteDomainURL { get => _CompleteDomainURL; set => _CompleteDomainURL = value; }
//#else
//        public string CompleteDomainURL 
//           {
//            get
//            {
//                var port = string.Empty;
//                var protocol = string.Empty;
//                var subDomain = string.Empty;
//                var slug = string.Empty;
//                protocol = IsSSLRequired.GetValueOrDefault(false) == true ? "https://" : "http://";
//                subDomain = SubDomain == "" ? string.Empty : SubDomain + ".";
//                port = IsPortRequired == true ? ":" + (IsSSLRequired == true ? SSLPort : Port) : string.Empty;
//                slug = Slug == "" ? "/" : "/" + Slug + "/";
//                _CompleteDomainURL = protocol + subDomain + Domain + port + slug;
//                return _CompleteDomainURL;
//            }
//        }
//#endif




        private string _SignalRServiceURLWithContext;
        public string SignalRServiceURLWithContext
        {
            get
            {
                _SignalRServiceURLWithContext = _CompleteDomainURL + SignalRContextName;
                return _SignalRServiceURLWithContext;
            }
        }

        private string _SignalRServiceURLWithContextQR;
       

        public string SignalRServiceURLWithContextQR
        {
            get
            {
                _SignalRServiceURLWithContextQR = _CompleteDomainURL;
                return _SignalRServiceURLWithContextQR;
            }
        }
    }
}
