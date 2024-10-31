using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using BDO.CustomAnnotation;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using BDO.Core.DataAccessObjects.SecurityModels;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "HubUserContextEntity", Namespace = "http://www.KAF.com/types")]
    public class HubUserContextEntity
    {
        protected string _TemIdentifierCode;

        [DataMember]
        public string TemIdentifierCode
        {
            get { return _TemIdentifierCode; }
            set { _TemIdentifierCode = value; }
        }


        protected owin_userEntity _userProfile;

        [DataMember]
        public owin_userEntity userProfile
        {
            get { return _userProfile; }
            set { _userProfile = value; }
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DataMember]
        public string Id { get; set; }

        protected string _UserIP;

        [DataMember]
        public string UserIP
        {
            get { return _UserIP; }
            set { _UserIP = value; }
        }

        protected string _UserName;

        [DataMember]
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        protected string _UserId;

        [DataMember]
        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        protected string _UserEmail;

        [DataMember]
        public string UserEmail
        {
            get { return _UserEmail; }
            set { _UserEmail = value; }
        }
        protected string _ConnectionId;

        [DataMember]
        public string ConnectionId
        {
            get { return _ConnectionId; }
            set { _ConnectionId = value; }
        }

        protected DateTime _LoggedInTime;
        [DataMember]
        public DateTime LoggedInTime
        {
            get { return _LoggedInTime; }
            set { _LoggedInTime = value; }
        }

        protected long? _PKeyEX;

        [DataMember]
        public long? PKeyEX
        {
            get { return _PKeyEX; }
            set { _PKeyEX = value; }
        }
        public HubUserContextEntity()
        {
        }
    }





    [Serializable]
    [DataContract(Name = "HubQRUserContextEntity", Namespace = "http://www.KAF.com/types")]
    public class HubQRUserContextEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DataMember]
        public string Id { get; set; }

        protected string _TemIdentifierCode;

        [DataMember]
        public string TemIdentifierCode
        {
            get { return _TemIdentifierCode; }
            set { _TemIdentifierCode = value; }
        }


        protected string _ConnectionId;

        [DataMember]
        public string ConnectionId
        {
            get { return _ConnectionId; }
            set { _ConnectionId = value; }
        }


        protected string _ResponseCode;

        [DataMember]
        public string ResponseCode
        {
            get { return _ResponseCode; }
            set { _ResponseCode = value; }
        }


        protected DateTime _LoggedInTime;
        [DataMember]
        public DateTime LoggedInTime
        {
            get { return _LoggedInTime; }
            set { _LoggedInTime = value; }
        }

        protected long? _PKeyEX;

        [DataMember]
        public long? PKeyEX
        {
            get { return _PKeyEX; }
            set { _PKeyEX = value; }
        }

        public HubQRUserContextEntity()
        {
        }
    }


    [Serializable]
    [DataContract(Name = "HubCivilUserContextEntity", Namespace = "http://www.KAF.com/types")]
    public class HubCivilUserContextEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DataMember]
        public string Id { get; set; }

        protected string _CivilID;

        [DataMember]
        public string CivilID
        {
            get { return _CivilID; }
            set { _CivilID = value; }
        }

        protected string _TemIdentifierCode;

        [DataMember]
        public string TemIdentifierCode
        {
            get { return _TemIdentifierCode; }
            set { _TemIdentifierCode = value; }
        }

        protected string _ResponseCode;

        [DataMember]
        public string ResponseCode
        {
            get { return _ResponseCode; }
            set { _ResponseCode = value; }
        }


        protected string _ConnectionId;

        [DataMember]
        public string ConnectionId
        {
            get { return _ConnectionId; }
            set { _ConnectionId = value; }
        }

        protected DateTime _LoggedInTime;
        [DataMember]
        public DateTime LoggedInTime
        {
            get { return _LoggedInTime; }
            set { _LoggedInTime = value; }
        }

        protected long? _PKeyEX;

        [DataMember]
        public long? PKeyEX
        {
            get { return _PKeyEX; }
            set { _PKeyEX = value; }
        }
        public HubCivilUserContextEntity()
        {
        }
    }

}
