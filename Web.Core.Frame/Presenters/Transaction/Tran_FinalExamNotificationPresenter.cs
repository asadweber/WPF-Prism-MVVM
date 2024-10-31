using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Serialization;

namespace Web.Core.Frame.Presenters
{
    /// <summary>
    /// Tran_FinalExamNotificationPresenter
    /// </summary>
    public sealed partial class Tran_FinalExamNotificationPresenter : IOutputPort<Tran_FinalExamNotificationResponse>, ICRUDRequestHandler<Tran_FinalExamNotificationResponse>
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
        public Tran_FinalExamNotificationPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(Tran_FinalExamNotificationResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <param name="response"></param>
        public void GetAll(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(response._tran_FinalExamNotificationList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_FinalExamNotificationList as object : response.Errors;
        }
        /// <summary>
        /// GetAllPaged
        /// </summary>
        /// <param name="response"></param>
        public void GetAllPaged(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(response._tran_FinalExamNotificationList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_FinalExamNotificationList as object : response.Errors;
            //Result = response.Success ? response._ajaxresponse as object : response.Errors;

        }

        /// <summary>
        /// GetListView
        /// </summary>
        /// <param name="response"></param>
        public void GetListView(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response._ajaxresponse) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }



        /// <summary>
        /// GetSingle
        /// </summary>
        /// <param name="response"></param>
        public void GetSingle(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(response._tran_FinalExamNotification, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_FinalExamNotification as object : response.Errors;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="response"></param>
        public void Save(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="response"></param>
        public void Update(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="response"></param>
        public void Delete(Tran_FinalExamNotificationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_FinalExamNotificationResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }




    }
}
