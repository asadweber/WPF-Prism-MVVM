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
	
	internal sealed partial class gen_countryclassDataAccessObjects : BaseDataAccess, Igen_countryclassDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_countryclassDataAccessObjects";
        
		public gen_countryclassDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_countryclassEntity gen_countryclass, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_countryclass.classid.HasValue)
				Database.AddInParameter(cmd, "@ClassID", DbType.Int64, gen_countryclass.classid);
            if (forDelete) return;
			if (gen_countryclass.countryid.HasValue)
				Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_countryclass.countryid);
			if (!(string.IsNullOrEmpty(gen_countryclass.classname)))
				Database.AddInParameter(cmd, "@ClassName", DbType.String, gen_countryclass.classname);
			if (gen_countryclass.classhierarchy.HasValue)
				Database.AddInParameter(cmd, "@ClassHierarchy", DbType.Int64, gen_countryclass.classhierarchy);
			if (!(string.IsNullOrEmpty(gen_countryclass.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_countryclass.comment);
			if (!(string.IsNullOrEmpty(gen_countryclass.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_countryclass.remarks);
			if (!(string.IsNullOrEmpty(gen_countryclass.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_countryclass.updateinfo);
			if (gen_countryclass.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_countryclass.tranformactionid);
			if (gen_countryclass.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_countryclass.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_countryclassDataAccessObjects.Add(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_countryclass_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_countryclass, cmd,Database);
                FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.Addgen_countryclass"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_countryclassDataAccessObjects.Update(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_countryclass_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_countryclass, cmd,Database);
                FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.Updategen_countryclass"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_countryclassDataAccessObjects.Delete(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_countryclass_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_countryclass, cmd,Database, true);
                FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.Deletegen_countryclass"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_countryclassDataAccessObjects.SaveList(IList<gen_countryclassEntity> listAdded, IList<gen_countryclassEntity> listUpdated, IList<gen_countryclassEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_countryclass_Ins";
            const string SPUpdate = "gen_countryclass_Upd";
            const string SPDelete = "gen_countryclass_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_countryclassEntity gen_countryclass in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_countryclass, cmd, Database, true);
                            FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_countryclassEntity gen_countryclass in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_countryclass, cmd, Database);
                            FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_countryclassEntity gen_countryclass in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_countryclass, cmd, Database);
                            FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.Save_gen_countryclass"));
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
       IList<gen_countryclassEntity> listAdded, 
       IList<gen_countryclassEntity> listUpdated, 
       IList<gen_countryclassEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_countryclass_Ins";
            const string SPUpdate = "gen_countryclass_Upd";
            const string SPDelete = "gen_countryclass_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_countryclassEntity gen_countryclass in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_countryclass, cmd, db, true);
                            FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, db);
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
                    foreach (gen_countryclassEntity gen_countryclass in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_countryclass, cmd, db);
                            FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, db);
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
                    foreach (gen_countryclassEntity gen_countryclass in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_countryclass, cmd, db);
                            FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.Save_gen_countryclass"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_countryclassEntity>> Igen_countryclassDataAccessObjects.GetAll(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_countryclass_GA";
                IList<gen_countryclassEntity> itemList = new List<gen_countryclassEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_countryclass.SortExpression);
                    FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_countryclass, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryclassEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GetAllgen_countryclass"));
            }	
        }
		
        async Task<IList<gen_countryclassEntity>> Igen_countryclassDataAccessObjects.GetAllByPages(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_countryclass_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_countryclass.SortExpression);
                    AddPageSizeParameter(cmd, gen_countryclass.PageSize);
                    AddCurrentPageParameter(cmd, gen_countryclass.CurrentPage);                    
                    FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_countryclass, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_countryclass.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_countryclass.strCommonSerachParam+"%");

                    IList<gen_countryclassEntity> itemList = new List<gen_countryclassEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryclassEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_countryclass.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GetAllByPagesgen_countryclass"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_countryclassDataAccessObjects.SaveMasterDetreg_familly(gen_countryclassEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_countryclass_Ins";
            const string MasterSPUpdate = "gen_countryclass_Upd";
            const string MasterSPDelete = "gen_countryclass_Del";
            
			
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
                                item.classid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.SaveDsgen_countryclass"));
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
        async Task<gen_countryclassEntity> Igen_countryclassDataAccessObjects.GetSingle(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_countryclass_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_countryclass, cmd, Database);
                    
                    IList<gen_countryclassEntity> itemList = new List<gen_countryclassEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryclassEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GetSinglegen_countryclass"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_countryclassEntity>> Igen_countryclassDataAccessObjects.GAPgListView(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_countryclass_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_countryclass.SortExpression);
                    AddPageSizeParameter(cmd, gen_countryclass.PageSize);
                    AddCurrentPageParameter(cmd, gen_countryclass.CurrentPage);                    
                    FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_countryclass, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_countryclass.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_countryclass.strCommonSerachParam+"%");

                    IList<gen_countryclassEntity> itemList = new List<gen_countryclassEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryclassEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_countryclass.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GAPgListViewgen_countryclass"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_countryclassDataAccessObjects.GetDataForDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_countryclass_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_countryclass.SortExpression);
					AddPageSizeParameter(cmd, gen_countryclass.PageSize);
					AddCurrentPageParameter(cmd, gen_countryclass.CurrentPage);                    
					FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
					FillParameters(gen_countryclass, cmd,Database);
					if (!string.IsNullOrEmpty(gen_countryclass.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_countryclass.strCommonSerachParam + " % ");
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
						gen_countryclass.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}