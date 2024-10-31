using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    public class KAFPaciServiceSettings
    {
        public string WebApiAddress { get; set; }
        public string ApplicationId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsEnable { get; set; }

    }
}
