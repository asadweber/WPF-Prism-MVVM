using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;
using System.Net.Mail;
using BDO.Core.DataAccessObjects.SecurityModels;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class OwinUserListLoadFromReader : owin_userEntity
    {
        public OwinUserListLoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationId"))) _applicationid = reader.GetGuid(reader.GetOrdinal("ApplicationId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _userprofilephoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _isanonymous = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKeyEX"))) _pkeyex = reader.GetInt64(reader.GetOrdinal("PKeyEX"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePIN"))) _mobilepin = reader.GetString(reader.GetOrdinal("MobilePIN"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLockoutDate"))) _lastlockoutdate = reader.GetDateTime(reader.GetOrdinal("LastLockoutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FailedPasswordAttemptCount"))) _failedpasswordattemptcount = reader.GetInt32(reader.GetOrdinal("FailedPasswordAttemptCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastActivityDate"))) _lastactivitydate = reader.GetDateTime(reader.GetOrdinal("LastActivityDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByUserName"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedBy"))) _approvedby = reader.GetInt64(reader.GetOrdinal("ApprovedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsEmailConfirmed"))) _isemailconfirmed = reader.GetBoolean(reader.GetOrdinal("IsEmailConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailConfirmationByUserDate"))) _emailconfirmationbyuserdate = reader.GetDateTime(reader.GetOrdinal("EmailConfirmationByUserDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TwoFactorEnable"))) _twofactorenable = reader.GetBoolean(reader.GetOrdinal("TwoFactorEnable"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsMobileNumberConfirmed"))) _ismobilenumberconfirmed = reader.GetBoolean(reader.GetOrdinal("IsMobileNumberConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumberConfirmedByUserDate"))) _mobilenumberconfirmedbyuserdate = reader.GetDateTime(reader.GetOrdinal("MobileNumberConfirmedByUserDate"));


                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) rolename = reader.GetString(reader.GetOrdinal("RoleName"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}