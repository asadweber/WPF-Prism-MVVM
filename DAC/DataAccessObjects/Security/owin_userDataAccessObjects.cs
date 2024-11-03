using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Security.Cryptography;
using BDO.Core.DataAccessObjects.Models;

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_userDataAccessObjects : BaseDataAccess, Iowin_userDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userDataAccessObjects";
        
		public owin_userDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userEntity owin_user, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_user.userid.HasValue)
				Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_user.userid);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@ApplicationId", DbType.Guid, owin_user.applicationid);
			if (owin_user.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_user.masteruserid);
			if (!(string.IsNullOrEmpty(owin_user.username)))
				Database.AddInParameter(cmd, "@UserName", DbType.String, owin_user.username);
            if (!(string.IsNullOrEmpty(owin_user.emailaddress)))
				Database.AddInParameter(cmd, "@EmailAddress", DbType.String, owin_user.emailaddress);
			if (!(string.IsNullOrEmpty(owin_user.loweredusername)))
				Database.AddInParameter(cmd, "@LoweredUserName", DbType.String, owin_user.loweredusername);
			if (!(string.IsNullOrEmpty(owin_user.mobilenumber)))
				Database.AddInParameter(cmd, "@MobileNumber", DbType.String, owin_user.mobilenumber);
			if (!(string.IsNullOrEmpty(owin_user.userprofilephoto)))
				Database.AddInParameter(cmd, "@UserProfilePhoto", DbType.String, owin_user.userprofilephoto);
			if ((owin_user.isanonymous != null))
				Database.AddInParameter(cmd, "@IsAnonymous", DbType.Boolean, owin_user.isanonymous);
			if ((owin_user.ischildenable != null))
				Database.AddInParameter(cmd, "@IsChildEnable", DbType.Boolean, owin_user.ischildenable);
			if (!(string.IsNullOrEmpty(owin_user.masprivatekey)))
				Database.AddInParameter(cmd, "@MasPrivateKey", DbType.String, owin_user.masprivatekey);
			if (!(string.IsNullOrEmpty(owin_user.maspublickey)))
				Database.AddInParameter(cmd, "@MasPublicKey", DbType.String, owin_user.maspublickey);
			if (!(string.IsNullOrEmpty(owin_user.password)))
				Database.AddInParameter(cmd, "@Password", DbType.String, owin_user.password);
			if (!(string.IsNullOrEmpty(owin_user.passwordsalt)))
				Database.AddInParameter(cmd, "@PasswordSalt", DbType.String, owin_user.passwordsalt);
			if (!(string.IsNullOrEmpty(owin_user.passwordkey)))
				Database.AddInParameter(cmd, "@PasswordKey", DbType.String, owin_user.passwordkey);
			if (!(string.IsNullOrEmpty(owin_user.passwordvector)))
				Database.AddInParameter(cmd, "@PasswordVector", DbType.String, owin_user.passwordvector);
			if (!(string.IsNullOrEmpty(owin_user.mobilepin)))
				Database.AddInParameter(cmd, "@MobilePIN", DbType.String, owin_user.mobilepin);
			if (!(string.IsNullOrEmpty(owin_user.passwordquestion)))
				Database.AddInParameter(cmd, "@PasswordQuestion", DbType.String, owin_user.passwordquestion);
			if (!(string.IsNullOrEmpty(owin_user.passwordanswer)))
				Database.AddInParameter(cmd, "@PasswordAnswer", DbType.String, owin_user.passwordanswer);
			if ((owin_user.approved != null))
				Database.AddInParameter(cmd, "@Approved", DbType.Boolean, owin_user.approved);
			if ((owin_user.locked != null))
				Database.AddInParameter(cmd, "@Locked", DbType.Boolean, owin_user.locked);
			if ((owin_user.lastlogindate.HasValue))
				Database.AddInParameter(cmd, "@LastLoginDate", DbType.DateTime, owin_user.lastlogindate);
			if ((owin_user.lastpasschangeddate.HasValue))
				Database.AddInParameter(cmd, "@LastPassChangedDate", DbType.DateTime, owin_user.lastpasschangeddate);
			if ((owin_user.lastlockoutdate.HasValue))
				Database.AddInParameter(cmd, "@LastLockoutDate", DbType.DateTime, owin_user.lastlockoutdate);
			if (owin_user.failedpasswordattemptcount.HasValue)
				Database.AddInParameter(cmd, "@FailedPasswordAttemptCount", DbType.Int32, owin_user.failedpasswordattemptcount);
			if (!(string.IsNullOrEmpty(owin_user.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, owin_user.comment);
			if ((owin_user.lastactivitydate.HasValue))
				Database.AddInParameter(cmd, "@LastActivityDate", DbType.DateTime, owin_user.lastactivitydate);
			if ((owin_user.isreviewed != null))
				Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, owin_user.isreviewed);
			if (owin_user.reviewedby.HasValue)
				Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, owin_user.reviewedby);
			if (!(string.IsNullOrEmpty(owin_user.reviewedbyusername)))
				Database.AddInParameter(cmd, "@ReviewedByUserName", DbType.String, owin_user.reviewedbyusername);
			if ((owin_user.revieweddate.HasValue))
				Database.AddInParameter(cmd, "@ReviewedDate", DbType.DateTime, owin_user.revieweddate);
			if ((owin_user.isapproved != null))
				Database.AddInParameter(cmd, "@IsApproved", DbType.Boolean, owin_user.isapproved);
			if (owin_user.approvedby.HasValue)
				Database.AddInParameter(cmd, "@ApprovedBy", DbType.Int64, owin_user.approvedby);
			if (!(string.IsNullOrEmpty(owin_user.approvedbyusername)))
				Database.AddInParameter(cmd, "@ApprovedByUserName", DbType.String, owin_user.approvedbyusername);
			if ((owin_user.approveddate.HasValue))
				Database.AddInParameter(cmd, "@ApprovedDate", DbType.DateTime, owin_user.approveddate);
			if ((owin_user.isemailconfirmed != null))
				Database.AddInParameter(cmd, "@IsEmailConfirmed", DbType.Boolean, owin_user.isemailconfirmed);
			if ((owin_user.emailconfirmationbyuserdate.HasValue))
				Database.AddInParameter(cmd, "@EmailConfirmationByUserDate", DbType.DateTime, owin_user.emailconfirmationbyuserdate);
			if ((owin_user.twofactorenable != null))
				Database.AddInParameter(cmd, "@TwoFactorEnable", DbType.Boolean, owin_user.twofactorenable);
			if ((owin_user.ismobilenumberconfirmed != null))
				Database.AddInParameter(cmd, "@IsMobileNumberConfirmed", DbType.Boolean, owin_user.ismobilenumberconfirmed);
			if ((owin_user.mobilenumberconfirmedbyuserdate.HasValue))
				Database.AddInParameter(cmd, "@MobileNumberConfirmedByUserDate", DbType.DateTime, owin_user.mobilenumberconfirmedbyuserdate);
			if (!(string.IsNullOrEmpty(owin_user.securitystamp)))
				Database.AddInParameter(cmd, "@SecurityStamp", DbType.String, owin_user.securitystamp);
			if (!(string.IsNullOrEmpty(owin_user.concurrencystamp)))
				Database.AddInParameter(cmd, "@ConcurrencyStamp", DbType.String, owin_user.concurrencystamp);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userDataAccessObjects.Add(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_user_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_user, cmd,Database);
                FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.Addowin_user"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userDataAccessObjects.Update(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_user_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_user, cmd,Database);
                FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.Updateowin_user"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userDataAccessObjects.Delete(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_user_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_user, cmd,Database, true);
                FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.Deleteowin_user"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userDataAccessObjects.SaveList(IList<owin_userEntity> listAdded, IList<owin_userEntity> listUpdated, IList<owin_userEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_user_Ins";
            const string SPUpdate = "owin_user_Upd";
            const string SPDelete = "owin_user_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userEntity owin_user in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_user, cmd, Database, true);
                            FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userEntity owin_user in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_user, cmd, Database);
                            FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userEntity owin_user in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_user, cmd, Database);
                            FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.Save_owin_user"));
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
       IList<owin_userEntity> listAdded, 
       IList<owin_userEntity> listUpdated, 
       IList<owin_userEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_user_Ins";
            const string SPUpdate = "owin_user_Upd";
            const string SPDelete = "owin_user_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userEntity owin_user in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_user, cmd, db, true);
                            FillSequrityParameters(owin_user.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userEntity owin_user in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_user, cmd, db);
                            FillSequrityParameters(owin_user.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userEntity owin_user in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_user, cmd, db);
                            FillSequrityParameters(owin_user.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.Save_owin_user"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userEntity>> Iowin_userDataAccessObjects.GetAll(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_user_GA";
                IList<owin_userEntity> itemList = new List<owin_userEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_user, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetAllowin_user"));
            }	
        }
		
        async Task<IList<owin_userEntity>> Iowin_userDataAccessObjects.GetAllByPages(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_user_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    AddPageSizeParameter(cmd, owin_user.PageSize);
                    AddCurrentPageParameter(cmd, owin_user.CurrentPage);                    
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_user, cmd,Database);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_user.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetAllByPagesowin_user"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Iowin_userDataAccessObjects.SaveMasterDetowin_lastworkingpage(owin_userEntity masterEntity, 
        IList<owin_lastworkingpageEntity> listAdded, 
        IList<owin_lastworkingpageEntity> listUpdated,
        IList<owin_lastworkingpageEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Guid PrimaryKeyMaster = new Guid();
            
            string SP = "";
            const string MasterSPInsert = "owin_user_Ins";
            const string MasterSPUpdate = "owin_user_Upd";
            const string MasterSPDelete = "owin_user_Del";
            
			
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
                                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = returnCode;
                        
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
                                item.userid=PrimaryKeyMaster;
                            }
                        }
                        owin_lastworkingpageDataAccessObjects objowin_lastworkingpage=new owin_lastworkingpageDataAccessObjects(this.Context);
                        objowin_lastworkingpage.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SaveDsowin_user"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_userDataAccessObjects.SaveMasterDetowin_userclaims(owin_userEntity masterEntity, 
        IList<owin_userclaimsEntity> listAdded, 
        IList<owin_userclaimsEntity> listUpdated,
        IList<owin_userclaimsEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Guid PrimaryKeyMaster = new Guid();
            
            string SP = "";
            const string MasterSPInsert = "owin_user_Ins";
            const string MasterSPUpdate = "owin_user_Upd";
            const string MasterSPDelete = "owin_user_Del";
            
			
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
                                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = returnCode;
                        
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
                                item.userid=PrimaryKeyMaster;
                            }
                        }
                        owin_userclaimsDataAccessObjects objowin_userclaims=new owin_userclaimsDataAccessObjects(this.Context);
                        objowin_userclaims.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SaveDsowin_user"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_userDataAccessObjects.SaveMasterDetowin_userlogintrail(owin_userEntity masterEntity, 
        IList<owin_userlogintrailEntity> listAdded, 
        IList<owin_userlogintrailEntity> listUpdated,
        IList<owin_userlogintrailEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Guid PrimaryKeyMaster = new Guid();
            
            string SP = "";
            const string MasterSPInsert = "owin_user_Ins";
            const string MasterSPUpdate = "owin_user_Upd";
            const string MasterSPDelete = "owin_user_Del";
            
			
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
                                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = returnCode;
                        
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
                                item.userid=PrimaryKeyMaster;
                            }
                        }
                        owin_userlogintrailDataAccessObjects objowin_userlogintrail=new owin_userlogintrailDataAccessObjects(this.Context);
                        objowin_userlogintrail.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SaveDsowin_user"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_userDataAccessObjects.SaveMasterDetowin_userpasswordresetinfo(owin_userEntity masterEntity, 
        IList<owin_userpasswordresetinfoEntity> listAdded, 
        IList<owin_userpasswordresetinfoEntity> listUpdated,
        IList<owin_userpasswordresetinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Guid PrimaryKeyMaster = new Guid();
            
            string SP = "";
            const string MasterSPInsert = "owin_user_Ins";
            const string MasterSPUpdate = "owin_user_Upd";
            const string MasterSPDelete = "owin_user_Del";
            
			
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
                                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = returnCode;
                        
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
                                item.userid=PrimaryKeyMaster;
                            }
                        }
                        owin_userpasswordresetinfoDataAccessObjects objowin_userpasswordresetinfo=new owin_userpasswordresetinfoDataAccessObjects(this.Context);
                        objowin_userpasswordresetinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SaveDsowin_user"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_userDataAccessObjects.SaveMasterDetowin_userprefferencessettings(owin_userEntity masterEntity, 
        IList<owin_userprefferencessettingsEntity> listAdded, 
        IList<owin_userprefferencessettingsEntity> listUpdated,
        IList<owin_userprefferencessettingsEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Guid PrimaryKeyMaster = new Guid();
            
            string SP = "";
            const string MasterSPInsert = "owin_user_Ins";
            const string MasterSPUpdate = "owin_user_Upd";
            const string MasterSPDelete = "owin_user_Del";
            
			
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
                                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = returnCode;
                        
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
                                item.userid=PrimaryKeyMaster;
                            }
                        }
                        owin_userprefferencessettingsDataAccessObjects objowin_userprefferencessettings=new owin_userprefferencessettingsDataAccessObjects(this.Context);
                        objowin_userprefferencessettings.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SaveDsowin_user"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        
        async Task<long> Iowin_userDataAccessObjects.SaveMasterDetowin_userrole(owin_userEntity masterEntity, 
        IList<owin_userroleEntity> listAdded, 
        IList<owin_userroleEntity> listUpdated,
        IList<owin_userroleEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Guid PrimaryKeyMaster = new Guid();
            
            string SP = "";
            const string MasterSPInsert = "owin_user_Ins";
            const string MasterSPUpdate = "owin_user_Upd";
            const string MasterSPDelete = "owin_user_Del";
            
			
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
                                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = returnCode;
                        
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
                                item.userid=PrimaryKeyMaster;
                            }
                        }
                        owin_userroleDataAccessObjects objowin_userrole=new owin_userroleDataAccessObjects(this.Context);
                        objowin_userrole.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.SaveDsowin_user"));
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
        async Task<owin_userEntity> Iowin_userDataAccessObjects.GetSingle(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_user_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_user, cmd, Database);
                    
                    IList<owin_userEntity> itemList = new List<owin_userEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetSingleowin_user"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userEntity>> Iowin_userDataAccessObjects.GAPgListView(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_user_GAPgListView_Ext";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    AddPageSizeParameter(cmd, owin_user.PageSize);
                    AddCurrentPageParameter(cmd, owin_user.CurrentPage);                    
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_user, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_user.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_user.strCommonSerachParam+"%");
                    if ((owin_user.fromdate.HasValue))
                        Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, owin_user.fromdate);
                    if ((owin_user.todate.HasValue))
                        Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, owin_user.todate);
                    if ((owin_user.roleid.HasValue))
                        Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_user.roleid);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new OwinUserListLoadFromReader(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_user.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GAPgListViewowin_user"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        async Task<long> Iowin_userDataAccessObjects.UpdateReviewed(owin_userEntity owin_user, CancellationToken cancellationToken)                    
        {
           long returnCode = -99;
            const string SP = "owin_user_UpdRev";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_user, cmd,Database);
                FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
                try
                {
                  	IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode= Database.EndExecuteNonQuery(result);
                        returnCode= (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UpdateReviewedowin_user"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        #endregion

        async Task<IList<gen_dropdownEntity>> Iowin_userDataAccessObjects.GetDataForDropDown(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "owin_user_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    AddPageSizeParameter(cmd, owin_user.PageSize);
                    AddCurrentPageParameter(cmd, owin_user.CurrentPage);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_user, cmd, Database);

                    if (!string.IsNullOrEmpty(owin_user.strCommonSerachParam)) Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + owin_user.strCommonSerachParam + " % ");
                    if (owin_user.roleid.HasValue) Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_user.roleid);

                    IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            gen_dropdownEntity obj = new gen_dropdownEntity();
                            if (!reader.IsDBNull(reader.GetOrdinal("strValue1"))) obj.strValue1 = reader.GetGuid(reader.GetOrdinal("strValue1")).ToString();
                            if (!reader.IsDBNull(reader.GetOrdinal("Id"))) obj.Id = reader.GetInt64(reader.GetOrdinal("Id"));
                            if (!reader.IsDBNull(reader.GetOrdinal("Text"))) obj.Text = reader.GetString(reader.GetOrdinal("Text"));
                            itemList.Add(obj);
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        owin_user.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetDataForDropDown"));
            }
        }
    }
}