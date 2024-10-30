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
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using IDAC.Core.IDataAccessObjects.General;

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_roleDataAccessObjects : BaseDataAccess, Iowin_roleDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_roleDataAccessObjects";
        
		public owin_roleDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_roleEntity owin_role, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_role.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_role.roleid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_role.rolename)))
				Database.AddInParameter(cmd, "@RoleName", DbType.String, owin_role.rolename);
            if (owin_role.isactive.HasValue)
                Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, owin_role.isactive);
            if (!(string.IsNullOrEmpty(owin_role.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, owin_role.description);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_roleDataAccessObjects.Add(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_role_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_role, cmd,Database);
                FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Addowin_role"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_roleDataAccessObjects.Update(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_role_Upd_ext";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_role, cmd,Database);
                FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Updateowin_role"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_roleDataAccessObjects.Delete(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_role_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_role, cmd,Database, true);
                FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Deleteowin_role"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_roleDataAccessObjects.SaveList(IList<owin_roleEntity> listAdded, IList<owin_roleEntity> listUpdated, IList<owin_roleEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_role_Ins";
            const string SPUpdate = "owin_role_Upd";
            const string SPDelete = "owin_role_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_roleEntity owin_role in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_role, cmd, Database, true);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_roleEntity owin_role in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_role, cmd, Database);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_roleEntity owin_role in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_role, cmd, Database);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Save_owin_role"));
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
       IList<owin_roleEntity> listAdded, 
       IList<owin_roleEntity> listUpdated, 
       IList<owin_roleEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_role_Ins";
            const string SPUpdate = "owin_role_Upd";
            const string SPDelete = "owin_role_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_roleEntity owin_role in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_role, cmd, db, true);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, db);
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
                    foreach (owin_roleEntity owin_role in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_role, cmd, db);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, db);
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
                    foreach (owin_roleEntity owin_role in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_role, cmd, db);
                            FillSequrityParameters(owin_role.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.Save_owin_role"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_roleEntity>> Iowin_roleDataAccessObjects.GetAll(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_role_GA";
                IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_role, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetAllowin_role"));
            }	
        }
		
        async Task<IList<owin_roleEntity>> Iowin_roleDataAccessObjects.GetAllByPages(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_role_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    AddPageSizeParameter(cmd, owin_role.PageSize);
                    AddCurrentPageParameter(cmd, owin_role.CurrentPage);                    
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_role, cmd,Database);

                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_role.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetAllByPagesowin_role"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_roleEntity> Iowin_roleDataAccessObjects.GetSingle(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_role_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_role, cmd, Database);
                    
                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetSingleowin_role"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_roleEntity>> Iowin_roleDataAccessObjects.GAPgListView(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_role_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    AddPageSizeParameter(cmd, owin_role.PageSize);
                    AddCurrentPageParameter(cmd, owin_role.CurrentPage);                    
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_role, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_role.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_role.strCommonSerachParam+"%");

                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_role.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GAPgListViewowin_role"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Iowin_roleDataAccessObjects.GetDataForDropDown(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "owin_role_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_role.SortExpression);
                    AddPageSizeParameter(cmd, owin_role.PageSize);
                    AddCurrentPageParameter(cmd, owin_role.CurrentPage);
                    FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_role, cmd, Database);
                    if (!string.IsNullOrEmpty(owin_role.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + owin_role.strCommonSerachParam + "%");
                    IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_dropdownEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        owin_role.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_roleDataAccess.GetDataForDropDown"));
            }
        }
        #endregion
    }
}