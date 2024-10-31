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
	
	internal sealed partial class gen_professiongroupDataAccessObjects : BaseDataAccess, Igen_professiongroupDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_professiongroupDataAccessObjects";
        
		public gen_professiongroupDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_professiongroupEntity gen_professiongroup, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_professiongroup.professiongroupid.HasValue)
				Database.AddInParameter(cmd, "@ProfessionGroupID", DbType.Int64, gen_professiongroup.professiongroupid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_professiongroup.professiongroupname)))
				Database.AddInParameter(cmd, "@ProfessionGroupName", DbType.String, gen_professiongroup.professiongroupname);
			if (!(string.IsNullOrEmpty(gen_professiongroup.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_professiongroup.comment);
			if (!(string.IsNullOrEmpty(gen_professiongroup.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_professiongroup.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_professiongroupDataAccessObjects.Add(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_professiongroup_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_professiongroup, cmd,Database);
                FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.Addgen_professiongroup"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_professiongroupDataAccessObjects.Update(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_professiongroup_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_professiongroup, cmd,Database);
                FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.Updategen_professiongroup"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_professiongroupDataAccessObjects.Delete(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_professiongroup_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_professiongroup, cmd,Database, true);
                FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.Deletegen_professiongroup"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_professiongroupDataAccessObjects.SaveList(IList<gen_professiongroupEntity> listAdded, IList<gen_professiongroupEntity> listUpdated, IList<gen_professiongroupEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_professiongroup_Ins";
            const string SPUpdate = "gen_professiongroup_Upd";
            const string SPDelete = "gen_professiongroup_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_professiongroupEntity gen_professiongroup in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_professiongroup, cmd, Database, true);
                            FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_professiongroupEntity gen_professiongroup in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_professiongroup, cmd, Database);
                            FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_professiongroupEntity gen_professiongroup in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_professiongroup, cmd, Database);
                            FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.Save_gen_professiongroup"));
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
       IList<gen_professiongroupEntity> listAdded, 
       IList<gen_professiongroupEntity> listUpdated, 
       IList<gen_professiongroupEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_professiongroup_Ins";
            const string SPUpdate = "gen_professiongroup_Upd";
            const string SPDelete = "gen_professiongroup_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_professiongroupEntity gen_professiongroup in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_professiongroup, cmd, db, true);
                            FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, db);
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
                    foreach (gen_professiongroupEntity gen_professiongroup in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_professiongroup, cmd, db);
                            FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, db);
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
                    foreach (gen_professiongroupEntity gen_professiongroup in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_professiongroup, cmd, db);
                            FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.Save_gen_professiongroup"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_professiongroupEntity>> Igen_professiongroupDataAccessObjects.GetAll(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_professiongroup_GA";
                IList<gen_professiongroupEntity> itemList = new List<gen_professiongroupEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_professiongroup.SortExpression);
                    FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_professiongroup, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professiongroupEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.GetAllgen_professiongroup"));
            }	
        }
		
        async Task<IList<gen_professiongroupEntity>> Igen_professiongroupDataAccessObjects.GetAllByPages(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_professiongroup_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_professiongroup.SortExpression);
                    AddPageSizeParameter(cmd, gen_professiongroup.PageSize);
                    AddCurrentPageParameter(cmd, gen_professiongroup.CurrentPage);                    
                    FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_professiongroup, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_professiongroup.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_professiongroup.strCommonSerachParam+"%");

                    IList<gen_professiongroupEntity> itemList = new List<gen_professiongroupEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professiongroupEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_professiongroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.GetAllByPagesgen_professiongroup"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_professiongroupDataAccessObjects.SaveMasterDetgen_profession(gen_professiongroupEntity masterEntity, 
        IList<gen_professionEntity> listAdded, 
        IList<gen_professionEntity> listUpdated,
        IList<gen_professionEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_professiongroup_Ins";
            const string MasterSPUpdate = "gen_professiongroup_Upd";
            const string MasterSPDelete = "gen_professiongroup_Del";
            
			
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
                                item.professiongroupid=PrimaryKeyMaster;
                            }
                        }
                        gen_professionDataAccessObjects objgen_profession=new gen_professionDataAccessObjects(this.Context);
                        objgen_profession.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.SaveDsgen_professiongroup"));
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
        async Task<gen_professiongroupEntity> Igen_professiongroupDataAccessObjects.GetSingle(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_professiongroup_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_professiongroup, cmd, Database);
                    
                    IList<gen_professiongroupEntity> itemList = new List<gen_professiongroupEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professiongroupEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.GetSinglegen_professiongroup"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_professiongroupEntity>> Igen_professiongroupDataAccessObjects.GAPgListView(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_professiongroup_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_professiongroup.SortExpression);
                    AddPageSizeParameter(cmd, gen_professiongroup.PageSize);
                    AddCurrentPageParameter(cmd, gen_professiongroup.CurrentPage);                    
                    FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_professiongroup, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_professiongroup.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_professiongroup.strCommonSerachParam+"%");

                    IList<gen_professiongroupEntity> itemList = new List<gen_professiongroupEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professiongroupEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_professiongroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.GAPgListViewgen_professiongroup"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_professiongroupDataAccessObjects.GetDataForDropDown(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_professiongroup_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_professiongroup.SortExpression);
					AddPageSizeParameter(cmd, gen_professiongroup.PageSize);
					AddCurrentPageParameter(cmd, gen_professiongroup.CurrentPage);                    
					FillSequrityParameters(gen_professiongroup.BaseSecurityParam, cmd, Database);
					FillParameters(gen_professiongroup, cmd,Database);
					if (!string.IsNullOrEmpty(gen_professiongroup.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_professiongroup.strCommonSerachParam + " % ");
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
						gen_professiongroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_professiongroupDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}