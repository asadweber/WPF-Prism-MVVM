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
	
	internal sealed partial class cnf_notificationconfigDataAccessObjects : BaseDataAccess, Icnf_notificationconfigDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_notificationconfigDataAccessObjects";
        
		public cnf_notificationconfigDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_notificationconfigEntity cnf_notificationconfig, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_notificationconfig.notificationconfigid.HasValue)
				Database.AddInParameter(cmd, "@NotificationConfigID", DbType.Int64, cnf_notificationconfig.notificationconfigid);
            if (forDelete) return;
			if (cnf_notificationconfig.phaseid.HasValue)
				Database.AddInParameter(cmd, "@PhaseID", DbType.Int64, cnf_notificationconfig.phaseid);
			if (cnf_notificationconfig.statusid.HasValue)
				Database.AddInParameter(cmd, "@StatusID", DbType.Int64, cnf_notificationconfig.statusid);
			if (!(string.IsNullOrEmpty(cnf_notificationconfig.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_notificationconfig.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Icnf_notificationconfigDataAccessObjects.Add(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_notificationconfig_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_notificationconfig, cmd,Database);
                FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.Addcnf_notificationconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_notificationconfigDataAccessObjects.Update(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_notificationconfig_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_notificationconfig, cmd,Database);
                FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.Updatecnf_notificationconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_notificationconfigDataAccessObjects.Delete(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_notificationconfig_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_notificationconfig, cmd,Database, true);
                FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.Deletecnf_notificationconfig"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_notificationconfigDataAccessObjects.SaveList(IList<cnf_notificationconfigEntity> listAdded, IList<cnf_notificationconfigEntity> listUpdated, IList<cnf_notificationconfigEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_notificationconfig_Ins";
            const string SPUpdate = "cnf_notificationconfig_Upd";
            const string SPDelete = "cnf_notificationconfig_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_notificationconfigEntity cnf_notificationconfig in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_notificationconfig, cmd, Database, true);
                            FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_notificationconfigEntity cnf_notificationconfig in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_notificationconfig, cmd, Database);
                            FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_notificationconfigEntity cnf_notificationconfig in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_notificationconfig, cmd, Database);
                            FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.Save_cnf_notificationconfig"));
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
       IList<cnf_notificationconfigEntity> listAdded, 
       IList<cnf_notificationconfigEntity> listUpdated, 
       IList<cnf_notificationconfigEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_notificationconfig_Ins";
            const string SPUpdate = "cnf_notificationconfig_Upd";
            const string SPDelete = "cnf_notificationconfig_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_notificationconfigEntity cnf_notificationconfig in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_notificationconfig, cmd, db, true);
                            FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_notificationconfigEntity cnf_notificationconfig in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_notificationconfig, cmd, db);
                            FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_notificationconfigEntity cnf_notificationconfig in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_notificationconfig, cmd, db);
                            FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.Save_cnf_notificationconfig"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigDataAccessObjects.GetAll(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationconfig_GA";
                IList<cnf_notificationconfigEntity> itemList = new List<cnf_notificationconfigEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfig, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GetAllcnf_notificationconfig"));
            }	
        }
		
        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigDataAccessObjects.GetAllByPages(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_notificationconfig_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfig.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfig.CurrentPage);                    
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_notificationconfig, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_notificationconfig.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_notificationconfig.strCommonSerachParam+"%");

                    IList<cnf_notificationconfigEntity> itemList = new List<cnf_notificationconfigEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GetAllByPagescnf_notificationconfig"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Icnf_notificationconfigDataAccessObjects.SaveMasterDetcnf_notificationconfigdetl(cnf_notificationconfigEntity masterEntity, 
        IList<cnf_notificationconfigdetlEntity> listAdded, 
        IList<cnf_notificationconfigdetlEntity> listUpdated,
        IList<cnf_notificationconfigdetlEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_notificationconfig_Ins";
            const string MasterSPUpdate = "cnf_notificationconfig_Upd";
            const string MasterSPDelete = "cnf_notificationconfig_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                                PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = PrimaryKeyMaster;
                        
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.notificationconfigid=PrimaryKeyMaster;
                            }
                        }
                        cnf_notificationconfigdetlDataAccessObjects objcnf_notificationconfigdetl=new cnf_notificationconfigdetlDataAccessObjects(this.Context);
                        objcnf_notificationconfigdetl.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.SaveDscnf_notificationconfig"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_notificationconfigEntity> Icnf_notificationconfigDataAccessObjects.GetSingle(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationconfig_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfig, cmd, Database);
                    
                    IList<cnf_notificationconfigEntity> itemList = new List<cnf_notificationconfigEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GetSinglecnf_notificationconfig"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigDataAccessObjects.GAPgListView(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_notificationconfig_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfig.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfig.CurrentPage);                    
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_notificationconfig, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_notificationconfig.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_notificationconfig.strCommonSerachParam+"%");

                    IList<cnf_notificationconfigEntity> itemList = new List<cnf_notificationconfigEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GAPgListViewcnf_notificationconfig"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_notificationconfigDataAccessObjects.GetDataForDropDown(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "cnf_notificationconfig_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
					AddPageSizeParameter(cmd, cnf_notificationconfig.PageSize);
					AddCurrentPageParameter(cmd, cnf_notificationconfig.CurrentPage);                    
					FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
					FillParameters(cnf_notificationconfig, cmd,Database);
					if (!string.IsNullOrEmpty(cnf_notificationconfig.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_notificationconfig.strCommonSerachParam + " % ");
					IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
					IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
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
					if(itemList.Count>0)
					{
						itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_notificationconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}