using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "ApplicantCertificateInformationReportSearchParameters", Namespace = "http://www.KAF.com/types")]
    public class ApplicantCertificateInformationReportSearchParameters : BaseEntity
    {
        [DataMember]
        public long batchid { get; set; }
        [DataMember]
        public string? batchidstring { get; set; }
        [DataMember]
        public long? candidatetypeid { get; set; }
        [DataMember]
        public string? candidatetypeidstring { get; set; }
        [DataMember]
        public long? countryid { get; set; }
        [DataMember]
        public string? countryidstring { get; set; }
        [DataMember]
        public string? civilid { get; set; }
        [DataMember]
        public long? certificatelevelid{ get; set; }
        [DataMember]
        public long? certificateid { get; set; }
        [DataMember]
        public long? certificatesubjectid{ get; set; }
        [DataMember]
        public long? phaseid { get; set; }
    }
}
