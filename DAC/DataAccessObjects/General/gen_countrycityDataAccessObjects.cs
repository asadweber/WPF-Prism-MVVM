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
	
	internal sealed partial class gen_countrycityDataAccessObjects : BaseDataAccess, Igen_countrycityDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_countrycityDataAccessObjects";
        
		public gen_countrycityDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_countrycityEntity gen_countrycity, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_countrycity.cityid.HasValue)
				Database.AddInParameter(cmd, "@CityID", DbType.Int64, gen_countrycity.cityid);
            if (forDelete) return;
			if (gen_countrycity.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, gen_countrycity.parentid);
			if (gen_countrycity.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_countrycity.countryid);
			if (!(string.IsNullOrEmpty(gen_countrycity.cityname)))
				Database.AddInParameter(cmd, "@CityName", DbType.String, gen_countrycity.cityname);
			if ((gen_countrycity.isgovernate != null))
				Database.AddInParameter(cmd, "@IsGovernate", DbType.Boolean, gen_countrycity.isgovernate);
			if (!(string.IsNullOrEmpty(gen_countrycity.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_countrycity.comment);
			if (!(string.IsNullOrEmpty(gen_countrycity.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_countrycity.remarks);
			if (!(string.IsNullOrEmpty(gen_countrycity.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_countrycity.updateinfo);
			if (gen_countrycity.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_countrycity.tranformactionid);
			if (gen_countrycity.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_countrycity.oracleid);
			if (gen_countrycity.oraclegovid.HasValue)
				Database.AddInParameter(cmd, "@OracleGovID", DbType.Int64, gen_countrycity.oraclegovid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_countrycityDataAccessObjects.Add(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_countrycity_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_countrycity, cmd,Database);
                FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.Addgen_countrycity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_countrycityDataAccessObjects.Update(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_countrycity_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_countrycity, cmd,Database);
                FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.Updategen_countrycity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_countrycityDataAccessObjects.Delete(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_countrycity_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_countrycity, cmd,Database, true);
                FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.Deletegen_countrycity"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_countrycityDataAccessObjects.SaveList(IList<gen_countrycityEntity> listAdded, IList<gen_countrycityEntity> listUpdated, IList<gen_countrycityEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_countrycity_Ins";
            const string SPUpdate = "gen_countrycity_Upd";
            const string SPDelete = "gen_countrycity_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_countrycityEntity gen_countrycity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_countrycity, cmd, Database, true);
                            FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_countrycityEntity gen_countrycity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_countrycity, cmd, Database);
                            FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_countrycityEntity gen_countrycity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_countrycity, cmd, Database);
                            FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.Save_gen_countrycity"));
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
       IList<gen_countrycityEntity> listAdded, 
       IList<gen_countrycityEntity> listUpdated, 
       IList<gen_countrycityEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_countrycity_Ins";
            const string SPUpdate = "gen_countrycity_Upd";
            const string SPDelete = "gen_countrycity_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_countrycityEntity gen_countrycity in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_countrycity, cmd, db, true);
                            FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, db);
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
                    foreach (gen_countrycityEntity gen_countrycity in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_countrycity, cmd, db);
                            FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, db);
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
                    foreach (gen_countrycityEntity gen_countrycity in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_countrycity, cmd, db);
                            FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.Save_gen_countrycity"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_countrycityEntity>> Igen_countrycityDataAccessObjects.GetAll(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_countrycity_GA";
                IList<gen_countrycityEntity> itemList = new List<gen_countrycityEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_countrycity.SortExpression);
                    FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_countrycity, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countrycityEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetAllgen_countrycity"));
            }	
        }
		
        async Task<IList<gen_countrycityEntity>> Igen_countrycityDataAccessObjects.GetAllByPages(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_countrycity_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_countrycity.SortExpression);
                    AddPageSizeParameter(cmd, gen_countrycity.PageSize);
                    AddCurrentPageParameter(cmd, gen_countrycity.CurrentPage);                    
                    FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_countrycity, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_countrycity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_countrycity.strCommonSerachParam+"%");

                    IList<gen_countrycityEntity> itemList = new List<gen_countrycityEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countrycityEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_countrycity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetAllByPagesgen_countrycity"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_countrycityDataAccessObjects.SaveMasterDetgen_civilworkplaces(gen_countrycityEntity masterEntity, 
        IList<gen_civilworkplacesEntity> listAdded, 
        IList<gen_civilworkplacesEntity> listUpdated,
        IList<gen_civilworkplacesEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_countrycity_Ins";
            const string MasterSPUpdate = "gen_countrycity_Upd";
            const string MasterSPDelete = "gen_countrycity_Del";
            
			
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
                                item.governorateid=PrimaryKeyMaster;
                            }
                        }
                        gen_civilworkplacesDataAccessObjects objgen_civilworkplaces=new gen_civilworkplacesDataAccessObjects(this.Context);
                        objgen_civilworkplaces.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.SaveDsgen_countrycity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Igen_countrycityDataAccessObjects.SaveMasterDetgen_countrycity(gen_countrycityEntity masterEntity, 
        IList<gen_countrycityEntity> listAdded, 
        IList<gen_countrycityEntity> listUpdated,
        IList<gen_countrycityEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_countrycity_Ins";
            const string MasterSPUpdate = "gen_countrycity_Upd";
            const string MasterSPDelete = "gen_countrycity_Del";
            
			
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
                                item.parentid=PrimaryKeyMaster;
                            }
                        }
                        gen_countrycityDataAccessObjects objgen_countrycity=new gen_countrycityDataAccessObjects(this.Context);
                        objgen_countrycity.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.SaveDsgen_countrycity"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Igen_countrycityDataAccessObjects.SaveMasterDetreg_familly(gen_countrycityEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_countrycity_Ins";
            const string MasterSPUpdate = "gen_countrycity_Upd";
            const string MasterSPDelete = "gen_countrycity_Del";
            
			
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
                                item.preaddgovernid=PrimaryKeyMaster;
                            }
                        }
                        reg_famillyDataAccessObjects objreg_familly=new reg_famillyDataAccessObjects(this.Context);
                        objreg_familly.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.SaveDsgen_countrycity"));
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
        async Task<gen_countrycityEntity> Igen_countrycityDataAccessObjects.GetSingle(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_countrycity_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_countrycity, cmd, Database);
                    
                    IList<gen_countrycityEntity> itemList = new List<gen_countrycityEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countrycityEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetSinglegen_countrycity"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_countrycityEntity>> Igen_countrycityDataAccessObjects.GAPgListView(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_countrycity_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_countrycity.SortExpression);
                    AddPageSizeParameter(cmd, gen_countrycity.PageSize);
                    AddCurrentPageParameter(cmd, gen_countrycity.CurrentPage);                    
                    FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_countrycity, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_countrycity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_countrycity.strCommonSerachParam+"%");

                    IList<gen_countrycityEntity> itemList = new List<gen_countrycityEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countrycityEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_countrycity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GAPgListViewgen_countrycity"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_countrycityDataAccessObjects.GetDataForDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_countrycity_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_countrycity.SortExpression);
					AddPageSizeParameter(cmd, gen_countrycity.PageSize);
					AddCurrentPageParameter(cmd, gen_countrycity.CurrentPage);                    
					FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
					FillParameters(gen_countrycity, cmd,Database);
					if (!string.IsNullOrEmpty(gen_countrycity.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_countrycity.strCommonSerachParam + " % ");
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
						gen_countrycity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}