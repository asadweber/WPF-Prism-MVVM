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
	
	internal sealed partial class gen_trainingcentreDataAccessObjects : BaseDataAccess, Igen_trainingcentreDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_trainingcentreDataAccessObjects";
        
		public gen_trainingcentreDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_trainingcentreEntity gen_trainingcentre, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_trainingcentre.trainingcentreid.HasValue)
				Database.AddInParameter(cmd, "@TrainingCentreID", DbType.Int64, gen_trainingcentre.trainingcentreid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_trainingcentre.trainingcentrename)))
				Database.AddInParameter(cmd, "@TrainingCentreName", DbType.String, gen_trainingcentre.trainingcentrename);
			if (!(string.IsNullOrEmpty(gen_trainingcentre.trainingcentrenameeng)))
				Database.AddInParameter(cmd, "@TrainingCentreNameEng", DbType.String, gen_trainingcentre.trainingcentrenameeng);
			if (!(string.IsNullOrEmpty(gen_trainingcentre.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_trainingcentre.remarks);
			if (!(string.IsNullOrEmpty(gen_trainingcentre.migrationinfo)))
				Database.AddInParameter(cmd, "@MigrationInfo", DbType.String, gen_trainingcentre.migrationinfo);
			if (!(string.IsNullOrEmpty(gen_trainingcentre.migrationtable)))
				Database.AddInParameter(cmd, "@MigrationTable", DbType.String, gen_trainingcentre.migrationtable);
			if (!(string.IsNullOrEmpty(gen_trainingcentre.migrationtext)))
				Database.AddInParameter(cmd, "@MigrationText", DbType.String, gen_trainingcentre.migrationtext);

        }
		
        
		#region Add Operation

        async Task<long> Igen_trainingcentreDataAccessObjects.Add(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_trainingcentre_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_trainingcentre, cmd,Database);
                FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.Addgen_trainingcentre"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_trainingcentreDataAccessObjects.Update(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_trainingcentre_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_trainingcentre, cmd,Database);
                FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.Updategen_trainingcentre"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_trainingcentreDataAccessObjects.Delete(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_trainingcentre_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_trainingcentre, cmd,Database, true);
                FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.Deletegen_trainingcentre"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_trainingcentreDataAccessObjects.SaveList(IList<gen_trainingcentreEntity> listAdded, IList<gen_trainingcentreEntity> listUpdated, IList<gen_trainingcentreEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_trainingcentre_Ins";
            const string SPUpdate = "gen_trainingcentre_Upd";
            const string SPDelete = "gen_trainingcentre_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_trainingcentreEntity gen_trainingcentre in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_trainingcentre, cmd, Database, true);
                            FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_trainingcentreEntity gen_trainingcentre in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_trainingcentre, cmd, Database);
                            FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_trainingcentreEntity gen_trainingcentre in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_trainingcentre, cmd, Database);
                            FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.Save_gen_trainingcentre"));
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
       IList<gen_trainingcentreEntity> listAdded, 
       IList<gen_trainingcentreEntity> listUpdated, 
       IList<gen_trainingcentreEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_trainingcentre_Ins";
            const string SPUpdate = "gen_trainingcentre_Upd";
            const string SPDelete = "gen_trainingcentre_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_trainingcentreEntity gen_trainingcentre in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_trainingcentre, cmd, db, true);
                            FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, db);
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
                    foreach (gen_trainingcentreEntity gen_trainingcentre in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_trainingcentre, cmd, db);
                            FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, db);
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
                    foreach (gen_trainingcentreEntity gen_trainingcentre in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_trainingcentre, cmd, db);
                            FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.Save_gen_trainingcentre"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_trainingcentreEntity>> Igen_trainingcentreDataAccessObjects.GetAll(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_trainingcentre_GA";
                IList<gen_trainingcentreEntity> itemList = new List<gen_trainingcentreEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_trainingcentre.SortExpression);
                    FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_trainingcentre, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_trainingcentreEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.GetAllgen_trainingcentre"));
            }	
        }
		
        async Task<IList<gen_trainingcentreEntity>> Igen_trainingcentreDataAccessObjects.GetAllByPages(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_trainingcentre_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_trainingcentre.SortExpression);
                    AddPageSizeParameter(cmd, gen_trainingcentre.PageSize);
                    AddCurrentPageParameter(cmd, gen_trainingcentre.CurrentPage);                    
                    FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_trainingcentre, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_trainingcentre.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_trainingcentre.strCommonSerachParam+"%");

                    IList<gen_trainingcentreEntity> itemList = new List<gen_trainingcentreEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_trainingcentreEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_trainingcentre.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.GetAllByPagesgen_trainingcentre"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_trainingcentreDataAccessObjects.SaveMasterDettran_trainingjoin(gen_trainingcentreEntity masterEntity, 
        IList<tran_trainingjoinEntity> listAdded, 
        IList<tran_trainingjoinEntity> listUpdated,
        IList<tran_trainingjoinEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_trainingcentre_Ins";
            const string MasterSPUpdate = "gen_trainingcentre_Upd";
            const string MasterSPDelete = "gen_trainingcentre_Del";
            
			
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
                                item.trgcentreid=PrimaryKeyMaster;
                            }
                        }
                        tran_trainingjoinDataAccessObjects objtran_trainingjoin=new tran_trainingjoinDataAccessObjects(this.Context);
                        objtran_trainingjoin.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.SaveDsgen_trainingcentre"));
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
        async Task<gen_trainingcentreEntity> Igen_trainingcentreDataAccessObjects.GetSingle(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_trainingcentre_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_trainingcentre, cmd, Database);
                    
                    IList<gen_trainingcentreEntity> itemList = new List<gen_trainingcentreEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_trainingcentreEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.GetSinglegen_trainingcentre"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_trainingcentreEntity>> Igen_trainingcentreDataAccessObjects.GAPgListView(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_trainingcentre_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_trainingcentre.SortExpression);
                    AddPageSizeParameter(cmd, gen_trainingcentre.PageSize);
                    AddCurrentPageParameter(cmd, gen_trainingcentre.CurrentPage);                    
                    FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_trainingcentre, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_trainingcentre.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_trainingcentre.strCommonSerachParam+"%");

                    IList<gen_trainingcentreEntity> itemList = new List<gen_trainingcentreEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_trainingcentreEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_trainingcentre.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.GAPgListViewgen_trainingcentre"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_trainingcentreDataAccessObjects.GetDataForDropDown(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_trainingcentre_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_trainingcentre.SortExpression);
					AddPageSizeParameter(cmd, gen_trainingcentre.PageSize);
					AddCurrentPageParameter(cmd, gen_trainingcentre.CurrentPage);                    
					FillSequrityParameters(gen_trainingcentre.BaseSecurityParam, cmd, Database);
					FillParameters(gen_trainingcentre, cmd,Database);
					if (!string.IsNullOrEmpty(gen_trainingcentre.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_trainingcentre.strCommonSerachParam + " % ");
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
						gen_trainingcentre.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_trainingcentreDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}