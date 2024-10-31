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
	
	internal sealed partial class gen_certificatelevelDataAccessObjects : BaseDataAccess, Igen_certificatelevelDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_certificatelevelDataAccessObjects";
        
		public gen_certificatelevelDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_certificatelevelEntity gen_certificatelevel, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_certificatelevel.certificatelevelid.HasValue)
				Database.AddInParameter(cmd, "@CertificateLevelID", DbType.Int64, gen_certificatelevel.certificatelevelid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_certificatelevel.certificatelevel)))
				Database.AddInParameter(cmd, "@CertificateLevel", DbType.String, gen_certificatelevel.certificatelevel);
			if (!(string.IsNullOrEmpty(gen_certificatelevel.certificateleveleng)))
				Database.AddInParameter(cmd, "@CertificateLevelEng", DbType.String, gen_certificatelevel.certificateleveleng);
			if (!(string.IsNullOrEmpty(gen_certificatelevel.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_certificatelevel.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_certificatelevelDataAccessObjects.Add(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_certificatelevel_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_certificatelevel, cmd,Database);
                FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.Addgen_certificatelevel"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_certificatelevelDataAccessObjects.Update(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_certificatelevel_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_certificatelevel, cmd,Database);
                FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.Updategen_certificatelevel"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_certificatelevelDataAccessObjects.Delete(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_certificatelevel_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_certificatelevel, cmd,Database, true);
                FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.Deletegen_certificatelevel"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_certificatelevelDataAccessObjects.SaveList(IList<gen_certificatelevelEntity> listAdded, IList<gen_certificatelevelEntity> listUpdated, IList<gen_certificatelevelEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_certificatelevel_Ins";
            const string SPUpdate = "gen_certificatelevel_Upd";
            const string SPDelete = "gen_certificatelevel_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_certificatelevelEntity gen_certificatelevel in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_certificatelevel, cmd, Database, true);
                            FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_certificatelevelEntity gen_certificatelevel in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_certificatelevel, cmd, Database);
                            FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_certificatelevelEntity gen_certificatelevel in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_certificatelevel, cmd, Database);
                            FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.Save_gen_certificatelevel"));
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
       IList<gen_certificatelevelEntity> listAdded, 
       IList<gen_certificatelevelEntity> listUpdated, 
       IList<gen_certificatelevelEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_certificatelevel_Ins";
            const string SPUpdate = "gen_certificatelevel_Upd";
            const string SPDelete = "gen_certificatelevel_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_certificatelevelEntity gen_certificatelevel in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_certificatelevel, cmd, db, true);
                            FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, db);
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
                    foreach (gen_certificatelevelEntity gen_certificatelevel in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_certificatelevel, cmd, db);
                            FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, db);
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
                    foreach (gen_certificatelevelEntity gen_certificatelevel in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_certificatelevel, cmd, db);
                            FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.Save_gen_certificatelevel"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelDataAccessObjects.GetAll(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificatelevel_GA";
                IList<gen_certificatelevelEntity> itemList = new List<gen_certificatelevelEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_certificatelevel.SortExpression);
                    FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificatelevel, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatelevelEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GetAllgen_certificatelevel"));
            }	
        }
		
        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelDataAccessObjects.GetAllByPages(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_certificatelevel_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatelevel.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatelevel.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatelevel.CurrentPage);                    
                    FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_certificatelevel, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_certificatelevel.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_certificatelevel.strCommonSerachParam+"%");

                    IList<gen_certificatelevelEntity> itemList = new List<gen_certificatelevelEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatelevelEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_certificatelevel.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GetAllByPagesgen_certificatelevel"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_certificatelevelDataAccessObjects.SaveMasterDetgen_batchcandidatecertificate(gen_certificatelevelEntity masterEntity, 
        IList<gen_batchcandidatecertificateEntity> listAdded, 
        IList<gen_batchcandidatecertificateEntity> listUpdated,
        IList<gen_batchcandidatecertificateEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_certificatelevel_Ins";
            const string MasterSPUpdate = "gen_certificatelevel_Upd";
            const string MasterSPDelete = "gen_certificatelevel_Del";
            
			
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
                                item.certificatelevelid=PrimaryKeyMaster;
                            }
                        }
                        gen_batchcandidatecertificateDataAccessObjects objgen_batchcandidatecertificate=new gen_batchcandidatecertificateDataAccessObjects(this.Context);
                        objgen_batchcandidatecertificate.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.SaveDsgen_certificatelevel"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Igen_certificatelevelDataAccessObjects.SaveMasterDetgen_certificate(gen_certificatelevelEntity masterEntity, 
        IList<gen_certificateEntity> listAdded, 
        IList<gen_certificateEntity> listUpdated,
        IList<gen_certificateEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_certificatelevel_Ins";
            const string MasterSPUpdate = "gen_certificatelevel_Upd";
            const string MasterSPDelete = "gen_certificatelevel_Del";
            
			
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
                                item.certificatelevelid=PrimaryKeyMaster;
                            }
                        }
                        gen_certificateDataAccessObjects objgen_certificate=new gen_certificateDataAccessObjects(this.Context);
                        objgen_certificate.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.SaveDsgen_certificatelevel"));
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
        async Task<gen_certificatelevelEntity> Igen_certificatelevelDataAccessObjects.GetSingle(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificatelevel_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificatelevel, cmd, Database);
                    
                    IList<gen_certificatelevelEntity> itemList = new List<gen_certificatelevelEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatelevelEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GetSinglegen_certificatelevel"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelDataAccessObjects.GAPgListView(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_certificatelevel_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatelevel.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatelevel.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatelevel.CurrentPage);                    
                    FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_certificatelevel, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_certificatelevel.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_certificatelevel.strCommonSerachParam+"%");

                    IList<gen_certificatelevelEntity> itemList = new List<gen_certificatelevelEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatelevelEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_certificatelevel.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GAPgListViewgen_certificatelevel"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_certificatelevelDataAccessObjects.GetDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_certificatelevel_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_certificatelevel.SortExpression);
					AddPageSizeParameter(cmd, gen_certificatelevel.PageSize);
					AddCurrentPageParameter(cmd, gen_certificatelevel.CurrentPage);                    
					FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
					FillParameters(gen_certificatelevel, cmd,Database);
					if (!string.IsNullOrEmpty(gen_certificatelevel.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificatelevel.strCommonSerachParam + "%");
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
						gen_certificatelevel.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}