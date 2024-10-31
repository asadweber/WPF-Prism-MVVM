using CLL.LLClasses.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_emergencycontactinfoEntity
    {
        private long? registrationID;
        private bool? _isemgcontactdataavailable;

        [DataMember]
        public string RelationShipName { get; set; }

        [DataMember]
        public reg_relativesworkinginmodEntity RelativesWorkingInMOD { get; set; }

        [DataMember]
        public long applicantTableID { get; set; }

        [DataMember]
        public long? RegistrationID { get => registrationID; set => registrationID = value; }

        [DataMember]
        public bool? IsEmgContactDataAvailable { get => _isemgcontactdataavailable; set => _isemgcontactdataavailable = value; }
    }
}
