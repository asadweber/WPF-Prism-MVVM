using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public long AccessTokenExpiration { get; set; }
        public long RefreshTokenExpiration { get; set; }
    }
}
