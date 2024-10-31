using System.Net;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Presenters.Configuration
{
    /// <summary>
    /// Cnf_NotificationTempletPresenter
    /// </summary>
    public sealed partial class Cnf_NotificationTempletPresenter : IOutputPort<Cnf_NotificationTempletResponse>, ICRUDRequestHandler<Cnf_NotificationTempletResponse>, IDDLRequestHandler<Cnf_NotificationTempletResponse>

    {
        /// <summary>
        /// ContentResult
        /// </summary>
        public JsonContentResult ContentResult { get; }
        /// <summary>
        /// Result list of object (anynomous)
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// Gen_PriorityPresenter
        /// </summary>
        public Cnf_NotificationTempletPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(Cnf_NotificationTempletResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <param name="response"></param>
        public void GetAll(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._cnf_NotificationTempletList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._cnf_NotificationTempletList as object : response.Errors;
        }
        /// <summary>
        /// GetAllPaged
        /// </summary>
        /// <param name="response"></param>
        public void GetAllPaged(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._cnf_NotificationTempletList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._cnf_NotificationTempletList as object : response.Errors;
            //Result = response.Success ? response._ajaxresponse as object : response.Errors;

        }

        /// <summary>
        /// GetListView
        /// </summary>
        /// <param name="response"></param>
        public void GetListView(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response._ajaxresponse) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }



        /// <summary>
        /// GetSingle
        /// </summary>
        /// <param name="response"></param>
        public void GetSingle(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._cnf_NotificationTemplet, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._cnf_NotificationTemplet as object : response.Errors;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="response"></param>
        public void Save(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="response"></param>
        public void Update(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="response"></param>
        public void Delete(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }


        /// <summary>
        /// GetDataForDropDown
        /// </summary>
        /// <param name="response"></param>
        public void GetDropDown(Cnf_NotificationTempletResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Cnf_NotificationTempletResponse(response._cnf_NotificationTempletList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }


    }
}
