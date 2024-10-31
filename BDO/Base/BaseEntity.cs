using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BDO.Core.Base
{
    [Serializable()]

    [DataContract(Name = "BaseEntity", Namespace = "http://www.MOI.com/types")]
    public abstract class BaseEntity : ICloneable
    {

        [DataMember]
        public long? ApplicantMaritalstatus { get; set; }

        [DataMember]
        public string strModelPrimaryKey { get => _strModelPrimaryKey; set => _strModelPrimaryKey = value; }

        [DataMember]
        public string strModelForigenKey { get => _strModelForigenKey; set => _strModelForigenKey = value; }

        [DataMember]
        public string strModelForigenKey1 { get => strModelForigenKey11; set => strModelForigenKey11 = value; }

        [DataMember]
        public string strModelForigenKey2 { get => strModelForigenKey22; set => strModelForigenKey22 = value; }

        protected SecurityCapsule _BaseSecurityParam;
        [DataMember]
        public SecurityCapsule BaseSecurityParam
        {
            get { return _BaseSecurityParam; }
            set { _BaseSecurityParam = value; }
        }

        [DataContract]
        public enum EntityState
        {
            /// <summary>
            /// Entity is unchanged
            /// </summary>
            [EnumMember]
            Unchanged = 0,

            /// <summary>
            /// Entity is new
            /// </summary>
            [EnumMember]
            Added = 1,

            /// <summary>
            /// Entity has been modified
            /// </summary>
            [EnumMember]
            Changed = 2,

            /// <summary>
            /// Entity has been deleted
            /// </summary>
            [EnumMember]
            Deleted = 3
        }
        public string strCommonSerachParam { get; set; }

        private EntityState currentEntityState = EntityState.Unchanged;

        [DataMember]
        public string status
        {
            get;
            set;
        }

        [DataMember]
        public string strMasterID
        {
            get;
            set;
        }

        [DataMember]
        public string strDetailID
        {
            get;
            set;
        }

        [DataMember]
        public string code
        {
            get;
            set;
        }
        [DataMember]
        public string SortExpression
        {
            get;
            set;
        }

        [DataMember]
        public long TotalRecord
        {
            get;
            set;
        }

        [DataMember]
        public int PageSize
        {
            get;
            set;
        }

        [DataMember]
        public int CurrentPage
        {
            get;
            set;
        }

        [DataMember]
        public long RowNumber
        {
            get;
            set;
        }


        [DataMember]
        public EntityState CurrentState
        {
            get { return currentEntityState; }
            set { currentEntityState = value; }
        }

        private long _RETURN_KEY;
        private string _strModelPrimaryKey;
        private string _strModelForigenKey;
        private string strModelForigenKey11;
        private string strModelForigenKey22;

        [DataMember]
        public long RETURN_KEY
        {
            get { return _RETURN_KEY; }
            set { _RETURN_KEY = value; }
        }



        protected BaseEntity()
        {
            this.currentEntityState = EntityState.Added;
        }

        protected void OnChnaged()
        {
            if (currentEntityState == EntityState.Unchanged)
                this.currentEntityState = EntityState.Changed;
        }

        protected void AcceptChnaged()
        {
            this.currentEntityState = EntityState.Unchanged;
        }

        public void Remove()
        {
            this.currentEntityState = EntityState.Deleted;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public virtual BaseEntity Clone()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(ms, this);

                ms.Seek(0, SeekOrigin.Begin);

                return (new BinaryFormatter()).Deserialize(ms) as BaseEntity;
            }
        }
        [DataMember]
        public string selectedculture
        {
            get;
            set;
        }

        [DataMember]
        public string selectedvalue
        {
            get;
            set;
        }

        [DataMember]
        public string selectedtext
        {
            get;
            set;
        }

        public string datatablebuttonscode
        {
            get;
            set;
        }
        [DataMember]
        public string ControllerName
        {
            get;
            set;
        }
        [DataMember]
        public string ActionName
        {
            get;
            set;
        }

    }
}
