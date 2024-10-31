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
	
	internal sealed partial class gen_relationshipDataAccessObjects : BaseDataAccess, Igen_relationshipDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_relationshipDataAccessObjects";
        
		public gen_relationshipDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_relationshipEntity gen_relationship, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_relationship.relationshipid.HasValue)
				Database.AddInParameter(cmd, "@RelationshipID", DbType.Int64, gen_relationship.relationshipid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_relationship.relationshipname)))
				Database.AddInParameter(cmd, "@RelationshipName", DbType.String, gen_relationship.relationshipname);
			if (!(string.IsNullOrEmpty(gen_relationship.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_relationship.comment);
			if (!(string.IsNullOrEmpty(gen_relationship.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_relationship.remarks);
			if (!(string.IsNullOrEmpty(gen_relationship.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_relationship.updateinfo);
			if (gen_relationship.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_relationship.tranformactionid);
			if (gen_relationship.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_relationship.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_relationshipDataAccessObjects.Add(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_relationship_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_relationship, cmd,Database);
                FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.Addgen_relationship"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_relationshipDataAccessObjects.Update(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_relationship_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_relationship, cmd,Database);
                FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.Updategen_relationship"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_relationshipDataAccessObjects.Delete(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_relationship_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_relationship, cmd,Database, true);
                FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.Deletegen_relationship"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_relationshipDataAccessObjects.SaveList(IList<gen_relationshipEntity> listAdded, IList<gen_relationshipEntity> listUpdated, IList<gen_relationshipEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_relationship_Ins";
            const string SPUpdate = "gen_relationship_Upd";
            const string SPDelete = "gen_relationship_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_relationshipEntity gen_relationship in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_relationship, cmd, Database, true);
                            FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_relationshipEntity gen_relationship in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_relationship, cmd, Database);
                            FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_relationshipEntity gen_relationship in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_relationship, cmd, Database);
                            FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.Save_gen_relationship"));
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
       IList<gen_relationshipEntity> listAdded, 
       IList<gen_relationshipEntity> listUpdated, 
       IList<gen_relationshipEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_relationship_Ins";
            const string SPUpdate = "gen_relationship_Upd";
            const string SPDelete = "gen_relationship_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_relationshipEntity gen_relationship in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_relationship, cmd, db, true);
                            FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, db);
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
                    foreach (gen_relationshipEntity gen_relationship in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_relationship, cmd, db);
                            FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, db);
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
                    foreach (gen_relationshipEntity gen_relationship in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_relationship, cmd, db);
                            FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.Save_gen_relationship"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_relationshipEntity>> Igen_relationshipDataAccessObjects.GetAll(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_relationship_GA";
                IList<gen_relationshipEntity> itemList = new List<gen_relationshipEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_relationship.SortExpression);
                    FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_relationship, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_relationshipEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.GetAllgen_relationship"));
            }	
        }
		
        async Task<IList<gen_relationshipEntity>> Igen_relationshipDataAccessObjects.GetAllByPages(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_relationship_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_relationship.SortExpression);
                    AddPageSizeParameter(cmd, gen_relationship.PageSize);
                    AddCurrentPageParameter(cmd, gen_relationship.CurrentPage);                    
                    FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_relationship, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_relationship.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_relationship.strCommonSerachParam+"%");

                    IList<gen_relationshipEntity> itemList = new List<gen_relationshipEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_relationshipEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_relationship.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.GetAllByPagesgen_relationship"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_relationshipDataAccessObjects.SaveMasterDetreg_familly(gen_relationshipEntity masterEntity, 
        IList<reg_famillyEntity> listAdded, 
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_relationship_Ins";
            const string MasterSPUpdate = "gen_relationship_Upd";
            const string MasterSPDelete = "gen_relationship_Del";
            
			
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
                                item.relationshipid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.SaveDsgen_relationship"));
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
        async Task<gen_relationshipEntity> Igen_relationshipDataAccessObjects.GetSingle(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_relationship_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_relationship, cmd, Database);
                    
                    IList<gen_relationshipEntity> itemList = new List<gen_relationshipEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_relationshipEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.GetSinglegen_relationship"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_relationshipEntity>> Igen_relationshipDataAccessObjects.GAPgListView(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_relationship_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_relationship.SortExpression);
                    AddPageSizeParameter(cmd, gen_relationship.PageSize);
                    AddCurrentPageParameter(cmd, gen_relationship.CurrentPage);                    
                    FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_relationship, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_relationship.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_relationship.strCommonSerachParam+"%");

                    IList<gen_relationshipEntity> itemList = new List<gen_relationshipEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_relationshipEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_relationship.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.GAPgListViewgen_relationship"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_relationshipDataAccessObjects.GetDataForDropDown(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_relationship_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_relationship.SortExpression);
					AddPageSizeParameter(cmd, gen_relationship.PageSize);
					AddCurrentPageParameter(cmd, gen_relationship.CurrentPage);                    
					FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
					FillParameters(gen_relationship, cmd,Database);
					if (!string.IsNullOrEmpty(gen_relationship.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_relationship.strCommonSerachParam + " % ");
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
						gen_relationship.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_relationshipDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}