using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BDO.Core.Base
{
    [Serializable()]

    [DataContract(Name = "BaseEntity", Namespace = "http://www.MOI.com/types")]
    public abstract class BaseEntity 
    {
		[DataMember]
		public string ReportName { get => _reportName; set => _reportName = value; }

		[DataMember]
        public string redirecturl { get => redirecturl1; set => redirecturl1 = value; }

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
        public string IsAccepted
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
        public DateTime? DOBStartDate { get; set; }
		
        [DataMember]
		public DateTime? DOBEndDate { get; set; }


		[DataMember]
        public EntityState CurrentState
        {
            get { return currentEntityState; }
            set { currentEntityState = value; }
        }

        private long _RETURN_KEY;
        private string redirecturl1;
		private string _reportName;

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
