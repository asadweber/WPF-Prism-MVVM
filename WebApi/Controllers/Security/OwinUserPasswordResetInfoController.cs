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
    /// Owin_UserPasswordResetInfoController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserPasswordResetInfoController : ControllerBase
    {
        private readonly IOwin_UserPasswordResetInfoUseCase _owin_UserPasswordResetInfoUseCase;
        private readonly Owin_UserPasswordResetInfoPresenter _owin_UserPasswordResetInfoPresenter;
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
        public Owin_UserPasswordResetInfoController(
            IOwin_UserPasswordResetInfoUseCase owin_UserPasswordResetInfoUseCase,
            Owin_UserPasswordResetInfoPresenter owin_UserPasswordResetInfoPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserPasswordResetInfoUseCase = owin_UserPasswordResetInfoUseCase;
            _owin_UserPasswordResetInfoPresenter = owin_UserPasswordResetInfoPresenter;
        }

        /// <summary>
        /// GetAllOwin_UserPasswordResetInfo
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserPasswordResetInfo()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.GetAll(new Owin_UserPasswordResetInfoRequest(new owin_userpasswordresetinfoEntity()), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserPasswordResetInfo
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserPasswordResetInfo([FromBody] owin_userpasswordresetinfoEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.GetAllPaged(new Owin_UserPasswordResetInfoRequest(request), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserPasswordResetInfo
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserPasswordResetInfo([FromBody] owin_userpasswordresetinfoEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.GetListView(new Owin_UserPasswordResetInfoRequest(request), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserPasswordResetInfo
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserPasswordResetInfo([FromBody] owin_userpasswordresetinfoEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.GetSingle(new Owin_UserPasswordResetInfoRequest(request), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserPasswordResetInfo
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserPasswordResetInfo([FromBody] owin_userpasswordresetinfoEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.Save(new Owin_UserPasswordResetInfoRequest(request), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserPasswordResetInfo
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserPasswordResetInfo([FromBody] owin_userpasswordresetinfoEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.Update(new Owin_UserPasswordResetInfoRequest(request), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserPasswordResetInfo
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserPasswordResetInfo")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserPasswordResetInfo([FromBody] owin_userpasswordresetinfoEntity request)
        {
            /*				 ModelState.Remove("serial");
				 ModelState.Remove("sessionid");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("sessiontoken");
				 ModelState.Remove("username");
				 ModelState.Remove("isactive");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserPasswordResetInfoUseCase.Delete(new Owin_UserPasswordResetInfoRequest(request), _owin_UserPasswordResetInfoPresenter);
            return _owin_UserPasswordResetInfoPresenter.ContentResult;
        }
    }
}
