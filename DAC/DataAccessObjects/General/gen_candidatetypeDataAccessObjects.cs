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
	
	internal sealed partial class gen_candidatetypeDataAccessObjects : BaseDataAccess, Igen_candidatetypeDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_candidatetypeDataAccessObjects";
        
		public gen_candidatetypeDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_candidatetypeEntity gen_candidatetype, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_candidatetype.candidatetypeid.HasValue)
				Database.AddInParameter(cmd, "@CandidateTypeID", DbType.Int64, gen_candidatetype.candidatetypeid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_candidatetype.candidatetypename)))
				Database.AddInParameter(cmd, "@CandidateTypeName", DbType.String, gen_candidatetype.candidatetypename);
			if (!(string.IsNullOrEmpty(gen_candidatetype.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_candidatetype.comment);
			if (!(string.IsNullOrEmpty(gen_candidatetype.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_candidatetype.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_candidatetypeDataAccessObjects.Add(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_candidatetype_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_candidatetype, cmd,Database);
                FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.Addgen_candidatetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_candidatetypeDataAccessObjects.Update(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_candidatetype_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_candidatetype, cmd,Database);
                FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.Updategen_candidatetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_candidatetypeDataAccessObjects.Delete(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_candidatetype_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_candidatetype, cmd,Database, true);
                FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.Deletegen_candidatetype"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_candidatetypeDataAccessObjects.SaveList(IList<gen_candidatetypeEntity> listAdded, IList<gen_candidatetypeEntity> listUpdated, IList<gen_candidatetypeEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_candidatetype_Ins";
            const string SPUpdate = "gen_candidatetype_Upd";
            const string SPDelete = "gen_candidatetype_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_candidatetypeEntity gen_candidatetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_candidatetype, cmd, Database, true);
                            FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_candidatetypeEntity gen_candidatetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_candidatetype, cmd, Database);
                            FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_candidatetypeEntity gen_candidatetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_candidatetype, cmd, Database);
                            FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.Save_gen_candidatetype"));
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
       IList<gen_candidatetypeEntity> listAdded, 
       IList<gen_candidatetypeEntity> listUpdated, 
       IList<gen_candidatetypeEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_candidatetype_Ins";
            const string SPUpdate = "gen_candidatetype_Upd";
            const string SPDelete = "gen_candidatetype_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_candidatetypeEntity gen_candidatetype in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_candidatetype, cmd, db, true);
                            FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_candidatetypeEntity gen_candidatetype in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_candidatetype, cmd, db);
                            FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, db);
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
                    foreach (gen_candidatetypeEntity gen_candidatetype in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_candidatetype, cmd, db);
                            FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.Save_gen_candidatetype"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GetAll(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_candidatetype_GA";
                IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetAllgen_candidatetype"));
            }	
        }
		
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GetAllByPages(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_candidatetype_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_candidatetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_candidatetype.CurrentPage);                    
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_candidatetype, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_candidatetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_candidatetype.strCommonSerachParam+"%");

                    IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_candidatetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetAllByPagesgen_candidatetype"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_candidatetypeDataAccessObjects.SaveMasterDetgen_batchcandidatetypemap(gen_candidatetypeEntity masterEntity, 
        IList<gen_batchcandidatetypemapEntity> listAdded, 
        IList<gen_batchcandidatetypemapEntity> listUpdated,
        IList<gen_batchcandidatetypemapEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_candidatetype_Ins";
            const string MasterSPUpdate = "gen_candidatetype_Upd";
            const string MasterSPDelete = "gen_candidatetype_Del";
            
			
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
                                item.candidatetypeid=PrimaryKeyMaster;
                            }
                        }
                        gen_batchcandidatetypemapDataAccessObjects objgen_batchcandidatetypemap=new gen_batchcandidatetypemapDataAccessObjects(this.Context);
                        objgen_batchcandidatetypemap.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.SaveDsgen_candidatetype"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Igen_candidatetypeDataAccessObjects.SaveMasterDetreg_registrationinfo(gen_candidatetypeEntity masterEntity, 
        IList<reg_registrationinfoEntity> listAdded, 
        IList<reg_registrationinfoEntity> listUpdated,
        IList<reg_registrationinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_candidatetype_Ins";
            const string MasterSPUpdate = "gen_candidatetype_Upd";
            const string MasterSPDelete = "gen_candidatetype_Del";
            
			
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
                                item.candidatetypeid=PrimaryKeyMaster;
                            }
                        }
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo=new reg_registrationinfoDataAccessObjects(this.Context);
                        objreg_registrationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.SaveDsgen_candidatetype"));
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
        async Task<gen_candidatetypeEntity> Igen_candidatetypeDataAccessObjects.GetSingle(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_candidatetype_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_candidatetype, cmd, Database);
                    
                    IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetSinglegen_candidatetype"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeDataAccessObjects.GAPgListView(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_candidatetype_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
                    AddPageSizeParameter(cmd, gen_candidatetype.PageSize);
                    AddCurrentPageParameter(cmd, gen_candidatetype.CurrentPage);                    
                    FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_candidatetype, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_candidatetype.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_candidatetype.strCommonSerachParam+"%");

                    IList<gen_candidatetypeEntity> itemList = new List<gen_candidatetypeEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_candidatetypeEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_candidatetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GAPgListViewgen_candidatetype"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_candidatetypeDataAccessObjects.GetDataForDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_candidatetype_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_candidatetype.SortExpression);
					AddPageSizeParameter(cmd, gen_candidatetype.PageSize);
					AddCurrentPageParameter(cmd, gen_candidatetype.CurrentPage);                    
					FillSequrityParameters(gen_candidatetype.BaseSecurityParam, cmd, Database);
					FillParameters(gen_candidatetype, cmd,Database);
					if (!string.IsNullOrEmpty(gen_candidatetype.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_candidatetype.strCommonSerachParam + "%");
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
						gen_candidatetype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_candidatetypeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}