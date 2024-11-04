using System;
using System.Collections.Generic;
using System.Text;

namespace KAF.Service.Proxy.Dto
{
    public sealed class AccessTokenDto
    {
        public string Token { get; set; }
        public int ExpiresIn { get; set; }

        public string RefreshToken { get; set; }

       
    }
}
