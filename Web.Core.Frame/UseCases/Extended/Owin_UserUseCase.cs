using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Owin_UserUseCase
    {
        public async Task<bool> ReviewOwin_User(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                    .ReviewOwin_User(message.Objowin_user, cancellationToken);

                outputPort.Update(new Owin_UserResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }
        public async Task<bool> LockOwin_User(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                    .LockOwin_User(message.Objowin_user, cancellationToken);

                outputPort.Update(new Owin_UserResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }
        public async Task<bool> PasswordResetOwin_User(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(message.Obj_owin_user.username);
                if (user == null)
                {
                    outputPort.Login(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_REQUEST"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_REQUEST"].Value));
                    return false;
                }
                else
                {
                    message.Obj_owin_user.emailaddress = message.Obj_owin_user.username;
                    message.Obj_owin_user.password = message.Obj_owin_user.newpassword;

                    long? i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.
                        GetFacadeCreate(_contextAccessor).PasswordResetOwin_User(message.Obj_owin_user, cancellationToken);
                    if (i != null)
                    {
                        //outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["RESET_PASSWORD_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        //    ), true, null));

                        outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["RESET_PASSWORD_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                        return true;
                    }
                    else
                    {
                        outputPort.Error(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_REQUEST"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                    ), false, _sharedLocalizer["INVALID_REQUEST"].Value));
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ForgetPassword(objResponse);
                return true;
            }
        }
        public async Task<bool> EmailResetOwin_User(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                if(!string.IsNullOrEmpty(message.Objowin_user.newemailaddress)) message.Objowin_user.emailaddress = message.Objowin_user.newemailaddress;

                i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                    .EmailResetOwin_User(message.Objowin_user, cancellationToken);

                outputPort.Update(new Owin_UserResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }
        public async Task<bool> GetSingleExt(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                owin_userEntity objSingle = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                .GetSingleExt(message.Objowin_user, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Owin_UserResponse(objSingle, true));
                }
                else
                {
                    Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }
    }
}
