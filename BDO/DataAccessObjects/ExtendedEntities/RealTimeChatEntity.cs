
using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "RealTimeChatEntity", Namespace = "http://www.KAF.com/types")]
    public class RealTimeChatEntity : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [DataMember]
        [BsonElement("fromuserid")]
        [JsonProperty("fromuserid")]
        public string fromuserid { get; set; }
        [DataMember]
        [BsonElement("fromusername")]
        [JsonProperty("fromusername")]
        public string fromusername { get; set; }
        [DataMember]
        [BsonElement("touserid")]
        [JsonProperty("touserid")]
        public string touserid { get; set; }
        [DataMember]
        [BsonElement("touserid")]
        [JsonProperty("touserid")]
        public string tousername { get; set; }
        [DataMember]
        [BsonElement("message")]
        [JsonProperty("message")]
        public string message { get; set; }

    }
}
