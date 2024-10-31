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
	
	internal sealed partial class gen_certificateDataAccessObjects : BaseDataAccess, Igen_certificateDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_certificateDataAccessObjects";
        
		public gen_certificateDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_certificateEntity gen_certificate, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_certificate.certificateid.HasValue)
				Database.AddInParameter(cmd, "@CertificateID", DbType.Int64, gen_certificate.certificateid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_certificate.certificatename)))
				Database.AddInParameter(cmd, "@CertificateName", DbType.String, gen_certificate.certificatename);
			if (gen_certificate.educationlevel.HasValue)
				Database.AddInParameter(cmd, "@EducationLevel", DbType.Int64, gen_certificate.educationlevel);
			if (gen_certificate.certificatelevelid.HasValue)
				Database.AddInParameter(cmd, "@CertificateLevelID", DbType.Int64, gen_certificate.certificatelevelid);
			if (gen_certificate.certificatetypeid.HasValue)
				Database.AddInParameter(cmd, "@CertificateTypeID", DbType.Int64, gen_certificate.certificatetypeid);
			if ((gen_certificate.ispercentage != null))
				Database.AddInParameter(cmd, "@IsPercentage", DbType.Boolean, gen_certificate.ispercentage);
			if (!(string.IsNullOrEmpty(gen_certificate.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_certificate.comment);
			if (!(string.IsNullOrEmpty(gen_certificate.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_certificate.remarks);

        }
		
        
		#region Add Operation

        async Task<long> Igen_certificateDataAccessObjects.Add(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_certificate_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_certificate, cmd,Database);
                FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.Addgen_certificate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_certificateDataAccessObjects.Update(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_certificate_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_certificate, cmd,Database);
                FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.Updategen_certificate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_certificateDataAccessObjects.Delete(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_certificate_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_certificate, cmd,Database, true);
                FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.Deletegen_certificate"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_certificateDataAccessObjects.SaveList(IList<gen_certificateEntity> listAdded, IList<gen_certificateEntity> listUpdated, IList<gen_certificateEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_certificate_Ins";
            const string SPUpdate = "gen_certificate_Upd";
            const string SPDelete = "gen_certificate_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_certificateEntity gen_certificate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_certificate, cmd, Database, true);
                            FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_certificateEntity gen_certificate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_certificate, cmd, Database);
                            FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_certificateEntity gen_certificate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_certificate, cmd, Database);
                            FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.Save_gen_certificate"));
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
       IList<gen_certificateEntity> listAdded, 
       IList<gen_certificateEntity> listUpdated, 
       IList<gen_certificateEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_certificate_Ins";
            const string SPUpdate = "gen_certificate_Upd";
            const string SPDelete = "gen_certificate_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_certificateEntity gen_certificate in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_certificate, cmd, db, true);
                            FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, db);
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
                    foreach (gen_certificateEntity gen_certificate in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_certificate, cmd, db);
                            FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, db);
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
                    foreach (gen_certificateEntity gen_certificate in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_certificate, cmd, db);
                            FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.Save_gen_certificate"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GetAll(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificate_GA";
                IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificate, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GetAllgen_certificate"));
            }	
        }
		
        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GetAllByPages(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_certificate_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificate.CurrentPage);                    
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_certificate, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_certificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_certificate.strCommonSerachParam+"%");

                    IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_certificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GetAllByPagesgen_certificate"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_certificateDataAccessObjects.SaveMasterDetgen_batchcandidatecertificate(gen_certificateEntity masterEntity, 
        IList<gen_batchcandidatecertificateEntity> listAdded, 
        IList<gen_batchcandidatecertificateEntity> listUpdated,
        IList<gen_batchcandidatecertificateEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_certificate_Ins";
            const string MasterSPUpdate = "gen_certificate_Upd";
            const string MasterSPDelete = "gen_certificate_Del";
            
			
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
                                item.certificateid=PrimaryKeyMaster;
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.SaveDsgen_certificate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Igen_certificateDataAccessObjects.SaveMasterDetgen_certificatesubjects(gen_certificateEntity masterEntity, 
        IList<gen_certificatesubjectsEntity> listAdded, 
        IList<gen_certificatesubjectsEntity> listUpdated,
        IList<gen_certificatesubjectsEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_certificate_Ins";
            const string MasterSPUpdate = "gen_certificate_Upd";
            const string MasterSPDelete = "gen_certificate_Del";
            
			
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
                                item.certificateid=PrimaryKeyMaster;
                            }
                        }
                        gen_certificatesubjectsDataAccessObjects objgen_certificatesubjects=new gen_certificatesubjectsDataAccessObjects(this.Context);
                        objgen_certificatesubjects.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.SaveDsgen_certificate"));
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
        async Task<gen_certificateEntity> Igen_certificateDataAccessObjects.GetSingle(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificate_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificate, cmd, Database);
                    
                    IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GetSinglegen_certificate"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_certificateEntity>> Igen_certificateDataAccessObjects.GAPgListView(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_certificate_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificate.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificate.CurrentPage);                    
                    FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_certificate, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_certificate.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_certificate.strCommonSerachParam+"%");

                    IList<gen_certificateEntity> itemList = new List<gen_certificateEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificateEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_certificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GAPgListViewgen_certificate"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_certificateDataAccessObjects.GetDataForDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_certificate_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_certificate.SortExpression);
					AddPageSizeParameter(cmd, gen_certificate.PageSize);
					AddCurrentPageParameter(cmd, gen_certificate.CurrentPage);                    
					FillSequrityParameters(gen_certificate.BaseSecurityParam, cmd, Database);
					FillParameters(gen_certificate, cmd,Database);
					if (!string.IsNullOrEmpty(gen_certificate.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificate.strCommonSerachParam + "%");
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
						gen_certificate.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_certificateDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}