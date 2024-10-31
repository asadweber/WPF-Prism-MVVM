using System.Net;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Serialization;
using Web.Core.Frame.Helpers;

namespace  Web.Core.Frame.Presenters
{
    /// <summary>
    /// Gen_FAQCagetogyPresenter
    /// </summary>
    public sealed class HomePresenter : IOutputPort<HomeResponse>, ICRUDRequestHandler<HomeResponse>
    {
         /// <summary>
        /// ContentResult
        /// </summary>
        public JsonContentResult ContentResult { get; }
        /// <summary>
        /// Result list of object (anynomous)
        /// </summary>
        public object Result { get; set; }
        public string jsonString { get; set; }

        /// <summary>
        /// Gen_PriorityPresenter
        /// </summary>
        public HomePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="response"></param>
        public void Handle(HomeResponse response)
        {
            //ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            //ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Gen_PriorityResponse(response._gen_PriorityList.AccessToken, response.RefreshToken)) : JsonSerializer.SerializeObject(response.Errors);
        }

        public void GetAll(HomeResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : httpStatusCodeParser.SetHttpStatusCode(response.Errors));
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new HomeResponse(response._MenuEntityList, response.Success)) : JsonSerializer.SerializeObject(response.Errors);
            Result = response.Success ? response._MenuEntityList as object : response.Errors;
            jsonString = response.Success ? response._ajaxresponse.responsetext : response.Errors.Description;
        }

        public void Delete(HomeResponse response)
        {
            throw new System.NotImplementedException();
        }

        public void GetAllPaged(HomeResponse response)
        {
            throw new System.NotImplementedException();
        }

        public void GetListView(HomeResponse response)
        {
            throw new System.NotImplementedException();
        }

        public void GetSingle(HomeResponse response)
        {
            throw new System.NotImplementedException();
        }

        public void Save(HomeResponse response)
        {
            throw new System.NotImplementedException();
        }

        public void Update(HomeResponse response)
        {
            throw new System.NotImplementedException();
        }
    }
}
