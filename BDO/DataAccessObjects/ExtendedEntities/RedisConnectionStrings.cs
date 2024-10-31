using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class RedisConnectionStrings
    {
        public string redisServerUrl { get; set; }

        public string redisDBColPrefix { get; set; }
        public string redisSessionCookieName { get; set; }
        public int IdleTimeout { get; set; }
        public bool HttpOnly { get; set; }
        public bool AllowAdmin { get; set; }
        public bool Ssl { get; set; }
        public int ConnectRetry { get; set; }

        public int DatabaseID { get; set; }
        public string ServiceName { get; set; }

    }
}
