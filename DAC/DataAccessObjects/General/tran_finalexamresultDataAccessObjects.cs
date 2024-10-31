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
	
	internal sealed partial class tran_finalexamresultDataAccessObjects : BaseDataAccess, Itran_finalexamresultDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_finalexamresultDataAccessObjects";
        
		public tran_finalexamresultDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_finalexamresultEntity tran_finalexamresult, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_finalexamresult.finalexamresultid.HasValue)
				Database.AddInParameter(cmd, "@FinalExamResultID", DbType.Int64, tran_finalexamresult.finalexamresultid);
            if (forDelete) return;
			if (tran_finalexamresult.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_finalexamresult.basicinfoid);
			if (tran_finalexamresult.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_finalexamresult.registrationid);
			if (tran_finalexamresult.finalexamresult.HasValue)
				Database.AddInParameter(cmd, "@FinalExamResult", DbType.Int32, tran_finalexamresult.finalexamresult);
			if (!(string.IsNullOrEmpty(tran_finalexamresult.finalexamcomment)))
				Database.AddInParameter(cmd, "@FinalExamComment", DbType.String, tran_finalexamresult.finalexamcomment);
			if ((tran_finalexamresult.finalexamresultdate.HasValue))
				Database.AddInParameter(cmd, "@FinalExamResultDate", DbType.DateTime, tran_finalexamresult.finalexamresultdate);
			if (!(string.IsNullOrEmpty(tran_finalexamresult.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_finalexamresult.remarks);
			if ((tran_finalexamresult.issoftdeleted != null))
				Database.AddInParameter(cmd, "@IsSoftDeleted", DbType.Boolean, tran_finalexamresult.issoftdeleted);
			if (!(string.IsNullOrEmpty(tran_finalexamresult.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_finalexamresult.updateinfo);
			if (tran_finalexamresult.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_finalexamresult.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_finalexamresultDataAccessObjects.Add(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_finalexamresult_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_finalexamresult, cmd,Database);
                FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.Addtran_finalexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_finalexamresultDataAccessObjects.Update(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_finalexamresult_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_finalexamresult, cmd,Database);
                FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.Updatetran_finalexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_finalexamresultDataAccessObjects.Delete(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_finalexamresult_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_finalexamresult, cmd,Database, true);
                FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.Deletetran_finalexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_finalexamresultDataAccessObjects.SaveList(IList<tran_finalexamresultEntity> listAdded, IList<tran_finalexamresultEntity> listUpdated, IList<tran_finalexamresultEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_finalexamresult_Ins";
            const string SPUpdate = "tran_finalexamresult_Upd";
            const string SPDelete = "tran_finalexamresult_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_finalexamresultEntity tran_finalexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_finalexamresult, cmd, Database, true);
                            FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_finalexamresultEntity tran_finalexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_finalexamresult, cmd, Database);
                            FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_finalexamresultEntity tran_finalexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_finalexamresult, cmd, Database);
                            FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.Save_tran_finalexamresult"));
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
       IList<tran_finalexamresultEntity> listAdded, 
       IList<tran_finalexamresultEntity> listUpdated, 
       IList<tran_finalexamresultEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_finalexamresult_Ins";
            const string SPUpdate = "tran_finalexamresult_Upd";
            const string SPDelete = "tran_finalexamresult_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_finalexamresultEntity tran_finalexamresult in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_finalexamresult, cmd, db, true);
                            FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_finalexamresultEntity tran_finalexamresult in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_finalexamresult, cmd, db);
                            FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, db);
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
                    foreach (tran_finalexamresultEntity tran_finalexamresult in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_finalexamresult, cmd, db);
                            FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.Save_tran_finalexamresult"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_finalexamresultEntity>> Itran_finalexamresultDataAccessObjects.GetAll(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_finalexamresult_GA";
                IList<tran_finalexamresultEntity> itemList = new List<tran_finalexamresultEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_finalexamresult.SortExpression);
                    FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_finalexamresult, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamresultEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.GetAlltran_finalexamresult"));
            }	
        }
		
        async Task<IList<tran_finalexamresultEntity>> Itran_finalexamresultDataAccessObjects.GetAllByPages(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_finalexamresult_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_finalexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_finalexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_finalexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_finalexamresult, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_finalexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_finalexamresult.strCommonSerachParam+"%");

                    IList<tran_finalexamresultEntity> itemList = new List<tran_finalexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_finalexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.GetAllByPagestran_finalexamresult"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_finalexamresultEntity> Itran_finalexamresultDataAccessObjects.GetSingle(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_finalexamresult_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_finalexamresult, cmd, Database);
                    
                    IList<tran_finalexamresultEntity> itemList = new List<tran_finalexamresultEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.GetSingletran_finalexamresult"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_finalexamresultEntity>> Itran_finalexamresultDataAccessObjects.GAPgListView(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_finalexamresult_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_finalexamresult.SortExpression);
                    AddPageSizeParameter(cmd, tran_finalexamresult.PageSize);
                    AddCurrentPageParameter(cmd, tran_finalexamresult.CurrentPage);                    
                    FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_finalexamresult, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_finalexamresult.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_finalexamresult.strCommonSerachParam+"%");

                    IList<tran_finalexamresultEntity> itemList = new List<tran_finalexamresultEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamresultEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_finalexamresult.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.GAPgListViewtran_finalexamresult"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}