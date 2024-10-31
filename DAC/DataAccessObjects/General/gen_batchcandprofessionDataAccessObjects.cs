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
	
	internal sealed partial class gen_batchcandprofessionDataAccessObjects : BaseDataAccess, Igen_batchcandprofessionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_batchcandprofessionDataAccessObjects";
        
		public gen_batchcandprofessionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_batchcandprofessionEntity gen_batchcandprofession, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_batchcandprofession.batchcandprofessionmapid.HasValue)
				Database.AddInParameter(cmd, "@BatchCandProfessionMapID", DbType.Int64, gen_batchcandprofession.batchcandprofessionmapid);
			if (gen_batchcandprofession.batchcandidatetypemapid.HasValue)
				Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandprofession.batchcandidatetypemapid);
            if (forDelete) return;
            if (gen_batchcandprofession.professionid.HasValue)
				Database.AddInParameter(cmd, "@ProfessionID", DbType.Int64, gen_batchcandprofession.professionid);
			if (gen_batchcandprofession.noofregistration.HasValue)
				Database.AddInParameter(cmd, "@NoOfRegistration", DbType.Int64, gen_batchcandprofession.noofregistration);
			if ((gen_batchcandprofession.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, gen_batchcandprofession.isactive);
			if (!(string.IsNullOrEmpty(gen_batchcandprofession.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_batchcandprofession.comment);
			if (!(string.IsNullOrEmpty(gen_batchcandprofession.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_batchcandprofession.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_batchcandprofessionDataAccessObjects.Add(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandprofession_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandprofession, cmd,Database);
                FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.Addgen_batchcandprofession"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_batchcandprofessionDataAccessObjects.Update(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_batchcandprofession_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_batchcandprofession, cmd,Database);
                FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.Updategen_batchcandprofession"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_batchcandprofessionDataAccessObjects.Delete(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_batchcandprofession_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_batchcandprofession, cmd,Database, true);
                FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.Deletegen_batchcandprofession"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_batchcandprofessionDataAccessObjects.SaveList(IList<gen_batchcandprofessionEntity> listAdded, IList<gen_batchcandprofessionEntity> listUpdated, IList<gen_batchcandprofessionEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandprofession_Ins";
            const string SPUpdate = "gen_batchcandprofession_Upd";
            const string SPDelete = "gen_batchcandprofession_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                //Delete all existing data by bachcandidatetypemapid
                gen_batchcandprofessionEntity objEntity = new gen_batchcandprofessionEntity();
                objEntity.batchcandidatetypemapid = listAdded.Count > 0 ? listAdded[0].batchcandidatetypemapid : 0;
                gen_batchcandprofessionDataAccessObjects objgen_batchcandidateprofession = new gen_batchcandprofessionDataAccessObjects(this.Context);
                objgen_batchcandidateprofession.DeletebyBatchCandidateTypeMapID(Database, transaction, objEntity, cancellationToken);

                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchcandprofessionEntity gen_batchcandprofession in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandprofession, cmd, Database, true);
                            FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchcandprofessionEntity gen_batchcandprofession in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandprofession, cmd, Database);
                            FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchcandprofessionEntity gen_batchcandprofession in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandprofession, cmd, Database);
                            FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.Save_gen_batchcandprofession"));
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
       IList<gen_batchcandprofessionEntity> listAdded, 
       IList<gen_batchcandprofessionEntity> listUpdated, 
       IList<gen_batchcandprofessionEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandprofession_Ins";
            const string SPUpdate = "gen_batchcandprofession_Upd";
            const string SPDelete = "gen_batchcandprofession_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchcandprofessionEntity gen_batchcandprofession in listDeleted)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandprofession, cmd, db, true);
                            FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchcandprofessionEntity gen_batchcandprofession in listUpdated)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandprofession, cmd, db);
                            FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchcandprofessionEntity gen_batchcandprofession in listAdded)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandprofession, cmd, db);
                            FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.Save_gen_batchcandprofession"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionDataAccessObjects.GetAll(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandprofession_GA";
                IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchcandprofession.SortExpression);
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandprofession, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GetAllgen_batchcandprofession"));
            }	
        }
		
        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionDataAccessObjects.GetAllByPages(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchcandprofession_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandprofession.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandprofession.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandprofession.CurrentPage);                    
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchcandprofession, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_batchcandprofession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchcandprofession.strCommonSerachParam+"%");

                    IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchcandprofession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GetAllByPagesgen_batchcandprofession"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_batchcandprofessionEntity> Igen_batchcandprofessionDataAccessObjects.GetSingle(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandprofession_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandprofession, cmd, Database);
                    
                    IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GetSinglegen_batchcandprofession"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionDataAccessObjects.GAPgListView(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchcandprofession_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandprofession.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandprofession.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandprofession.CurrentPage);                    
                    FillSequrityParameters(gen_batchcandprofession.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchcandprofession, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_batchcandprofession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchcandprofession.strCommonSerachParam+"%");

                    IList<gen_batchcandprofessionEntity> itemList = new List<gen_batchcandprofessionEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandprofessionEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchcandprofession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandprofessionDataAccess.GAPgListViewgen_batchcandprofession"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}