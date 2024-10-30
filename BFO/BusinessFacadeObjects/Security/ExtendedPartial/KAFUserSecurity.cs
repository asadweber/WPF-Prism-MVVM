

using AppConfig.ConfigDAAC;
using AppConfig.HelperClasses;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security.ExtendedPartial;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security.ExtendedPartial
{
    public sealed class KAFUserSecurity : BaseFacade, IKAFUserSecurity
    {

        #region Instance Variables
        private string ClassName = "KAFUserSecurity";
        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public KAFUserSecurity()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~KAFUserSecurity()
        {
            Dispose(false);
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion

        async Task<owin_userEntity> IKAFUserSecurity.GetUserByParams(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserByParams(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetUserByParams"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<owin_userEntity> IKAFUserSecurity.UserSignInAsync(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().UserSignInAsync(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UserSignInAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<long> IKAFUserSecurity.UserSignInLogUpdateAsync(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().UserSignInLogUpdateAsync(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UserSignInLogUpdateAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<long> IKAFUserSecurity.UserResetPasswordAsync(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().UserResetPasswordAsync(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UserResetPasswordAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<long> IKAFUserSecurity.UserEmailAddressConfirmed(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().UserEmailAddressConfirmed(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UserEmailAddressConfirmed"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<long> IKAFUserSecurity.UserPhoneNumberConfirmed(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().UserPhoneNumberConfirmed(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UserPhoneNumberConfirmed"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<IList<owin_userEntity>> IKAFUserSecurity.GetUsersInRoleAsync(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUsersInRoleAsync(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetUsersInRoleAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        async Task<long> IKAFUserSecurity.RemoveFromRoleAsync(owin_userEntity user, owin_roleEntity role, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().RemoveFromRoleAsync(user, role, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.RemoveFromRoleAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<long> IKAFUserSecurity.SetEmailAsync(owin_userEntity user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().SetEmailAsync(user, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.SetEmailAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<string> IKAFUserSecurity.ForgetPasswordRequest(owin_userEntity user, CancellationToken cancellationToken)
        {
            string authCode = string.Empty;
            try
            {
                owin_userEntity objGetUserbyEmail = await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserByParams(user, cancellationToken);

                if (objGetUserbyEmail != null)
                {
                    user.username = objGetUserbyEmail.username;

                    owin_userEntity objGetUser = await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserByUserName(user, cancellationToken);
                    if (objGetUser != null)
                    {
                        long i = -99;
                        owin_userpasswordresetinfoEntity obj = new owin_userpasswordresetinfoEntity();
                        SecurityCapsule objBase = new SecurityCapsule();
                        transactioncodeGen ojbTransGen = new transactioncodeGen();

                        objBase.actioname = user.BaseSecurityParam.actioname;
                        objBase.controllername = user.BaseSecurityParam.controllername;
                        objBase.createdbyusername = user.username;
                        objBase.updatedbyusername = user.username;
                        objBase.sessionid = user.BaseSecurityParam.sessionid;
                        objBase.ipaddress = user.BaseSecurityParam.ipaddress;
                        objBase.createddate = user.BaseSecurityParam.createddate;
                        objBase.updateddate = user.BaseSecurityParam.createddate;
                        objBase.transid = user.BaseSecurityParam.transid;

                        authCode = ojbTransGen.GetRandomAlphaNumericString(16);
                        obj.BaseSecurityParam = new SecurityCapsule();
                        obj.BaseSecurityParam = objBase;
                        obj.sessionid = objBase.sessionid;
                        obj.userid = objGetUser.userid;
                        obj.masteruserid = objGetUser.masteruserid;
                        obj.sessiontoken = authCode;
                        obj.username = objGetUser.username;
                        obj.isactive = true;

                        await DataAccessFactory.CreateKAFUserSecurityDataAccess().ForgetPasswordRequest(obj, cancellationToken);
                    }
                    return authCode;
                }
                else
                    throw new Exception("User Not Found");

            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.ForgetPasswordRequest"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<owin_userEntity> IKAFUserSecurity.ChangePasswordRequest(owin_userEntity user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().ChangePasswordRequest(user, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.ChangePasswordRequest"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        async Task<IList<MenuEntity>> IKAFUserSecurity.GetLoadMenuByUserID(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetLoadMenuByUserID(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetLoadMenuByUserID"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        async Task<long?> IKAFUserSecurity.createuser(owin_userEntity user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().createuser(user, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.createuser"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        async Task<IList<Owin_ProcessGetFormActionistEntity_Ext>> IKAFUserSecurity.GetMenuWiseFormActionList(owin_userEntity objEntity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetMenuWiseFormActionList(objEntity, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetLoadMenuByUserID"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        async Task<long> IKAFUserSecurity.ReviewOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().ReviewOwin_User(owin_user, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.ReviewOwin_User"));
            }
        }

        async Task<long> IKAFUserSecurity.LockOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().LockOwin_User(owin_user, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.LockOwin_User"));
            }
        }

        async Task<long> IKAFUserSecurity.PasswordResetOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().PasswordResetOwin_User(owin_user, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.PasswordResetOwin_User"));
            }
        }

        async Task<long> IKAFUserSecurity.EmailResetOwin_User(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().EmailResetOwin_User(owin_user, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.EmailResetOwin_User"));
            }
        }

        async Task<owin_userEntity> IKAFUserSecurity.GetSingleExt(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetSingleExt(owin_user, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userEntity Iowin_userFacade.GetSingleowin_user"));
            }
        }


        async Task<long> IKAFUserSecurity.UserChangePasswordAsync(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().UserChangePasswordAsync(owin_user, cancellationToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UserChangePasswordAsync"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        async Task<owin_userEntity> IKAFUserSecurity.GetSingleExtByPKeyEX(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.CreateKAFUserSecurityDataAccess().GetSingleExtByPKeyEX(owin_user, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userEntity Iowin_userFacade.GetSingleExtByPKeyEX"));
            }
        }
    }
}
