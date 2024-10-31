using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2Parameters", Namespace = "http://www.KAF.com/types")]
    public class PreRegistrationValidationParameters : BaseEntity
    {
        [DataMember]
        public DateTime? DateOfBirth { get; set; }

        [DataMember]
        public string MobileNumber { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string CivilId { get; set; }

        [DataMember]
        public long? BatchId { get; set; }

        [DataMember]
        public bool? isSpecialRegistration { get; set; }

        [DataMember]
        public bool? isRollbackedFromAdmin { get; set; }

    }

}
