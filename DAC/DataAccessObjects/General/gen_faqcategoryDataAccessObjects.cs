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
	
	internal sealed partial class gen_faqcategoryDataAccessObjects : BaseDataAccess, Igen_faqcategoryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_faqcategoryDataAccessObjects";
        
		public gen_faqcategoryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_faqcategoryEntity gen_faqcategory, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_faqcategory.faqcategoryid.HasValue)
				Database.AddInParameter(cmd, "@FAQCategoryID", DbType.Int64, gen_faqcategory.faqcategoryid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_faqcategory.faqcategory)))
				Database.AddInParameter(cmd, "@FAQCategory", DbType.String, gen_faqcategory.faqcategory);
			if (!(string.IsNullOrEmpty(gen_faqcategory.faqcategoryen)))
				Database.AddInParameter(cmd, "@FAQCategoryEn", DbType.String, gen_faqcategory.faqcategoryen);

        }
		
        
		#region Add Operation

        async Task<long> Igen_faqcategoryDataAccessObjects.Add(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_faqcategory_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_faqcategory, cmd,Database);
                FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.Addgen_faqcategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_faqcategoryDataAccessObjects.Update(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_faqcategory_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_faqcategory, cmd,Database);
                FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.Updategen_faqcategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_faqcategoryDataAccessObjects.Delete(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_faqcategory_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_faqcategory, cmd,Database, true);
                FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.Deletegen_faqcategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_faqcategoryDataAccessObjects.SaveList(IList<gen_faqcategoryEntity> listAdded, IList<gen_faqcategoryEntity> listUpdated, IList<gen_faqcategoryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_faqcategory_Ins";
            const string SPUpdate = "gen_faqcategory_Upd";
            const string SPDelete = "gen_faqcategory_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_faqcategoryEntity gen_faqcategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_faqcategory, cmd, Database, true);
                            FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_faqcategoryEntity gen_faqcategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_faqcategory, cmd, Database);
                            FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_faqcategoryEntity gen_faqcategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_faqcategory, cmd, Database);
                            FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.Save_gen_faqcategory"));
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
       IList<gen_faqcategoryEntity> listAdded, 
       IList<gen_faqcategoryEntity> listUpdated, 
       IList<gen_faqcategoryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_faqcategory_Ins";
            const string SPUpdate = "gen_faqcategory_Upd";
            const string SPDelete = "gen_faqcategory_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_faqcategoryEntity gen_faqcategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_faqcategory, cmd, db, true);
                            FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_faqcategoryEntity gen_faqcategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_faqcategory, cmd, db);
                            FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_faqcategoryEntity gen_faqcategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_faqcategory, cmd, db);
                            FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.Save_gen_faqcategory"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryDataAccessObjects.GetAll(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_faqcategory_GA";
                IList<gen_faqcategoryEntity> itemList = new List<gen_faqcategoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_faqcategory.SortExpression);
                    FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_faqcategory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqcategoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.GetAllgen_faqcategory"));
            }	
        }
		
        async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryDataAccessObjects.GetAllByPages(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_faqcategory_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_faqcategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_faqcategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_faqcategory.CurrentPage);                    
                    FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_faqcategory, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_faqcategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_faqcategory.strCommonSerachParam+"%");

                    IList<gen_faqcategoryEntity> itemList = new List<gen_faqcategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqcategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_faqcategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.GetAllByPagesgen_faqcategory"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_faqcategoryDataAccessObjects.SaveMasterDetgen_faq(gen_faqcategoryEntity masterEntity, 
        IList<gen_faqEntity> listAdded, 
        IList<gen_faqEntity> listUpdated,
        IList<gen_faqEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_faqcategory_Ins";
            const string MasterSPUpdate = "gen_faqcategory_Upd";
            const string MasterSPDelete = "gen_faqcategory_Del";
            
			
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
                                item.faqcategoryid=PrimaryKeyMaster;
                            }
                        }
                        gen_faqDataAccessObjects objgen_faq=new gen_faqDataAccessObjects(this.Context);
                        objgen_faq.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.SaveDsgen_faqcategory"));
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
        async Task<gen_faqcategoryEntity> Igen_faqcategoryDataAccessObjects.GetSingle(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_faqcategory_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_faqcategory, cmd, Database);
                    
                    IList<gen_faqcategoryEntity> itemList = new List<gen_faqcategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqcategoryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.GetSinglegen_faqcategory"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryDataAccessObjects.GAPgListView(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_faqcategory_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_faqcategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_faqcategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_faqcategory.CurrentPage);                    
                    FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_faqcategory, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_faqcategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_faqcategory.strCommonSerachParam+"%");

                    IList<gen_faqcategoryEntity> itemList = new List<gen_faqcategoryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqcategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_faqcategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.GAPgListViewgen_faqcategory"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_faqcategoryDataAccessObjects.GetDataForDropDown(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_faqcategory_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_faqcategory.SortExpression);
					AddPageSizeParameter(cmd, gen_faqcategory.PageSize);
					AddCurrentPageParameter(cmd, gen_faqcategory.CurrentPage);                    
					FillSequrityParameters(gen_faqcategory.BaseSecurityParam, cmd, Database);
					FillParameters(gen_faqcategory, cmd,Database);
					if (!string.IsNullOrEmpty(gen_faqcategory.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_faqcategory.strCommonSerachParam + " % ");
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
						gen_faqcategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_faqcategoryDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}