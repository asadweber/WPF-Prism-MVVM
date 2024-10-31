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
	
	internal sealed partial class stp_organizationentityDataAccessObjects : BaseDataAccess, Istp_organizationentityDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_organizationentityDataAccessObjects";
        
		public stp_organizationentityDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_organizationentityEntity stp_organizationentity, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_organizationentity.entitykey.HasValue)
				Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, stp_organizationentity.entitykey);
            if (forDelete) return;
			if (stp_organizationentity.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_organizationentity.organizationkey);
			if (stp_organizationentity.parentkey.HasValue)
				Database.AddInParameter(cmd, "@ParentKey", DbType.Int64, stp_organizationentity.parentkey);
			if (stp_organizationentity.entirytypekey.HasValue)
				Database.AddInParameter(cmd, "@EntiryTypeKey", DbType.Int64, stp_organizationentity.entirytypekey);
			if (stp_organizationentity.entitylevel.HasValue)
				Database.AddInParameter(cmd, "@EntityLevel", DbType.Int32, stp_organizationentity.entitylevel);
			if (!(string.IsNullOrEmpty(stp_organizationentity.seqfirstindex)))
				Database.AddInParameter(cmd, "@SeqFirstIndex", DbType.String, stp_organizationentity.seqfirstindex);
			if (!(string.IsNullOrEmpty(stp_organizationentity.seqfullindex)))
				Database.AddInParameter(cmd, "@SeqFullIndex", DbType.String, stp_organizationentity.seqfullindex);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitycpde)))
				Database.AddInParameter(cmd, "@EntityCpde", DbType.String, stp_organizationentity.entitycpde);
			if (!(string.IsNullOrEmpty(stp_organizationentity.entitytname)))
				Database.AddInParameter(cmd, "@EntitytName", DbType.String, stp_organizationentity.entitytname);
			if (!(string.IsNullOrEmpty(stp_organizationentity.description)))
				Database.AddInParameter(cmd, "@Description", DbType.String, stp_organizationentity.description);
			if ((stp_organizationentity.isactive != null))
				Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, stp_organizationentity.isactive);
			if (!(string.IsNullOrEmpty(stp_organizationentity.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, stp_organizationentity.updateinfo);
			if (stp_organizationentity.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, stp_organizationentity.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Istp_organizationentityDataAccessObjects.Add(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "stp_organizationentity_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_organizationentity, cmd,Database);
                FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Addstp_organizationentity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Istp_organizationentityDataAccessObjects.Update(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "stp_organizationentity_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_organizationentity, cmd,Database);
                FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Updatestp_organizationentity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Istp_organizationentityDataAccessObjects.Delete(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "stp_organizationentity_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_organizationentity, cmd,Database, true);
                FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Deletestp_organizationentity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Istp_organizationentityDataAccessObjects.SaveList(IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "stp_organizationentity_Ins";
            const string SPUpdate = "stp_organizationentity_Upd";
            const string SPDelete = "stp_organizationentity_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationentityEntity stp_organizationentity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organizationentity, cmd, Database, true);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organizationentity, cmd, Database);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organizationentity, cmd, Database);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Save_stp_organizationentity"));
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
       IList<stp_organizationentityEntity> listAdded, 
       IList<stp_organizationentityEntity> listUpdated, 
       IList<stp_organizationentityEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "stp_organizationentity_Ins";
            const string SPUpdate = "stp_organizationentity_Upd";
            const string SPDelete = "stp_organizationentity_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationentityEntity stp_organizationentity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organizationentity, cmd, db, true);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organizationentity, cmd, db);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationentityEntity stp_organizationentity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organizationentity, cmd, db);
                            FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.Save_stp_organizationentity"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<stp_organizationentityEntity>> Istp_organizationentityDataAccessObjects.GetAll(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organizationentity_GA";
                IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentity, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetAllstp_organizationentity"));
            }	
        }
		
        async Task<IList<stp_organizationentityEntity>> Istp_organizationentityDataAccessObjects.GetAllByPages(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "stp_organizationentity_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentity.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentity.CurrentPage);                    
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organizationentity, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (stp_organizationentity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+stp_organizationentity.strCommonSerachParam+"%");

                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organizationentity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetAllByPagesstp_organizationentity"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Istp_organizationentityDataAccessObjects.SaveMasterDetreg_relativesworkinginmod(stp_organizationentityEntity masterEntity, 
        IList<reg_relativesworkinginmodEntity> listAdded, 
        IList<reg_relativesworkinginmodEntity> listUpdated,
        IList<reg_relativesworkinginmodEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";
            
			
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
                                item.relativeentitykey=PrimaryKeyMaster;
                            }
                        }
                        reg_relativesworkinginmodDataAccessObjects objreg_relativesworkinginmod=new reg_relativesworkinginmodDataAccessObjects(this.Context);
                        objreg_relativesworkinginmod.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Istp_organizationentityDataAccessObjects.SaveMasterDetstp_organizationentity(stp_organizationentityEntity masterEntity, 
        IList<stp_organizationentityEntity> listAdded, 
        IList<stp_organizationentityEntity> listUpdated,
        IList<stp_organizationentityEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organizationentity_Ins";
            const string MasterSPUpdate = "stp_organizationentity_Upd";
            const string MasterSPDelete = "stp_organizationentity_Del";
            
			
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
                                item.parentkey=PrimaryKeyMaster;
                            }
                        }
                        stp_organizationentityDataAccessObjects objstp_organizationentity=new stp_organizationentityDataAccessObjects(this.Context);
                        objstp_organizationentity.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.SaveDsstp_organizationentity"));
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
        async Task<stp_organizationentityEntity> Istp_organizationentityDataAccessObjects.GetSingle(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organizationentity_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organizationentity, cmd, Database);
                    
                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetSinglestp_organizationentity"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<stp_organizationentityEntity>> Istp_organizationentityDataAccessObjects.GAPgListView(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "stp_organizationentity_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentity.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentity.CurrentPage);                    
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organizationentity, cmd,Database);
                    
					if (!string.IsNullOrEmpty (stp_organizationentity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+stp_organizationentity.strCommonSerachParam+"%");

                    IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organizationentity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GAPgListViewstp_organizationentity"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Istp_organizationentityDataAccessObjects.GetDataForDropDown(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "stp_organizationentity_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
					AddPageSizeParameter(cmd, stp_organizationentity.PageSize);
					AddCurrentPageParameter(cmd, stp_organizationentity.CurrentPage);                    
					FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);
					FillParameters(stp_organizationentity, cmd,Database);
					if (!string.IsNullOrEmpty(stp_organizationentity.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + stp_organizationentity.strCommonSerachParam + "%");
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
						stp_organizationentity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Istp_organizationentityDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}