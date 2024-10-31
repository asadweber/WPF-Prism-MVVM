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
	
	internal sealed partial class gen_applicanttablesDataAccessObjects : BaseDataAccess, Igen_applicanttablesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_applicanttablesDataAccessObjects";
        
		public gen_applicanttablesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_applicanttablesEntity gen_applicanttables, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_applicanttables.applicanttableid.HasValue)
				Database.AddInParameter(cmd, "@ApplicantTableID", DbType.Int64, gen_applicanttables.applicanttableid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_applicanttables.applicanttablename)))
				Database.AddInParameter(cmd, "@ApplicantTableName", DbType.String, gen_applicanttables.applicanttablename);
			if (!(string.IsNullOrEmpty(gen_applicanttables.tabledescription)))
				Database.AddInParameter(cmd, "@TableDescription", DbType.String, gen_applicanttables.tabledescription);
			if (gen_applicanttables.dataorder.HasValue)
				Database.AddInParameter(cmd, "@DataOrder", DbType.Int64, gen_applicanttables.dataorder);

        }
		
        
		#region Add Operation

        async Task<long> Igen_applicanttablesDataAccessObjects.Add(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_applicanttables_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_applicanttables, cmd,Database);
                FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.Addgen_applicanttables"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_applicanttablesDataAccessObjects.Update(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_applicanttables_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_applicanttables, cmd,Database);
                FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.Updategen_applicanttables"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_applicanttablesDataAccessObjects.Delete(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_applicanttables_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_applicanttables, cmd,Database, true);
                FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.Deletegen_applicanttables"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_applicanttablesDataAccessObjects.SaveList(IList<gen_applicanttablesEntity> listAdded, IList<gen_applicanttablesEntity> listUpdated, IList<gen_applicanttablesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_applicanttables_Ins";
            const string SPUpdate = "gen_applicanttables_Upd";
            const string SPDelete = "gen_applicanttables_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_applicanttablesEntity gen_applicanttables in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_applicanttables, cmd, Database, true);
                            FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_applicanttablesEntity gen_applicanttables in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_applicanttables, cmd, Database);
                            FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_applicanttablesEntity gen_applicanttables in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_applicanttables, cmd, Database);
                            FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.Save_gen_applicanttables"));
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
       IList<gen_applicanttablesEntity> listAdded, 
       IList<gen_applicanttablesEntity> listUpdated, 
       IList<gen_applicanttablesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_applicanttables_Ins";
            const string SPUpdate = "gen_applicanttables_Upd";
            const string SPDelete = "gen_applicanttables_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_applicanttablesEntity gen_applicanttables in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_applicanttables, cmd, db, true);
                            FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, db);
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
                    foreach (gen_applicanttablesEntity gen_applicanttables in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_applicanttables, cmd, db);
                            FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, db);
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
                    foreach (gen_applicanttablesEntity gen_applicanttables in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_applicanttables, cmd, db);
                            FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.Save_gen_applicanttables"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_applicanttablesEntity>> Igen_applicanttablesDataAccessObjects.GetAll(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_applicanttables_GA";
                IList<gen_applicanttablesEntity> itemList = new List<gen_applicanttablesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_applicanttables.SortExpression);
                    FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_applicanttables, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_applicanttablesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.GetAllgen_applicanttables"));
            }	
        }
		
        async Task<IList<gen_applicanttablesEntity>> Igen_applicanttablesDataAccessObjects.GetAllByPages(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_applicanttables_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_applicanttables.SortExpression);
                    AddPageSizeParameter(cmd, gen_applicanttables.PageSize);
                    AddCurrentPageParameter(cmd, gen_applicanttables.CurrentPage);                    
                    FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_applicanttables, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_applicanttables.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_applicanttables.strCommonSerachParam+"%");

                    IList<gen_applicanttablesEntity> itemList = new List<gen_applicanttablesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_applicanttablesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_applicanttables.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.GetAllByPagesgen_applicanttables"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_applicanttablesDataAccessObjects.SaveMasterDetreg_datachecked(gen_applicanttablesEntity masterEntity, 
        IList<reg_datacheckedEntity> listAdded, 
        IList<reg_datacheckedEntity> listUpdated,
        IList<reg_datacheckedEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_applicanttables_Ins";
            const string MasterSPUpdate = "gen_applicanttables_Upd";
            const string MasterSPDelete = "gen_applicanttables_Del";
            
			
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
                                item.applicanttableid=PrimaryKeyMaster;
                            }
                        }
                        reg_datacheckedDataAccessObjects objreg_datachecked=new reg_datacheckedDataAccessObjects(this.Context);
                        objreg_datachecked.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.SaveDsgen_applicanttables"));
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
        async Task<gen_applicanttablesEntity> Igen_applicanttablesDataAccessObjects.GetSingle(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_applicanttables_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_applicanttables, cmd, Database);
                    
                    IList<gen_applicanttablesEntity> itemList = new List<gen_applicanttablesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_applicanttablesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.GetSinglegen_applicanttables"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_applicanttablesEntity>> Igen_applicanttablesDataAccessObjects.GAPgListView(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_applicanttables_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_applicanttables.SortExpression);
                    AddPageSizeParameter(cmd, gen_applicanttables.PageSize);
                    AddCurrentPageParameter(cmd, gen_applicanttables.CurrentPage);                    
                    FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_applicanttables, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_applicanttables.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_applicanttables.strCommonSerachParam+"%");

                    IList<gen_applicanttablesEntity> itemList = new List<gen_applicanttablesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_applicanttablesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_applicanttables.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.GAPgListViewgen_applicanttables"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_applicanttablesDataAccessObjects.GetDataForDropDown(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_applicanttables_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_applicanttables.SortExpression);
					AddPageSizeParameter(cmd, gen_applicanttables.PageSize);
					AddCurrentPageParameter(cmd, gen_applicanttables.CurrentPage);                    
					FillSequrityParameters(gen_applicanttables.BaseSecurityParam, cmd, Database);
					FillParameters(gen_applicanttables, cmd,Database);
					if (!string.IsNullOrEmpty(gen_applicanttables.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_applicanttables.strCommonSerachParam + " % ");
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
						gen_applicanttables.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_applicanttablesDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}