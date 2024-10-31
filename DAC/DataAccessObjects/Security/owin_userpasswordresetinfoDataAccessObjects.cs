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
	
	internal sealed partial class owin_userpasswordresetinfoDataAccessObjects : BaseDataAccess, Iowin_userpasswordresetinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userpasswordresetinfoDataAccessObjects";
        
		public owin_userpasswordresetinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userpasswordresetinfo.serial.HasValue)
				Database.AddInParameter(cmd, "@Serial", DbType.Int64, owin_userpasswordresetinfo.serial);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_userpasswordresetinfo.sessionid)))
				Database.AddInParameter(cmd, "@SessionID", DbType.String, owin_userpasswordresetinfo.sessionid);
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userpasswordresetinfo.userid);
			if (owin_userpasswordresetinfo.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_userpasswordresetinfo.masteruserid);
			if (!(string.IsNullOrEmpty(owin_userpasswordresetinfo.sessiontoken)))
				Database.AddInParameter(cmd, "@SessionToken", DbType.String, owin_userpasswordresetinfo.sessiontoken);
			if (!(string.IsNullOrEmpty(owin_userpasswordresetinfo.username)))
				Database.AddInParameter(cmd, "@UserName", DbType.String, owin_userpasswordresetinfo.username);
			if ((owin_userpasswordresetinfo.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, owin_userpasswordresetinfo.isactive);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userpasswordresetinfoDataAccessObjects.Add(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userpasswordresetinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userpasswordresetinfo, cmd,Database);
                FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.Addowin_userpasswordresetinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userpasswordresetinfoDataAccessObjects.Update(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userpasswordresetinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userpasswordresetinfo, cmd,Database);
                FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.Updateowin_userpasswordresetinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userpasswordresetinfoDataAccessObjects.Delete(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userpasswordresetinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userpasswordresetinfo, cmd,Database, true);
                FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.Deleteowin_userpasswordresetinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userpasswordresetinfoDataAccessObjects.SaveList(IList<owin_userpasswordresetinfoEntity> listAdded, IList<owin_userpasswordresetinfoEntity> listUpdated, IList<owin_userpasswordresetinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userpasswordresetinfo_Ins";
            const string SPUpdate = "owin_userpasswordresetinfo_Upd";
            const string SPDelete = "owin_userpasswordresetinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userpasswordresetinfoEntity owin_userpasswordresetinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userpasswordresetinfo, cmd, Database, true);
                            FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userpasswordresetinfoEntity owin_userpasswordresetinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userpasswordresetinfo, cmd, Database);
                            FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userpasswordresetinfoEntity owin_userpasswordresetinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userpasswordresetinfo, cmd, Database);
                            FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.Save_owin_userpasswordresetinfo"));
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
       IList<owin_userpasswordresetinfoEntity> listAdded, 
       IList<owin_userpasswordresetinfoEntity> listUpdated, 
       IList<owin_userpasswordresetinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userpasswordresetinfo_Ins";
            const string SPUpdate = "owin_userpasswordresetinfo_Upd";
            const string SPDelete = "owin_userpasswordresetinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userpasswordresetinfoEntity owin_userpasswordresetinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userpasswordresetinfo, cmd, db, true);
                            FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userpasswordresetinfoEntity owin_userpasswordresetinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userpasswordresetinfo, cmd, db);
                            FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userpasswordresetinfoEntity owin_userpasswordresetinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userpasswordresetinfo, cmd, db);
                            FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.Save_owin_userpasswordresetinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userpasswordresetinfoEntity>> Iowin_userpasswordresetinfoDataAccessObjects.GetAll(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userpasswordresetinfo_GA";
                IList<owin_userpasswordresetinfoEntity> itemList = new List<owin_userpasswordresetinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userpasswordresetinfo.SortExpression);
                    FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userpasswordresetinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userpasswordresetinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.GetAllowin_userpasswordresetinfo"));
            }	
        }
		
        async Task<IList<owin_userpasswordresetinfoEntity>> Iowin_userpasswordresetinfoDataAccessObjects.GetAllByPages(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userpasswordresetinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userpasswordresetinfo.SortExpression);
                    AddPageSizeParameter(cmd, owin_userpasswordresetinfo.PageSize);
                    AddCurrentPageParameter(cmd, owin_userpasswordresetinfo.CurrentPage);                    
                    FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userpasswordresetinfo, cmd,Database);

                    IList<owin_userpasswordresetinfoEntity> itemList = new List<owin_userpasswordresetinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userpasswordresetinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userpasswordresetinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.GetAllByPagesowin_userpasswordresetinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userpasswordresetinfoEntity> Iowin_userpasswordresetinfoDataAccessObjects.GetSingle(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userpasswordresetinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userpasswordresetinfo, cmd, Database);
                    
                    IList<owin_userpasswordresetinfoEntity> itemList = new List<owin_userpasswordresetinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userpasswordresetinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.GetSingleowin_userpasswordresetinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userpasswordresetinfoEntity>> Iowin_userpasswordresetinfoDataAccessObjects.GAPgListView(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userpasswordresetinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userpasswordresetinfo.SortExpression);
                    AddPageSizeParameter(cmd, owin_userpasswordresetinfo.PageSize);
                    AddCurrentPageParameter(cmd, owin_userpasswordresetinfo.CurrentPage);                    
                    FillSequrityParameters(owin_userpasswordresetinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userpasswordresetinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userpasswordresetinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userpasswordresetinfo.strCommonSerachParam+"%");

                    IList<owin_userpasswordresetinfoEntity> itemList = new List<owin_userpasswordresetinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userpasswordresetinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userpasswordresetinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userpasswordresetinfoDataAccess.GAPgListViewowin_userpasswordresetinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}