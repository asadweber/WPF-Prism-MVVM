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
    /// Owin_UserPrefferencesSettingsController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserPrefferencesSettingsController : ControllerBase
    {
        private readonly IOwin_UserPrefferencesSettingsUseCase _owin_UserPrefferencesSettingsUseCase;
        private readonly Owin_UserPrefferencesSettingsPresenter _owin_UserPrefferencesSettingsPresenter;
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
        public Owin_UserPrefferencesSettingsController(
            IOwin_UserPrefferencesSettingsUseCase owin_UserPrefferencesSettingsUseCase,
            Owin_UserPrefferencesSettingsPresenter owin_UserPrefferencesSettingsPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserPrefferencesSettingsUseCase = owin_UserPrefferencesSettingsUseCase;
            _owin_UserPrefferencesSettingsPresenter = owin_UserPrefferencesSettingsPresenter;
        }

        /// <summary>
        /// GetAllOwin_UserPrefferencesSettings
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserPrefferencesSettings()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.GetAll(new Owin_UserPrefferencesSettingsRequest(new owin_userprefferencessettingsEntity()), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserPrefferencesSettings
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserPrefferencesSettings([FromBody] owin_userprefferencessettingsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.GetAllPaged(new Owin_UserPrefferencesSettingsRequest(request), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserPrefferencesSettings
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserPrefferencesSettings([FromBody] owin_userprefferencessettingsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.GetListView(new Owin_UserPrefferencesSettingsRequest(request), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserPrefferencesSettings
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserPrefferencesSettings([FromBody] owin_userprefferencessettingsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.GetSingle(new Owin_UserPrefferencesSettingsRequest(request), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserPrefferencesSettings
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserPrefferencesSettings([FromBody] owin_userprefferencessettingsEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.Save(new Owin_UserPrefferencesSettingsRequest(request), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserPrefferencesSettings
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserPrefferencesSettings([FromBody] owin_userprefferencessettingsEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.Update(new Owin_UserPrefferencesSettingsRequest(request), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserPrefferencesSettings
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserPrefferencesSettings")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserPrefferencesSettings([FromBody] owin_userprefferencessettingsEntity request)
        {
            /*				 ModelState.Remove("serialno");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("appformid");
				 ModelState.Remove("prepagesize");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPrefferencesSettingsUseCase.Delete(new Owin_UserPrefferencesSettingsRequest(request), _owin_UserPrefferencesSettingsPresenter);
            return _owin_UserPrefferencesSettingsPresenter.ContentResult;
        }
    }
}
