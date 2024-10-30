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
    /// Owin_LastWorkingPageController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]

    public partial class Owin_LastWorkingPageController : ControllerBase
    {
        private readonly IOwin_LastWorkingPageUseCase _owin_LastWorkingPageUseCase;
        private readonly Owin_LastWorkingPagePresenter _owin_LastWorkingPagePresenter;
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
        public Owin_LastWorkingPageController(
            IOwin_LastWorkingPageUseCase owin_LastWorkingPageUseCase,
            Owin_LastWorkingPagePresenter owin_LastWorkingPagePresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_LastWorkingPageUseCase = owin_LastWorkingPageUseCase;
            _owin_LastWorkingPagePresenter = owin_LastWorkingPagePresenter;
        }

        /// <summary>
        /// GetAllOwin_LastWorkingPage
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_LastWorkingPage()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.GetAll(new Owin_LastWorkingPageRequest(new owin_lastworkingpageEntity()), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_LastWorkingPage
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_LastWorkingPage([FromBody] owin_lastworkingpageEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.GetAllPaged(new Owin_LastWorkingPageRequest(request), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_LastWorkingPage
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_LastWorkingPage([FromBody] owin_lastworkingpageEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.GetListView(new Owin_LastWorkingPageRequest(request), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_LastWorkingPage
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_LastWorkingPage([FromBody] owin_lastworkingpageEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.GetSingle(new Owin_LastWorkingPageRequest(request), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_LastWorkingPage
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_LastWorkingPage([FromBody] owin_lastworkingpageEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.Save(new Owin_LastWorkingPageRequest(request), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_LastWorkingPage
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_LastWorkingPage([FromBody] owin_lastworkingpageEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.Update(new Owin_LastWorkingPageRequest(request), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_LastWorkingPage
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_LastWorkingPage")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_LastWorkingPage([FromBody] owin_lastworkingpageEntity request)
        {
            /*				 ModelState.Remove("lastpageid");
				 ModelState.Remove("appformid");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("lastentrydate");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_LastWorkingPageUseCase.Delete(new Owin_LastWorkingPageRequest(request), _owin_LastWorkingPagePresenter);
            return _owin_LastWorkingPagePresenter.ContentResult;
        }
    }
}
