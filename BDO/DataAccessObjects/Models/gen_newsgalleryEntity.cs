using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_newsgalleryEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_newsgalleryEntity : BaseEntity
    {
        #region Properties
        private long? _newsgalleryid;
        private long? _newsid;
        private string _imagepath;
        private string _imagetype;
        private string _imageextension;
        private string _imagename;
        private bool? _isslider;

        [DataMember]
        public long? newsgalleryid
        {
            get { return _newsgalleryid; }
            set { _newsgalleryid = value; }
        }

        [DataMember]
        public long? newsid
        {
            get { return _newsid; }
            set { _newsid = value; }
        }

        [DataMember]
        public string imagepath
        {
            get { return _imagepath; }
            set { _imagepath = value; }
        }

        [DataMember]
        public string imagetype
        {
            get { return _imagetype; }
            set { _imagetype = value; }
        }

        [DataMember]
        public string imageextension
        {
            get { return _imageextension; }
            set { _imageextension = value; }
        }

        [DataMember]
        public string imagename
        {
            get { return _imagename; }
            set { _imagename = value; }
        }

        [DataMember]
        public bool? isslider
        {
            get { return _isslider; }
            set { _isslider = value; }
        }

        #endregion

        #region Constructor

        public gen_newsgalleryEntity() : base()
        {
        }

        public gen_newsgalleryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public gen_newsgalleryEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NewsGalleryID"))) _newsgalleryid = reader.GetInt64(reader.GetOrdinal("NewsGalleryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsID"))) _newsid = reader.GetInt64(reader.GetOrdinal("NewsID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImagePath"))) _imagepath = reader.GetString(reader.GetOrdinal("ImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageType"))) _imagetype = reader.GetString(reader.GetOrdinal("ImageType"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageExtension"))) _imageextension = reader.GetString(reader.GetOrdinal("ImageExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageName"))) _imagename = reader.GetString(reader.GetOrdinal("ImageName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSlider"))) _isslider = reader.GetBoolean(reader.GetOrdinal("IsSlider"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("NewsGalleryID"))) _newsgalleryid = reader.GetInt64(reader.GetOrdinal("NewsGalleryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewsID"))) _newsid = reader.GetInt64(reader.GetOrdinal("NewsID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImagePath"))) _imagepath = reader.GetString(reader.GetOrdinal("ImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageType"))) _imagetype = reader.GetString(reader.GetOrdinal("ImageType"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageExtension"))) _imageextension = reader.GetString(reader.GetOrdinal("ImageExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageName"))) _imagename = reader.GetString(reader.GetOrdinal("ImageName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSlider"))) _isslider = reader.GetBoolean(reader.GetOrdinal("IsSlider"));
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
