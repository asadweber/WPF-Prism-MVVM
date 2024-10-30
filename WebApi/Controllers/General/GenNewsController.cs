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
    /// Gen_NewsController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_NewsController : ControllerBase
    {
        private readonly IGen_NewsUseCase _gen_NewsUseCase;
        private readonly Gen_NewsPresenter _gen_NewsPresenter;
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
        public Gen_NewsController(
            IGen_NewsUseCase gen_NewsUseCase,
            Gen_NewsPresenter gen_NewsPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_NewsUseCase = gen_NewsUseCase;
            _gen_NewsPresenter = gen_NewsPresenter;
        }

        /// <summary>
        /// GetAllGen_News
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_News()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.GetAll(new Gen_NewsRequest(new gen_newsEntity()), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_News
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_News([FromBody] gen_newsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.GetAllPaged(new Gen_NewsRequest(request), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_News
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_News([FromBody] gen_newsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.GetListView(new Gen_NewsRequest(request), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_News
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_News([FromBody] gen_newsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.GetSingle(new Gen_NewsRequest(request), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_News
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_News([FromBody] gen_newsEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.Save(new Gen_NewsRequest(request), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_News
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_News([FromBody] gen_newsEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.Update(new Gen_NewsRequest(request), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_News
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_News")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_News([FromBody] gen_newsEntity request)
        {
            /*				 ModelState.Remove("newsid");
				 ModelState.Remove("newscategoryid");
				 ModelState.Remove("newsheadlinear");
				 ModelState.Remove("newsheadline");
				 ModelState.Remove("newsdetailar");
				 ModelState.Remove("newsdetail");
				 ModelState.Remove("showinticker");
				 ModelState.Remove("showinscroller");
				 ModelState.Remove("showasmodal");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsUseCase.Delete(new Gen_NewsRequest(request), _gen_NewsPresenter);
            return _gen_NewsPresenter.ContentResult;
        }
    }
}
