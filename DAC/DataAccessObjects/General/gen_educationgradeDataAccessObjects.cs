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
	
	internal sealed partial class gen_educationgradeDataAccessObjects : BaseDataAccess, Igen_educationgradeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_educationgradeDataAccessObjects";
        
		public gen_educationgradeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_educationgradeEntity gen_educationgrade, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_educationgrade.edugradeid.HasValue)
				Database.AddInParameter(cmd, "@EduGradeID", DbType.Int64, gen_educationgrade.edugradeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_educationgrade.edugradename)))
				Database.AddInParameter(cmd, "@EduGradeName", DbType.String, gen_educationgrade.edugradename);
			if (gen_educationgrade.marksfrom.HasValue)
				Database.AddInParameter(cmd, "@MarksFrom", DbType.Decimal, gen_educationgrade.marksfrom);
			if (gen_educationgrade.marksto.HasValue)
				Database.AddInParameter(cmd, "@MarksTo", DbType.Decimal, gen_educationgrade.marksto);
			if (!(string.IsNullOrEmpty(gen_educationgrade.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_educationgrade.comment);
			if (!(string.IsNullOrEmpty(gen_educationgrade.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_educationgrade.remarks);
			if (!(string.IsNullOrEmpty(gen_educationgrade.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_educationgrade.updateinfo);
			if (gen_educationgrade.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_educationgrade.tranformactionid);
			if (gen_educationgrade.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_educationgrade.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_educationgradeDataAccessObjects.Add(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_educationgrade_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_educationgrade, cmd,Database);
                FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.Addgen_educationgrade"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_educationgradeDataAccessObjects.Update(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_educationgrade_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_educationgrade, cmd,Database);
                FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.Updategen_educationgrade"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_educationgradeDataAccessObjects.Delete(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_educationgrade_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_educationgrade, cmd,Database, true);
                FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.Deletegen_educationgrade"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_educationgradeDataAccessObjects.SaveList(IList<gen_educationgradeEntity> listAdded, IList<gen_educationgradeEntity> listUpdated, IList<gen_educationgradeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_educationgrade_Ins";
            const string SPUpdate = "gen_educationgrade_Upd";
            const string SPDelete = "gen_educationgrade_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_educationgradeEntity gen_educationgrade in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_educationgrade, cmd, Database, true);
                            FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_educationgradeEntity gen_educationgrade in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_educationgrade, cmd, Database);
                            FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_educationgradeEntity gen_educationgrade in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_educationgrade, cmd, Database);
                            FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.Save_gen_educationgrade"));
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
       IList<gen_educationgradeEntity> listAdded, 
       IList<gen_educationgradeEntity> listUpdated, 
       IList<gen_educationgradeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_educationgrade_Ins";
            const string SPUpdate = "gen_educationgrade_Upd";
            const string SPDelete = "gen_educationgrade_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_educationgradeEntity gen_educationgrade in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_educationgrade, cmd, db, true);
                            FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, db);
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
                    foreach (gen_educationgradeEntity gen_educationgrade in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_educationgrade, cmd, db);
                            FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, db);
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
                    foreach (gen_educationgradeEntity gen_educationgrade in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_educationgrade, cmd, db);
                            FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.Save_gen_educationgrade"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeDataAccessObjects.GetAll(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationgrade_GA";
                IList<gen_educationgradeEntity> itemList = new List<gen_educationgradeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_educationgrade.SortExpression);
                    FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationgrade, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationgradeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GetAllgen_educationgrade"));
            }	
        }
		
        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeDataAccessObjects.GetAllByPages(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_educationgrade_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationgrade.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationgrade.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationgrade.CurrentPage);                    
                    FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_educationgrade, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_educationgrade.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_educationgrade.strCommonSerachParam+"%");

                    IList<gen_educationgradeEntity> itemList = new List<gen_educationgradeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationgradeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_educationgrade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GetAllByPagesgen_educationgrade"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_educationgradeDataAccessObjects.SaveMasterDetreg_educationinfo(gen_educationgradeEntity masterEntity, 
        IList<reg_educationinfoEntity> listAdded, 
        IList<reg_educationinfoEntity> listUpdated,
        IList<reg_educationinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_educationgrade_Ins";
            const string MasterSPUpdate = "gen_educationgrade_Upd";
            const string MasterSPDelete = "gen_educationgrade_Del";
            
			
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
                                item.edugradeid=PrimaryKeyMaster;
                            }
                        }
                        reg_educationinfoDataAccessObjects objreg_educationinfo=new reg_educationinfoDataAccessObjects(this.Context);
                        objreg_educationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.SaveDsgen_educationgrade"));
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
        async Task<gen_educationgradeEntity> Igen_educationgradeDataAccessObjects.GetSingle(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationgrade_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationgrade, cmd, Database);
                    
                    IList<gen_educationgradeEntity> itemList = new List<gen_educationgradeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationgradeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GetSinglegen_educationgrade"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeDataAccessObjects.GAPgListView(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_educationgrade_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationgrade.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationgrade.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationgrade.CurrentPage);                    
                    FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_educationgrade, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_educationgrade.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_educationgrade.strCommonSerachParam+"%");

                    IList<gen_educationgradeEntity> itemList = new List<gen_educationgradeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationgradeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_educationgrade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GAPgListViewgen_educationgrade"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_educationgradeDataAccessObjects.GetDataForDropDown(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_educationgrade_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_educationgrade.SortExpression);
					AddPageSizeParameter(cmd, gen_educationgrade.PageSize);
					AddCurrentPageParameter(cmd, gen_educationgrade.CurrentPage);                    
					FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
					FillParameters(gen_educationgrade, cmd,Database);
					if (!string.IsNullOrEmpty(gen_educationgrade.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_educationgrade.strCommonSerachParam + " % ");
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
						gen_educationgrade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}