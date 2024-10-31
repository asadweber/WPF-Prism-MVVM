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
	
	internal sealed partial class cnf_notificationconfigdetlDataAccessObjects : BaseDataAccess, Icnf_notificationconfigdetlDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_notificationconfigdetlDataAccessObjects";
        
		public cnf_notificationconfigdetlDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_notificationconfigdetl.notificationconfigdetlid.HasValue)
				Database.AddInParameter(cmd, "@NotificationConfigDetlID", DbType.Int64, cnf_notificationconfigdetl.notificationconfigdetlid);
            if (forDelete) return;
			if (cnf_notificationconfigdetl.notificationconfigid.HasValue)
				Database.AddInParameter(cmd, "@NotificationConfigID", DbType.Int64, cnf_notificationconfigdetl.notificationconfigid);
			if (cnf_notificationconfigdetl.notificationtypeid.HasValue)
				Database.AddInParameter(cmd, "@NotificationTypeID", DbType.Int64, cnf_notificationconfigdetl.notificationtypeid);
			if (cnf_notificationconfigdetl.notificationtemplateid.HasValue)
				Database.AddInParameter(cmd, "@NotificationTemplateID", DbType.Int64, cnf_notificationconfigdetl.notificationtemplateid);
			if (!(string.IsNullOrEmpty(cnf_notificationconfigdetl.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_notificationconfigdetl.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Icnf_notificationconfigdetlDataAccessObjects.Add(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_notificationconfigdetl_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_notificationconfigdetl, cmd,Database);
                FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.Addcnf_notificationconfigdetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_notificationconfigdetlDataAccessObjects.Update(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_notificationconfigdetl_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_notificationconfigdetl, cmd,Database);
                FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.Updatecnf_notificationconfigdetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_notificationconfigdetlDataAccessObjects.Delete(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_notificationconfigdetl_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_notificationconfigdetl, cmd,Database, true);
                FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.Deletecnf_notificationconfigdetl"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_notificationconfigdetlDataAccessObjects.SaveList(IList<cnf_notificationconfigdetlEntity> listAdded, IList<cnf_notificationconfigdetlEntity> listUpdated, IList<cnf_notificationconfigdetlEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_notificationconfigdetl_Ins";
            const string SPUpdate = "cnf_notificationconfigdetl_Upd";
            const string SPDelete = "cnf_notificationconfigdetl_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_notificationconfigdetlEntity cnf_notificationconfigdetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_notificationconfigdetl, cmd, Database, true);
                            FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_notificationconfigdetlEntity cnf_notificationconfigdetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_notificationconfigdetl, cmd, Database);
                            FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_notificationconfigdetlEntity cnf_notificationconfigdetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_notificationconfigdetl, cmd, Database);
                            FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.Save_cnf_notificationconfigdetl"));
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
       IList<cnf_notificationconfigdetlEntity> listAdded, 
       IList<cnf_notificationconfigdetlEntity> listUpdated, 
       IList<cnf_notificationconfigdetlEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_notificationconfigdetl_Ins";
            const string SPUpdate = "cnf_notificationconfigdetl_Upd";
            const string SPDelete = "cnf_notificationconfigdetl_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_notificationconfigdetlEntity cnf_notificationconfigdetl in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_notificationconfigdetl, cmd, db, true);
                            FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_notificationconfigdetlEntity cnf_notificationconfigdetl in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_notificationconfigdetl, cmd, db);
                            FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_notificationconfigdetlEntity cnf_notificationconfigdetl in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_notificationconfigdetl, cmd, db);
                            FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.Save_cnf_notificationconfigdetl"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlDataAccessObjects.GetAll(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationconfigdetl_GA";
                IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_notificationconfigdetl.SortExpression);
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfigdetl, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GetAllcnf_notificationconfigdetl"));
            }	
        }
		
        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlDataAccessObjects.GetAllByPages(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_notificationconfigdetl_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfigdetl.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfigdetl.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfigdetl.CurrentPage);                    
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_notificationconfigdetl, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_notificationconfigdetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_notificationconfigdetl.strCommonSerachParam+"%");

                    IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationconfigdetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GetAllByPagescnf_notificationconfigdetl"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlDataAccessObjects.GetSingle(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationconfigdetl_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfigdetl, cmd, Database);
                    
                    IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GetSinglecnf_notificationconfigdetl"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlDataAccessObjects.GAPgListView(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_notificationconfigdetl_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfigdetl.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfigdetl.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfigdetl.CurrentPage);                    
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_notificationconfigdetl, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_notificationconfigdetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_notificationconfigdetl.strCommonSerachParam+"%");

                    IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationconfigdetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GAPgListViewcnf_notificationconfigdetl"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}