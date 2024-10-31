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
    /// Owin_UserController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserController : ControllerBase
    {
        private readonly IOwin_UserUseCase _owin_UserUseCase;
        private readonly Owin_UserPresenter _owin_UserPresenter;
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
        public Owin_UserController(
            IOwin_UserUseCase owin_UserUseCase,
            Owin_UserPresenter owin_UserPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserUseCase = owin_UserUseCase;
            _owin_UserPresenter = owin_UserPresenter;
        }

        /// <summary>
        /// GetAllOwin_User
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_User()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.GetAll(new Owin_UserRequest(new owin_userEntity()), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_User
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_User([FromBody] owin_userEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.GetAllPaged(new Owin_UserRequest(request), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_User
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_User([FromBody] owin_userEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.GetListView(new Owin_UserRequest(request), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_User
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_User([FromBody] owin_userEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.GetSingle(new Owin_UserRequest(request), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_User([FromBody] owin_userEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.Save(new Owin_UserRequest(request), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_User([FromBody] owin_userEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.Update(new Owin_UserRequest(request), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_User")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_User([FromBody] owin_userEntity request)
        {
            /*				 ModelState.Remove("applicationid");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("username");
				 ModelState.Remove("emailaddress");
				 ModelState.Remove("loweredusername");
				 ModelState.Remove("mobilenumber");
				 ModelState.Remove("userprofilephoto");
				 ModelState.Remove("isanonymous");
				 ModelState.Remove("ischildenable");
				 ModelState.Remove("masprivatekey");
				 ModelState.Remove("maspublickey");
				 ModelState.Remove("password");
				 ModelState.Remove("passwordsalt");
				 ModelState.Remove("passwordkey");
				 ModelState.Remove("passwordvector");
				 ModelState.Remove("mobilepin");
				 ModelState.Remove("passwordquestion");
				 ModelState.Remove("passwordanswer");
				 ModelState.Remove("approved");
				 ModelState.Remove("locked");
				 ModelState.Remove("lastlogindate");
				 ModelState.Remove("lastpasschangeddate");
				 ModelState.Remove("lastlockoutdate");
				 ModelState.Remove("failedpasswordattemptcount");
				 ModelState.Remove("comment");
				 ModelState.Remove("lastactivitydate");
				 ModelState.Remove("isapproved");
				 ModelState.Remove("approvedby");
				 ModelState.Remove("approvedbyusername");
				 ModelState.Remove("approveddate");
				 ModelState.Remove("isemailconfirmed");
				 ModelState.Remove("emailconfirmationbyuserdate");
				 ModelState.Remove("twofactorenable");
				 ModelState.Remove("ismobilenumberconfirmed");
				 ModelState.Remove("mobilenumberconfirmedbyuserdate");
				 ModelState.Remove("securitystamp");
				 ModelState.Remove("concurrencystamp");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserUseCase.Delete(new Owin_UserRequest(request), _owin_UserPresenter);
            return _owin_UserPresenter.ContentResult;
        }
    }
}
