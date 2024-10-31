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
	
	internal sealed partial class reg_registrationinfoDataAccessObjects : BaseDataAccess, Ireg_registrationinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_registrationinfoDataAccessObjects";
        
		public reg_registrationinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(reg_registrationinfoEntity reg_registrationinfo, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (reg_registrationinfo.registrationid.HasValue)
                Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, reg_registrationinfo.registrationid);
            if (forDelete) return;
            if (reg_registrationinfo.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_registrationinfo.basicinfoid);
            if ((reg_registrationinfo.applicationdate.HasValue))
                Database.AddInParameter(cmd, "@ApplicationDate", DbType.DateTime, reg_registrationinfo.applicationdate);
            if (!(string.IsNullOrEmpty(reg_registrationinfo.appliedfromip)))
                Database.AddInParameter(cmd, "@AppliedFromIP", DbType.String, reg_registrationinfo.appliedfromip);
            if ((reg_registrationinfo.isactive != null))
                Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, reg_registrationinfo.isactive);
            if (reg_registrationinfo.idtype.HasValue)
                Database.AddInParameter(cmd, "@IDType", DbType.Int64, reg_registrationinfo.idtype);
            if ((reg_registrationinfo.idissuedate.HasValue))
                Database.AddInParameter(cmd, "@IDIssueDate", DbType.DateTime, reg_registrationinfo.idissuedate);
            if ((reg_registrationinfo.idexpirydate.HasValue))
                Database.AddInParameter(cmd, "@IDExpiryDate", DbType.DateTime, reg_registrationinfo.idexpirydate);
            if (reg_registrationinfo.batchcandidatetypemapid.HasValue)
                Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, reg_registrationinfo.batchcandidatetypemapid);
            if (reg_registrationinfo.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, reg_registrationinfo.batchid);
            if (reg_registrationinfo.candidatetypeid.HasValue)
                Database.AddInParameter(cmd, "@CandidateTypeID", DbType.Int64, reg_registrationinfo.candidatetypeid);
            if (reg_registrationinfo.batchcandprofessionmapid.HasValue)
                Database.AddInParameter(cmd, "@BatchCandProfessionMapID", DbType.Int64, reg_registrationinfo.batchcandprofessionmapid);
            if (reg_registrationinfo.professionid.HasValue)
                Database.AddInParameter(cmd, "@ProfessionID", DbType.Int64, reg_registrationinfo.professionid);
            if (reg_registrationinfo.batchunitlistid.HasValue)
                Database.AddInParameter(cmd, "@BatchUnitListID", DbType.Int64, reg_registrationinfo.batchunitlistid);
            if (reg_registrationinfo.entitykey.HasValue)
                Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, reg_registrationinfo.entitykey);
            if (reg_registrationinfo.isspecialregistration.HasValue)
                Database.AddInParameter(cmd, "@IsSpecialRegistration", DbType.Boolean, reg_registrationinfo.isspecialregistration);
            if (reg_registrationinfo.SpecialRegID.HasValue)
                Database.AddInParameter(cmd, "@SpecialRegID", DbType.Int64, reg_registrationinfo.SpecialRegID);
            if ((reg_registrationinfo.isfinal != null))
                Database.AddInParameter(cmd, "@IsFinal", DbType.Boolean, reg_registrationinfo.isfinal);
            if ((reg_registrationinfo.submitteddate.HasValue))
                Database.AddInParameter(cmd, "@SubmittedDate", DbType.DateTime, reg_registrationinfo.submitteddate);
            if (!(string.IsNullOrEmpty(reg_registrationinfo.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_registrationinfo.remarks);
            if (!(string.IsNullOrEmpty(reg_registrationinfo.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_registrationinfo.updateinfo);
            if (reg_registrationinfo.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_registrationinfo.tranformactionid);

        }



        #region Add Operation

        async Task<long> Ireg_registrationinfoDataAccessObjects.Add(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_registrationinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_registrationinfo, cmd,Database);
                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.Addreg_registrationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_registrationinfoDataAccessObjects.Update(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_registrationinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_registrationinfo, cmd,Database);
                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.Updatereg_registrationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_registrationinfoDataAccessObjects.Delete(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_registrationinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_registrationinfo, cmd,Database, true);
                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.Deletereg_registrationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_registrationinfoDataAccessObjects.SaveList(IList<reg_registrationinfoEntity> listAdded, IList<reg_registrationinfoEntity> listUpdated, IList<reg_registrationinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_registrationinfo_Ins";
            const string SPUpdate = "reg_registrationinfo_Upd";
            const string SPDelete = "reg_registrationinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_registrationinfoEntity reg_registrationinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_registrationinfo, cmd, Database, true);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_registrationinfoEntity reg_registrationinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_registrationinfo, cmd, Database);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_registrationinfoEntity reg_registrationinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_registrationinfo, cmd, Database);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.Save_reg_registrationinfo"));
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
       IList<reg_registrationinfoEntity> listAdded, 
       IList<reg_registrationinfoEntity> listUpdated, 
       IList<reg_registrationinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_registrationinfo_Ins";
            const string SPUpdate = "reg_registrationinfo_Upd";
            const string SPDelete = "reg_registrationinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_registrationinfoEntity reg_registrationinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_registrationinfo, cmd, db, true);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_registrationinfoEntity reg_registrationinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_registrationinfo, cmd, db);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_registrationinfoEntity reg_registrationinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_registrationinfo, cmd, db);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.Save_reg_registrationinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetAll(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_registrationinfo_GA";
                IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_registrationinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAllreg_registrationinfo"));
            }	
        }
		
        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetAllByPages(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_registrationinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);                    
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_registrationinfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_registrationinfo.strCommonSerachParam+"%");

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_registrationinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAllByPagesreg_registrationinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Ireg_registrationinfoDataAccessObjects.SaveMasterDetreg_studentfilestorage(reg_registrationinfoEntity masterEntity, 
        IList<reg_studentfilestorageEntity> listAdded, 
        IList<reg_studentfilestorageEntity> listUpdated,
        IList<reg_studentfilestorageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_registrationinfo_Ins";
            const string MasterSPUpdate = "reg_registrationinfo_Upd";
            const string MasterSPDelete = "reg_registrationinfo_Del";
            
			
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
				
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.SaveDsreg_registrationinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_registrationinfoDataAccessObjects.SaveMasterDettran_applicantphases(reg_registrationinfoEntity masterEntity, 
        IList<tran_applicantphasesEntity> listAdded, 
        IList<tran_applicantphasesEntity> listUpdated,
        IList<tran_applicantphasesEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_registrationinfo_Ins";
            const string MasterSPUpdate = "reg_registrationinfo_Upd";
            const string MasterSPDelete = "reg_registrationinfo_Del";
            
			
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
                                item.registrationid=PrimaryKeyMaster;
                            }
                        }
                        tran_applicantphasesDataAccessObjects objtran_applicantphases=new tran_applicantphasesDataAccessObjects(this.Context);
                        objtran_applicantphases.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.SaveDsreg_registrationinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_registrationinfoDataAccessObjects.SaveMasterDettran_exportprofile(reg_registrationinfoEntity masterEntity, 
        IList<tran_exportprofileEntity> listAdded, 
        IList<tran_exportprofileEntity> listUpdated,
        IList<tran_exportprofileEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_registrationinfo_Ins";
            const string MasterSPUpdate = "reg_registrationinfo_Upd";
            const string MasterSPDelete = "reg_registrationinfo_Del";
            
			
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
                                item.registrationid=PrimaryKeyMaster;
                            }
                        }
                        tran_exportprofileDataAccessObjects objtran_exportprofile=new tran_exportprofileDataAccessObjects(this.Context);
                        objtran_exportprofile.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.SaveDsreg_registrationinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_registrationinfoDataAccessObjects.SaveMasterDettran_notificationbatchdet(reg_registrationinfoEntity masterEntity, 
        IList<tran_notificationbatchdetEntity> listAdded, 
        IList<tran_notificationbatchdetEntity> listUpdated,
        IList<tran_notificationbatchdetEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_registrationinfo_Ins";
            const string MasterSPUpdate = "reg_registrationinfo_Upd";
            const string MasterSPDelete = "reg_registrationinfo_Del";
            
			
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
                                item.registrationid=PrimaryKeyMaster;
                            }
                        }
                        tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdet=new tran_notificationbatchdetDataAccessObjects(this.Context);
                        objtran_notificationbatchdet.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.SaveDsreg_registrationinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Ireg_registrationinfoDataAccessObjects.SaveMasterDettran_rollbackinfo(reg_registrationinfoEntity masterEntity, 
        IList<tran_rollbackinfoEntity> listAdded, 
        IList<tran_rollbackinfoEntity> listUpdated,
        IList<tran_rollbackinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "reg_registrationinfo_Ins";
            const string MasterSPUpdate = "reg_registrationinfo_Upd";
            const string MasterSPDelete = "reg_registrationinfo_Del";
            
			
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
                                item.registrationid=PrimaryKeyMaster;
                            }
                        }
                        tran_rollbackinfoDataAccessObjects objtran_rollbackinfo=new tran_rollbackinfoDataAccessObjects(this.Context);
                        objtran_rollbackinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.SaveDsreg_registrationinfo"));
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
        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingle(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_registrationinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);
                    
                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_registrationinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSinglereg_registrationinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GAPgListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_registrationinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);                    
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_registrationinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_registrationinfo.strCommonSerachParam+"%");

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_registrationinfoEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GAPgListViewreg_registrationinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_registrationinfoDataAccessObjects.GetDataForDropDown(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "reg_registrationinfo_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
					AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
					AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);                    
					FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
					FillParameters(reg_registrationinfo, cmd,Database);
					if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + reg_registrationinfo.strCommonSerachParam + " % ");
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
						reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}