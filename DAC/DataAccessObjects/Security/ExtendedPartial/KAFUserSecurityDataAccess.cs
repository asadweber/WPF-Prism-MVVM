using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using AppConfig.EncryptionHandler;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security.ExtendedPartial;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using IDAC.Core.IDataAccessObjects.Security;
using CLL.LLClasses.SecurityModels;
using System.Linq;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.Enums;
using BDO.Core.Base;
using AppConfig.HelperClasses;
using DAC.Core.DataAccessObjects.General;
using RestSharp;
using Newtonsoft.Json;
using BDO.Base;
using System.IO;

namespace DAC.Core.DataAccessObjects.Security.ExtendedPartial
{
    internal sealed class KAFUserSecurityDataAccess : BaseDataAccess, IKAFUserSecurityDataAccess
    {
        #region Constructors
        private string ClassName = "KAFUserSecurityDataAccess";
        public KAFUserSecurityDataAccess(Context context)
            : base(context)
        {
        }
        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #region public method

        #endregion


        public owin_userEntity FillParameters(owin_userEntity owin_user, DbCommand cmd, Database Database, bool? isDelete = false)
        {
            if (owin_user.userid.HasValue)
                Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_user.userid);
            if (owin_user.masteruserid.HasValue)
                Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_user.masteruserid);
            if (isDelete.GetValueOrDefault(false))
                return owin_user;

            Database.AddInParameter(cmd, "@ApplicationId", DbType.Guid, owin_user.applicationid);

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

