using BDO.Core.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class MilShortInfoEntity : BaseEntity
    {
        private bool _isSecretary;

        [DataMember]
        public long? officerid { get; set; }
        [DataMember]
        public string militarytype { get; set; }
        [DataMember]
        public string officertype { get; set; }
        [DataMember]
        public long? militarynumber { get; set; }
        [DataMember]
        public long? militaryinfoid { get; set; }
        [DataMember]
        public long? hrbasicid { get; set; }
        [DataMember]
        public long? militaryno { get; set; }
        [DataMember]
        public string rankname { get; set; }
        [DataMember]
        public string ranktype { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public DateTime? birthdate { get; set; }
        [DataMember]
        public long? civilid { get; set; }
        [DataMember]
        public DateTime? joindate { get; set; }

        [DataMember]
        public DateTime? tojoindate { get; set; }
        [DataMember]
        public long? batchno { get; set; }
        [DataMember]
        public long? senno { get; set; }
        [DataMember]
        public Guid userid { get; set; }
        [DataMember]
        public long? militarytypeid { get; set; }
        [DataMember]
        public long? rankid { get; set; }
        [DataMember]
        public long? ranktypeid { get; set; }
        [DataMember]
        public long? currententitykey { get; set; }
        [DataMember]
        public string entityname { get; set; }
        [DataMember]
        public string passportno { get; set; }
        [DataMember]
        public string position { get; set; }
        [DataMember]
        public string photo { get; set; }
        [DataMember]
        public string positionname { get; set; }
        [DataMember]
        public string mainunit { get; set; }
        [DataMember]
        public string nationality { get; set; }
        [DataMember]
        public long? leavebalance { get; set; }
        [DataMember]
        public string ademail { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]

        public DateTime? generateddatetime { get; set; }


        [DataMember]
        public long? directorateid { get; set; }
        [DataMember]
        public string directoratename { get; set; }
        [DataMember]
        public long? authorityid { get; set; }
        [DataMember]
        public string authorityname { get; set; }

        [DataMember]
        public long? positionid { get; set; }
        [DataMember]
        public long? mainunitid { get; set; }

        [DataMember]
        public string jobresponsibility { get; set; }
        [DataMember]
        public string unitrole { get; set; }

        [DataMember]
        public string OrgLogo { get; set; }

        [DataMember]
        public string FullRank { get; set; }
        [DataMember]
        public bool IsSecretary
        {
            get => _isSecretary;
            set => _isSecretary = value;
        }

        [DataMember]
        public string lastleavedate { get; set; }
        [DataMember]
        public DateTime? lastpromotiondate { get; set; }
        [DataMember]
        public string mobileno { get; set; }

        [DataMember]
        public long? folderid { get; set; }


        [DataMember]
        public long? headerfor { get; set; }

        [DataMember]
        public long? nextrankid { get; set; }

        private string _entitycode;
        [DataMember]
        public string EntityCode
        {
            get => _entitycode;
            set => _entitycode = value;
        }



        private long _milipossitiondetlid;
        [DataMember]
        public long milipossitiondetlid
        {
            get { return _milipossitiondetlid; }
            set { _milipossitiondetlid = value; }
        }


        private long? _unitparentunitid;
        [DataMember]
        public long? unitparentunitid
        {
            get { return _unitparentunitid; }
            set { _unitparentunitid = value; }
        }


        private string _unitparentunit;
        [DataMember]
        public string unitparentunit
        {
            get { return _unitparentunit; }
            set { _unitparentunit = value; }
        }



        private long? _currentunitid;
        [DataMember]
        public long? currentunitid
        {
            get { return _currentunitid; }
            set { _currentunitid = value; }
        }



        private string _currentunit;
        [DataMember]
        public string currentunit
        {
            get { return _currentunit; }
            set { _currentunit = value; }
        }



        private string _Samaccount;
        [DataMember]
        public string Samaccount
        {
            get { return _Samaccount; }
            set { _Samaccount = value; }
        }

        private string _displayName;
        private string jobRequirements;

        [DataMember]
        public string DisplayName
        {
            get => $"{this.positionname}/{this.rankname}/{this.fullname} "; set => _displayName = value;
        }
        [DataMember]
        [JsonProperty("Requirements")]
        public string JobRequirements { get => jobRequirements; set => jobRequirements = value; }

        public MilShortInfoEntity()
        {
        }


    }
}
