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
	
	internal sealed partial class tran_loginDataAccessObjects : BaseDataAccess, Itran_loginDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_loginDataAccessObjects";
        
		public tran_loginDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_loginEntity tran_login, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_login.serialloginid.HasValue)
				Database.AddInParameter(cmd, "@SerialLoginID", DbType.Int64, tran_login.serialloginid);
            if (forDelete) return;
			if (tran_login.parentserialloginid.HasValue)
				Database.AddInParameter(cmd, "@ParentSerialLoginID", DbType.Int64, tran_login.parentserialloginid);
			if (!(string.IsNullOrEmpty(tran_login.samaccount)))
				Database.AddInParameter(cmd, "@SAMAccount", DbType.String, tran_login.samaccount);
			if (!(string.IsNullOrEmpty(tran_login.samemail)))
				Database.AddInParameter(cmd, "@SAMEmail", DbType.String, tran_login.samemail);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, tran_login.userid);
			if ((tran_login.logindate.HasValue))
				Database.AddInParameter(cmd, "@LoginDate", DbType.DateTime, tran_login.logindate);
			if (!(string.IsNullOrEmpty(tran_login.logintoken)))
				Database.AddInParameter(cmd, "@LoginToken", DbType.String, tran_login.logintoken);
			if (!(string.IsNullOrEmpty(tran_login.refreshtoken)))
				Database.AddInParameter(cmd, "@RefreshToken", DbType.String, tran_login.refreshtoken);
			if ((tran_login.tokenissuedate.HasValue))
				Database.AddInParameter(cmd, "@TokenIssueDate", DbType.DateTime, tran_login.tokenissuedate);
			if ((tran_login.expires.HasValue))
				Database.AddInParameter(cmd, "@Expires", DbType.DateTime, tran_login.expires);
			if (!(string.IsNullOrEmpty(tran_login.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_login.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Itran_loginDataAccessObjects.Add(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_login_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_login, cmd,Database);
                FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.Addtran_login"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_loginDataAccessObjects.Update(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_login_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_login, cmd,Database);
                FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.Updatetran_login"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_loginDataAccessObjects.Delete(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_login_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_login, cmd,Database, true);
                FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.Deletetran_login"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_loginDataAccessObjects.SaveList(IList<tran_loginEntity> listAdded, IList<tran_loginEntity> listUpdated, IList<tran_loginEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_login_Ins";
            const string SPUpdate = "tran_login_Upd";
            const string SPDelete = "tran_login_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_loginEntity tran_login in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_login, cmd, Database, true);
                            FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_loginEntity tran_login in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_login, cmd, Database);
                            FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_loginEntity tran_login in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_login, cmd, Database);
                            FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.Save_tran_login"));
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
       IList<tran_loginEntity> listAdded, 
       IList<tran_loginEntity> listUpdated, 
       IList<tran_loginEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_login_Ins";
            const string SPUpdate = "tran_login_Upd";
            const string SPDelete = "tran_login_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_loginEntity tran_login in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_login, cmd, db, true);
                            FillSequrityParameters(tran_login.BaseSecurityParam, cmd, db);
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
                    foreach (tran_loginEntity tran_login in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_login, cmd, db);
                            FillSequrityParameters(tran_login.BaseSecurityParam, cmd, db);
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
                    foreach (tran_loginEntity tran_login in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_login, cmd, db);
                            FillSequrityParameters(tran_login.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.Save_tran_login"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_loginEntity>> Itran_loginDataAccessObjects.GetAll(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_login_GA";
                IList<tran_loginEntity> itemList = new List<tran_loginEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_login.SortExpression);
                    FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_login, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_loginEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.GetAlltran_login"));
            }	
        }
		
        async Task<IList<tran_loginEntity>> Itran_loginDataAccessObjects.GetAllByPages(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_login_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_login.SortExpression);
                    AddPageSizeParameter(cmd, tran_login.PageSize);
                    AddCurrentPageParameter(cmd, tran_login.CurrentPage);                    
                    FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_login, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_login.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_login.strCommonSerachParam+"%");

                    IList<tran_loginEntity> itemList = new List<tran_loginEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_loginEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_login.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.GetAllByPagestran_login"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_loginEntity> Itran_loginDataAccessObjects.GetSingle(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_login_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_login, cmd, Database);
                    
                    IList<tran_loginEntity> itemList = new List<tran_loginEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_loginEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.GetSingletran_login"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_loginEntity>> Itran_loginDataAccessObjects.GAPgListView(tran_loginEntity tran_login, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_login_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_login.SortExpression);
                    AddPageSizeParameter(cmd, tran_login.PageSize);
                    AddCurrentPageParameter(cmd, tran_login.CurrentPage);                    
                    FillSequrityParameters(tran_login.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_login, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_login.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_login.strCommonSerachParam+"%");

                    IList<tran_loginEntity> itemList = new List<tran_loginEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_loginEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_login.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_loginDataAccess.GAPgListViewtran_login"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}