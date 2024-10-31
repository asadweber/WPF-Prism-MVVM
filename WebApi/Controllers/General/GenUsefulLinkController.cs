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
    /// Gen_UsefulLinkController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_UsefulLinkController : ControllerBase
    {
        private readonly IGen_UsefulLinkUseCase _gen_UsefulLinkUseCase;
        private readonly Gen_UsefulLinkPresenter _gen_UsefulLinkPresenter;
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
        public Gen_UsefulLinkController(
            IGen_UsefulLinkUseCase gen_UsefulLinkUseCase,
            Gen_UsefulLinkPresenter gen_UsefulLinkPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_UsefulLinkUseCase = gen_UsefulLinkUseCase;
            _gen_UsefulLinkPresenter = gen_UsefulLinkPresenter;
        }

        /// <summary>
        /// GetAllGen_UsefulLink
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_UsefulLink()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.GetAll(new Gen_UsefulLinkRequest(new gen_usefullinkEntity()), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_UsefulLink
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_UsefulLink([FromBody] gen_usefullinkEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.GetAllPaged(new Gen_UsefulLinkRequest(request), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_UsefulLink
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_UsefulLink([FromBody] gen_usefullinkEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.GetListView(new Gen_UsefulLinkRequest(request), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_UsefulLink
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_UsefulLink([FromBody] gen_usefullinkEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.GetSingle(new Gen_UsefulLinkRequest(request), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_UsefulLink
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_UsefulLink([FromBody] gen_usefullinkEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.Save(new Gen_UsefulLinkRequest(request), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_UsefulLink
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_UsefulLink([FromBody] gen_usefullinkEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.Update(new Gen_UsefulLinkRequest(request), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_UsefulLink
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_UsefulLink")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_UsefulLink([FromBody] gen_usefullinkEntity request)
        {
            /*				 ModelState.Remove("usefullinkid");
				 ModelState.Remove("usefullinkcategoryid");
				 ModelState.Remove("usefullink");
				 ModelState.Remove("usefullinkar");
				 ModelState.Remove("servicelogopath");
				 ModelState.Remove("usefullinkurl");
				 ModelState.Remove("openinnewtab");
				 ModelState.Remove("usefullinkdescription");
				 ModelState.Remove("usefullinkdescriptionar");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkUseCase.Delete(new Gen_UsefulLinkRequest(request), _gen_UsefulLinkPresenter);
            return _gen_UsefulLinkPresenter.ContentResult;
        }
    }
}
