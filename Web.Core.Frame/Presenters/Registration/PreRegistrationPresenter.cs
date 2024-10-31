using System.Net;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Presenters.Registration
{
    /// <summary>
    /// Reg_BasicInfoPresenter
    /// </summary>
    public sealed partial class PreRegistrationPresenter : IOutputPort<VCRegistrationResponse>, ICRUDRequestHandler<VCRegistrationResponse>, IDDLRequestHandler<VCRegistrationResponse>, IPreRegistrationRequestHandler<VCRegistrationResponse>

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
        public PreRegistrationPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(VCRegistrationResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }
        
        void ICRUDRequestHandler<VCRegistrationResponse>.GetAll(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        void ICRUDRequestHandler<VCRegistrationResponse>.Delete(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        void ICRUDRequestHandler<VCRegistrationResponse>.GetAllPaged(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        void ICRUDRequestHandler<VCRegistrationResponse>.GetListView(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        

        void ICRUDRequestHandler<VCRegistrationResponse>.Save(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        void ICRUDRequestHandler<VCRegistrationResponse>.Update(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        void IDDLRequestHandler<VCRegistrationResponse>.GetDropDown(VCRegistrationResponse response)
        {
            throw new System.NotImplementedException();
        }

        
        public void GetSingle(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._reg_BasicInfo, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._reg_BasicInfo as object : response.Errors;
        }

        public void ValidationPolicy(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(HttpStatusCode.OK);
            ContentResult.Content = JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success));// response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Message as object;
        }

        public void SavePreRegistration(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

		public void SaveVarification(VCRegistrationResponse response)
		{
			ContentResult.StatusCode = (int)(HttpStatusCode.OK);
			ContentResult.Content = JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success));// response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
			Result = response.Message as object;
		}


       
        public void GetSingleById(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);

            Result = response.Success ? response.RegistrationViewModel as object : response.Errors;
        }


        public void GetReportProfile(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);

            Result = response.Success ? response.ProfileReportModel as object : response.Errors;
        }

        public void GetProfileDataCheckStatus(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Reg_ApplicantDataCheckedModel as object : response.Errors;
        }

        public void SaveDocument(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        public void AccountActivation(VCRegistrationResponse response)
        {
            ContentResult.StatusCode = (int)(HttpStatusCode.OK);
            ContentResult.Content = JsonSerializer.SerializeObject(new Auth_Response(response._ajaxresponse, response.Success));// response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Message as object;
        }
    }
}
