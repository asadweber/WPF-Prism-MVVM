using System.Net;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;

namespace  Web.Core.Frame.Presenters
{
    /// <summary>
    /// Gen_CertificatePresenter
    /// </summary>
    public sealed partial class Gen_CertificatePresenter : IOutputPort<Gen_CertificateResponse>, ICRUDRequestHandler<Gen_CertificateResponse>, IDDLRequestHandler<Gen_CertificateResponse>

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
        public Gen_CertificatePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(Gen_CertificateResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <param name="response"></param>
        public void GetAll(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._gen_CertificateList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._gen_CertificateList as object : response.Errors;
        }
        /// <summary>
        /// GetAllPaged
        /// </summary>
        /// <param name="response"></param>
        public void GetAllPaged(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._gen_CertificateList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._gen_CertificateList as object : response.Errors;
            //Result = response.Success ? response._ajaxresponse as object : response.Errors;

        }

        /// <summary>
        /// GetListView
        /// </summary>
        /// <param name="response"></param>
        public void GetListView(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response._ajaxresponse) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._ajaxresponse as object : response.Errors;
        }



        /// <summary>
        /// GetSingle
        /// </summary>
        /// <param name="response"></param>
        public void GetSingle(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._gen_Certificate, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._gen_Certificate as object : response.Errors;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="response"></param>
        public void Save(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="response"></param>
        public void Update(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="response"></param>
        public void Delete(Gen_CertificateResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(true, response.Message)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }
        
        
        /// <summary>
		/// GetDataForDropDown
		/// </summary>
		/// <param name="response"></param>
		public void GetDropDown(Gen_CertificateResponse response)
		{
			ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors)); 
			ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_CertificateResponse(response._gen_CertificateList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
			Result = response.Success ? response._ajaxresponse as object : response.Errors;
		}

        
    }
}
