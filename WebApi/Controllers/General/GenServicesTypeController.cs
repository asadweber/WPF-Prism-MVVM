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
    /// Gen_ServicesTypeController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_ServicesTypeController : ControllerBase
    {
        private readonly IGen_ServicesTypeUseCase _gen_ServicesTypeUseCase;
        private readonly Gen_ServicesTypePresenter _gen_ServicesTypePresenter;
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
        public Gen_ServicesTypeController(
            IGen_ServicesTypeUseCase gen_ServicesTypeUseCase,
            Gen_ServicesTypePresenter gen_ServicesTypePresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_ServicesTypeUseCase = gen_ServicesTypeUseCase;
            _gen_ServicesTypePresenter = gen_ServicesTypePresenter;
        }

        /// <summary>
        /// GetAllGen_ServicesType
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_ServicesType()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.GetAll(new Gen_ServicesTypeRequest(new gen_servicestypeEntity()), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_ServicesType
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_ServicesType([FromBody] gen_servicestypeEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.GetAllPaged(new Gen_ServicesTypeRequest(request), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_ServicesType
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_ServicesType([FromBody] gen_servicestypeEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.GetListView(new Gen_ServicesTypeRequest(request), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_ServicesType
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_ServicesType([FromBody] gen_servicestypeEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.GetSingle(new Gen_ServicesTypeRequest(request), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_ServicesType
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_ServicesType([FromBody] gen_servicestypeEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.Save(new Gen_ServicesTypeRequest(request), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_ServicesType
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_ServicesType([FromBody] gen_servicestypeEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.Update(new Gen_ServicesTypeRequest(request), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_ServicesType
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_ServicesType")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_ServicesType([FromBody] gen_servicestypeEntity request)
        {
            /*				 ModelState.Remove("servicetypeid");
				 ModelState.Remove("servicetypear");
				 ModelState.Remove("descriptionar");
				 ModelState.Remove("servicetype");
				 ModelState.Remove("description");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ServicesTypeUseCase.Delete(new Gen_ServicesTypeRequest(request), _gen_ServicesTypePresenter);
            return _gen_ServicesTypePresenter.ContentResult;
        }
    }
}
