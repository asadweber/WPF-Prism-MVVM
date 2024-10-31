using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptTrainingJoinInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptTrainingJoinInfo

    {
       
        public long BasicInfoId { get; set; }
        public string CivilId { get; set; }


        public DateTime JoinDate { get; set; }
        public long VolunteerNo { get; set; }
        public string TrainingCentreName { get; set; }
        public long BatchNo { get; set; }

    }
}
