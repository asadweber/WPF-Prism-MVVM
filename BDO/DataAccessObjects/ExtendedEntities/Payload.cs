using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "DataObjectPaci", Namespace = "http://www.KAF.com/types")]
    public class DataObjectPaci
    {
        [DataMember]
        public string civno { get; set; }

        [DataMember]
        public string persoN_STATUS { get; set; }

        [DataMember]
        public string birtH_DATE { get; set; }

        [DataMember]
        public string araB_FULL_NAME { get; set; }

        [DataMember]
        public string araB_NAME_1 { get; set; }

        [DataMember]
        public string araB_NAME_2 { get; set; }

        [DataMember]
        public string araB_NAME_3 { get; set; }

        [DataMember]
        public string araB_NAME_4 { get; set; }

        [DataMember]
        public string governoratE_NAME { get; set; }

        [DataMember]
        public string districtname { get; set; }

        [DataMember]
        public string block { get; set; }

        [DataMember]
        public string plot { get; set; }

        [DataMember]
        public string streeT_NAME { get; set; }

        [DataMember]
        public string buildinG_NO { get; set; }

        [DataMember]
        public string bldG_COMPUTER_NO { get; set; }

        [DataMember]
        public string uniT_NO { get; set; }

        [DataMember]
        public string uniT_TYPE { get; set; }

        [DataMember]
        public string flooR_NO { get; set; }

        [DataMember]
        public string teL_1 { get; set; }

        [DataMember]
        public string teL_2 { get; set; }

        [DataMember]
        public string educatioN_TEXT { get; set; }

        [DataMember]
        public string relegioN_TEXT { get; set; }

        [DataMember]
        public string joB_STATUS { get; set; }

        [DataMember]
        public string blooD_TYPE { get; set; }

        [DataMember]
        public string datE_GRANT { get; set; }

        [DataMember]
        public string datE_WITHDRAWL { get; set; }

        [DataMember]
        public string eoS_CARD_NAME { get; set; }

        [DataMember]
        public string cons { get; set; }

        [DataMember]
        public string fatheR_CIVNO { get; set; }

        [DataMember]
        public string fatheR_STATUS_TEXT { get; set; }

        [DataMember]
        public string motheR_CIVNO { get; set; }

        [DataMember]
        public string motheR_STATUS_TEXT { get; set; }

        [DataMember]
        public string motheR_ARAB_NAME_1 { get; set; }

        [DataMember]
        public string motheR_ARAB_NAME_2 { get; set; }

        [DataMember]
        public string motheR_ARAB_NAME_3 { get; set; }

        [DataMember]
        public string motheR_ARAB_NAME_4 { get; set; }

        [DataMember]
        public string rc { get; set; }

        [DataMember]
        public string enquiryTime { get; set; }

        [DataMember]
        public string msg { get; set; }

        [DataMember]
        public string info { get; set; }

        [DataMember]
        public string responseTime { get; set; }

        [DataMember]
        public string verNo { get; set; }

        [DataMember]
        public string env { get; set; }

        [DataMember]
        public string hitsRemaining { get; set; }

        [DataMember]
        public string disclaimer { get; set; }
    }


    [Serializable]
    [DataContract(Name = "Payload", Namespace = "http://www.KAF.com/types")]
    public class Payload
    {
        [DataMember]
        public DataObjectPaci data { get; set; }

        [DataMember]
        public int recordsTotal { get; set; }

        [DataMember]
        public int recordsFiltered { get; set; }
    }

}
