using System.Net;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Presenters.Transaction
{
    /// <summary>
    /// Tran_NotificationBatchPresenter
    /// </summary>
    public sealed partial class Tran_NotificationBatchPresenter : IOutputPort<Tran_NotificationBatchResponse>, ICRUDRequestHandler<Tran_NotificationBatchResponse>, IDDLRequestHandler<Tran_NotificationBatchResponse>

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
        public Tran_NotificationBatchPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(Tran_NotificationBatchResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <param name="response"></param>
        public void GetAll(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._tran_NotificationBatchList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_NotificationBatchList as object : response.Errors;
        }
        /// <summary>
        /// GetAllPaged
        /// </summary>
        /// <param name="response"></param>
        public void GetAllPaged(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._tran_NotificationBatchList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_NotificationBatchList as object : response.Errors;
            //Result = response.Success ? response._ajaxresponse as object : response.Errors;

        }

        /// <summary>
        /// GetListView
        /// </summary>
        /// <param name="response"></param>
        public void GetListView(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response._ajaxresponse) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }



        /// <summary>
        /// GetSingle
        /// </summary>
        /// <param name="response"></param>
        public void GetSingle(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._tran_NotificationBatch, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_NotificationBatch as object : response.Errors;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="response"></param>
        public void Save(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._tran_NotificationBatch as object : response.Errors;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="response"></param>
        public void Update(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="response"></param>
        public void Delete(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }


        /// <summary>
        /// GetDataForDropDown
        /// </summary>
        /// <param name="response"></param>
        public void GetDropDown(Tran_NotificationBatchResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Tran_NotificationBatchResponse(response._tran_NotificationBatchList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }


    }
}
