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
	
	internal sealed partial class gen_batchcandidatereqfileDataAccessObjects : BaseDataAccess, Igen_batchcandidatereqfileDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_batchcandidatereqfileDataAccessObjects";
        
		public gen_batchcandidatereqfileDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_batchcandidatereqfile.batchcandreqfileid.HasValue)
				Database.AddInParameter(cmd, "@BatchCandReqFileID", DbType.Int64, gen_batchcandidatereqfile.batchcandreqfileid);
            if (forDelete) return;
			if (gen_batchcandidatereqfile.batchcandidatetypemapid.HasValue)
				Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandidatereqfile.batchcandidatetypemapid);
			if (gen_batchcandidatereqfile.fileconfigid.HasValue)
				Database.AddInParameter(cmd, "@FileConfigID", DbType.Int64, gen_batchcandidatereqfile.fileconfigid);
			if (!(string.IsNullOrEmpty(gen_batchcandidatereqfile.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, gen_batchcandidatereqfile.description);
			if ((gen_batchcandidatereqfile.isrequired != null))
				Database.AddInParameter(cmd, "@IsRequired", DbType.Boolean, gen_batchcandidatereqfile.isrequired);
			if (!(string.IsNullOrEmpty(gen_batchcandidatereqfile.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_batchcandidatereqfile.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Igen_batchcandidatereqfileDataAccessObjects.Add(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatereqfile_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatereqfile, cmd,Database);
                FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.Addgen_batchcandidatereqfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_batchcandidatereqfileDataAccessObjects.Update(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_batchcandidatereqfile_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_batchcandidatereqfile, cmd,Database);
                FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.Updategen_batchcandidatereqfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_batchcandidatereqfileDataAccessObjects.Delete(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_batchcandidatereqfile_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_batchcandidatereqfile, cmd,Database, true);
                FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.Deletegen_batchcandidatereqfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_batchcandidatereqfileDataAccessObjects.SaveList(IList<gen_batchcandidatereqfileEntity> listAdded, IList<gen_batchcandidatereqfileEntity> listUpdated, IList<gen_batchcandidatereqfileEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandidatereqfile_Ins";
            const string SPUpdate = "gen_batchcandidatereqfile_Upd";
            const string SPDelete = "gen_batchcandidatereqfile_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchcandidatereqfileEntity gen_batchcandidatereqfile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandidatereqfile, cmd, Database, true);
                            FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchcandidatereqfileEntity gen_batchcandidatereqfile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandidatereqfile, cmd, Database);
                            FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchcandidatereqfileEntity gen_batchcandidatereqfile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandidatereqfile, cmd, Database);
                            FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.Save_gen_batchcandidatereqfile"));
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
       IList<gen_batchcandidatereqfileEntity> listAdded, 
       IList<gen_batchcandidatereqfileEntity> listUpdated, 
       IList<gen_batchcandidatereqfileEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandidatereqfile_Ins";
            const string SPUpdate = "gen_batchcandidatereqfile_Upd";
            const string SPDelete = "gen_batchcandidatereqfile_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_batchcandidatereqfileEntity gen_batchcandidatereqfile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandidatereqfile, cmd, db, true);
                            FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchcandidatereqfileEntity gen_batchcandidatereqfile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandidatereqfile, cmd, db);
                            FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchcandidatereqfileEntity gen_batchcandidatereqfile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandidatereqfile, cmd, db);
                            FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.Save_gen_batchcandidatereqfile"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileDataAccessObjects.GetAll(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandidatereqfile_GA";
                IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_batchcandidatereqfile.SortExpression);
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatereqfile, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GetAllgen_batchcandidatereqfile"));
            }	
        }
		
        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileDataAccessObjects.GetAllByPages(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchcandidatereqfile_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatereqfile.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatereqfile.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatereqfile.CurrentPage);                    
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchcandidatereqfile, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_batchcandidatereqfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchcandidatereqfile.strCommonSerachParam+"%");

                    IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchcandidatereqfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GetAllByPagesgen_batchcandidatereqfile"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileDataAccessObjects.GetSingle(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_batchcandidatereqfile_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatereqfile, cmd, Database);
                    
                    IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GetSinglegen_batchcandidatereqfile"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileDataAccessObjects.GAPgListView(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_batchcandidatereqfile_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatereqfile.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatereqfile.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatereqfile.CurrentPage);                    
                    FillSequrityParameters(gen_batchcandidatereqfile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_batchcandidatereqfile, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_batchcandidatereqfile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_batchcandidatereqfile.strCommonSerachParam+"%");

                    IList<gen_batchcandidatereqfileEntity> itemList = new List<gen_batchcandidatereqfileEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatereqfileEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_batchcandidatereqfile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatereqfileDataAccess.GAPgListViewgen_batchcandidatereqfile"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}