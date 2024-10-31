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
	
	internal sealed partial class gen_maritalstatusDataAccessObjects : BaseDataAccess, Igen_maritalstatusDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_maritalstatusDataAccessObjects";
        
		public gen_maritalstatusDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_maritalstatusEntity gen_maritalstatus, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_maritalstatus.maritalstatusid.HasValue)
				Database.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, gen_maritalstatus.maritalstatusid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_maritalstatus.maritalstatus)))
				Database.AddInParameter(cmd, "@MaritalStatus", DbType.String, gen_maritalstatus.maritalstatus);
			if ((gen_maritalstatus.ismarried != null))
				Database.AddInParameter(cmd, "@IsMarried", DbType.Boolean, gen_maritalstatus.ismarried);
			if (!(string.IsNullOrEmpty(gen_maritalstatus.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_maritalstatus.comment);
			if (!(string.IsNullOrEmpty(gen_maritalstatus.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_maritalstatus.remarks);
			if (!(string.IsNullOrEmpty(gen_maritalstatus.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_maritalstatus.updateinfo);
			if (gen_maritalstatus.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_maritalstatus.tranformactionid);
			if (gen_maritalstatus.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_maritalstatus.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_maritalstatusDataAccessObjects.Add(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_maritalstatus_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_maritalstatus, cmd,Database);
                FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Addgen_maritalstatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_maritalstatusDataAccessObjects.Update(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_maritalstatus_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_maritalstatus, cmd,Database);
                FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Updategen_maritalstatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_maritalstatusDataAccessObjects.Delete(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_maritalstatus_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_maritalstatus, cmd,Database, true);
                FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Deletegen_maritalstatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_maritalstatusDataAccessObjects.SaveList(IList<gen_maritalstatusEntity> listAdded, IList<gen_maritalstatusEntity> listUpdated, IList<gen_maritalstatusEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_maritalstatus_Ins";
            const string SPUpdate = "gen_maritalstatus_Upd";
            const string SPDelete = "gen_maritalstatus_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_maritalstatus, cmd, Database, true);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_maritalstatus, cmd, Database);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_maritalstatus, cmd, Database);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Save_gen_maritalstatus"));
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
       IList<gen_maritalstatusEntity> listAdded, 
       IList<gen_maritalstatusEntity> listUpdated, 
       IList<gen_maritalstatusEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_maritalstatus_Ins";
            const string SPUpdate = "gen_maritalstatus_Upd";
            const string SPDelete = "gen_maritalstatus_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_maritalstatus, cmd, db, true);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_maritalstatus, cmd, db);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_maritalstatusEntity gen_maritalstatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_maritalstatus, cmd, db);
                            FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.Save_gen_maritalstatus"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusDataAccessObjects.GetAll(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_maritalstatus_GA";
                IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_maritalstatus, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetAllgen_maritalstatus"));
            }	
        }
		
        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusDataAccessObjects.GetAllByPages(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_maritalstatus_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_maritalstatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_maritalstatus.CurrentPage);                    
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_maritalstatus, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_maritalstatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_maritalstatus.strCommonSerachParam+"%");

                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_maritalstatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetAllByPagesgen_maritalstatus"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_maritalstatusDataAccessObjects.SaveMasterDetreg_familly(gen_maritalstatusEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_maritalstatus_Ins";
            const string MasterSPUpdate = "gen_maritalstatus_Upd";
            const string MasterSPDelete = "gen_maritalstatus_Del";
            
			
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
                                item.maritalstatusid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.SaveDsgen_maritalstatus"));
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
        async Task<gen_maritalstatusEntity> Igen_maritalstatusDataAccessObjects.GetSingle(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_maritalstatus_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_maritalstatus, cmd, Database);
                    
                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetSinglegen_maritalstatus"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusDataAccessObjects.GAPgListView(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_maritalstatus_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_maritalstatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_maritalstatus.CurrentPage);                    
                    FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_maritalstatus, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_maritalstatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_maritalstatus.strCommonSerachParam+"%");

                    IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_maritalstatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GAPgListViewgen_maritalstatus"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_maritalstatusDataAccessObjects.GetDataForDropDown(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_maritalstatus_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_maritalstatus.SortExpression);
					AddPageSizeParameter(cmd, gen_maritalstatus.PageSize);
					AddCurrentPageParameter(cmd, gen_maritalstatus.CurrentPage);                    
					FillSequrityParameters(gen_maritalstatus.BaseSecurityParam, cmd, Database);
					FillParameters(gen_maritalstatus, cmd,Database);
					if (!string.IsNullOrEmpty(gen_maritalstatus.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_maritalstatus.strCommonSerachParam + " % ");
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
						gen_maritalstatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_maritalstatusDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}