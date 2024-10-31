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
	
	internal sealed partial class gen_bloodgroupDataAccessObjects : BaseDataAccess, Igen_bloodgroupDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_bloodgroupDataAccessObjects";
        
		public gen_bloodgroupDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_bloodgroupEntity gen_bloodgroup, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_bloodgroup.bloodgroupid.HasValue)
				Database.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, gen_bloodgroup.bloodgroupid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_bloodgroup.bloodgroupname)))
				Database.AddInParameter(cmd, "@BloodGroupName", DbType.String, gen_bloodgroup.bloodgroupname);
			if (!(string.IsNullOrEmpty(gen_bloodgroup.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_bloodgroup.comment);
			if (!(string.IsNullOrEmpty(gen_bloodgroup.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_bloodgroup.remarks);
			if (!(string.IsNullOrEmpty(gen_bloodgroup.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_bloodgroup.updateinfo);
			if (gen_bloodgroup.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_bloodgroup.tranformactionid);
			if (gen_bloodgroup.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_bloodgroup.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_bloodgroupDataAccessObjects.Add(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_bloodgroup_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_bloodgroup, cmd,Database);
                FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.Addgen_bloodgroup"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_bloodgroupDataAccessObjects.Update(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_bloodgroup_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_bloodgroup, cmd,Database);
                FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.Updategen_bloodgroup"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_bloodgroupDataAccessObjects.Delete(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_bloodgroup_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_bloodgroup, cmd,Database, true);
                FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.Deletegen_bloodgroup"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_bloodgroupDataAccessObjects.SaveList(IList<gen_bloodgroupEntity> listAdded, IList<gen_bloodgroupEntity> listUpdated, IList<gen_bloodgroupEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_bloodgroup_Ins";
            const string SPUpdate = "gen_bloodgroup_Upd";
            const string SPDelete = "gen_bloodgroup_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_bloodgroupEntity gen_bloodgroup in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_bloodgroup, cmd, Database, true);
                            FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_bloodgroupEntity gen_bloodgroup in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_bloodgroup, cmd, Database);
                            FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_bloodgroupEntity gen_bloodgroup in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_bloodgroup, cmd, Database);
                            FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.Save_gen_bloodgroup"));
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
       IList<gen_bloodgroupEntity> listAdded, 
       IList<gen_bloodgroupEntity> listUpdated, 
       IList<gen_bloodgroupEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_bloodgroup_Ins";
            const string SPUpdate = "gen_bloodgroup_Upd";
            const string SPDelete = "gen_bloodgroup_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_bloodgroupEntity gen_bloodgroup in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_bloodgroup, cmd, db, true);
                            FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, db);
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
                    foreach (gen_bloodgroupEntity gen_bloodgroup in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_bloodgroup, cmd, db);
                            FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, db);
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
                    foreach (gen_bloodgroupEntity gen_bloodgroup in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_bloodgroup, cmd, db);
                            FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.Save_gen_bloodgroup"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupDataAccessObjects.GetAll(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_bloodgroup_GA";
                IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_bloodgroup.SortExpression);
                    FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bloodgroup, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GetAllgen_bloodgroup"));
            }	
        }
		
        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupDataAccessObjects.GetAllByPages(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_bloodgroup_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bloodgroup.SortExpression);
                    AddPageSizeParameter(cmd, gen_bloodgroup.PageSize);
                    AddCurrentPageParameter(cmd, gen_bloodgroup.CurrentPage);                    
                    FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_bloodgroup, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_bloodgroup.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_bloodgroup.strCommonSerachParam+"%");

                    IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_bloodgroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GetAllByPagesgen_bloodgroup"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_bloodgroupDataAccessObjects.SaveMasterDetreg_familly(gen_bloodgroupEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_bloodgroup_Ins";
            const string MasterSPUpdate = "gen_bloodgroup_Upd";
            const string MasterSPDelete = "gen_bloodgroup_Del";
            
			
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
                                item.familybloodgroupid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.SaveDsgen_bloodgroup"));
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
        async Task<gen_bloodgroupEntity> Igen_bloodgroupDataAccessObjects.GetSingle(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_bloodgroup_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bloodgroup, cmd, Database);
                    
                    IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GetSinglegen_bloodgroup"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupDataAccessObjects.GAPgListView(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_bloodgroup_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bloodgroup.SortExpression);
                    AddPageSizeParameter(cmd, gen_bloodgroup.PageSize);
                    AddCurrentPageParameter(cmd, gen_bloodgroup.CurrentPage);                    
                    FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_bloodgroup, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_bloodgroup.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_bloodgroup.strCommonSerachParam+"%");

                    IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_bloodgroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GAPgListViewgen_bloodgroup"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_bloodgroupDataAccessObjects.GetDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_bloodgroup_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_bloodgroup.SortExpression);
					AddPageSizeParameter(cmd, gen_bloodgroup.PageSize);
					AddCurrentPageParameter(cmd, gen_bloodgroup.CurrentPage);                    
					FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
					FillParameters(gen_bloodgroup, cmd,Database);
					if (!string.IsNullOrEmpty(gen_bloodgroup.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_bloodgroup.strCommonSerachParam + " % ");
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
						gen_bloodgroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}