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
    /// Owin_UserStatusChangeHistoryController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]

    public partial class Owin_UserStatusChangeHistoryController : ControllerBase
    {
        private readonly IOwin_UserStatusChangeHistoryUseCase _owin_UserStatusChangeHistoryUseCase;
        private readonly Owin_UserStatusChangeHistoryPresenter _owin_UserStatusChangeHistoryPresenter;
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
        public Owin_UserStatusChangeHistoryController(
            IOwin_UserStatusChangeHistoryUseCase owin_UserStatusChangeHistoryUseCase,
            Owin_UserStatusChangeHistoryPresenter owin_UserStatusChangeHistoryPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserStatusChangeHistoryUseCase = owin_UserStatusChangeHistoryUseCase;
            _owin_UserStatusChangeHistoryPresenter = owin_UserStatusChangeHistoryPresenter;
        }

        /// <summary>
        /// GetAllOwin_UserStatusChangeHistory
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserStatusChangeHistory()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.GetAll(new Owin_UserStatusChangeHistoryRequest(new owin_userstatuschangehistoryEntity()), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserStatusChangeHistory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserStatusChangeHistory([FromBody] owin_userstatuschangehistoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.GetAllPaged(new Owin_UserStatusChangeHistoryRequest(request), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserStatusChangeHistory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserStatusChangeHistory([FromBody] owin_userstatuschangehistoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.GetListView(new Owin_UserStatusChangeHistoryRequest(request), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserStatusChangeHistory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserStatusChangeHistory([FromBody] owin_userstatuschangehistoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.GetSingle(new Owin_UserStatusChangeHistoryRequest(request), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserStatusChangeHistory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserStatusChangeHistory([FromBody] owin_userstatuschangehistoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.Save(new Owin_UserStatusChangeHistoryRequest(request), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserStatusChangeHistory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserStatusChangeHistory([FromBody] owin_userstatuschangehistoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.Update(new Owin_UserStatusChangeHistoryRequest(request), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserStatusChangeHistory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserStatusChangeHistory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserStatusChangeHistory([FromBody] owin_userstatuschangehistoryEntity request)
        {
            /*				 ModelState.Remove("serial");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("statuschanged");
				 ModelState.Remove("statusremark");
				 ModelState.Remove("comment");
				 ModelState.Remove("extrafld");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserStatusChangeHistoryUseCase.Delete(new Owin_UserStatusChangeHistoryRequest(request), _owin_UserStatusChangeHistoryPresenter);
            return _owin_UserStatusChangeHistoryPresenter.ContentResult;
        }
    }
}
