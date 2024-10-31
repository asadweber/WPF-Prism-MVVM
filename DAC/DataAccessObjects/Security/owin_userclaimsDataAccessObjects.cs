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
	
	internal sealed partial class owin_userclaimsDataAccessObjects : BaseDataAccess, Iowin_userclaimsDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userclaimsDataAccessObjects";
        
		public owin_userclaimsDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userclaimsEntity owin_userclaims, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userclaims.id.HasValue)
				Database.AddInParameter(cmd, "@Id", DbType.Int32, owin_userclaims.id);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(owin_userclaims.claimtype)))
				Database.AddInParameter(cmd, "@ClaimType", DbType.String, owin_userclaims.claimtype);
			if (!(string.IsNullOrEmpty(owin_userclaims.claimvalue)))
				Database.AddInParameter(cmd, "@ClaimValue", DbType.String, owin_userclaims.claimvalue);
			
				Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_userclaims.userid);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userclaimsDataAccessObjects.Add(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userclaims_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userclaims, cmd,Database);
                FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.Addowin_userclaims"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userclaimsDataAccessObjects.Update(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userclaims_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userclaims, cmd,Database);
                FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.Updateowin_userclaims"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userclaimsDataAccessObjects.Delete(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userclaims_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userclaims, cmd,Database, true);
                FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.Deleteowin_userclaims"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userclaimsDataAccessObjects.SaveList(IList<owin_userclaimsEntity> listAdded, IList<owin_userclaimsEntity> listUpdated, IList<owin_userclaimsEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userclaims_Ins";
            const string SPUpdate = "owin_userclaims_Upd";
            const string SPDelete = "owin_userclaims_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userclaimsEntity owin_userclaims in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userclaims, cmd, Database, true);
                            FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userclaimsEntity owin_userclaims in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userclaims, cmd, Database);
                            FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userclaimsEntity owin_userclaims in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userclaims, cmd, Database);
                            FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.Save_owin_userclaims"));
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
       IList<owin_userclaimsEntity> listAdded, 
       IList<owin_userclaimsEntity> listUpdated, 
       IList<owin_userclaimsEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userclaims_Ins";
            const string SPUpdate = "owin_userclaims_Upd";
            const string SPDelete = "owin_userclaims_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userclaimsEntity owin_userclaims in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userclaims, cmd, db, true);
                            FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userclaimsEntity owin_userclaims in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userclaims, cmd, db);
                            FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userclaimsEntity owin_userclaims in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userclaims, cmd, db);
                            FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.Save_owin_userclaims"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userclaimsEntity>> Iowin_userclaimsDataAccessObjects.GetAll(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userclaims_GA";
                IList<owin_userclaimsEntity> itemList = new List<owin_userclaimsEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userclaims.SortExpression);
                    FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userclaims, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userclaimsEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.GetAllowin_userclaims"));
            }	
        }
		
        async Task<IList<owin_userclaimsEntity>> Iowin_userclaimsDataAccessObjects.GetAllByPages(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userclaims_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userclaims.SortExpression);
                    AddPageSizeParameter(cmd, owin_userclaims.PageSize);
                    AddCurrentPageParameter(cmd, owin_userclaims.CurrentPage);                    
                    FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userclaims, cmd,Database);

                    IList<owin_userclaimsEntity> itemList = new List<owin_userclaimsEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userclaimsEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userclaims.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.GetAllByPagesowin_userclaims"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userclaimsEntity> Iowin_userclaimsDataAccessObjects.GetSingle(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userclaims_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userclaims, cmd, Database);
                    
                    IList<owin_userclaimsEntity> itemList = new List<owin_userclaimsEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userclaimsEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.GetSingleowin_userclaims"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userclaimsEntity>> Iowin_userclaimsDataAccessObjects.GAPgListView(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userclaims_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userclaims.SortExpression);
                    AddPageSizeParameter(cmd, owin_userclaims.PageSize);
                    AddCurrentPageParameter(cmd, owin_userclaims.CurrentPage);                    
                    FillSequrityParameters(owin_userclaims.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userclaims, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userclaims.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userclaims.strCommonSerachParam+"%");

                    IList<owin_userclaimsEntity> itemList = new List<owin_userclaimsEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userclaimsEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userclaims.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userclaimsDataAccess.GAPgListViewowin_userclaims"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}