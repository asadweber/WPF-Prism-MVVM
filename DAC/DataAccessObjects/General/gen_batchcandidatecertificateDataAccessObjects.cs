using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class gen_batchcandidatecertificateDataAccessObjects : BaseDataAccess, Igen_batchcandidatecertificateDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_batchcandidatecertificateDataAccessObjects";
        
		public gen_batchcandidatecertificateDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_batchcandidatecertificate.batchcandcertificateid.HasValue)
				Database.AddInParameter(cmd, "@BatchCandCertificateID", DbType.Int64, gen_batchcandidatecertificate.batchcandcertificateid);
            if (forDelete) return;
			if (gen_batchcandidatecertificate.batchcandidatetypemapid.HasValue)
				Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandidatecertificate.batchcandidatetypemapid);
			if (gen_batchcandidatecertificate.certificatelevelid.HasValue)
				Database.AddInParameter(cmd, "@CertificateLevelID", DbType.Int64, gen_batchcandidatecertificate.certificatelevelid);
			if (gen_batchcandidatecertificate.certificateid.HasValue)
				Database.AddInParameter(cmd, "@CertificateID", DbType.Int64, gen_batchcandidatecertificate.certificateid);
			if ((gen_batchcandidatecertificate.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_batchcandidatecertificate.isactive);
			if (!(string.IsNullOrEmpty(gen_batchcandidatecertificate.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_batchcandidatecertificate.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Igen_batchcandidatecertificateDataAccessObjects.Add(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatecertificate_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatecertificate, cmd,Database);
                FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.Addgen_batchcandidatecertificate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_batchcandidatecertificateDataAccessObjects.Update(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_batchcandidatecertificate_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_batchcandidatecertificate, cmd,Database);
                FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.Updategen_batchcandidatecertificate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_batchcandidatecertificateDataAccessObjects.Delete(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_batchcandidatecertificate_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				if (gen_batchcandidatecertificate.batchcandidatetypemapid.HasValue)
					Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandidatecertificate.batchcandidatetypemapid);
				FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                   	IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                   throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.Deletegen_batchcandidatecertificate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_batchcandidatecertificateDataAccessObjects.SaveList(IList<gen_batchcandidatecertificateEntity> listAdded, IList<gen_batchcandidatecertificateEntity> listUpdated, IList<gen_batchcandidatecertificateEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandidatecertificate_Ins";
            const string SPUpdate = "gen_batchcandidatecertificate_Upd";
            const string SPDelete = "gen_batchcandidatecertificate_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                //Delete all existing data by bachcandidatetypemapid
                gen_batchcandidatecertificateEntity objEntity = new gen_batchcandidatecertificateEntity();
                objEntity.batchcandidatetypemapid = listAdded.Count > 0 ? listAdded[0].batchcandidatetypemapid : 0;
                gen_batchcandidatecertificateDataAccessObjects objgen_batchcandidatecertificate = new gen_batchcandidatecertificateDataAccessObjects(this.Context);
                objgen_batchcandidatecertificate.DeletebyBatchCandidateTypeMapID(Database, transaction, objEntity, cancellationToken);

                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchcandidatecertificateEntity gen_batchcandidatecertificate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandidatecertificate, cmd, Database, true);
                            FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            { 
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listUpdated.Count > 0 )
                {
                    foreach (gen_batchcandidatecertificateEntity gen_batchcandidatecertificate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandidatecertificate, cmd, Database);
                            FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                 throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listAdded.Count > 0 )
                {
                    foreach (gen_batchcandidatecertificateEntity gen_batchcandidatecertificate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandidatecertificate, cmd, Database);
                            FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                 throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.Save_gen_batchcandidatecertificate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
       public async Task<long> SaveList(
       Database db , 
       DbTransaction transaction,
       IList<gen_batchcandidatecertificateEntity> listAdded, 
       IList<gen_batchcandidatecertificateEntity> listUpdated, 
       IList<gen_batchcandidatecertificateEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandidatecertificate_Ins";
            const string SPUpdate = "gen_batchcandidatecertificate_Upd";
            const string SPDelete = "gen_batchcandidatecertificate_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchcandidatecertificateEntity gen_batchcandidatecertificate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandidatecertificate, cmd, db, true);
                            FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            { 
                                  throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listUpdated.Count > 0 )
                {
                    foreach (gen_batchcandidatecertificateEntity gen_batchcandidatecertificate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandidatecertificate, cmd, db);
                            FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                 throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (listAdded.Count > 0 )
                {
                    foreach (gen_batchcandidatecertificateEntity gen_batchcandidatecertificate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandidatecertificate, cmd, db);
                            FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);
                            
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                 throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }

              
            }
            catch (Exception ex)
            {
               
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.Save_gen_batchcandidatecertificate"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateDataAccessObjects.GetAll(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandidatecertificate_GA";
                IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchcandidatecertificate.SortExpression);
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatecertificate, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GetAllgen_batchcandidatecertificate"));
            }	
        }
		
        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateDataAccessObjects.GetAllByPages(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchcandidatecertificate_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatecertificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatecertificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatecertificate.CurrentPage);                    
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchcandidatecertificate, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_batchcandidatecertificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchcandidatecertificate.strCommonSerachParam+"%");

                    IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchcandidatecertificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GetAllByPagesgen_batchcandidatecertificate"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateDataAccessObjects.GetSingle(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandidatecertificate_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatecertificate, cmd, Database);
                    
                    IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    
                    if(itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GetSinglegen_batchcandidatecertificate"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateDataAccessObjects.GAPgListView(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchcandidatecertificate_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatecertificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatecertificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatecertificate.CurrentPage);                    
                    FillSequrityParameters(gen_batchcandidatecertificate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchcandidatecertificate, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_batchcandidatecertificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchcandidatecertificate.strCommonSerachParam+"%");

                    IList<gen_batchcandidatecertificateEntity> itemList = new List<gen_batchcandidatecertificateEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatecertificateEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchcandidatecertificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatecertificateDataAccess.GAPgListViewgen_batchcandidatecertificate"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}