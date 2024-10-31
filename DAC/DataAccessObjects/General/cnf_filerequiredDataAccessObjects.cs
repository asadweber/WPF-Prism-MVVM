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
	
	internal sealed partial class cnf_filerequiredDataAccessObjects : BaseDataAccess, Icnf_filerequiredDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_filerequiredDataAccessObjects";
        
		public cnf_filerequiredDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_filerequiredEntity cnf_filerequired, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_filerequired.fileconfigid.HasValue)
				Database.AddInParameter(cmd, "@FileConfigID", DbType.Int64, cnf_filerequired.fileconfigid);
            if (forDelete) return;
            if (cnf_filerequired.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, cnf_filerequired.batchid);
            if (cnf_filerequired.fileconfignameid.HasValue)
				Database.AddInParameter(cmd, "@FileConfigNameID", DbType.Int64, cnf_filerequired.fileconfignameid);
			if ((cnf_filerequired.isrequired != null))
				Database.AddInParameter(cmd, "@IsRequired", DbType.Boolean, cnf_filerequired.isrequired);
			if ((cnf_filerequired.isprintrequired != null))
				Database.AddInParameter(cmd, "@IsPrintRequired", DbType.Boolean, cnf_filerequired.isprintrequired);
			if (!(string.IsNullOrEmpty(cnf_filerequired.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_filerequired.remarks);
        }
		
        
		#region Add Operation

        async Task<long> Icnf_filerequiredDataAccessObjects.Add(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_filerequired_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_filerequired, cmd,Database);
                FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.Addcnf_filerequired"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_filerequiredDataAccessObjects.Update(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_filerequired_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_filerequired, cmd,Database);
                FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.Updatecnf_filerequired"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_filerequiredDataAccessObjects.Delete(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_filerequired_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_filerequired, cmd,Database, true);
                FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.Deletecnf_filerequired"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_filerequiredDataAccessObjects.SaveList(IList<cnf_filerequiredEntity> listAdded, IList<cnf_filerequiredEntity> listUpdated, IList<cnf_filerequiredEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_filerequired_Ins";
            const string SPUpdate = "cnf_filerequired_Upd";
            const string SPDelete = "cnf_filerequired_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_filerequiredEntity cnf_filerequired in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_filerequired, cmd, Database, true);
                            FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_filerequiredEntity cnf_filerequired in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_filerequired, cmd, Database);
                            FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_filerequiredEntity cnf_filerequired in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_filerequired, cmd, Database);
                            FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.Save_cnf_filerequired"));
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
       IList<cnf_filerequiredEntity> listAdded, 
       IList<cnf_filerequiredEntity> listUpdated, 
       IList<cnf_filerequiredEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_filerequired_Ins";
            const string SPUpdate = "cnf_filerequired_Upd";
            const string SPDelete = "cnf_filerequired_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_filerequiredEntity cnf_filerequired in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_filerequired, cmd, db, true);
                            FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_filerequiredEntity cnf_filerequired in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_filerequired, cmd, db);
                            FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_filerequiredEntity cnf_filerequired in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_filerequired, cmd, db);
                            FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.Save_cnf_filerequired"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredDataAccessObjects.GetAll(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_filerequired_GA";
                IList<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_filerequired, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_filerequiredEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GetAllcnf_filerequired"));
            }	
        }
		
        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredDataAccessObjects.GetAllByPages(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_filerequired_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
                    AddPageSizeParameter(cmd, cnf_filerequired.PageSize);
                    AddCurrentPageParameter(cmd, cnf_filerequired.CurrentPage);                    
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_filerequired, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_filerequired.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_filerequired.strCommonSerachParam+"%");

                    IList<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_filerequiredEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_filerequired.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GetAllByPagescnf_filerequired"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Icnf_filerequiredDataAccessObjects.SaveMasterDetgen_batchcandidatereqfile(cnf_filerequiredEntity masterEntity, 
        IList<gen_batchcandidatereqfileEntity> listAdded, 
        IList<gen_batchcandidatereqfileEntity> listUpdated,
        IList<gen_batchcandidatereqfileEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_filerequired_Ins";
            const string MasterSPUpdate = "cnf_filerequired_Upd";
            const string MasterSPDelete = "cnf_filerequired_Del";
            
			
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
                                item.fileconfigid=PrimaryKeyMaster;
                            }
                        }
                        gen_batchcandidatereqfileDataAccessObjects objgen_batchcandidatereqfile=new gen_batchcandidatereqfileDataAccessObjects(this.Context);
                        objgen_batchcandidatereqfile.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.SaveDscnf_filerequired"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Icnf_filerequiredDataAccessObjects.SaveMasterDetreg_studentfilestorage(cnf_filerequiredEntity masterEntity, 
        IList<reg_studentfilestorageEntity> listAdded, 
        IList<reg_studentfilestorageEntity> listUpdated,
        IList<reg_studentfilestorageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_filerequired_Ins";
            const string MasterSPUpdate = "cnf_filerequired_Upd";
            const string MasterSPDelete = "cnf_filerequired_Del";
            
			
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
                                item.fileconfignameid=PrimaryKeyMaster;
                            }
                        }
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorage=new reg_studentfilestorageDataAccessObjects(this.Context);
                        objreg_studentfilestorage.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.SaveDscnf_filerequired"));
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
        async Task<cnf_filerequiredEntity> Icnf_filerequiredDataAccessObjects.GetSingle(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_filerequired_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_filerequired, cmd, Database);
                    
                    IList<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_filerequiredEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GetSinglecnf_filerequired"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredDataAccessObjects.GAPgListView(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_filerequired_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
                    AddPageSizeParameter(cmd, cnf_filerequired.PageSize);
                    AddCurrentPageParameter(cmd, cnf_filerequired.CurrentPage);                    
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_filerequired, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_filerequired.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_filerequired.strCommonSerachParam+"%");

                    IList<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_filerequiredEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_filerequired.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GAPgListViewcnf_filerequired"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_filerequiredDataAccessObjects.GetDataForDropDown(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "cnf_filerequired_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
					AddPageSizeParameter(cmd, cnf_filerequired.PageSize);
					AddCurrentPageParameter(cmd, cnf_filerequired.CurrentPage);                    
					FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
					FillParameters(cnf_filerequired, cmd,Database);
					if (!string.IsNullOrEmpty(cnf_filerequired.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_filerequired.strCommonSerachParam + " % ");
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
						cnf_filerequired.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}