using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using BDO.Core.Base;

namespace BDO.DataAccessObjects.ApiModels
{
    [Serializable]
    [DataContract(Name = "gen_militarypossitionentitymapEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_militarypossitionentitymapEntity : BaseEntity
    {
        #region Properties

        protected long? _milipossitionentitymapid;
        protected long? _milipossitionid;
        protected long? _entitykey;
        protected string _remarks;
        private long? _positionType;
        public long? forprofile { get; set; }


        [DataMember]
        public long? milipossitionentitymapid
        {
            get { return _milipossitionentitymapid; }
            set { _milipossitionentitymapid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? milipossitionid
        {
            get { return _milipossitionid; }
            set { _milipossitionid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? PositionType
        {
            get => _positionType;
            set => _positionType = value;
        }

        
        protected string _ademail;
        [DataMember]
        public string ademail
        {
            get { return _ademail; }
            set { _ademail = value; this.OnChnaged(); }
        }

        #endregion
    }
}
