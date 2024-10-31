using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using CLL.Localization;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;


namespace Web.Core.Frame.CustomStores
{
    public class CustomUserStore :
                                IUserStore<owin_userEntity>,
                                IUserEmailStore<owin_userEntity>,
                                IUserPhoneNumberStore<owin_userEntity>,
                                IUserTwoFactorStore<owin_userEntity>,
                                IUserPasswordStore<owin_userEntity>,
                                IUserRoleStore<owin_userEntity>,
                                IUserClaimStore<owin_userEntity>,
                                IUserLockoutStore<owin_userEntity>,
                                IUserAuthenticationTokenStore<owin_userEntity>,
                                IUserAuthenticatorKeyStore<owin_userEntity>,
                                IUserTwoFactorRecoveryCodeStore<owin_userEntity>,
                                ICustomExtendedStore<owin_userEntity>
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ISecCapFillerFromJWTClaim _seccapfillerfromjwtclaim;

        public CusIdentityErrorDescriber ErrorDescriber { get; set; }

        private bool _disposed;
        public void Dispose() { }
        protected void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }
        public CustomUserStore(IHttpContextAccessor contextAccessor,
            ISecCapFillerFromJWTClaim seccapfillerfromjwtclaim)
        {
            _contextAccessor = contextAccessor;
            _seccapfillerfromjwtclaim = seccapfillerfromjwtclaim;
        }


        #region FIND FUNCTION FROM DB
        public async Task<owin_userEntity> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            var user = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetUserByParams(new owin_userEntity()
            {
                emailaddress = normalizedEmail
            }, cancellationToken);
            return user;
            //if (user != null)
            //    return user;
            //else
            //    throw new InvalidCredentialException("Oops!!!");
        }

        public async Task<owin_userEntity> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            var user = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetUserByParams(new owin_userEntity()
            {
                userid = new Guid(userId)
            }, cancellationToken);
            return user;
            //if (user != null)
            //    return user;
            //else
            //    throw new InvalidCredentialException("Oops!!!");
        }

        public async Task<owin_userEntity> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var user = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetUserByParams(new owin_userEntity()
            {
                username = normalizedUserName
            }, cancellationToken);
            return user;
        }




        #endregion

        #region USER CREATE UPDATE DELETE FUNCTIONS 
        public async Task<IdentityResult> CreateAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> UpdateAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            return IdentityResult.Success;
        }
        #endregion

        public Task AddToRoleAsync(owin_userEntity user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public async Task<IdentityResult> UpdateEmailAsync(owin_userEntity user, string email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            await SetEmailAsync(user, email, cancellationToken);
            await SetEmailConfirmedAsync(user, false, cancellationToken);
            user.emailconfirmationbyuserdate = null;

            try
            {
                long i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).SetEmailAsync(user, cancellationToken);
            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(ErrorDescriber.ConcurrencyFailure());
            }
            return IdentityResult.Success;
        }


        #region GET CURRENT USER OBJECT

        public async Task<string> GetEmailAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.emailaddress;
        }
        public async Task<bool> GetEmailConfirmedAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.isemailconfirmed.GetValueOrDefault(true);
        }
        public async Task<string> GetNormalizedEmailAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.emailaddress;
        }
        public async Task<string> GetNormalizedUserNameAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.username;
        }
        public async Task<string> GetPasswordHashAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.PasswordHash;
        }

        public async Task<string> GetPhoneNumberAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return string.IsNullOrEmpty(user.mobilenumber) == true ? "99999999" : user.mobilenumber;
        }
        public async Task<bool> GetPhoneNumberConfirmedAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.ismobilenumberconfirmed.GetValueOrDefault(true);
        }
        public async Task<IList<string>> GetRolesAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            var Owin_Role = await BFC.Core.FacadeCreatorObjects.Security.owin_roleFCC.GetFacadeCreate(_contextAccessor).GetByUsrID(user, cancellationToken);
            if (Owin_Role != null && Owin_Role.Count > 0)
            {
                List<string> strlist = new List<string>();
                foreach (owin_roleEntity role in Owin_Role)
                {
                    strlist.Add(role.rolename);
                }
                return strlist;
            }
            return await Task.FromResult<IList<string>>(new List<string>());
        }

        public async Task<bool> GetTwoFactorEnabledAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.twofactorenable.GetValueOrDefault(false);
        }
        public async Task<string> GetUserIdAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.userid.ToString();
        }
        public async Task<string> GetUserNameAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return user.username;
        }
        public Task<bool> HasPasswordAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return Task.FromResult(user.PasswordHash != null);
        }

        #endregion


        #region SET CURRENT USER OBJECT
        public async Task SetEmailAsync(owin_userEntity user, string email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.emailaddress = email;
        }
        public async Task SetEmailConfirmedAsync(owin_userEntity user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.isemailconfirmed = confirmed;
        }
        public async Task SetNormalizedEmailAsync(owin_userEntity user, string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.emailaddress = normalizedEmail;
        }
        public async Task SetUserNameAsync(owin_userEntity user, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.username = userName;
        }
        public async Task SetNormalizedUserNameAsync(owin_userEntity user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.loweredusername = normalizedName;
        }
        public async Task SetTwoFactorEnabledAsync(owin_userEntity user, bool enabled, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.TwoFactorEnabled = enabled;
        }

        public async Task SetPasswordHashAsync(owin_userEntity user, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.password = passwordHash;
            var longVal = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).UserResetPasswordAsync(user, cancellationToken);
        }

        public async Task SetPhoneNumberAsync(owin_userEntity user, string phoneNumber, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.mobilenumber = phoneNumber;
        }
        public async Task SetPhoneNumberConfirmedAsync(owin_userEntity user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.PhoneNumberConfirmed = confirmed;
        }
        #endregion


        public async Task<IList<owin_userEntity>> GetUsersInRoleAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (string.IsNullOrEmpty(normalizedRoleName))
            {
                throw new ArgumentNullException(nameof(normalizedRoleName));
            }

            var Owin_Role = await BFC.Core.FacadeCreatorObjects.Security.owin_roleFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_roleEntity() { rolename = normalizedRoleName }, cancellationToken);
            if (Owin_Role != null)
            {
                var userlist = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetUsersInRoleAsync(new owin_userEntity()
                {
                    roleid = Owin_Role.FirstOrDefault().roleid
                }, cancellationToken);

                return userlist;
            }
            return new List<owin_userEntity>();
        }

        public async Task<bool> IsInRoleAsync(owin_userEntity user, string roleName, CancellationToken cancellationToken)
        {
            var _roles = await BFC.Core.FacadeCreatorObjects.Security.owin_roleFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_roleEntity() { rolename = roleName }, cancellationToken);
            if (_roles != null && _roles.Count > 0)
            {
                var userlist = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetUsersInRoleAsync(new owin_userEntity()
                {
                    roleid = _roles.FirstOrDefault().roleid,
                    userid = user.userid
                }, cancellationToken);

                if (userlist != null && userlist.Count > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task RemoveFromRoleAsync(owin_userEntity user, string roleName, CancellationToken cancellationToken)
        {
            var _roles = await BFC.Core.FacadeCreatorObjects.Security.owin_roleFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_roleEntity() { rolename = roleName }, cancellationToken);
            if (_roles != null && _roles.Count > 0)
            {
                var userlist = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetUsersInRoleAsync(new owin_userEntity()
                {
                    roleid = _roles.FirstOrDefault().roleid,
                    userid = user.userid
                }, cancellationToken);

                if (userlist != null && userlist.Count > 0)
                {
                    long i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).RemoveFromRoleAsync(userlist.FirstOrDefault(), _roles.FirstOrDefault(), cancellationToken);
                }
            }

        }

        public async Task<IList<Claim>> GetClaimsAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            if (cancellationToken != null)
                cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
                throw new ArgumentNullException(nameof(user));

            IList<Claim> result = BFC.Core.FacadeCreatorObjects.Security.owin_userclaimsFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_userclaimsEntity()
            {
                userid = user.userid
            }, cancellationToken).Result.ToList().Select(x => new Claim(x.claimtype, x.claimvalue)).ToList();

            return result;
        }

        public Task AddClaimsAsync(owin_userEntity user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            if (cancellationToken != null)
                cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
                throw new ArgumentNullException(nameof(user));

            foreach (var claim in claims)
            {
                user.Claims.Add(new owin_userclaimsEntity { claimtype = claim.Type, claimvalue = claim.Value, userid = user.userid });
            }
            return Task.FromResult(0);
        }

        public Task ReplaceClaimAsync(owin_userEntity user, Claim claim, Claim newClaim, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveClaimsAsync(owin_userEntity user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<owin_userEntity>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }





        public async Task<DateTimeOffset?> GetLockoutEndDateAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            DateTime? utcTime1 = user.lastlockoutdate.GetValueOrDefault();
            utcTime1 = DateTime.SpecifyKind(utcTime1.GetValueOrDefault(), DateTimeKind.Utc);
            DateTimeOffset? utcTime2 = utcTime1;
            return await Task.FromResult(utcTime2);
        }

        public async Task SetLockoutEndDateAsync(owin_userEntity user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.LockoutEnd = lockoutEnd;
        }

        public Task<int> IncrementAccessFailedCountAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            int i = user.failedpasswordattemptcount.GetValueOrDefault(0);
            i++;
            user.failedpasswordattemptcount = i;
            return Task.FromResult(user.failedpasswordattemptcount.GetValueOrDefault(0));
        }

        public Task ResetAccessFailedCountAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.failedpasswordattemptcount = 0;
            return Task.CompletedTask;
        }

        public Task<int> GetAccessFailedCountAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return Task.FromResult(user.failedpasswordattemptcount.GetValueOrDefault(0));
        }

        public async Task<bool> GetLockoutEnabledAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return await Task.FromResult(user.locked.GetValueOrDefault(false));
        }

        public Task SetLockoutEnabledAsync(owin_userEntity user, bool enabled, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.locked = enabled;
            return Task.CompletedTask;
        }


        //IUserAuthenticationTokenStore

        public Task SetTokenAsync(owin_userEntity user, string loginProvider, string name, string value, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveTokenAsync(owin_userEntity user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTokenAsync(owin_userEntity user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //IUserAuthenticatorKeyStore
        public Task SetAuthenticatorKeyAsync(owin_userEntity user, string key, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAuthenticatorKeyAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        //IUserTwoFactorRecoveryCodeStore
        public Task ReplaceCodesAsync(owin_userEntity user, IEnumerable<string> recoveryCodes, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RedeemCodeAsync(owin_userEntity user, string code, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountCodesAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


      
    }
}
