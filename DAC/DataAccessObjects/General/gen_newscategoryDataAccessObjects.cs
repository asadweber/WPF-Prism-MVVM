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
	
	internal sealed partial class gen_newscategoryDataAccessObjects : BaseDataAccess, Igen_newscategoryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_newscategoryDataAccessObjects";
        
		public gen_newscategoryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_newscategoryEntity gen_newscategory, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_newscategory.newscategoryid.HasValue)
				Database.AddInParameter(cmd, "@NewsCategoryID", DbType.Int64, gen_newscategory.newscategoryid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_newscategory.newscategoryar)))
				Database.AddInParameter(cmd, "@NewsCategoryAR", DbType.String, gen_newscategory.newscategoryar);
			if (!(string.IsNullOrEmpty(gen_newscategory.newscategory)))
				Database.AddInParameter(cmd, "@NewsCategory", DbType.String, gen_newscategory.newscategory);

        }
		
        
		#region Add Operation

        async Task<long> Igen_newscategoryDataAccessObjects.Add(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_newscategory_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_newscategory, cmd,Database);
                FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.Addgen_newscategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_newscategoryDataAccessObjects.Update(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_newscategory_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_newscategory, cmd,Database);
                FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.Updategen_newscategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_newscategoryDataAccessObjects.Delete(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_newscategory_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_newscategory, cmd,Database, true);
                FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.Deletegen_newscategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_newscategoryDataAccessObjects.SaveList(IList<gen_newscategoryEntity> listAdded, IList<gen_newscategoryEntity> listUpdated, IList<gen_newscategoryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_newscategory_Ins";
            const string SPUpdate = "gen_newscategory_Upd";
            const string SPDelete = "gen_newscategory_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_newscategoryEntity gen_newscategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_newscategory, cmd, Database, true);
                            FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_newscategoryEntity gen_newscategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_newscategory, cmd, Database);
                            FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_newscategoryEntity gen_newscategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_newscategory, cmd, Database);
                            FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.Save_gen_newscategory"));
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
       IList<gen_newscategoryEntity> listAdded, 
       IList<gen_newscategoryEntity> listUpdated, 
       IList<gen_newscategoryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_newscategory_Ins";
            const string SPUpdate = "gen_newscategory_Upd";
            const string SPDelete = "gen_newscategory_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_newscategoryEntity gen_newscategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_newscategory, cmd, db, true);
                            FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_newscategoryEntity gen_newscategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_newscategory, cmd, db);
                            FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_newscategoryEntity gen_newscategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_newscategory, cmd, db);
                            FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.Save_gen_newscategory"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_newscategoryEntity>> Igen_newscategoryDataAccessObjects.GetAll(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_newscategory_GA";
                IList<gen_newscategoryEntity> itemList = new List<gen_newscategoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_newscategory.SortExpression);
                    FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_newscategory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newscategoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.GetAllgen_newscategory"));
            }	
        }
		
        async Task<IList<gen_newscategoryEntity>> Igen_newscategoryDataAccessObjects.GetAllByPages(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_newscategory_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_newscategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_newscategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_newscategory.CurrentPage);                    
                    FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_newscategory, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_newscategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_newscategory.strCommonSerachParam+"%");

                    IList<gen_newscategoryEntity> itemList = new List<gen_newscategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newscategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_newscategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.GetAllByPagesgen_newscategory"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_newscategoryDataAccessObjects.SaveMasterDetgen_news(gen_newscategoryEntity masterEntity, 
        IList<gen_newsEntity> listAdded, 
        IList<gen_newsEntity> listUpdated,
        IList<gen_newsEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_newscategory_Ins";
            const string MasterSPUpdate = "gen_newscategory_Upd";
            const string MasterSPDelete = "gen_newscategory_Del";
            
			
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
                                item.newscategoryid=PrimaryKeyMaster;
                            }
                        }
                        gen_newsDataAccessObjects objgen_news=new gen_newsDataAccessObjects(this.Context);
                        objgen_news.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.SaveDsgen_newscategory"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Igen_newscategoryDataAccessObjects.SaveMasterDetgen_newscategory(gen_newscategoryEntity masterEntity, 
        IList<gen_newscategoryEntity> listAdded, 
        IList<gen_newscategoryEntity> listUpdated,
        IList<gen_newscategoryEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_newscategory_Ins";
            const string MasterSPUpdate = "gen_newscategory_Upd";
            const string MasterSPDelete = "gen_newscategory_Del";
            
			
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
                                item.newscategoryid=PrimaryKeyMaster;
                            }
                        }
                        gen_newscategoryDataAccessObjects objgen_newscategory=new gen_newscategoryDataAccessObjects(this.Context);
                        objgen_newscategory.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.SaveDsgen_newscategory"));
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
        async Task<gen_newscategoryEntity> Igen_newscategoryDataAccessObjects.GetSingle(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_newscategory_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_newscategory, cmd, Database);
                    
                    IList<gen_newscategoryEntity> itemList = new List<gen_newscategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newscategoryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.GetSinglegen_newscategory"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_newscategoryEntity>> Igen_newscategoryDataAccessObjects.GAPgListView(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_newscategory_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_newscategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_newscategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_newscategory.CurrentPage);                    
                    FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_newscategory, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_newscategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_newscategory.strCommonSerachParam+"%");

                    IList<gen_newscategoryEntity> itemList = new List<gen_newscategoryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newscategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_newscategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.GAPgListViewgen_newscategory"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_newscategoryDataAccessObjects.GetDataForDropDown(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_newscategory_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_newscategory.SortExpression);
					AddPageSizeParameter(cmd, gen_newscategory.PageSize);
					AddCurrentPageParameter(cmd, gen_newscategory.CurrentPage);                    
					FillSequrityParameters(gen_newscategory.BaseSecurityParam, cmd, Database);
					FillParameters(gen_newscategory, cmd,Database);
					if (!string.IsNullOrEmpty(gen_newscategory.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_newscategory.strCommonSerachParam + " % ");
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
						gen_newscategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_newscategoryDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}