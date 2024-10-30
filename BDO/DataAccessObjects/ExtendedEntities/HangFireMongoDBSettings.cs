using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
	public class HangFireMongoDBSettings
	{
		public string ConnectionString { get; set; }
		public string HangFireDatabaseName { get; set; }
        public bool Enable { get; set; }
    }
}
