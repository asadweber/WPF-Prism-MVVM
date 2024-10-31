using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Base
{
    public class SahilAccesstoken
    {
        public Accesstoken accessToken { get; set; }
        public string refreshToken { get; set; }
        public int expiresIn { get; set; }
        public bool success { get; set; }
        public class Accesstoken
        {
            public string token { get; set; }
            public int expiresIn { get; set; }
        }
    }

}
