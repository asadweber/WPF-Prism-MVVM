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
	
	internal sealed partial class owin_userrolesDataAccessObjects : BaseDataAccess, Iowin_userrolesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userrolesDataAccessObjects";
        
		public owin_userrolesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userrolesEntity owin_userroles, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userroles.userid.HasValue)
				Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_userroles.userid);
			if (owin_userroles.roleid.HasValue)
				Database.AddInParameter(cmd, "@RoleId", DbType.Int64, owin_userroles.roleid);
            if (forDelete) return;

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userrolesDataAccessObjects.Add(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userroles_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userroles, cmd,Database);
                FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.Addowin_userroles"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userrolesDataAccessObjects.Update(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userroles_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userroles, cmd,Database);
                FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.Updateowin_userroles"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userrolesDataAccessObjects.Delete(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userroles_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userroles, cmd,Database, true);
                FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.Deleteowin_userroles"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userrolesDataAccessObjects.SaveList(IList<owin_userrolesEntity> listAdded, IList<owin_userrolesEntity> listUpdated, IList<owin_userrolesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userroles_Ins";
            const string SPUpdate = "owin_userroles_Upd";
            const string SPDelete = "owin_userroles_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userrolesEntity owin_userroles in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroles, cmd, Database, true);
                            FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userrolesEntity owin_userroles in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroles, cmd, Database);
                            FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userrolesEntity owin_userroles in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroles, cmd, Database);
                            FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.Save_owin_userroles"));
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
       IList<owin_userrolesEntity> listAdded, 
       IList<owin_userrolesEntity> listUpdated, 
       IList<owin_userrolesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userroles_Ins";
            const string SPUpdate = "owin_userroles_Upd";
            const string SPDelete = "owin_userroles_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userrolesEntity owin_userroles in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userroles, cmd, db, true);
                            FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userrolesEntity owin_userroles in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userroles, cmd, db);
                            FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userrolesEntity owin_userroles in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userroles, cmd, db);
                            FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.Save_owin_userroles"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userrolesEntity>> Iowin_userrolesDataAccessObjects.GetAll(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userroles_GA";
                IList<owin_userrolesEntity> itemList = new List<owin_userrolesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userroles.SortExpression);
                    FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroles, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userrolesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.GetAllowin_userroles"));
            }	
        }
		
        async Task<IList<owin_userrolesEntity>> Iowin_userrolesDataAccessObjects.GetAllByPages(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userroles_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroles.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroles.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroles.CurrentPage);                    
                    FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroles, cmd,Database);

                    IList<owin_userrolesEntity> itemList = new List<owin_userrolesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userrolesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroles.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.GetAllByPagesowin_userroles"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userrolesEntity> Iowin_userrolesDataAccessObjects.GetSingle(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userroles_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userroles, cmd, Database);
                    
                    IList<owin_userrolesEntity> itemList = new List<owin_userrolesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userrolesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.GetSingleowin_userroles"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userrolesEntity>> Iowin_userrolesDataAccessObjects.GAPgListView(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userroles_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userroles.SortExpression);
                    AddPageSizeParameter(cmd, owin_userroles.PageSize);
                    AddCurrentPageParameter(cmd, owin_userroles.CurrentPage);                    
                    FillSequrityParameters(owin_userroles.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userroles, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userroles.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userroles.strCommonSerachParam+"%");

                    IList<owin_userrolesEntity> itemList = new List<owin_userrolesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userrolesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userroles.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userrolesDataAccess.GAPgListViewowin_userroles"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}