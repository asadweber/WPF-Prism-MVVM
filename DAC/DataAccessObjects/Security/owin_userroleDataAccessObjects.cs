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
	
	internal sealed partial class owin_userroleDataAccessObjects : BaseDataAccess, Iowin_userroleDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userroleDataAccessObjects";
        
		public owin_userroleDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userroleEntity owin_userrole, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userrole.userroleid.HasValue)
				Database.AddInParameter(cmd, "@UserRoleID", DbType.Int64, owin_userrole.userroleid);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userrole.userid);
			if (owin_userrole.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_userrole.masteruserid);
			if (owin_userrole.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_userrole.roleid);
			if ((owin_userrole.isenable != null))
				Database.AddInParameter(cmd, "@IsEnable", DbType.Boolean, owin_userrole.isenable);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userroleDataAccessObjects.Add(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userrole_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userrole, cmd,Database);
                FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.Addowin_userrole"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userroleDataAccessObjects.Update(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userrole_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userrole, cmd,Database);
                FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.Updateowin_userrole"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userroleDataAccessObjects.Delete(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userrole_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userrole, cmd,Database, true);
                FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.Deleteowin_userrole"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userroleDataAccessObjects.SaveList(IList<owin_userroleEntity> listAdded, IList<owin_userroleEntity> listUpdated, IList<owin_userroleEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userrole_Ins";
            const string SPUpdate = "owin_userrole_Upd";
            const string SPDelete = "owin_userrole_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroleEntity owin_userrole in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userrole, cmd, Database, true);
                            FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroleEntity owin_userrole in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userrole, cmd, Database);
                            FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userroleEntity owin_userrole in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userrole, cmd, Database);
                            FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.Save_owin_userrole"));
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
       IList<owin_userroleEntity> listAdded, 
       IList<owin_userroleEntity> listUpdated, 
       IList<owin_userroleEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userrole_Ins";
            const string SPUpdate = "owin_userrole_Upd";
            const string SPDelete = "owin_userrole_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userroleEntity owin_userrole in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userrole, cmd, db, true);
                            FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroleEntity owin_userrole in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userrole, cmd, db);
                            FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userroleEntity owin_userrole in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userrole, cmd, db);
                            FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.Save_owin_userrole"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userroleEntity>> Iowin_userroleDataAccessObjects.GetAll(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userrole_GA";
                IList<owin_userroleEntity> itemList = new List<owin_userroleEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userrole.SortExpression);
                    FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userrole, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroleEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.GetAllowin_userrole"));
            }	
        }
		
        async Task<IList<owin_userroleEntity>> Iowin_userroleDataAccessObjects.GetAllByPages(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userrole_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userrole.SortExpression);
                    AddPageSizeParameter(cmd, owin_userrole.PageSize);
                    AddCurrentPageParameter(cmd, owin_userrole.CurrentPage);                    
                    FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userrole, cmd,Database);

                    IList<owin_userroleEntity> itemList = new List<owin_userroleEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroleEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userrole.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.GetAllByPagesowin_userrole"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userroleEntity> Iowin_userroleDataAccessObjects.GetSingle(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userrole_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userrole, cmd, Database);
                    
                    IList<owin_userroleEntity> itemList = new List<owin_userroleEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroleEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.GetSingleowin_userrole"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userroleEntity>> Iowin_userroleDataAccessObjects.GAPgListView(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userrole_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userrole.SortExpression);
                    AddPageSizeParameter(cmd, owin_userrole.PageSize);
                    AddCurrentPageParameter(cmd, owin_userrole.CurrentPage);                    
                    FillSequrityParameters(owin_userrole.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userrole, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userrole.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userrole.strCommonSerachParam+"%");

                    IList<owin_userroleEntity> itemList = new List<owin_userroleEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userroleEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userrole.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userroleDataAccess.GAPgListViewowin_userrole"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}