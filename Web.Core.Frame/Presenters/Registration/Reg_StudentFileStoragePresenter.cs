using System.Net;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Presenters.Registration
{
    /// <summary>
    /// Reg_StudentFileStoragePresenter
    /// </summary>
    public sealed partial class Reg_StudentFileStoragePresenter : IOutputPort<Reg_StudentFileStorageResponse>, ICRUDRequestHandler<Reg_StudentFileStorageResponse>
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
        public Reg_StudentFileStoragePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(Reg_StudentFileStorageResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <param name="response"></param>
        public void GetAll(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(response._reg_StudentFileStorageList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._reg_StudentFileStorageList as object : response.Errors;
        }
        /// <summary>
        /// GetAllPaged
        /// </summary>
        /// <param name="response"></param>
        public void GetAllPaged(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(response._reg_StudentFileStorageList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._reg_StudentFileStorageList as object : response.Errors;
            //Result = response.Success ? response._ajaxresponse as object : response.Errors;

        }

        /// <summary>
        /// GetListView
        /// </summary>
        /// <param name="response"></param>
        public void GetListView(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response._ajaxresponse) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }



        /// <summary>
        /// GetSingle
        /// </summary>
        /// <param name="response"></param>
        public void GetSingle(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(response._reg_StudentFileStorage, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._reg_StudentFileStorage as object : response.Errors;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="response"></param>
        public void Save(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="response"></param>
        public void Update(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="response"></param>
        public void Delete(Reg_StudentFileStorageResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Reg_StudentFileStorageResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }




    }
}
