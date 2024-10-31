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
    /// Owin_UserClaimsController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserClaimsController : ControllerBase
    {
        private readonly IOwin_UserClaimsUseCase _owin_UserClaimsUseCase;
        private readonly Owin_UserClaimsPresenter _owin_UserClaimsPresenter;
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
        public Owin_UserClaimsController(
            IOwin_UserClaimsUseCase owin_UserClaimsUseCase,
            Owin_UserClaimsPresenter owin_UserClaimsPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserClaimsUseCase = owin_UserClaimsUseCase;
            _owin_UserClaimsPresenter = owin_UserClaimsPresenter;
        }

        /// <summary>
        /// GetAllOwin_UserClaims
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserClaims()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.GetAll(new Owin_UserClaimsRequest(new owin_userclaimsEntity()), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserClaims
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserClaims([FromBody] owin_userclaimsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.GetAllPaged(new Owin_UserClaimsRequest(request), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserClaims
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserClaims([FromBody] owin_userclaimsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.GetListView(new Owin_UserClaimsRequest(request), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserClaims
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserClaims([FromBody] owin_userclaimsEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.GetSingle(new Owin_UserClaimsRequest(request), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserClaims
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserClaims([FromBody] owin_userclaimsEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.Save(new Owin_UserClaimsRequest(request), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserClaims
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserClaims([FromBody] owin_userclaimsEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.Update(new Owin_UserClaimsRequest(request), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserClaims
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserClaims")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserClaims([FromBody] owin_userclaimsEntity request)
        {
            /*				 ModelState.Remove("id");
				 ModelState.Remove("claimtype");
				 ModelState.Remove("claimvalue");
				 ModelState.Remove("userid");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserClaimsUseCase.Delete(new Owin_UserClaimsRequest(request), _owin_UserClaimsPresenter);
            return _owin_UserClaimsPresenter.ContentResult;
        }
    }
}
