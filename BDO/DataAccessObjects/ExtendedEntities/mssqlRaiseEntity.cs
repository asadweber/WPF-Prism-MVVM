using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "mssqlRaiseEntity", Namespace = "http://www.KAF.com/types")]
    public partial class mssqlRaiseEntity : BaseEntity
    {
    
        protected long ? _Id;
        protected string _Text;
        protected string _TextEn;

        [DataMember]
        public long ? Id
        {
            get { return _Id; }
            set { _Id = value;  }
        }
        
        [DataMember]
        public string Text
        {
            get { return _Text; }
            set { _Text = value;  }
        }

       [DataMember]
        public string TextEn
        {
            get { return _TextEn; }
            set { _TextEn = value; }
        }


        #region Constructor

        public mssqlRaiseEntity():base()
        {
        }
        
        public mssqlRaiseEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("Id"))) _Id = reader.GetInt64(reader.GetOrdinal("Id"));
                if (!reader.IsDBNull(reader.GetOrdinal("Text"))) _Text = reader.GetString(reader.GetOrdinal("Text"));
                if (!reader.IsDBNull(reader.GetOrdinal("TextEn"))) _TextEn = reader.GetString(reader.GetOrdinal("TextEn"));
            }
        }


        #endregion
    }
}
