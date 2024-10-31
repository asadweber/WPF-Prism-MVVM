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
	
	internal sealed partial class tran_applyanotherbatchDataAccessObjects : BaseDataAccess, Itran_applyanotherbatchDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_applyanotherbatchDataAccessObjects";
        
		public tran_applyanotherbatchDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_applyanotherbatchEntity tran_applyanotherbatch, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_applyanotherbatch.applyanotherbatchid.HasValue)
				Database.AddInParameter(cmd, "@ApplyAnotherBatchID", DbType.Int64, tran_applyanotherbatch.applyanotherbatchid);
            if (forDelete) return;
			if (tran_applyanotherbatch.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_applyanotherbatch.basicinfoid);
			if (tran_applyanotherbatch.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_applyanotherbatch.registrationid);
			if (tran_applyanotherbatch.batchid.HasValue)
				Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_applyanotherbatch.batchid);
            if (tran_applyanotherbatch.oldbatchid.HasValue)
                Database.AddInParameter(cmd, "@OldBatchID", DbType.Int64, tran_applyanotherbatch.oldbatchid);
            if (tran_applyanotherbatch.candidatetypeid.HasValue)
				Database.AddInParameter(cmd, "@CandidateTypeID", DbType.Int64, tran_applyanotherbatch.candidatetypeid);
			if (tran_applyanotherbatch.professionid.HasValue)
				Database.AddInParameter(cmd, "@ProfessionID", DbType.Int64, tran_applyanotherbatch.professionid);
			if (tran_applyanotherbatch.nationalityid.HasValue)
				Database.AddInParameter(cmd, "@NationalityID", DbType.Int64, tran_applyanotherbatch.nationalityid);
			if (!(string.IsNullOrEmpty(tran_applyanotherbatch.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_applyanotherbatch.remarks);
			if ((tran_applyanotherbatch.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_applyanotherbatch.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_applyanotherbatch.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_applyanotherbatch.updateinfo);
			if (tran_applyanotherbatch.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_applyanotherbatch.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_applyanotherbatchDataAccessObjects.Add(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applyanotherbatch_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applyanotherbatch, cmd,Database);
                FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.Addtran_applyanotherbatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_applyanotherbatchDataAccessObjects.Update(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_applyanotherbatch_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_applyanotherbatch, cmd,Database);
                FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.Updatetran_applyanotherbatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_applyanotherbatchDataAccessObjects.Delete(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_applyanotherbatch_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_applyanotherbatch, cmd,Database, true);
                FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.Deletetran_applyanotherbatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_applyanotherbatchDataAccessObjects.SaveList(IList<tran_applyanotherbatchEntity> listAdded, IList<tran_applyanotherbatchEntity> listUpdated, IList<tran_applyanotherbatchEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_applyanotherbatch_Ins";
            const string SPUpdate = "tran_applyanotherbatch_Upd";
            const string SPDelete = "tran_applyanotherbatch_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applyanotherbatchEntity tran_applyanotherbatch in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applyanotherbatch, cmd, Database, true);
                            FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applyanotherbatchEntity tran_applyanotherbatch in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applyanotherbatch, cmd, Database);
                            FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applyanotherbatchEntity tran_applyanotherbatch in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applyanotherbatch, cmd, Database);
                            FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.Save_tran_applyanotherbatch"));
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
       IList<tran_applyanotherbatchEntity> listAdded, 
       IList<tran_applyanotherbatchEntity> listUpdated, 
       IList<tran_applyanotherbatchEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_applyanotherbatch_Ins";
            const string SPUpdate = "tran_applyanotherbatch_Upd";
            const string SPDelete = "tran_applyanotherbatch_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applyanotherbatchEntity tran_applyanotherbatch in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applyanotherbatch, cmd, db, true);
                            FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applyanotherbatchEntity tran_applyanotherbatch in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applyanotherbatch, cmd, db);
                            FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applyanotherbatchEntity tran_applyanotherbatch in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applyanotherbatch, cmd, db);
                            FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.Save_tran_applyanotherbatch"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_applyanotherbatchEntity>> Itran_applyanotherbatchDataAccessObjects.GetAll(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applyanotherbatch_GA";
                IList<tran_applyanotherbatchEntity> itemList = new List<tran_applyanotherbatchEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_applyanotherbatch.SortExpression);
                    FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applyanotherbatch, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applyanotherbatchEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.GetAlltran_applyanotherbatch"));
            }	
        }
		
        async Task<IList<tran_applyanotherbatchEntity>> Itran_applyanotherbatchDataAccessObjects.GetAllByPages(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applyanotherbatch_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applyanotherbatch.SortExpression);
                    AddPageSizeParameter(cmd, tran_applyanotherbatch.PageSize);
                    AddCurrentPageParameter(cmd, tran_applyanotherbatch.CurrentPage);                    
                    FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applyanotherbatch, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_applyanotherbatch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applyanotherbatch.strCommonSerachParam+"%");

                    IList<tran_applyanotherbatchEntity> itemList = new List<tran_applyanotherbatchEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applyanotherbatchEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applyanotherbatch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.GetAllByPagestran_applyanotherbatch"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_applyanotherbatchEntity> Itran_applyanotherbatchDataAccessObjects.GetSingle(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applyanotherbatch_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applyanotherbatch, cmd, Database);
                    
                    IList<tran_applyanotherbatchEntity> itemList = new List<tran_applyanotherbatchEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applyanotherbatchEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.GetSingletran_applyanotherbatch"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_applyanotherbatchEntity>> Itran_applyanotherbatchDataAccessObjects.GAPgListView(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applyanotherbatch_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applyanotherbatch.SortExpression);
                    AddPageSizeParameter(cmd, tran_applyanotherbatch.PageSize);
                    AddCurrentPageParameter(cmd, tran_applyanotherbatch.CurrentPage);                    
                    FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applyanotherbatch, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_applyanotherbatch.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applyanotherbatch.strCommonSerachParam+"%");

                    IList<tran_applyanotherbatchEntity> itemList = new List<tran_applyanotherbatchEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applyanotherbatchEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applyanotherbatch.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.GAPgListViewtran_applyanotherbatch"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}