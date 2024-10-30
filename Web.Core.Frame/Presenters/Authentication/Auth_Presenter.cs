using System.Net;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;

namespace Web.Core.Frame.Presenters
{
    /// <summary>
    /// Auth_Presenter
    /// </summary>
    public sealed class Auth_Presenter : IOutputPort<Auth_Response>, IOutputPort_Auth<Auth_Response>
    {
        /// <summary>
        /// ContentResult
        /// </summary>
        public JsonContentResult ContentResult { get; }

        /// <summary>
        /// Auth_Presenter
        /// </summary>
        public Auth_Presenter()
        {
            ContentResult = new JsonContentResult();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>

        public void Handle(Auth_Response response)
        {
            //throw new System.NotImplementedException();

            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Auth_Response(response._owin_userEntity, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
        }
        public void Login(Auth_Response response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Auth_Response(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
        }
        public void ForgetPassword(Auth_Response response)
        {
            //throw new System.NotImplementedException();

            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Auth_Response(response._owin_userEntity, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
        }

        public void ForgetPasswordAjax(Auth_Response response)
        {
            //throw new System.NotImplementedException();

            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Auth_Response(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
        }
        public void PasswordResetAuthTokenValidatedAjax(Auth_Response response)
        {
            //throw new System.NotImplementedException();

            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Auth_Response(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
        }

        public void Error(Auth_Response response)
        {
            //throw new System.NotImplementedException();

            ContentResult.StatusCode = int.Parse(response._ajaxresponse.responsecode);
            ContentResult.Content = JsonSerializer.SerializeObject(new Auth_Response(response._ajaxresponse, response.Success));
        }

        //
    }
}
