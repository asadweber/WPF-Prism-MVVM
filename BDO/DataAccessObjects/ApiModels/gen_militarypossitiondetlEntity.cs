using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using BDO.Core.Base;

namespace BDO.DataAccessObjects.ApiModels
{
    [Serializable]
    [DataContract(Name = "gen_militarypossitiondetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_militarypossitiondetlEntity : BaseEntity
    {
        #region Properties

        protected long? _milipossitiondetlid;
        protected long? _parentmilipossitiondetlid;
        protected long? _milipossitionentitymapid;
        protected long? _levelid;
        protected string _sqlindex;
        protected long? _miljobid;
        protected long? _posseqno;
        protected bool? _status;
        protected DateTime? _holddate;
        protected DateTime? _releasedate;
        protected string _remarks;

        [DataMember]
        public long? milipossitiondetlid
        {
            get { return _milipossitiondetlid; }
            set { _milipossitiondetlid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? parentmilipossitiondetlid
        {
            get { return _parentmilipossitiondetlid; }
            set { _parentmilipossitiondetlid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? milipossitionentitymapid
        {
            get { return _milipossitionentitymapid; }
            set { _milipossitionentitymapid = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? levelid
        {
            get { return _levelid; }
            set { _levelid = value; this.OnChnaged(); }
        }
        [DataMember]
        public string sqlindex
        {
            get { return _sqlindex; }
            set { _sqlindex = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? miljobid
        {
            get { return _miljobid; }
            set { _miljobid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? posseqno
        {
            get { return _posseqno; }
            set { _posseqno = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? status
        {
            get { return _status; }
            set { _status = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? holddate
        {
            get { return _holddate; }
            set { _holddate = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? releasedate
        {
            get { return _releasedate; }
            set { _releasedate = value; this.OnChnaged(); }
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