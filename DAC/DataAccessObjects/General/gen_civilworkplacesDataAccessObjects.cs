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
	
	internal sealed partial class gen_civilworkplacesDataAccessObjects : BaseDataAccess, Igen_civilworkplacesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_civilworkplacesDataAccessObjects";
        
		public gen_civilworkplacesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_civilworkplacesEntity gen_civilworkplaces, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_civilworkplaces.civilworkplacesid.HasValue)
				Database.AddInParameter(cmd, "@CivilWorkPlacesID", DbType.Int64, gen_civilworkplaces.civilworkplacesid);
            if (forDelete) return;
			if (gen_civilworkplaces.parentid.HasValue)
				Database.AddInParameter(cmd, "@ParentID", DbType.Int64, gen_civilworkplaces.parentid);
			if (!(string.IsNullOrEmpty(gen_civilworkplaces.workplacename)))
				Database.AddInParameter(cmd, "@WorkPlaceName", DbType.String, gen_civilworkplaces.workplacename);
			if (!(string.IsNullOrEmpty(gen_civilworkplaces.workplacenameeng)))
				Database.AddInParameter(cmd, "@WorkPlaceNameEng", DbType.String, gen_civilworkplaces.workplacenameeng);
			if (gen_civilworkplaces.governorateid.HasValue)
				Database.AddInParameter(cmd, "@GovernorateID", DbType.Int64, gen_civilworkplaces.governorateid);
			if (gen_civilworkplaces.areaid.HasValue)
				Database.AddInParameter(cmd, "@AreaID", DbType.Int64, gen_civilworkplaces.areaid);
			if (!(string.IsNullOrEmpty(gen_civilworkplaces.block)))
				Database.AddInParameter(cmd, "@Block", DbType.String, gen_civilworkplaces.block);
			if (!(string.IsNullOrEmpty(gen_civilworkplaces.address)))
				Database.AddInParameter(cmd, "@Address", DbType.String, gen_civilworkplaces.address);
			if (!(string.IsNullOrEmpty(gen_civilworkplaces.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_civilworkplaces.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_civilworkplacesDataAccessObjects.Add(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_civilworkplaces_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_civilworkplaces, cmd,Database);
                FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.Addgen_civilworkplaces"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_civilworkplacesDataAccessObjects.Update(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_civilworkplaces_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_civilworkplaces, cmd,Database);
                FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.Updategen_civilworkplaces"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_civilworkplacesDataAccessObjects.Delete(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_civilworkplaces_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_civilworkplaces, cmd,Database, true);
                FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.Deletegen_civilworkplaces"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_civilworkplacesDataAccessObjects.SaveList(IList<gen_civilworkplacesEntity> listAdded, IList<gen_civilworkplacesEntity> listUpdated, IList<gen_civilworkplacesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_civilworkplaces_Ins";
            const string SPUpdate = "gen_civilworkplaces_Upd";
            const string SPDelete = "gen_civilworkplaces_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_civilworkplacesEntity gen_civilworkplaces in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_civilworkplaces, cmd, Database, true);
                            FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_civilworkplacesEntity gen_civilworkplaces in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_civilworkplaces, cmd, Database);
                            FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_civilworkplacesEntity gen_civilworkplaces in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_civilworkplaces, cmd, Database);
                            FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.Save_gen_civilworkplaces"));
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
       IList<gen_civilworkplacesEntity> listAdded, 
       IList<gen_civilworkplacesEntity> listUpdated, 
       IList<gen_civilworkplacesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_civilworkplaces_Ins";
            const string SPUpdate = "gen_civilworkplaces_Upd";
            const string SPDelete = "gen_civilworkplaces_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_civilworkplacesEntity gen_civilworkplaces in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_civilworkplaces, cmd, db, true);
                            FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, db);
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
                    foreach (gen_civilworkplacesEntity gen_civilworkplaces in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_civilworkplaces, cmd, db);
                            FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, db);
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
                    foreach (gen_civilworkplacesEntity gen_civilworkplaces in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_civilworkplaces, cmd, db);
                            FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.Save_gen_civilworkplaces"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesDataAccessObjects.GetAll(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_civilworkplaces_GA";
                IList<gen_civilworkplacesEntity> itemList = new List<gen_civilworkplacesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_civilworkplaces.SortExpression);
                    FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_civilworkplaces, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_civilworkplacesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GetAllgen_civilworkplaces"));
            }	
        }
		
        async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesDataAccessObjects.GetAllByPages(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_civilworkplaces_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_civilworkplaces.SortExpression);
                    AddPageSizeParameter(cmd, gen_civilworkplaces.PageSize);
                    AddCurrentPageParameter(cmd, gen_civilworkplaces.CurrentPage);                    
                    FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_civilworkplaces, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_civilworkplaces.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_civilworkplaces.strCommonSerachParam+"%");

                    IList<gen_civilworkplacesEntity> itemList = new List<gen_civilworkplacesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_civilworkplacesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_civilworkplaces.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GetAllByPagesgen_civilworkplaces"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_civilworkplacesDataAccessObjects.SaveMasterDetgen_civilworkplaces(gen_civilworkplacesEntity masterEntity, 
        IList<gen_civilworkplacesEntity> listAdded, 
        IList<gen_civilworkplacesEntity> listUpdated,
        IList<gen_civilworkplacesEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_civilworkplaces_Ins";
            const string MasterSPUpdate = "gen_civilworkplaces_Upd";
            const string MasterSPDelete = "gen_civilworkplaces_Del";
            
			
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
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.SaveDsgen_civilworkplaces"));
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
        async Task<gen_civilworkplacesEntity> Igen_civilworkplacesDataAccessObjects.GetSingle(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_civilworkplaces_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_civilworkplaces, cmd, Database);
                    
                    IList<gen_civilworkplacesEntity> itemList = new List<gen_civilworkplacesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_civilworkplacesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GetSinglegen_civilworkplaces"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesDataAccessObjects.GAPgListView(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_civilworkplaces_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_civilworkplaces.SortExpression);
                    AddPageSizeParameter(cmd, gen_civilworkplaces.PageSize);
                    AddCurrentPageParameter(cmd, gen_civilworkplaces.CurrentPage);                    
                    FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_civilworkplaces, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_civilworkplaces.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_civilworkplaces.strCommonSerachParam+"%");

                    IList<gen_civilworkplacesEntity> itemList = new List<gen_civilworkplacesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_civilworkplacesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_civilworkplaces.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GAPgListViewgen_civilworkplaces"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_civilworkplacesDataAccessObjects.GetDataForDropDown(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_civilworkplaces_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_civilworkplaces.SortExpression);
					AddPageSizeParameter(cmd, gen_civilworkplaces.PageSize);
					AddCurrentPageParameter(cmd, gen_civilworkplaces.CurrentPage);                    
					FillSequrityParameters(gen_civilworkplaces.BaseSecurityParam, cmd, Database);
					FillParameters(gen_civilworkplaces, cmd,Database);
					if (!string.IsNullOrEmpty(gen_civilworkplaces.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_civilworkplaces.strCommonSerachParam + "%");
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
						gen_civilworkplaces.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_civilworkplacesDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}