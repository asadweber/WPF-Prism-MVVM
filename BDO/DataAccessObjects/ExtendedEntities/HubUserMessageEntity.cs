using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using BDO.CustomAnnotation;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "HubUserMessageEntity", Namespace = "http://www.KAF.com/types")]
    public class HubUserMessageEntity
    {
        protected string _MessageId;
        [DataMember]
        public string MessageId
        {
            get { return _MessageId; }
            set { _MessageId = value; }
        }

        protected string _FromUserId;
        [DataMember]
        public string FromUserId
        {
            get { return _FromUserId; }
            set { _FromUserId = value; }
        }

        protected string _ToUserId;
        [DataMember]
        public string ToUserId
        {
            get { return _ToUserId; }
            set { _ToUserId = value; }
        }

        protected string _FromUserEmail;
        [DataMember]
        public string FromUserEmail
        {
            get { return _FromUserEmail; }
            set { _FromUserEmail = value; }
        }

        protected string _ToUserEmail;
        [DataMember]
        public string ToUserEmail
        {
            get { return _ToUserEmail; }
            set { _ToUserEmail = value; }
        }

        protected string _FromConnectionId;
        [DataMember]
        public string FromConnectionId
        {
            get { return _FromConnectionId; }
            set { _FromConnectionId = value; }
        }

        protected string _ToConnectionId;
        [DataMember]
        public string ToConnectionId
        {
            get { return _ToConnectionId; }
            set { _ToConnectionId = value; }
        }

        protected string _Message;
        [DataMember]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        protected byte?[] _Img;
        [DataMember]
        public byte?[]  Imgessage
        {
            get { return _Img; }
            set { _Img = value; }
        }

        public HubUserMessageEntity()
        {
        }
    }
}
