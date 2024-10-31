using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_newsEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_newsEntity : BaseEntity
    {
        #region Properties

        protected long? _newsid;
        protected long? _newscategoryid;
        protected string _newsheadlinear;
        protected string _newsheadline;
        protected string _newsdetailar;
        protected string _newsdetail;
        protected bool? _ispublished;
        protected DateTime? _publisheddate;
        protected long? _publishedby;
        protected bool? _isreviewed;
        protected DateTime? _revieweddate;
        protected long? _reviewedby;
        protected bool? _showinticker;
        protected bool? _showinscroller;
        protected bool? _showasmodal;

        private string _newsimagepath;

        [DataMember]
        public long? newsid
        {
            get { return _newsid; }
            set { _newsid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "newscategoryid", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_news), ErrorMessageResourceName = "newscategoryidRequired")]
        public long? newscategoryid
        {
            get { return _newscategoryid; }
            set { _newscategoryid = value; this.OnChnaged(); }
        }

        [DataMember]
        //[MaxLength(-1)]
        [Display(Name = "newsheadlinear", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_news), ErrorMessageResourceName = "newsheadlinearRequired")]
        public string newsheadlinear
        {
            get { return _newsheadlinear; }
            set { _newsheadlinear = value; this.OnChnaged(); }
        }

        [DataMember]
        //[MaxLength(-1)]
        [Display(Name = "newsheadline", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public string newsheadline
        {
            get { return _newsheadline; }
            set { _newsheadline = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "newsdetailar", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_news), ErrorMessageResourceName = "newsdetailarRequired")]
        [AllowHtml]
        public string newsdetailar
        {
            get { return _newsdetailar; }
            set { _newsdetailar = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "newsdetail", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        [AllowHtml]
        public string newsdetail
        {
            get { return _newsdetail; }
            set { _newsdetail = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispublished", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public bool? ispublished
        {
            get { return _ispublished; }
            set { _ispublished = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "publisheddate", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public DateTime? publisheddate
        {
            get { return _publisheddate; }
            set { _publisheddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "publishedby", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public long? publishedby
        {
            get { return _publishedby; }
            set { _publishedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isreviewed", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public bool? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "revieweddate", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public DateTime? revieweddate
        {
            get { return _revieweddate; }
            set { _revieweddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewedby", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public long? reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "showinticker", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public bool? showinticker
        {
            get { return _showinticker; }
            set { _showinticker = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "showinscroller", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public bool? showinscroller
        {
            get { return _showinscroller; }
            set { _showinscroller = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "showasmodal", ResourceType = typeof(CLL.LLClasses.Models._gen_news))]
        public bool? showasmodal
        {
            get { return _showasmodal; }
            set { _showasmodal = value; this.OnChnaged(); }
        }




        public string newsimagepath { get => _newsimagepath; set => _newsimagepath = value; }

        #endregion

        #region Constructor

        public gen_newsEntity() : base()
        {
        }

        public gen_newsEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public gen_newsEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NewsID"))) _newsid = reader.GetInt64(reader.GetOrdinal("NewsID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsCategoryID"))) _newscategoryid = reader.GetInt64(reader.GetOrdinal("NewsCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsHeadlineAR"))) _newsheadlinear = reader.GetString(reader.GetOrdinal("NewsHeadlineAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsHeadline"))) _newsheadline = reader.GetString(reader.GetOrdinal("NewsHeadline"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsDetailAR"))) _newsdetailar = reader.GetString(reader.GetOrdinal("NewsDetailAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsDetail"))) _newsdetail = reader.GetString(reader.GetOrdinal("NewsDetail"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsImagePath"))) _newsimagepath = reader.GetString(reader.GetOrdinal("NewsImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPublished"))) _ispublished = reader.GetBoolean(reader.GetOrdinal("IsPublished"));
                if (!reader.IsDBNull(reader.GetOrdinal("PublishedDate"))) _publisheddate = reader.GetDateTime(reader.GetOrdinal("PublishedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PublishedBy"))) _publishedby = reader.GetInt64(reader.GetOrdinal("PublishedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ShowInTicker"))) _showinticker = reader.GetBoolean(reader.GetOrdinal("ShowInTicker"));
                if (!reader.IsDBNull(reader.GetOrdinal("ShowInScroller"))) _showinscroller = reader.GetBoolean(reader.GetOrdinal("ShowInScroller"));
                if (!reader.IsDBNull(reader.GetOrdinal("ShowAsModal"))) _showasmodal = reader.GetBoolean(reader.GetOrdinal("ShowAsModal"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NewsID"))) _newsid = reader.GetInt64(reader.GetOrdinal("NewsID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsCategoryID"))) _newscategoryid = reader.GetInt64(reader.GetOrdinal("NewsCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsHeadlineAR"))) _newsheadlinear = reader.GetString(reader.GetOrdinal("NewsHeadlineAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsHeadline"))) _newsheadline = reader.GetString(reader.GetOrdinal("NewsHeadline"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsDetailAR"))) _newsdetailar = reader.GetString(reader.GetOrdinal("NewsDetailAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsDetail"))) _newsdetail = reader.GetString(reader.GetOrdinal("NewsDetail"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPublished"))) _ispublished = reader.GetBoolean(reader.GetOrdinal("IsPublished"));
                if (!reader.IsDBNull(reader.GetOrdinal("PublishedDate"))) _publisheddate = reader.GetDateTime(reader.GetOrdinal("PublishedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PublishedBy"))) _publishedby = reader.GetInt64(reader.GetOrdinal("PublishedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ShowInTicker"))) _showinticker = reader.GetBoolean(reader.GetOrdinal("ShowInTicker"));
                if (!reader.IsDBNull(reader.GetOrdinal("ShowInScroller"))) _showinscroller = reader.GetBoolean(reader.GetOrdinal("ShowInScroller"));
                if (!reader.IsDBNull(reader.GetOrdinal("ShowAsModal"))) _showasmodal = reader.GetBoolean(reader.GetOrdinal("ShowAsModal"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
