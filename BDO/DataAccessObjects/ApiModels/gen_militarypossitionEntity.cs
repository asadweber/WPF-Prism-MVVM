using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using BDO.Core.Base;

namespace BDO.DataAccessObjects.ApiModels
{
    [Serializable]
    [DataContract(Name = "gen_militarypossitionEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_militarypossitionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _milipossitionid;
        protected long ? _entitykey;
        protected string _possitionname;
        protected string _possitionnameeng;
        protected bool ? _possitionstatus;
        protected string _remarks;

        protected long? _positionlevel;

        [DataMember]
        public long? positionlevel
        {
            get { return _positionlevel; }
            set { _positionlevel = value; }
        }

        protected long? _positiontype;

        [DataMember]
        public long? positiontype
        {
            get { return _positiontype; }
            set { _positiontype = value; }
        }

        [DataMember]
        public long ? milipossitionid
        {
            get { return _milipossitionid; }
            set { _milipossitionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        public long ? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        public string possitionname
        {
            get { return _possitionname; }
            set { _possitionname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        public string possitionnameeng
        {
            get { return _possitionnameeng; }
            set { _possitionnameeng = value; this.OnChnaged(); }
        }
        
        [DataMember]
        public bool ? possitionstatus
        {
            get { return _possitionstatus; }
            set { _possitionstatus = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    }
}
