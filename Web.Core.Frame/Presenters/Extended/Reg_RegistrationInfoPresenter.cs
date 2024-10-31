using System.Net;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Presenters.Registration
{
    /// <summary>
    /// Reg_RegistrationInfoPresenter
    /// </summary>
    public sealed partial class Reg_RegistrationInfoPresenter : IOutputPort<Reg_RegistrationInfoResponse>, ICRUDRequestHandler<Reg_RegistrationInfoResponse>, IDDLRequestHandler<Reg_RegistrationInfoResponse>, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse>

    {
        /// <summary>
        /// GetListViewExt
        /// </summary>
        /// <param name="response"></param>
        public void GetListViewExt(Reg_RegistrationInfoResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response._ajaxresponse) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._reg_RegistrationInfoList as object : response.Errors;
        }

    }
}
