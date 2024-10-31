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
	
	internal sealed partial class tran_auditresultDataAccessObjects : BaseDataAccess, Itran_auditresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_auditresultDataAccessObjects";
        
		public tran_auditresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_auditresultEntity tran_auditresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_auditresult.auditresultid.HasValue)
				Database.AddInParameter(cmd, "@AuditResultID", DbType.Int64, tran_auditresult.auditresultid);
            if (forDelete) return;
			if (tran_auditresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_auditresult.basicinfoid);
			if (tran_auditresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_auditresult.registrationid);
			if (tran_auditresult.auditresult.HasValue)
				Database.AddInParameter(cmd, "@AuditResult", DbType.Int64, tran_auditresult.auditresult);
			if (!(string.IsNullOrEmpty(tran_auditresult.auditcomment)))
				Database.AddInParameter(cmd, "@AuditComment", DbType.String, tran_auditresult.auditcomment);
			if ((tran_auditresult.auditdate.HasValue))
				Database.AddInParameter(cmd, "@AuditDate", DbType.DateTime, tran_auditresult.auditdate);
			if (!(string.IsNullOrEmpty(tran_auditresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_auditresult.remarks);
			if ((tran_auditresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_auditresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_auditresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_auditresult.updateinfo);
			if (tran_auditresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_auditresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_auditresultDataAccessObjects.Add(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_auditresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_auditresult, cmd,Database);
                FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.Addtran_auditresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_auditresultDataAccessObjects.Update(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_auditresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_auditresult, cmd,Database);
                FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.Updatetran_auditresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_auditresultDataAccessObjects.Delete(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_auditresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_auditresult, cmd,Database, true);
                FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.Deletetran_auditresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_auditresultDataAccessObjects.SaveList(IList<tran_auditresultEntity> listAdded, IList<tran_auditresultEntity> listUpdated, IList<tran_auditresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_auditresult_Ins";
            const string SPUpdate = "tran_auditresult_Upd";
            const string SPDelete = "tran_auditresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_auditresultEntity tran_auditresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_auditresult, cmd, Database, true);
                            FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_auditresultEntity tran_auditresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_auditresult, cmd, Database);
                            FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_auditresultEntity tran_auditresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_auditresult, cmd, Database);
                            FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.Save_tran_auditresult"));
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
       IList<tran_auditresultEntity> listAdded, 
       IList<tran_auditresultEntity> listUpdated, 
       IList<tran_auditresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_auditresult_Ins";
            const string SPUpdate = "tran_auditresult_Upd";
            const string SPDelete = "tran_auditresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_auditresultEntity tran_auditresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_auditresult, cmd, db, true);
                            FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_auditresultEntity tran_auditresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_auditresult, cmd, db);
                            FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_auditresultEntity tran_auditresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_auditresult, cmd, db);
                            FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.Save_tran_auditresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_auditresultEntity>> Itran_auditresultDataAccessObjects.GetAll(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_auditresult_GA";
                IList<tran_auditresultEntity> itemList = new List<tran_auditresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_auditresult.SortExpression);
                    FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_auditresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_auditresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.GetAlltran_auditresult"));
            }	
        }
		
        async Task<IList<tran_auditresultEntity>> Itran_auditresultDataAccessObjects.GetAllByPages(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_auditresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_auditresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_auditresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_auditresult.CurrentPage);                    
                    FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_auditresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_auditresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_auditresult.strCommonSerachParam+"%");

                    IList<tran_auditresultEntity> itemList = new List<tran_auditresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_auditresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_auditresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.GetAllByPagestran_auditresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_auditresultEntity> Itran_auditresultDataAccessObjects.GetSingle(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_auditresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_auditresult, cmd, Database);
                    
                    IList<tran_auditresultEntity> itemList = new List<tran_auditresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_auditresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.GetSingletran_auditresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_auditresultEntity>> Itran_auditresultDataAccessObjects.GAPgListView(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_auditresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_auditresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_auditresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_auditresult.CurrentPage);                    
                    FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_auditresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_auditresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_auditresult.strCommonSerachParam+"%");

                    IList<tran_auditresultEntity> itemList = new List<tran_auditresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_auditresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_auditresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.GAPgListViewtran_auditresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}