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
	
	internal sealed partial class stp_organizationDataAccessObjects : BaseDataAccess, Istp_organizationDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "stp_organizationDataAccessObjects";
        
		public stp_organizationDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(stp_organizationEntity stp_organization, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (stp_organization.organizationkey.HasValue)
				Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_organization.organizationkey);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(stp_organization.organizationname)))
				Database.AddInParameter(cmd, "@OrganizationName", DbType.String, stp_organization.organizationname);
			if (!(string.IsNullOrEmpty(stp_organization.addresslineone)))
				Database.AddInParameter(cmd, "@AddressLineOne", DbType.String, stp_organization.addresslineone);
			if (!(string.IsNullOrEmpty(stp_organization.addresslinetwo)))
				Database.AddInParameter(cmd, "@AddressLineTwo", DbType.String, stp_organization.addresslinetwo);
			if (!(string.IsNullOrEmpty(stp_organization.phone)))
				Database.AddInParameter(cmd, "@Phone", DbType.String, stp_organization.phone);
			if (!(string.IsNullOrEmpty(stp_organization.email)))
				Database.AddInParameter(cmd, "@Email", DbType.String, stp_organization.email);
			if (!(string.IsNullOrEmpty(stp_organization.website)))
				Database.AddInParameter(cmd, "@Website", DbType.String, stp_organization.website);
			if (!(string.IsNullOrEmpty(stp_organization.domain)))
				Database.AddInParameter(cmd, "@Domain", DbType.String, stp_organization.domain);
			if (!(string.IsNullOrEmpty(stp_organization.fax)))
				Database.AddInParameter(cmd, "@Fax", DbType.String, stp_organization.fax);
			if ((stp_organization.ismailenable != null))
				Database.AddInParameter(cmd, "@IsMailEnable", DbType.Boolean, stp_organization.ismailenable);
			if (!(string.IsNullOrEmpty(stp_organization.smtphost)))
				Database.AddInParameter(cmd, "@smtpHost", DbType.String, stp_organization.smtphost);
			if (stp_organization.mailport.HasValue)
				Database.AddInParameter(cmd, "@mailPort", DbType.Int64, stp_organization.mailport);
			if (!(string.IsNullOrEmpty(stp_organization.smtpusername)))
				Database.AddInParameter(cmd, "@smtpUserName", DbType.String, stp_organization.smtpusername);
			if (!(string.IsNullOrEmpty(stp_organization.smtppassword)))
				Database.AddInParameter(cmd, "@smtpPassword", DbType.String, stp_organization.smtppassword);
			if ((stp_organization.mailssl != null))
				Database.AddInParameter(cmd, "@mailSSL", DbType.Boolean, stp_organization.mailssl);
			if (!(string.IsNullOrEmpty(stp_organization.fromemailaddress)))
				Database.AddInParameter(cmd, "@fromemailaddress", DbType.String, stp_organization.fromemailaddress);
			if (!(string.IsNullOrEmpty(stp_organization.maildisplayname)))
				Database.AddInParameter(cmd, "@maildisplayName", DbType.String, stp_organization.maildisplayname);
			if ((stp_organization.isftpenable != null))
				Database.AddInParameter(cmd, "@isFtpEnable", DbType.Boolean, stp_organization.isftpenable);
			if (!(string.IsNullOrEmpty(stp_organization.ftpaddress)))
				Database.AddInParameter(cmd, "@ftpAddress", DbType.String, stp_organization.ftpaddress);
			if (!(string.IsNullOrEmpty(stp_organization.ftpport)))
				Database.AddInParameter(cmd, "@ftpPort", DbType.String, stp_organization.ftpport);
			if (!(string.IsNullOrEmpty(stp_organization.ftpusername)))
				Database.AddInParameter(cmd, "@ftpUserName", DbType.String, stp_organization.ftpusername);
			if (!(string.IsNullOrEmpty(stp_organization.ftppassword)))
				Database.AddInParameter(cmd, "@ftpPassword", DbType.String, stp_organization.ftppassword);
			if ((stp_organization.isssl != null))
				Database.AddInParameter(cmd, "@IsSSL", DbType.Boolean, stp_organization.isssl);
			if (!(string.IsNullOrEmpty(stp_organization.logoimg)))
				Database.AddInParameter(cmd, "@LogoImg", DbType.String, stp_organization.logoimg);
			if (!(string.IsNullOrEmpty(stp_organization.webheader)))
				Database.AddInParameter(cmd, "@WebHeader", DbType.String, stp_organization.webheader);
			if (!(string.IsNullOrEmpty(stp_organization.folderpath)))
				Database.AddInParameter(cmd, "@FolderPath", DbType.String, stp_organization.folderpath);
			if (!(string.IsNullOrEmpty(stp_organization.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, stp_organization.updateinfo);
			if (stp_organization.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, stp_organization.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Istp_organizationDataAccessObjects.Add(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "stp_organization_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(stp_organization, cmd,Database);
                FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.Addstp_organization"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Istp_organizationDataAccessObjects.Update(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "stp_organization_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(stp_organization, cmd,Database);
                FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.Updatestp_organization"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Istp_organizationDataAccessObjects.Delete(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "stp_organization_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(stp_organization, cmd,Database, true);
                FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.Deletestp_organization"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Istp_organizationDataAccessObjects.SaveList(IList<stp_organizationEntity> listAdded, IList<stp_organizationEntity> listUpdated, IList<stp_organizationEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "stp_organization_Ins";
            const string SPUpdate = "stp_organization_Upd";
            const string SPDelete = "stp_organization_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationEntity stp_organization in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organization, cmd, Database, true);
                            FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationEntity stp_organization in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organization, cmd, Database);
                            FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
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
                    foreach (stp_organizationEntity stp_organization in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organization, cmd, Database);
                            FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.Save_stp_organization"));
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
       IList<stp_organizationEntity> listAdded, 
       IList<stp_organizationEntity> listUpdated, 
       IList<stp_organizationEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "stp_organization_Ins";
            const string SPUpdate = "stp_organization_Upd";
            const string SPDelete = "stp_organization_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (stp_organizationEntity stp_organization in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(stp_organization, cmd, db, true);
                            FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationEntity stp_organization in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(stp_organization, cmd, db);
                            FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, db);
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
                    foreach (stp_organizationEntity stp_organization in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(stp_organization, cmd, db);
                            FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.Save_stp_organization"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<stp_organizationEntity>> Istp_organizationDataAccessObjects.GetAll(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organization_GA";
                IList<stp_organizationEntity> itemList = new List<stp_organizationEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, stp_organization.SortExpression);
                    FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organization, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.GetAllstp_organization"));
            }	
        }
		
        async Task<IList<stp_organizationEntity>> Istp_organizationDataAccessObjects.GetAllByPages(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "stp_organization_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organization.SortExpression);
                    AddPageSizeParameter(cmd, stp_organization.PageSize);
                    AddCurrentPageParameter(cmd, stp_organization.CurrentPage);                    
                    FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organization, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (stp_organization.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+stp_organization.strCommonSerachParam+"%");

                    IList<stp_organizationEntity> itemList = new List<stp_organizationEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organization.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.GetAllByPagesstp_organization"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Istp_organizationDataAccessObjects.SaveMasterDetstp_organizationentity(stp_organizationEntity masterEntity, 
        IList<stp_organizationentityEntity> listAdded, 
        IList<stp_organizationentityEntity> listUpdated,
        IList<stp_organizationentityEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organization_Ins";
            const string MasterSPUpdate = "stp_organization_Upd";
            const string MasterSPDelete = "stp_organization_Del";
            
			
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
                                item.organizationkey=PrimaryKeyMaster;
                            }
                        }
                        stp_organizationentityDataAccessObjects objstp_organizationentity=new stp_organizationentityDataAccessObjects(this.Context);
                        objstp_organizationentity.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.SaveDsstp_organization"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Istp_organizationDataAccessObjects.SaveMasterDetstp_organizationentitytype(stp_organizationEntity masterEntity, 
        IList<stp_organizationentitytypeEntity> listAdded, 
        IList<stp_organizationentitytypeEntity> listUpdated,
        IList<stp_organizationentitytypeEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "stp_organization_Ins";
            const string MasterSPUpdate = "stp_organization_Upd";
            const string MasterSPDelete = "stp_organization_Del";
            
			
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
                                item.organizationkey=PrimaryKeyMaster;
                            }
                        }
                        stp_organizationentitytypeDataAccessObjects objstp_organizationentitytype=new stp_organizationentitytypeDataAccessObjects(this.Context);
                        objstp_organizationentitytype.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.SaveDsstp_organization"));
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
        async Task<stp_organizationEntity> Istp_organizationDataAccessObjects.GetSingle(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "stp_organization_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
                    FillParameters(stp_organization, cmd, Database);
                    
                    IList<stp_organizationEntity> itemList = new List<stp_organizationEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.GetSinglestp_organization"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<stp_organizationEntity>> Istp_organizationDataAccessObjects.GAPgListView(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "stp_organization_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organization.SortExpression);
                    AddPageSizeParameter(cmd, stp_organization.PageSize);
                    AddCurrentPageParameter(cmd, stp_organization.CurrentPage);                    
                    FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
                    
					FillParameters(stp_organization, cmd,Database);
                    
					if (!string.IsNullOrEmpty (stp_organization.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+stp_organization.strCommonSerachParam+"%");

                    IList<stp_organizationEntity> itemList = new List<stp_organizationEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						stp_organization.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.GAPgListViewstp_organization"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Istp_organizationDataAccessObjects.GetDataForDropDown(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "stp_organization_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, stp_organization.SortExpression);
					AddPageSizeParameter(cmd, stp_organization.PageSize);
					AddCurrentPageParameter(cmd, stp_organization.CurrentPage);                    
					FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
					FillParameters(stp_organization, cmd,Database);
					if (!string.IsNullOrEmpty(stp_organization.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + stp_organization.strCommonSerachParam + "%");
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
						stp_organization.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Istp_organizationDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}