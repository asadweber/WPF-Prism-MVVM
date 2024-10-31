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
	
	internal sealed partial class gen_usefullinkcategoryDataAccessObjects : BaseDataAccess, Igen_usefullinkcategoryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_usefullinkcategoryDataAccessObjects";
        
		public gen_usefullinkcategoryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_usefullinkcategoryEntity gen_usefullinkcategory, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_usefullinkcategory.usefullinkcategoryid.HasValue)
				Database.AddInParameter(cmd, "@UsefulLinkCategoryID", DbType.Int64, gen_usefullinkcategory.usefullinkcategoryid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_usefullinkcategory.usefullinkcategory)))
				Database.AddInParameter(cmd, "@UsefulLinkCategory", DbType.String, gen_usefullinkcategory.usefullinkcategory);
			if (!(string.IsNullOrEmpty(gen_usefullinkcategory.usefullinkcategoryar)))
				Database.AddInParameter(cmd, "@UsefulLinkCategoryAR", DbType.String, gen_usefullinkcategory.usefullinkcategoryar);
			if (!(string.IsNullOrEmpty(gen_usefullinkcategory.usefullinkcategorydescription)))
				Database.AddInParameter(cmd, "@UsefulLinkCategoryDescription", DbType.String, gen_usefullinkcategory.usefullinkcategorydescription);
			if (!(string.IsNullOrEmpty(gen_usefullinkcategory.usefullinkcategorydescriptionar)))
				Database.AddInParameter(cmd, "@UsefulLinkCategoryDescriptionAR", DbType.String, gen_usefullinkcategory.usefullinkcategorydescriptionar);

        }
		
        
		#region Add Operation

        async Task<long> Igen_usefullinkcategoryDataAccessObjects.Add(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_usefullinkcategory_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_usefullinkcategory, cmd,Database);
                FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.Addgen_usefullinkcategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_usefullinkcategoryDataAccessObjects.Update(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_usefullinkcategory_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_usefullinkcategory, cmd,Database);
                FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.Updategen_usefullinkcategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_usefullinkcategoryDataAccessObjects.Delete(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_usefullinkcategory_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_usefullinkcategory, cmd,Database, true);
                FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.Deletegen_usefullinkcategory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_usefullinkcategoryDataAccessObjects.SaveList(IList<gen_usefullinkcategoryEntity> listAdded, IList<gen_usefullinkcategoryEntity> listUpdated, IList<gen_usefullinkcategoryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_usefullinkcategory_Ins";
            const string SPUpdate = "gen_usefullinkcategory_Upd";
            const string SPDelete = "gen_usefullinkcategory_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_usefullinkcategoryEntity gen_usefullinkcategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_usefullinkcategory, cmd, Database, true);
                            FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_usefullinkcategoryEntity gen_usefullinkcategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_usefullinkcategory, cmd, Database);
                            FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_usefullinkcategoryEntity gen_usefullinkcategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_usefullinkcategory, cmd, Database);
                            FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.Save_gen_usefullinkcategory"));
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
       IList<gen_usefullinkcategoryEntity> listAdded, 
       IList<gen_usefullinkcategoryEntity> listUpdated, 
       IList<gen_usefullinkcategoryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_usefullinkcategory_Ins";
            const string SPUpdate = "gen_usefullinkcategory_Upd";
            const string SPDelete = "gen_usefullinkcategory_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_usefullinkcategoryEntity gen_usefullinkcategory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_usefullinkcategory, cmd, db, true);
                            FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_usefullinkcategoryEntity gen_usefullinkcategory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_usefullinkcategory, cmd, db);
                            FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, db);
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
                    foreach (gen_usefullinkcategoryEntity gen_usefullinkcategory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_usefullinkcategory, cmd, db);
                            FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.Save_gen_usefullinkcategory"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryDataAccessObjects.GetAll(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_usefullinkcategory_GA";
                IList<gen_usefullinkcategoryEntity> itemList = new List<gen_usefullinkcategoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_usefullinkcategory.SortExpression);
                    FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_usefullinkcategory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkcategoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.GetAllgen_usefullinkcategory"));
            }	
        }
		
        async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryDataAccessObjects.GetAllByPages(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_usefullinkcategory_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_usefullinkcategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_usefullinkcategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_usefullinkcategory.CurrentPage);                    
                    FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_usefullinkcategory, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_usefullinkcategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_usefullinkcategory.strCommonSerachParam+"%");

                    IList<gen_usefullinkcategoryEntity> itemList = new List<gen_usefullinkcategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkcategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_usefullinkcategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.GetAllByPagesgen_usefullinkcategory"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_usefullinkcategoryDataAccessObjects.SaveMasterDetgen_usefullink(gen_usefullinkcategoryEntity masterEntity, 
        IList<gen_usefullinkEntity> listAdded, 
        IList<gen_usefullinkEntity> listUpdated,
        IList<gen_usefullinkEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_usefullinkcategory_Ins";
            const string MasterSPUpdate = "gen_usefullinkcategory_Upd";
            const string MasterSPDelete = "gen_usefullinkcategory_Del";
            
			
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
                                item.usefullinkcategoryid=PrimaryKeyMaster;
                            }
                        }
                        gen_usefullinkDataAccessObjects objgen_usefullink=new gen_usefullinkDataAccessObjects(this.Context);
                        objgen_usefullink.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.SaveDsgen_usefullinkcategory"));
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
        async Task<gen_usefullinkcategoryEntity> Igen_usefullinkcategoryDataAccessObjects.GetSingle(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_usefullinkcategory_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_usefullinkcategory, cmd, Database);
                    
                    IList<gen_usefullinkcategoryEntity> itemList = new List<gen_usefullinkcategoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkcategoryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.GetSinglegen_usefullinkcategory"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryDataAccessObjects.GAPgListView(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_usefullinkcategory_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_usefullinkcategory.SortExpression);
                    AddPageSizeParameter(cmd, gen_usefullinkcategory.PageSize);
                    AddCurrentPageParameter(cmd, gen_usefullinkcategory.CurrentPage);                    
                    FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_usefullinkcategory, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_usefullinkcategory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_usefullinkcategory.strCommonSerachParam+"%");

                    IList<gen_usefullinkcategoryEntity> itemList = new List<gen_usefullinkcategoryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkcategoryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_usefullinkcategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.GAPgListViewgen_usefullinkcategory"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_usefullinkcategoryDataAccessObjects.GetDataForDropDown(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_usefullinkcategory_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_usefullinkcategory.SortExpression);
					AddPageSizeParameter(cmd, gen_usefullinkcategory.PageSize);
					AddCurrentPageParameter(cmd, gen_usefullinkcategory.CurrentPage);                    
					FillSequrityParameters(gen_usefullinkcategory.BaseSecurityParam, cmd, Database);
					FillParameters(gen_usefullinkcategory, cmd,Database);
					if (!string.IsNullOrEmpty(gen_usefullinkcategory.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_usefullinkcategory.strCommonSerachParam + " % ");
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
						gen_usefullinkcategory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkcategoryDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}