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
	
	internal sealed partial class gen_skillproficiencyDataAccessObjects : BaseDataAccess, Igen_skillproficiencyDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_skillproficiencyDataAccessObjects";
        
		public gen_skillproficiencyDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_skillproficiencyEntity gen_skillproficiency, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_skillproficiency.skillproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@SkillProficiencyID", DbType.Int64, gen_skillproficiency.skillproficiencyid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_skillproficiency.skillname)))
				Database.AddInParameter(cmd, "@SkillName", DbType.String, gen_skillproficiency.skillname);
			if (gen_skillproficiency.skillvalue.HasValue)
				Database.AddInParameter(cmd, "@SkillValue", DbType.Int32, gen_skillproficiency.skillvalue);
			if (!(string.IsNullOrEmpty(gen_skillproficiency.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_skillproficiency.comment);
			if (!(string.IsNullOrEmpty(gen_skillproficiency.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_skillproficiency.remarks);
			if (!(string.IsNullOrEmpty(gen_skillproficiency.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_skillproficiency.updateinfo);
			if (gen_skillproficiency.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_skillproficiency.tranformactionid);
			if (gen_skillproficiency.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_skillproficiency.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_skillproficiencyDataAccessObjects.Add(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_skillproficiency_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_skillproficiency, cmd,Database);
                FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.Addgen_skillproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_skillproficiencyDataAccessObjects.Update(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_skillproficiency_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_skillproficiency, cmd,Database);
                FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.Updategen_skillproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_skillproficiencyDataAccessObjects.Delete(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_skillproficiency_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_skillproficiency, cmd,Database, true);
                FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.Deletegen_skillproficiency"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_skillproficiencyDataAccessObjects.SaveList(IList<gen_skillproficiencyEntity> listAdded, IList<gen_skillproficiencyEntity> listUpdated, IList<gen_skillproficiencyEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_skillproficiency_Ins";
            const string SPUpdate = "gen_skillproficiency_Upd";
            const string SPDelete = "gen_skillproficiency_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_skillproficiencyEntity gen_skillproficiency in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_skillproficiency, cmd, Database, true);
                            FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_skillproficiencyEntity gen_skillproficiency in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_skillproficiency, cmd, Database);
                            FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_skillproficiencyEntity gen_skillproficiency in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_skillproficiency, cmd, Database);
                            FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.Save_gen_skillproficiency"));
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
       IList<gen_skillproficiencyEntity> listAdded, 
       IList<gen_skillproficiencyEntity> listUpdated, 
       IList<gen_skillproficiencyEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_skillproficiency_Ins";
            const string SPUpdate = "gen_skillproficiency_Upd";
            const string SPDelete = "gen_skillproficiency_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_skillproficiencyEntity gen_skillproficiency in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_skillproficiency, cmd, db, true);
                            FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, db);
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
                    foreach (gen_skillproficiencyEntity gen_skillproficiency in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_skillproficiency, cmd, db);
                            FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, db);
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
                    foreach (gen_skillproficiencyEntity gen_skillproficiency in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_skillproficiency, cmd, db);
                            FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.Save_gen_skillproficiency"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyDataAccessObjects.GetAll(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_skillproficiency_GA";
                IList<gen_skillproficiencyEntity> itemList = new List<gen_skillproficiencyEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_skillproficiency.SortExpression);
                    FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_skillproficiency, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_skillproficiencyEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.GetAllgen_skillproficiency"));
            }	
        }
		
        async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyDataAccessObjects.GetAllByPages(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_skillproficiency_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_skillproficiency.SortExpression);
                    AddPageSizeParameter(cmd, gen_skillproficiency.PageSize);
                    AddCurrentPageParameter(cmd, gen_skillproficiency.CurrentPage);                    
                    FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_skillproficiency, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_skillproficiency.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_skillproficiency.strCommonSerachParam+"%");

                    IList<gen_skillproficiencyEntity> itemList = new List<gen_skillproficiencyEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_skillproficiencyEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_skillproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.GetAllByPagesgen_skillproficiency"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_skillproficiencyDataAccessObjects.SaveMasterDetreg_language(gen_skillproficiencyEntity masterEntity, 
        IList<reg_languageEntity> listAdded, 
        IList<reg_languageEntity> listUpdated,
        IList<reg_languageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_skillproficiency_Ins";
            const string MasterSPUpdate = "gen_skillproficiency_Upd";
            const string MasterSPDelete = "gen_skillproficiency_Del";
            
			
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
                                item.readingskillproficiencyid=PrimaryKeyMaster;
                            }
                        }
                        reg_languageDataAccessObjects objreg_language=new reg_languageDataAccessObjects(this.Context);
                        objreg_language.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.SaveDsgen_skillproficiency"));
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
        async Task<gen_skillproficiencyEntity> Igen_skillproficiencyDataAccessObjects.GetSingle(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_skillproficiency_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_skillproficiency, cmd, Database);
                    
                    IList<gen_skillproficiencyEntity> itemList = new List<gen_skillproficiencyEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_skillproficiencyEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.GetSinglegen_skillproficiency"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyDataAccessObjects.GAPgListView(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_skillproficiency_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_skillproficiency.SortExpression);
                    AddPageSizeParameter(cmd, gen_skillproficiency.PageSize);
                    AddCurrentPageParameter(cmd, gen_skillproficiency.CurrentPage);                    
                    FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_skillproficiency, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_skillproficiency.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_skillproficiency.strCommonSerachParam+"%");

                    IList<gen_skillproficiencyEntity> itemList = new List<gen_skillproficiencyEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_skillproficiencyEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_skillproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.GAPgListViewgen_skillproficiency"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_skillproficiencyDataAccessObjects.GetDataForDropDown(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_skillproficiency_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_skillproficiency.SortExpression);
					AddPageSizeParameter(cmd, gen_skillproficiency.PageSize);
					AddCurrentPageParameter(cmd, gen_skillproficiency.CurrentPage);                    
					FillSequrityParameters(gen_skillproficiency.BaseSecurityParam, cmd, Database);
					FillParameters(gen_skillproficiency, cmd,Database);
					if (!string.IsNullOrEmpty(gen_skillproficiency.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_skillproficiency.strCommonSerachParam + " % ");
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
						gen_skillproficiency.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_skillproficiencyDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}