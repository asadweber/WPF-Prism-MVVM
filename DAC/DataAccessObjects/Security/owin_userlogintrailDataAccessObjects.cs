using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.Base;

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_userlogintrailDataAccessObjects : BaseDataAccess, Iowin_userlogintrailDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userlogintrailDataAccessObjects";
        
		public owin_userlogintrailDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userlogintrailEntity owin_userlogintrail, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userlogintrail.serialno.HasValue)
				Database.AddInParameter(cmd, "@SerialNo", DbType.Int64, owin_userlogintrail.serialno);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userlogintrail.userid);
			if (owin_userlogintrail.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_userlogintrail.masteruserid);
			if (!(string.IsNullOrEmpty(owin_userlogintrail.loginfrom)))
				Database.AddInParameter(cmd, "@LoginFrom", DbType.String, owin_userlogintrail.loginfrom);
			if ((owin_userlogintrail.logindate.HasValue))
				Database.AddInParameter(cmd, "@LoginDate", DbType.DateTime, owin_userlogintrail.logindate);
			if ((owin_userlogintrail.logoutdate.HasValue))
				Database.AddInParameter(cmd, "@LogoutDate", DbType.DateTime, owin_userlogintrail.logoutdate);
			if (!(string.IsNullOrEmpty(owin_userlogintrail.machineip)))
				Database.AddInParameter(cmd, "@MachineIP", DbType.String, owin_userlogintrail.machineip);
			if (!(string.IsNullOrEmpty(owin_userlogintrail.loginstatus)))
				Database.AddInParameter(cmd, "@LoginStatus", DbType.String, owin_userlogintrail.loginstatus);
			if ((owin_userlogintrail.loginstatusbit != null))
				Database.AddInParameter(cmd, "@LoginStatusBit", DbType.Boolean, owin_userlogintrail.loginstatusbit);
			if (!(string.IsNullOrEmpty(owin_userlogintrail.sessionid)))
				Database.AddInParameter(cmd, "@SessionID", DbType.String, owin_userlogintrail.sessionid);
			if (!(string.IsNullOrEmpty(owin_userlogintrail.usertoken)))
				Database.AddInParameter(cmd, "@UserToken", DbType.String, owin_userlogintrail.usertoken);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userlogintrailDataAccessObjects.Add(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userlogintrail_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userlogintrail, cmd,Database);
                FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.Addowin_userlogintrail"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userlogintrailDataAccessObjects.Update(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userlogintrail_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userlogintrail, cmd,Database);
                FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.Updateowin_userlogintrail"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userlogintrailDataAccessObjects.Delete(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userlogintrail_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userlogintrail, cmd,Database, true);
                FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.Deleteowin_userlogintrail"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userlogintrailDataAccessObjects.SaveList(IList<owin_userlogintrailEntity> listAdded, IList<owin_userlogintrailEntity> listUpdated, IList<owin_userlogintrailEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userlogintrail_Ins";
            const string SPUpdate = "owin_userlogintrail_Upd";
            const string SPDelete = "owin_userlogintrail_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userlogintrailEntity owin_userlogintrail in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userlogintrail, cmd, Database, true);
                            FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userlogintrailEntity owin_userlogintrail in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userlogintrail, cmd, Database);
                            FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userlogintrailEntity owin_userlogintrail in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userlogintrail, cmd, Database);
                            FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.Save_owin_userlogintrail"));
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
       IList<owin_userlogintrailEntity> listAdded, 
       IList<owin_userlogintrailEntity> listUpdated, 
       IList<owin_userlogintrailEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userlogintrail_Ins";
            const string SPUpdate = "owin_userlogintrail_Upd";
            const string SPDelete = "owin_userlogintrail_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userlogintrailEntity owin_userlogintrail in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userlogintrail, cmd, db, true);
                            FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userlogintrailEntity owin_userlogintrail in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userlogintrail, cmd, db);
                            FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userlogintrailEntity owin_userlogintrail in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userlogintrail, cmd, db);
                            FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.Save_owin_userlogintrail"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userlogintrailEntity>> Iowin_userlogintrailDataAccessObjects.GetAll(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userlogintrail_GA";
                IList<owin_userlogintrailEntity> itemList = new List<owin_userlogintrailEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userlogintrail.SortExpression);
                    FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userlogintrail, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userlogintrailEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.GetAllowin_userlogintrail"));
            }	
        }
		
        async Task<IList<owin_userlogintrailEntity>> Iowin_userlogintrailDataAccessObjects.GetAllByPages(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userlogintrail_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userlogintrail.SortExpression);
                    AddPageSizeParameter(cmd, owin_userlogintrail.PageSize);
                    AddCurrentPageParameter(cmd, owin_userlogintrail.CurrentPage);                    
                    FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userlogintrail, cmd,Database);

                    IList<owin_userlogintrailEntity> itemList = new List<owin_userlogintrailEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userlogintrailEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userlogintrail.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.GetAllByPagesowin_userlogintrail"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userlogintrailEntity> Iowin_userlogintrailDataAccessObjects.GetSingle(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userlogintrail_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userlogintrail, cmd, Database);
                    
                    IList<owin_userlogintrailEntity> itemList = new List<owin_userlogintrailEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userlogintrailEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.GetSingleowin_userlogintrail"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userlogintrailEntity>> Iowin_userlogintrailDataAccessObjects.GAPgListView(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userlogintrail_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userlogintrail.SortExpression);
                    AddPageSizeParameter(cmd, owin_userlogintrail.PageSize);
                    AddCurrentPageParameter(cmd, owin_userlogintrail.CurrentPage);                    
                    FillSequrityParameters(owin_userlogintrail.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userlogintrail, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userlogintrail.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userlogintrail.strCommonSerachParam+"%");

                    IList<owin_userlogintrailEntity> itemList = new List<owin_userlogintrailEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userlogintrailEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userlogintrail.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userlogintrailDataAccess.GAPgListViewowin_userlogintrail"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}