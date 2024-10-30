using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class FtpSettings
    {
        public string FtpAddress { get; set; }
        public string httpAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IsSSL { get; set; }
    }
}
