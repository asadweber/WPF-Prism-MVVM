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
	
	internal sealed partial class gen_imagegallarycategoryDataAccessObjects : BaseDataAccess, Igen_imagegallarycategoryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_imagegallarycategoryDataAccessObjects";
        
		public gen_imagegallarycategoryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_imagegallarycategoryEntity gen_imagegallarycategory, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_imagegallarycategory.imagegallarycategoryid.HasValue)
				Database.AddInParameter(cmd, "@ImageGallaryCategoryID", DbType.Int64, gen_imagegallarycategory.imagegallarycategoryid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_imagegallarycategory.imagegallarycategory)))
				Database.AddInParameter(cmd, "@ImageGallaryCategory", DbType.String, gen_imagegallarycategory.imagegallarycategory);
			if (!(string.IsNullOrEmpty(gen_imagegallarycategory.descriptions)))
				Database.AddInParameter(cmd, "@Descriptions", DbType.String, gen_imagegallarycategory.descriptions);

        }
		
        
		#region Add Operation

        async Task<long> Igen_imagegallarycategoryDataAccessObjects.Add(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_imagegallarycategory_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_imagegallarycategory, cmd,Database);
                FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.Addgen_imagegallarycategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_imagegallarycategoryDataAccessObjects.Update(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_imagegallarycategory_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_imagegallarycategory, cmd,Database);
                FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.Updategen_imagegallarycategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_imagegallarycategoryDataAccessObjects.Delete(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_imagegallarycategory_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_imagegallarycategory, cmd,Database, true);
                FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.Deletegen_imagegallarycategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_imagegallarycategoryDataAccessObjects.SaveList(IList<gen_imagegallarycategoryEntity> listAdded, IList<gen_imagegallarycategoryEntity> listUpdated, IList<gen_imagegallarycategoryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_imagegallarycategory_Ins";
            const string SPUpdate = "gen_imagegallarycategory_Upd";
            const string SPDelete = "gen_imagegallarycategory_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_imagegallarycategoryEntity gen_imagegallarycategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_imagegallarycategory, cmd, Database, true);
                            FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_imagegallarycategoryEntity gen_imagegallarycategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_imagegallarycategory, cmd, Database);
                            FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_imagegallarycategoryEntity gen_imagegallarycategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_imagegallarycategory, cmd, Database);
                            FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.Save_gen_imagegallarycategory"));
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
       IList<gen_imagegallarycategoryEntity> listAdded, 
       IList<gen_imagegallarycategoryEntity> listUpdated, 
       IList<gen_imagegallarycategoryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_imagegallarycategory_Ins";
            const string SPUpdate = "gen_imagegallarycategory_Upd";
            const string SPDelete = "gen_imagegallarycategory_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_imagegallarycategoryEntity gen_imagegallarycategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_imagegallarycategory, cmd, db, true);
                            FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_imagegallarycategoryEntity gen_imagegallarycategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_imagegallarycategory, cmd, db);
                            FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_imagegallarycategoryEntity gen_imagegallarycategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_imagegallarycategory, cmd, db);
                            FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.Save_gen_imagegallarycategory"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryDataAccessObjects.GetAll(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_imagegallarycategory_GA";
                IList<gen_imagegallarycategoryEntity> itemList = new List<gen_imagegallarycategoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_imagegallarycategory.SortExpression);
                    FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_imagegallarycategory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallarycategoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.GetAllgen_imagegallarycategory"));
            }	
        }
		
        async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryDataAccessObjects.GetAllByPages(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_imagegallarycategory_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_imagegallarycategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_imagegallarycategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_imagegallarycategory.CurrentPage);                    
                    FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_imagegallarycategory, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_imagegallarycategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_imagegallarycategory.strCommonSerachParam+"%");

                    IList<gen_imagegallarycategoryEntity> itemList = new List<gen_imagegallarycategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallarycategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_imagegallarycategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.GetAllByPagesgen_imagegallarycategory"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_imagegallarycategoryDataAccessObjects.SaveMasterDetgen_imagegallary(gen_imagegallarycategoryEntity masterEntity, 
        IList<gen_imagegallaryEntity> listAdded, 
        IList<gen_imagegallaryEntity> listUpdated,
        IList<gen_imagegallaryEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_imagegallarycategory_Ins";
            const string MasterSPUpdate = "gen_imagegallarycategory_Upd";
            const string MasterSPDelete = "gen_imagegallarycategory_Del";
            
			
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
                                item.imagegallarycategoryid=PrimaryKeyMaster;
                            }
                        }
                        gen_imagegallaryDataAccessObjects objgen_imagegallary=new gen_imagegallaryDataAccessObjects(this.Context);
                        objgen_imagegallary.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.SaveDsgen_imagegallarycategory"));
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
        async Task<gen_imagegallarycategoryEntity> Igen_imagegallarycategoryDataAccessObjects.GetSingle(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_imagegallarycategory_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_imagegallarycategory, cmd, Database);
                    
                    IList<gen_imagegallarycategoryEntity> itemList = new List<gen_imagegallarycategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallarycategoryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.GetSinglegen_imagegallarycategory"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryDataAccessObjects.GAPgListView(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_imagegallarycategory_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_imagegallarycategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_imagegallarycategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_imagegallarycategory.CurrentPage);                    
                    FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_imagegallarycategory, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_imagegallarycategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_imagegallarycategory.strCommonSerachParam+"%");

                    IList<gen_imagegallarycategoryEntity> itemList = new List<gen_imagegallarycategoryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallarycategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_imagegallarycategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.GAPgListViewgen_imagegallarycategory"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_imagegallarycategoryDataAccessObjects.GetDataForDropDown(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_imagegallarycategory_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_imagegallarycategory.SortExpression);
					AddPageSizeParameter(cmd, gen_imagegallarycategory.PageSize);
					AddCurrentPageParameter(cmd, gen_imagegallarycategory.CurrentPage);                    
					FillSequrityParameters(gen_imagegallarycategory.BaseSecurityParam, cmd, Database);
					FillParameters(gen_imagegallarycategory, cmd,Database);
					if (!string.IsNullOrEmpty(gen_imagegallarycategory.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_imagegallarycategory.strCommonSerachParam + " % ");
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
						gen_imagegallarycategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_imagegallarycategoryDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}