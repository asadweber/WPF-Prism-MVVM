using System;
using System.Data;
using System.Runtime.Serialization;

namespace BDO.Core.DataAccessObjects.HRDomainModel
{
    #region GetMilShortInfoByBasicMilEntity
    /// <summary>
    /// This object represents the properties and methods of a getPersonnelShortProfileByParam.
    /// </summary>
    [Serializable]
    [DataContract(Name = "GetMilShortInfoByBasicMilEntity", Namespace = "http://www.KAF.com/types")]
    public class GetMilShortInfoByBasicMilEntity
    {
        [DataMember]
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


        private string _authorityDisplayName;
        private string _mainEntityNameDisplay;
        private string _rankNameDisplay;
        private string _positionNameDisplay;
        private string _fullNameDisplay;


        [DataMember]
        public string AuthorityDisplayName
        {
            get => _authorityDisplayName;
            set => _authorityDisplayName = value;
        }

        [DataMember]
        public string MainEntityNameDisplay
        {
            get => _mainEntityNameDisplay;
            set => _mainEntityNameDisplay = value;
        }

        [DataMember]
        public string RankNameDisplay
        {
            get => _rankNameDisplay;
            set => _rankNameDisplay = value;
        }


        [DataMember]
        public string PositionNameDisplay
        {
            get => _positionNameDisplay;
            set => _positionNameDisplay = value;
        }

        [DataMember]
        public string FullNameDisplay
        {
            get => _fullNameDisplay;
            set => _fullNameDisplay = value;
        }

        [DataMember]
        public long? headerfor { get; set; }

        [DataMember]
        public long? nextrankid { get; set; }

        private string _entitycode;
        //private string _requirements;

        [DataMember]
        public string EntityCode
        {
            get => _entitycode;
            set => _entitycode = value;
        }

        [DataMember]
        public long? milipossitiondetlid { get; set; }

        [DataMember]
        public long? unitparentunitid { get; set; }

        [DataMember]
        public string unitparentunit { get; set; }

        [DataMember]
        public long? currentunitid { get; set; }

        [DataMember]
        public string currentunit { get; set; }

        [DataMember]
        public string Samaccount { get; set; }

        [DataMember]
        public string requirements { get; set; }


        public GetMilShortInfoByBasicMilEntity()
        {
        }

        [DataMember]
        public string TransID { get; set; }


        [DataMember]
        public string RemoteIP { get; set; }
    }
    #endregion
}
