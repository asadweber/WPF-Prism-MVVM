using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    public class MongoDBSettingsSignalRServices
    {
        public string ConnectionString { get; set; } = null!;
        public string CoreSignalRDatabaseName { get; set; } = null!;
        public string MessageCollection { get; set; } = null!;
        public string ChatCollection { get; set; } = null!;
        public string OnlineUserCollection { get; set; } = null!;
        public string OnlineUserCollectionWPF { get; set; } = null!;
        public string MailAttachmentViewCounterCollection { get; set; } = null!;
        public string OnlineQRUserCollection { get; set; } = null!;
        public string OnlineCivilUserCollection { get; set; } = null!;
    }
}
