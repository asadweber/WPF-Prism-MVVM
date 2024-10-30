using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "gen_dropdownEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_dropdownEntity : BaseEntity
    {
    
        protected long ? _Id;
        protected string _Text;
        protected string _strValue1;

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
        public string strValue1
        {
            get { return _strValue1; }
            set { _strValue1 = value; }
        }


        #region Constructor

        public gen_dropdownEntity():base()
        {
        }
        
        public gen_dropdownEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {

                if (!reader.IsDBNull(reader.GetOrdinal("Id"))) _Id = reader.GetInt64(reader.GetOrdinal("Id"));
                if (!reader.IsDBNull(reader.GetOrdinal("Text"))) _Text = reader.GetString(reader.GetOrdinal("Text"));
            }
        }


        #endregion
    }
}
