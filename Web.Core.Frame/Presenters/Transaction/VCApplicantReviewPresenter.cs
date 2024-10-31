using BDO.DataAccessObjects.ExtendedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;

namespace Web.Core.Frame.Presenters.Transaction
{
    public sealed partial class VCApplicantReviewPresenter : IOutputPort<VCApplicantReviewResponse>, ICRUDRequestHandler<VCApplicantReviewResponse>, IDDLRequestHandler<VCApplicantReviewResponse>, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse>
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
        public VCApplicantReviewPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Delete(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void GetAll(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void GetAllPaged(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void GetDropDown(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void GetListView(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void GetSingle(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void Handle(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void Save(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void Update(VCApplicantReviewResponse response)
        {
            throw new NotImplementedException();
        }

        public void GetApplicantDetailsForReview(VCApplicantReviewResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCApplicantReviewResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);

            Result = response.Success ? response.ApplicantReviewViewModel as object : response.Errors;
        }

        public void GetRegisteredApplicantProfileDataByBasicInfoId(VCApplicantReviewResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCApplicantReviewResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);

            Result = response.Success ? response.ApplicantReviewViewModel as object : response.Errors;
        }

        public void ValidationPolicy(VCApplicantReviewResponse response)
        {
            ContentResult.StatusCode = (int)(HttpStatusCode.OK);
            ContentResult.Content = JsonSerializer.SerializeObject(new VCApplicantReviewResponse(response._ajaxresponse, response.Success));// response.Success ? JsonSerializer.SerializeObject(new VCRegistrationResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Message as object;
        }

        public void SaveApplicantReviewData(VCApplicantReviewResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCApplicantReviewResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }

        public void SaveDocument(VCApplicantReviewResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new VCApplicantReviewResponse(response._ajaxresponse, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response.Message as object : response.Errors;
        }
    }
}
