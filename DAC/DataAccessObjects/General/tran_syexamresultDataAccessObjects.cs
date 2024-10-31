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
	
	internal sealed partial class tran_syexamresultDataAccessObjects : BaseDataAccess, Itran_syexamresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_syexamresultDataAccessObjects";
        
		public tran_syexamresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_syexamresultEntity tran_syexamresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_syexamresult.syexamresultid.HasValue)
				Database.AddInParameter(cmd, "@SyExamResultID", DbType.Int64, tran_syexamresult.syexamresultid);
            if (forDelete) return;
			if (tran_syexamresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_syexamresult.basicinfoid);
			if (tran_syexamresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_syexamresult.registrationid);
			if (tran_syexamresult.syexamresult.HasValue)
				Database.AddInParameter(cmd, "@SyExamResult", DbType.Int32, tran_syexamresult.syexamresult);
			if (!(string.IsNullOrEmpty(tran_syexamresult.syexamcomment)))
				Database.AddInParameter(cmd, "@SyExamComment", DbType.String, tran_syexamresult.syexamcomment);
			if ((tran_syexamresult.syexamresultdate.HasValue))
				Database.AddInParameter(cmd, "@SyExamResultDate", DbType.DateTime, tran_syexamresult.syexamresultdate);
			if (!(string.IsNullOrEmpty(tran_syexamresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_syexamresult.remarks);
			if ((tran_syexamresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_syexamresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_syexamresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_syexamresult.updateinfo);
			if (tran_syexamresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_syexamresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_syexamresultDataAccessObjects.Add(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_syexamresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_syexamresult, cmd,Database);
                FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.Addtran_syexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_syexamresultDataAccessObjects.Update(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_syexamresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_syexamresult, cmd,Database);
                FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.Updatetran_syexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_syexamresultDataAccessObjects.Delete(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_syexamresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_syexamresult, cmd,Database, true);
                FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.Deletetran_syexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_syexamresultDataAccessObjects.SaveList(IList<tran_syexamresultEntity> listAdded, IList<tran_syexamresultEntity> listUpdated, IList<tran_syexamresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_syexamresult_Ins";
            const string SPUpdate = "tran_syexamresult_Upd";
            const string SPDelete = "tran_syexamresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_syexamresultEntity tran_syexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_syexamresult, cmd, Database, true);
                            FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_syexamresultEntity tran_syexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_syexamresult, cmd, Database);
                            FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_syexamresultEntity tran_syexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_syexamresult, cmd, Database);
                            FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.Save_tran_syexamresult"));
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
       IList<tran_syexamresultEntity> listAdded, 
       IList<tran_syexamresultEntity> listUpdated, 
       IList<tran_syexamresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_syexamresult_Ins";
            const string SPUpdate = "tran_syexamresult_Upd";
            const string SPDelete = "tran_syexamresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_syexamresultEntity tran_syexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_syexamresult, cmd, db, true);
                            FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_syexamresultEntity tran_syexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_syexamresult, cmd, db);
                            FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_syexamresultEntity tran_syexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_syexamresult, cmd, db);
                            FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.Save_tran_syexamresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_syexamresultEntity>> Itran_syexamresultDataAccessObjects.GetAll(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_syexamresult_GA";
                IList<tran_syexamresultEntity> itemList = new List<tran_syexamresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_syexamresult.SortExpression);
                    FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_syexamresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.GetAlltran_syexamresult"));
            }	
        }
		
        async Task<IList<tran_syexamresultEntity>> Itran_syexamresultDataAccessObjects.GetAllByPages(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_syexamresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_syexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_syexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_syexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_syexamresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_syexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_syexamresult.strCommonSerachParam+"%");

                    IList<tran_syexamresultEntity> itemList = new List<tran_syexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_syexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.GetAllByPagestran_syexamresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_syexamresultEntity> Itran_syexamresultDataAccessObjects.GetSingle(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_syexamresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_syexamresult, cmd, Database);
                    
                    IList<tran_syexamresultEntity> itemList = new List<tran_syexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.GetSingletran_syexamresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_syexamresultEntity>> Itran_syexamresultDataAccessObjects.GAPgListView(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_syexamresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_syexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_syexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_syexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_syexamresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_syexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_syexamresult.strCommonSerachParam+"%");

                    IList<tran_syexamresultEntity> itemList = new List<tran_syexamresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_syexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.GAPgListViewtran_syexamresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}