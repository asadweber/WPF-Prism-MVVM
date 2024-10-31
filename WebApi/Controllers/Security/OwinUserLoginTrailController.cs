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
    /// Owin_UserLoginTrailController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserLoginTrailController : ControllerBase
    {
        private readonly IOwin_UserLoginTrailUseCase _owin_UserLoginTrailUseCase;
        private readonly Owin_UserLoginTrailPresenter _owin_UserLoginTrailPresenter;
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
        public Owin_UserLoginTrailController(
            IOwin_UserLoginTrailUseCase owin_UserLoginTrailUseCase,
            Owin_UserLoginTrailPresenter owin_UserLoginTrailPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserLoginTrailUseCase = owin_UserLoginTrailUseCase;
            _owin_UserLoginTrailPresenter = owin_UserLoginTrailPresenter;
        }

        /// <summary>
        /// GetAllOwin_UserLoginTrail
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserLoginTrail()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.GetAll(new Owin_UserLoginTrailRequest(new owin_userlogintrailEntity()), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserLoginTrail
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserLoginTrail([FromBody] owin_userlogintrailEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.GetAllPaged(new Owin_UserLoginTrailRequest(request), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserLoginTrail
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserLoginTrail([FromBody] owin_userlogintrailEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.GetListView(new Owin_UserLoginTrailRequest(request), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserLoginTrail
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserLoginTrail([FromBody] owin_userlogintrailEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.GetSingle(new Owin_UserLoginTrailRequest(request), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserLoginTrail
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserLoginTrail([FromBody] owin_userlogintrailEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.Save(new Owin_UserLoginTrailRequest(request), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserLoginTrail
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserLoginTrail([FromBody] owin_userlogintrailEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.Update(new Owin_UserLoginTrailRequest(request), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserLoginTrail
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserLoginTrail")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserLoginTrail([FromBody] owin_userlogintrailEntity request)
        {
            /*				 ModelState.Remove("serialno");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("loginfrom");
				 ModelState.Remove("logindate");
				 ModelState.Remove("logoutdate");
				 ModelState.Remove("machineip");
				 ModelState.Remove("loginstatus");
				 ModelState.Remove("loginstatusbit");
				 ModelState.Remove("sessionid");
				 ModelState.Remove("usertoken");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserLoginTrailUseCase.Delete(new Owin_UserLoginTrailRequest(request), _owin_UserLoginTrailPresenter);
            return _owin_UserLoginTrailPresenter.ContentResult;
        }
    }
}
