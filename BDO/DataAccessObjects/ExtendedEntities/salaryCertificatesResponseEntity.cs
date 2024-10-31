using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "salaryCertificatesResponseEntity", Namespace = "http://www.KAF.com/types")]
    public partial class salaryCertificatesResponseEntity
    {
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string responsetext { get; set; }

    }
}
