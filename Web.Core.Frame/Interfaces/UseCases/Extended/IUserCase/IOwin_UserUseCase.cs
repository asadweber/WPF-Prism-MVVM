using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserUseCase
    {
        Task<bool> ReviewOwin_User(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort);
        Task<bool> LockOwin_User(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort);
        Task<bool> PasswordResetOwin_User(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
        Task<bool> EmailResetOwin_User(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort);
        Task<bool> GetSingleExt(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort);
    }
}
