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
    /// Owin_FormActionController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_FormActionController : ControllerBase
    {
        private readonly IOwin_FormActionUseCase _owin_FormActionUseCase;
        private readonly Owin_FormActionPresenter _owin_FormActionPresenter;
        private readonly AuthSettings _authSettings;

        /// <summary>
        /// _configuration
        /// </summary>
        public IConfiguration _configuration { get; }

        /// <summary>
        /// GenFAQCagetogyController
        /// </summary>
        /// <param name="gen_FAQCagetogyUseCase"></param>
        /// <param name="gen_FAQCagetogyPresenter"></param>
        /// <param name="authSettings"></param>
        public Owin_FormActionController(
            IOwin_FormActionUseCase owin_FormActionUseCase,
            Owin_FormActionPresenter owin_FormActionPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_FormActionUseCase = owin_FormActionUseCase;
            _owin_FormActionPresenter = owin_FormActionPresenter;
        }

        /// <summary>
        /// GetAllOwin_FormAction
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_FormAction()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.GetAll(new Owin_FormActionRequest(new owin_formactionEntity()), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_FormAction
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_FormAction([FromBody] owin_formactionEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.GetAllPaged(new Owin_FormActionRequest(request), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_FormAction
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_FormAction([FromBody] owin_formactionEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.GetListView(new Owin_FormActionRequest(request), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_FormAction
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_FormAction([FromBody] owin_formactionEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.GetSingle(new Owin_FormActionRequest(request), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_FormAction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_FormAction([FromBody] owin_formactionEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.Save(new Owin_FormActionRequest(request), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_FormAction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_FormAction([FromBody] owin_formactionEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.Update(new Owin_FormActionRequest(request), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_FormAction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_FormAction")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_FormAction([FromBody] owin_formactionEntity request)
        {
            /*				 ModelState.Remove("formactionid");
				 ModelState.Remove("parentid");
				 ModelState.Remove("actionname");
				 ModelState.Remove("displaynamear");
				 ModelState.Remove("displayname");
				 ModelState.Remove("actiontype");
				 ModelState.Remove("isview");
				 ModelState.Remove("isapi");
				 ModelState.Remove("isshowonmenu");
				 ModelState.Remove("classicon");
				 ModelState.Remove("isitem");
				 ModelState.Remove("eventname");
				 ModelState.Remove("sequence");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_FormActionUseCase.Delete(new Owin_FormActionRequest(request), _owin_FormActionPresenter);
            return _owin_FormActionPresenter.ContentResult;
        }
    }
}