            if (owin_user.pkeyex.HasValue)
                Database.AddInParameter(cmd, "@PKeyEX", DbType.Int64, owin_user.pkeyex);


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
            return owin_user;
        }
        #endregion

        async Task<owin_userEntity> IKAFUserSecurityDataAccess.GetUserByUserName(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            IList<owin_userEntity> itemList = new List<owin_userEntity>();
            try
            {
                #region Check if user exists

                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_OwinUserByUserName"))
                {
                    owin_user = FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                }

                #endregion
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserByParams"));
            }
            finally
            {
            }
            if (itemList != null && itemList.Count > 0)
                return itemList[0];
            else
                return null;
        }

        async Task<owin_userEntity> IKAFUserSecurityDataAccess.GetUserByParams(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            IList<owin_userEntity> itemList = new List<owin_userEntity>();
            try
            {
                #region Check if user exists

                using (DbCommand cmd = Database.GetStoredProcCommand("owin_user_GA"))
                {
                    owin_user = FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                }

                #endregion
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserByParams"));
            }
            finally
            {
            }
            if (itemList != null && itemList.Count > 0)
                return itemList[0];
            else
                return null;
        }

        async Task<owin_userEntity> IKAFUserSecurityDataAccess.UserSignInAsync(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            owin_userEntity returnObject = new owin_userEntity();
            IList<owin_userEntity> itemList = new List<owin_userEntity>();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand("owin_user_GA"))
                {
                    owin_user = FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                }

                if (itemList != null && itemList.Count > 0)
                {
                    try
                    {

                        if (itemList[0].isreviewed != true || itemList[0].isapproved != true || itemList[0].locked == true)
                        {
                            return null;
                        }


                        //return itemList[0];
                        EncryptionHelper objenc = new EncryptionHelper();
                        string usersalt = itemList[0].passwordsalt;
                        HashWithSaltResult ob2 = objenc.EncodePassword(owin_user.password, usersalt);
                        if (itemList[0].password.Equals(ob2.Digest) && owin_user.username == itemList[0].username)
                        {
                            itemList[0].password = "blablablabla";
                            itemList[0].passwordquestion = "blablablabla";
                            itemList[0].passwordanswer = "blablablabla";
                            itemList[0].passwordkey = "blablablabla";
                            itemList[0].passwordvector = "blablablabla";
                            itemList[0].passwordsalt = "blablablabla";
                            itemList[0].masprivatekey = "blablablabla";
                            itemList[0].maspublickey = "blablablabla";

                            //if(itemList[0].isemailconfirmed.GetValueOrDefault(false))
                            //    throw new Exception("User Email address has not been confirmed.");
                            //if (itemList[0].isreviewed.GetValueOrDefault(false))
                            //    throw new Exception("User has not been reviewed.");
                            //if (itemList[0].approved.GetValueOrDefault(false))
                            //    throw new Exception("User has not been approved.");


                            return itemList[0];
                        }
                        else
                            return null;
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserSignInAsync"));
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserSignInAsync"));
            }
        }

        async Task<long> IKAFUserSecurityDataAccess.UserSignInLogUpdateAsync(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_UpdLastLogin";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    owin_user.lastlogindate = DateTime.Now;
                    owin_user = FillParameters(owin_user, cmd, Database);

                    Database.AddInParameter(cmd, "@SessionID", DbType.String, owin_user.BaseSecurityParam.sessionid);
                    Database.AddInParameter(cmd, "@UserToken", DbType.String, owin_user.BaseSecurityParam.usertoken);

                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnValue = Database.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.CreateUser"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserSignInAsync"));
            }
            return returnValue;
        }

        async Task<long> IKAFUserSecurityDataAccess.UserResetPasswordAsync(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            try
            {
                const string SP = "KAF_Owin_UserPasswordChangeWithCode";

                EncryptionHelper objenc = new EncryptionHelper();
                var salt = objenc.GenerateRandomCryptographicKey(128);
                HashWithSaltResult ob1 = objenc.EncodePassword(owin_user.password, salt);
                owin_user.password = ob1.Digest;
                owin_user.passwordsalt = ob1.Salt;
                owin_user.passwordkey = objenc.GenerateRandomCryptographicKey(24);
                owin_user.passwordvector = objenc.GenerateRandomCryptographicKey(32);

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    owin_user.lastlogindate = DateTime.Now;
                    owin_user = FillParameters(owin_user, cmd, Database);

                    Database.AddInParameter(cmd, "@SessionID", DbType.String, owin_user.BaseSecurityParam.sessionid);
                    Database.AddInParameter(cmd, "@SessionToken", DbType.String, owin_user.code);

                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnValue = Database.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserResetPasswordAsync"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserResetPasswordAsync"));
            }
            return returnValue;
        }

        async Task<long> IKAFUserSecurityDataAccess.UserEmailAddressConfirmed(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            try
            {
                const string SP = "KAF_UserEmailAddressConfirmed";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    owin_user = FillParameters(owin_user, cmd, Database);

                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnValue = Database.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserEmailAddressConfirmed"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserEmailAddressConfirmed"));
            }
            return returnValue;
        }

        async Task<long> IKAFUserSecurityDataAccess.UserPhoneNumberConfirmed(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            try
            {
                const string SP = "KAF_UserPhoneNumberConfirmed";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    owin_user = FillParameters(owin_user, cmd, Database);

                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnValue = Database.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserPhoneNumberConfirmed"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserPhoneNumberConfirmed"));
            }
            return returnValue;
        }

        async Task<IList<owin_userEntity>> IKAFUserSecurityDataAccess.GetUsersInRoleAsync(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetUsersInRoleAsync";
                IList<owin_userEntity> itemList = new List<owin_userEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);

                    FillParameters(objEntity, cmd, Database);
                    if (objEntity.roleid != null && objEntity.roleid > 0)
                        Database.AddInParameter(cmd, "@RoleID", DbType.Int64, objEntity.roleid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUsersInRoleAsync"));
            }
        }

        async Task<long> IKAFUserSecurityDataAccess.RemoveFromRoleAsync(owin_userEntity user, owin_roleEntity role, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            try
            {
                const string SP = "KAF_RemoveFromRoleAsync";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillSequrityParameters(user.BaseSecurityParam, cmd, Database);
                    Database.AddInParameter(cmd, "@RoleID", DbType.Int64, role.roleid);
                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, user.userid);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnValue = Database.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.RemoveFromRoleAsync"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserPhoneNumberConfirmed"));
            }
            return returnValue;
        }
        async Task<long> IKAFUserSecurityDataAccess.SetEmailAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            try
            {
                const string SP = "KAF_SetEmailAsync";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillSequrityParameters(user.BaseSecurityParam, cmd, Database);
                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, user.userid);
                    Database.AddInParameter(cmd, "@EmailAddress", DbType.String, user.emailaddress);
                    Database.AddInParameter(cmd, "@IsEmailConfirmed", DbType.Boolean, user.isemailconfirmed);
                    Database.AddInParameter(cmd, "@EmailConfirmationByUserDate", DbType.DateTime, user.emailconfirmationbyuserdate);

                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnValue = Database.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.SetEmailAsync"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.SetEmailAsync"));
            }
            return returnValue;
        }

        async Task<long?> IKAFUserSecurityDataAccess.ForgetPasswordRequest(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
        {
            long i = -99;
            try
            {
                List<owin_userpasswordresetinfoEntity> listAdded = new List<owin_userpasswordresetinfoEntity>();
                listAdded.Add(owin_userpasswordresetinfo);

                DbConnection connection = Database.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    owin_userpasswordresetinfoDataAccessObjects owin_userpasswordresetinfoDA = new owin_userpasswordresetinfoDataAccessObjects(this.Context);
                    i = await owin_userpasswordresetinfoDA.SaveList(Database, transaction, listAdded, new List<owin_userpasswordresetinfoEntity>(), new List<owin_userpasswordresetinfoEntity>(), cancellationToken);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.ForgetPasswordRequest"));
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
                return i;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ForgetPasswordRequest"));
            }
        }

        async Task<owin_userEntity> IKAFUserSecurityDataAccess.ChangePasswordRequest(owin_userEntity requestuser, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            owin_userEntity returnObject = new owin_userEntity();
            IList<owin_userEntity> itemList = new List<owin_userEntity>();
            try
            {
                owin_userEntity getUser = new owin_userEntity();
                getUser.emailaddress = requestuser.emailaddress;
                requestuser.username = requestuser.username;
                using (DbCommand cmd = Database.GetStoredProcCommand("owin_user_GA"))
                {
                    getUser = FillParameters(getUser, cmd, Database);
                    FillSequrityParameters(requestuser.BaseSecurityParam, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                }
                if (itemList != null && itemList.Count > 0)
                {
                    try
                    {
                        EncryptionHelper objenc = new EncryptionHelper();
                        string usersalt = itemList[0].passwordsalt;
                        HashWithSaltResult ob2 = objenc.EncodePassword(requestuser.password, usersalt);
                        if (itemList[0].password.Equals(ob2.Digest) && requestuser.username == itemList[0].username)
                        {
                            itemList[0].password = "blablablabla";
                            itemList[0].passwordquestion = "blablablabla";
                            itemList[0].passwordanswer = "blablablabla";
                            itemList[0].passwordkey = "blablablabla";
                            itemList[0].passwordvector = "blablablabla";
                            itemList[0].passwordsalt = "blablablabla";
                            itemList[0].masprivatekey = "blablablabla";
                            itemList[0].maspublickey = "blablablabla";

                            var salt = objenc.GenerateRandomCryptographicKey(128);
                            HashWithSaltResult ob1 = objenc.EncodePassword(requestuser.newpassword, salt);
                            requestuser.password = ob1.Digest;
                            requestuser.passwordsalt = ob1.Salt;
                            requestuser.passwordkey = objenc.GenerateRandomCryptographicKey(24);
                            requestuser.passwordvector = objenc.GenerateRandomCryptographicKey(32);

                            requestuser.masteruserid = itemList[0].masteruserid;
                            requestuser.userid = itemList[0].userid;

                            using (DbCommand cmd = Database.GetStoredProcCommand("KAF_Owin_UserPasswordChange"))
                            {
                                requestuser.lastlogindate = DateTime.Now;
                                requestuser = FillParameters(requestuser, cmd, Database);

                                Database.AddInParameter(cmd, "@SessionID", DbType.String, requestuser.BaseSecurityParam.sessionid);
                                Database.AddInParameter(cmd, "@SessionToken", DbType.String, requestuser.BaseSecurityParam.transid);

                                FillSequrityParameters(requestuser.BaseSecurityParam, cmd, Database);
                                AddOutputParameter(cmd);
                                try
                                {
                                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                                    while (!result.IsCompleted)
                                    {
                                    }
                                    returnValue = Database.EndExecuteNonQuery(result);
                                    returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                }
                                catch (Exception ex)
                                {
                                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.ChangePasswordRequest"));
                                }
                                cmd.Dispose();
                            }
                            if (returnValue > 0)
                                return requestuser;
                            else
                                return null;
                        }
                        else
                            return null;
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ChangePasswordRequest"));
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ChangePasswordRequest"));
            }
        }

        async Task<long?> IKAFUserSecurityDataAccess.updateUser(owin_userEntity user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                if (user != null)
                {
                    const string SP = "owin_user_Upd_Ext";

                    using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                    {
                        user = FillParameters(user, cmd, Database);

                        FillSequrityParameters(user.BaseSecurityParam, cmd, Database);
                        AddOutputParameter(cmd);
                        try
                        {
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnValue = Database.EndExecuteNonQuery(result);
                            returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        }
                        catch (Exception ex)
                        {
                            throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.updateUser"));
                        }
                        cmd.Dispose();
                    }
                }
                if (returnValue > 0)
                    transaction.Commit();
                else
                    throw new ArgumentException("Error Code." + returnValue.ToString());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.updateUser"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnValue;
        }


        async Task<IList<MenuEntity>> IKAFUserSecurityDataAccess.GetLoadMenuByUserID(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            IList<MenuEntity> itemList = new List<MenuEntity>();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand("GetLoadMenuByUserID"))
                {
                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, objEntity.userid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new MenuEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }
                if (itemList != null && itemList.Count > 0)
                {
                    return itemList;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetLoadMenuByUserID"));
            }
        }

        public async Task<owin_userEntity> GetUserAccountByMasterUserId(Database db,
         DbTransaction transaction, owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_owin_user_by_MasterUserId";
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    db.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_user.masteruserid);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();

                    IAsyncResult result = db.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = db.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
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

        public async Task<owin_userEntity> GetUserAccountByUserName(Database db,
       DbTransaction transaction, owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_owin_user_by_UserName";
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    db.AddInParameter(cmd, "@UserName", DbType.Int64, owin_user.username);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();

                    IAsyncResult result = db.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = db.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
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


        public async Task<long> UpdateUserAccountMobile_EmailByUserId(Database db,
             DbTransaction transaction, owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnValue = -99;

            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand("KAF_owin_user_Upd_ByUserId"))
                {
                    FillParameters(owin_user, cmd, db);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, db);
                    AddOutputParameter(cmd);
                    try
                    {
                        IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {

                        }
                        returnValue = db.EndExecuteNonQuery(result);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.updateUser"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetSingleowin_user"));
            }

            return returnValue;
        }


        public async Task<long?> CreateApplicationUser(Database db,
        DbTransaction transaction, owin_userEntity user, CancellationToken cancellationToken)
        {
            long returnValue = -99;

            try
            {
                if (user != null)
                {
                    const string SP = "owin_user_Ins_Ext";
                    EncryptionHelper objenc = new EncryptionHelper();
                    var salt = objenc.GenerateRandomCryptographicKey(128);
                    HashWithSaltResult ob1 = objenc.EncodePassword(user.password, salt);
                    user.password = ob1.Digest;
                    user.passwordsalt = ob1.Salt;
                    user.passwordkey = objenc.GenerateRandomCryptographicKey(24);
                    user.passwordvector = objenc.GenerateRandomCryptographicKey(32);


                    if (user.applicationid is null)
                    {
                        user.applicationid = Guid.Parse("C4077E81-CD92-42E9-8811-B93A6578A4C1");
                    }

                    using (DbCommand cmd = db.GetStoredProcCommand(SP))
                    {
                        user = FillParameters(user, cmd, db);
                        FillSequrityParameters(user.BaseSecurityParam, cmd, db);

                        if (user.roleid != null && user.roleid > 0)
                            db.AddInParameter(cmd, "@RoleID", DbType.Int64, user.roleid);
                        AddOutputParameter(cmd);
                        try
                        {
                            IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {

                            }
                            returnValue = db.EndExecuteNonQuery(result);
                            returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        }
                        catch (Exception ex)
                        {
                            throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.updateUser"));
                        }
                        cmd.Dispose();
                    }
                }
                if (returnValue > 0)
                {
                }
                else
                    throw new ArgumentException("Error Code." + returnValue.ToString());
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.updateUser"));
            }
            finally
            {

            }
            return returnValue;
        }

        async Task<long?> IKAFUserSecurityDataAccess.createuser(owin_userEntity user, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            Guid RETURN_KEY_USERID = new Guid();
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                if (user != null)
                {
                    const string SP = "owin_user_Ins_Ext";
                    EncryptionHelper objenc = new EncryptionHelper();
                    var salt = objenc.GenerateRandomCryptographicKey(128);
                    HashWithSaltResult ob1 = objenc.EncodePassword(user.password, salt);
                    user.password = ob1.Digest;
                    user.passwordsalt = ob1.Salt;
                    user.passwordkey = objenc.GenerateRandomCryptographicKey(24);
                    user.passwordvector = objenc.GenerateRandomCryptographicKey(32);


                    if (user.applicationid is null)
                    {
                        user.applicationid = Guid.Parse("C4077E81-CD92-42E9-8811-B93A6578A4C1");
                    }

                    using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                    {
                        user = FillParameters(user, cmd, Database);
                        FillSequrityParameters(user.BaseSecurityParam, cmd, Database);
                        if (user.roleid != null && user.roleid > 0)
                            Database.AddInParameter(cmd, "@RoleID", DbType.Int64, user.roleid);

                        Database.AddOutParameter(cmd, "@RETURN_KEY_USERID", DbType.Guid, 128);

                        try
                        {
                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {

                            }
                            var returnCode = Database.EndExecuteNonQuery(result);
                            RETURN_KEY_USERID = (Guid)(cmd.Parameters["@RETURN_KEY_USERID"].Value);
                        }
                        catch (Exception ex)
                        {
                            throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.updateUser"));
                        }
                        cmd.Dispose();
                    }
                }
                if (RETURN_KEY_USERID != null)
                {
                    transaction.Commit();
                }
                else
                    throw new ArgumentException("Error Code." + returnValue.ToString());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.updateUser"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnValue;
        }

       
        async Task<IList<Owin_ProcessGetFormActionistEntity_Ext>> IKAFUserSecurityDataAccess.GetMenuWiseFormActionList(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            IList<Owin_ProcessGetFormActionistEntity_Ext> itemList = new List<Owin_ProcessGetFormActionistEntity_Ext>();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_GetMenuWiseFormActionList"))
                {
                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, objEntity.userid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new Owin_ProcessGetFormActionistEntity_Ext(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }
                if (itemList != null && itemList.Count > 0)
                {
                    return itemList;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetLoadMenuByUserID"));
            }
        }


        async Task<long> IKAFUserSecurityDataAccess.ReviewOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_user_UpdReview";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_user, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.ReviewOwin_User"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<long> IKAFUserSecurityDataAccess.LockOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_user_UpdStatusLock";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_user, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.LockOwin_User"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<long> IKAFUserSecurityDataAccess.PasswordResetOwin_User(owin_userEntity requestuser, CancellationToken cancellationToken)
        {
            long returnValue = -99;
            owin_userEntity returnObject = new owin_userEntity();
            IList<owin_userEntity> itemList = new List<owin_userEntity>();
            try
            {
                owin_userEntity getUser = new owin_userEntity();
                getUser.username = requestuser.emailaddress;
                requestuser.username = requestuser.emailaddress;
                using (DbCommand cmd = Database.GetStoredProcCommand("owin_user_by_UserName"))
                {
                    //getUser = FillParameters(getUser, cmd, Database);
                    //FillSequrityParameters(requestuser.BaseSecurityParam, cmd, Database);
                    Database.AddInParameter(cmd, "@UserName", DbType.String, getUser.username);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                }
                if (itemList != null && itemList.Count > 0)
                {
                    try
                    {
                        EncryptionHelper objenc = new EncryptionHelper();
                        string usersalt = itemList[0].passwordsalt;
                        //HashWithSaltResult ob2 = objenc.EncodePassword(requestuser.password, usersalt);
                        //if (itemList[0].password.Equals(ob2.Digest) && requestuser.username == itemList[0].username)
                        //{

                        var salt = objenc.GenerateRandomCryptographicKey(128);
                        HashWithSaltResult ob1 = objenc.EncodePassword(requestuser.newpassword, salt);
                        requestuser.password = ob1.Digest;
                        requestuser.passwordsalt = ob1.Salt;
                        requestuser.passwordkey = objenc.GenerateRandomCryptographicKey(24);
                        requestuser.passwordvector = objenc.GenerateRandomCryptographicKey(32);

                        requestuser.masteruserid = itemList[0].masteruserid;
                        requestuser.userid = itemList[0].userid;

                        using (DbCommand cmd = Database.GetStoredProcCommand("KAF_Owin_UserPasswordChange"))
                        {
                            requestuser.lastlogindate = DateTime.Now;
                            requestuser = FillParameters(requestuser, cmd, Database);

                            Database.AddInParameter(cmd, "@SessionID", DbType.String, requestuser.BaseSecurityParam.sessionid);
                            Database.AddInParameter(cmd, "@SessionToken", DbType.String, requestuser.BaseSecurityParam.transid);

                            FillSequrityParameters(requestuser.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            try
                            {
                                IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                                while (!result.IsCompleted)
                                {
                                }
                                returnValue = Database.EndExecuteNonQuery(result);
                                returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                            }
                            catch (Exception ex)
                            {
                                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.PasswordResetOwin_User"));
                            }
                            cmd.Dispose();
                        }
                        if (returnValue > 0)
                            return returnValue;
                        else
                            return returnValue;
                        //}
                        //else
                        //    return returnValue;
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ChangePasswordRequest"));
                    }
                }
                else
                    return returnValue;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ChangePasswordRequest"));
            }
        }

        async Task<long> IKAFUserSecurityDataAccess.EmailResetOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_user_UpdEmail";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_user, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.EmailResetOwin_User"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        async Task<owin_userEntity> IKAFUserSecurityDataAccess.GetSingleExt(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "owin_user_GS_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_user, cmd, Database);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader, "owin_user_GS_Ext"));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
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
        async Task<owin_userEntity> IKAFUserSecurityDataAccess.GetSingleExtByPKeyEX(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "owin_user_GS_Ext_ByPKeyEX";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_user, cmd, Database);

                    IList<owin_userEntity> itemList = new List<owin_userEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader, "owin_user_GS_Ext"));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetSingleExtByPKeyEX"));
            }
        }
    }
}
