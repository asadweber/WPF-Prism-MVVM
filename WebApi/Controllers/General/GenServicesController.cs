using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;
using Microsoft.AspNetCore.Authorization;
using WebApi.Extensions;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;

namespace Web.Api.Controllers
{
    /// <summary>
    /// Gen_ServicesController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_ServicesController : ControllerBase
    {
        private readonly IGen_ServicesUseCase _gen_ServicesUseCase;
        private readonly Gen_ServicesPresenter _gen_ServicesPresenter;
        private readonly AuthSettings _authSettings;

        /// <summary>
        /// _configuration
        /// </summary>
        public IConfiguration _configuration { get; }

        /// <summary>
        /// GenFAQCategoryController
        /// </summary>
        /// <param name="gen_FAQCategoryUseCase"></param>
        /// <param name="gen_FAQCategoryPresenter"></param>
        /// <param name="authSettings"></param>
        public Gen_ServicesController(
            IGen_ServicesUseCase gen_ServicesUseCase,
            Gen_ServicesPresenter gen_ServicesPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_ServicesUseCase = gen_ServicesUseCase;
            _gen_ServicesPresenter = gen_ServicesPresenter;
        }

        /// <summary>
        /// GetAllGen_Services
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_Services()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.GetAll(new Gen_ServicesRequest(new gen_servicesEntity()), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_Services
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_Services([FromBody] gen_servicesEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.GetAllPaged(new Gen_ServicesRequest(request), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_Services
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_Services([FromBody] gen_servicesEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.GetListView(new Gen_ServicesRequest(request), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_Services
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_Services([FromBody] gen_servicesEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.GetSingle(new Gen_ServicesRequest(request), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_Services
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_Services([FromBody] gen_servicesEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.Save(new Gen_ServicesRequest(request), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_Services
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_Services([FromBody] gen_servicesEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.Update(new Gen_ServicesRequest(request), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_Services
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_Services")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_Services([FromBody] gen_servicesEntity request)
        {
            /*				 ModelState.Remove("serviceid");
				 ModelState.Remove("servicetypeid");
				 ModelState.Remove("servicename");
				 ModelState.Remove("servicenamear");
				 ModelState.Remove("servicedescription");
				 ModelState.Remove("servicedescriptionar");
				 ModelState.Remove("servicelogopath");
				 ModelState.Remove("serviceurl");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesUseCase.Delete(new Gen_ServicesRequest(request), _gen_ServicesPresenter);
            return _gen_ServicesPresenter.ContentResult;
        }
    }
}
