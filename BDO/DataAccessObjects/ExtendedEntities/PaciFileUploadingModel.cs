using BDO.Core.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace BDO.DataAccessObjects.ExtendedEntities
{
	#region GetAllJobByApplicationID_GA
	/// <summary>
	/// This object represents the properties and methods of a GetAllJobByApplicationID_GA.
	/// </summary>
	[Serializable]
	[DataContract(Name = "PaciFileUploadingModel", Namespace = "http://www.aa.com/types")]
	public class PaciFileUploadingModel : BaseEntity
	{
		[DataMember]
		public IFormFile uploadFile { get; set; }

		[DataMember]
		public Guid applicationguid { get; set; }

		[DataMember]
		public string filename { get; set; }
		[DataMember]
		public string responsecode { get; set; }
		[DataMember]
		public bool isprocessed { get; set; }
		[DataMember]
		public DateTime? processeddate { get; set; }
		[DataMember]
		public string processingcomment { get; set; }
		[DataMember]
		public bool repeatedtry { get; set; }
		[DataMember]
		public int? repeatedtrycount { get; set; }
		[DataMember]
		public string repeatedtryreason { get; set; }
		[DataMember]
		public DateTime? processstartdate { get; set; }
		[DataMember]
		public DateTime? processendstartdate { get; set; }

		//[DataMember]		public bool datareadytoprocess { get; set; }

		public PaciFileUploadingModel()
		{
		}

		public PaciFileUploadingModel(IDataReader ireader)
		{
			//LoadFromReader(ireader);
			PaciFileUploadingModelReader(ireader);
		}

		protected void PaciFileUploadingModelReader(IDataReader reader)
		{
			//SqlDataReader reader = (SqlDataReader)ireader;
			if (reader != null && !reader.IsClosed)
			{
				
				//if (!reader.IsDBNull(reader.GetOrdinal("datareadytoprocess"))) datareadytoprocess = reader.GetBoolean(reader.GetOrdinal("datareadytoprocess"));
			}
		}
	}
	#endregion
}
