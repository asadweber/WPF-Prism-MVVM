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
	
	internal sealed partial class gen_religionDataAccessObjects : BaseDataAccess, Igen_religionDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_religionDataAccessObjects";
        
		public gen_religionDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_religionEntity gen_religion, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_religion.religionid.HasValue)
				Database.AddInParameter(cmd, "@ReligionID", DbType.Int64, gen_religion.religionid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_religion.religionname)))
				Database.AddInParameter(cmd, "@ReligionName", DbType.String, gen_religion.religionname);
			if (!(string.IsNullOrEmpty(gen_religion.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_religion.comment);
			if (!(string.IsNullOrEmpty(gen_religion.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_religion.remarks);
			if (!(string.IsNullOrEmpty(gen_religion.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_religion.updateinfo);
			if (gen_religion.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_religion.tranformactionid);
			if (gen_religion.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_religion.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_religionDataAccessObjects.Add(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_religion_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_religion, cmd,Database);
                FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.Addgen_religion"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_religionDataAccessObjects.Update(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_religion_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_religion, cmd,Database);
                FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.Updategen_religion"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_religionDataAccessObjects.Delete(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_religion_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_religion, cmd,Database, true);
                FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.Deletegen_religion"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_religionDataAccessObjects.SaveList(IList<gen_religionEntity> listAdded, IList<gen_religionEntity> listUpdated, IList<gen_religionEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_religion_Ins";
            const string SPUpdate = "gen_religion_Upd";
            const string SPDelete = "gen_religion_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_religionEntity gen_religion in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_religion, cmd, Database, true);
                            FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_religionEntity gen_religion in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_religion, cmd, Database);
                            FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_religionEntity gen_religion in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_religion, cmd, Database);
                            FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.Save_gen_religion"));
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
       IList<gen_religionEntity> listAdded, 
       IList<gen_religionEntity> listUpdated, 
       IList<gen_religionEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_religion_Ins";
            const string SPUpdate = "gen_religion_Upd";
            const string SPDelete = "gen_religion_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_religionEntity gen_religion in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_religion, cmd, db, true);
                            FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, db);
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
                    foreach (gen_religionEntity gen_religion in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_religion, cmd, db);
                            FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, db);
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
                    foreach (gen_religionEntity gen_religion in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_religion, cmd, db);
                            FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.Save_gen_religion"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_religionEntity>> Igen_religionDataAccessObjects.GetAll(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_religion_GA";
                IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_religion.SortExpression);
                    FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_religion, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GetAllgen_religion"));
            }	
        }
		
        async Task<IList<gen_religionEntity>> Igen_religionDataAccessObjects.GetAllByPages(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_religion_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_religion.SortExpression);
                    AddPageSizeParameter(cmd, gen_religion.PageSize);
                    AddCurrentPageParameter(cmd, gen_religion.CurrentPage);                    
                    FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_religion, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_religion.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_religion.strCommonSerachParam+"%");

                    IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_religion.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GetAllByPagesgen_religion"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_religionDataAccessObjects.SaveMasterDetreg_familly(gen_religionEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_religion_Ins";
            const string MasterSPUpdate = "gen_religion_Upd";
            const string MasterSPDelete = "gen_religion_Del";
            
			
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
                                item.familyreligionid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.SaveDsgen_religion"));
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
        async Task<gen_religionEntity> Igen_religionDataAccessObjects.GetSingle(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_religion_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_religion, cmd, Database);
                    
                    IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GetSinglegen_religion"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_religionEntity>> Igen_religionDataAccessObjects.GAPgListView(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_religion_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_religion.SortExpression);
                    AddPageSizeParameter(cmd, gen_religion.PageSize);
                    AddCurrentPageParameter(cmd, gen_religion.CurrentPage);                    
                    FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_religion, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_religion.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_religion.strCommonSerachParam+"%");

                    IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_religion.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GAPgListViewgen_religion"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_religionDataAccessObjects.GetDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_religion_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_religion.SortExpression);
					AddPageSizeParameter(cmd, gen_religion.PageSize);
					AddCurrentPageParameter(cmd, gen_religion.CurrentPage);                    
					FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
					FillParameters(gen_religion, cmd,Database);
					if (!string.IsNullOrEmpty(gen_religion.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_religion.strCommonSerachParam + " % ");
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
						gen_religion.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}