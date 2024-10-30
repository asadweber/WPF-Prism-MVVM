using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2Parameters", Namespace = "http://www.KAF.com/types")]
    public class S2Parameters : BaseEntity
    {
		private bool? _isResponsibleStatus;
        private long? _parentId;

        [DataMember]
        public string s2SearchTerm { get; set; }
        [DataMember]
        public int? s2PageSize { get; set; }
        [DataMember]
        public int? s2PageNum { get; set; }
        [DataMember]
        public string s2Param { get; set; }
        [DataMember]
        public string s2Paramkey { get; set; }

        [DataMember]
        public string s2ParamParentkey { get; set; }

        [DataMember]
        public Int64? SearchID { get; set; }

        [DataMember]
        public bool? IsMapped { get; set; }
      
        
        [DataMember]
        public string serviceId { get; set; }

		[DataMember]
		public bool? isResponsibleStatus { get => _isResponsibleStatus; set => _isResponsibleStatus = value; }

        [DataMember]
        public long? parentId { get => _parentId; set => _parentId = value; }
    }

}
