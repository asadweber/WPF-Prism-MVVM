using System.Net;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;

namespace Web.Core.Frame.Presenters
{
    /// <summary>
    /// ConfigSMSGatewayPresenter
    /// </summary>
    public sealed partial class Owin_FormActionPresenter : IOwin_FormActionHandler<Owin_FormActionResponse>
    {
        public void GetFormActionByRole(Owin_FormActionResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Owin_FormActionResponse(response._owin_ProcessFormActionList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Owin_FormActionResponse(response._menuwiseform, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._menuwiseform as object : response.Errors;
            //strResult = response.Success ? response._owin_FormAction.ActionName : response.Errors.ToString();
        }
    }
}
