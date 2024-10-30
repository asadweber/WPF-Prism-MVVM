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
	
	internal sealed partial class owin_rolepermissionDataAccessObjects : BaseDataAccess, Iowin_rolepermissionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_rolepermissionDataAccessObjects";
        
		public owin_rolepermissionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_rolepermissionEntity owin_rolepermission, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_rolepermission.rolepremissionid.HasValue)
				Database.AddInParameter(cmd, "@RolePremissionID", DbType.Int64, owin_rolepermission.rolepremissionid);
            if (forDelete) return;
			if (owin_rolepermission.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_rolepermission.roleid);
			if (owin_rolepermission.formactionid.HasValue)
				Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, owin_rolepermission.formactionid);
			if ((owin_rolepermission.status != null))
				Database.AddInParameter(cmd, "@Status", DbType.Boolean, owin_rolepermission.status);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_rolepermissionDataAccessObjects.Add(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_rolepermission_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_rolepermission, cmd,Database);
                FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.Addowin_rolepermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_rolepermissionDataAccessObjects.Update(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_rolepermission_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_rolepermission, cmd,Database);
                FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.Updateowin_rolepermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_rolepermissionDataAccessObjects.Delete(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_rolepermission_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_rolepermission, cmd,Database, true);
                FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.Deleteowin_rolepermission"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_rolepermissionDataAccessObjects.SaveList(IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_rolepermission_Ins";
            const string SPUpdate = "owin_rolepermission_Upd";
            const string SPDelete = "owin_rolepermission_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_rolepermissionEntity owin_rolepermission in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_rolepermission, cmd, Database, true);
                            FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_rolepermissionEntity owin_rolepermission in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_rolepermission, cmd, Database);
                            FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_rolepermissionEntity owin_rolepermission in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_rolepermission, cmd, Database);
                            FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.Save_owin_rolepermission"));
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
       IList<owin_rolepermissionEntity> listAdded, 
       IList<owin_rolepermissionEntity> listUpdated, 
       IList<owin_rolepermissionEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_rolepermission_Ins";
            const string SPUpdate = "owin_rolepermission_Upd";
            const string SPDelete = "owin_rolepermission_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_rolepermissionEntity owin_rolepermission in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_rolepermission, cmd, db, true);
                            FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, db);
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
                    foreach (owin_rolepermissionEntity owin_rolepermission in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_rolepermission, cmd, db);
                            FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, db);
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
                    foreach (owin_rolepermissionEntity owin_rolepermission in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_rolepermission, cmd, db);
                            FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.Save_owin_rolepermission"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_rolepermissionEntity>> Iowin_rolepermissionDataAccessObjects.GetAll(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_rolepermission_GA";
                IList<owin_rolepermissionEntity> itemList = new List<owin_rolepermissionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_rolepermission.SortExpression);
                    FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_rolepermission, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_rolepermissionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.GetAllowin_rolepermission"));
            }	
        }
		
        async Task<IList<owin_rolepermissionEntity>> Iowin_rolepermissionDataAccessObjects.GetAllByPages(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_rolepermission_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_rolepermission.SortExpression);
                    AddPageSizeParameter(cmd, owin_rolepermission.PageSize);
                    AddCurrentPageParameter(cmd, owin_rolepermission.CurrentPage);                    
                    FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_rolepermission, cmd,Database);

                    IList<owin_rolepermissionEntity> itemList = new List<owin_rolepermissionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_rolepermissionEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_rolepermission.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.GetAllByPagesowin_rolepermission"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_rolepermissionEntity> Iowin_rolepermissionDataAccessObjects.GetSingle(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_rolepermission_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_rolepermission, cmd, Database);
                    
                    IList<owin_rolepermissionEntity> itemList = new List<owin_rolepermissionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_rolepermissionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.GetSingleowin_rolepermission"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_rolepermissionEntity>> Iowin_rolepermissionDataAccessObjects.GAPgListView(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_rolepermission_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_rolepermission.SortExpression);
                    AddPageSizeParameter(cmd, owin_rolepermission.PageSize);
                    AddCurrentPageParameter(cmd, owin_rolepermission.CurrentPage);                    
                    FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_rolepermission, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_rolepermission.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_rolepermission.strCommonSerachParam+"%");

                    IList<owin_rolepermissionEntity> itemList = new List<owin_rolepermissionEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_rolepermissionEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_rolepermission.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.GAPgListViewowin_rolepermission"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}