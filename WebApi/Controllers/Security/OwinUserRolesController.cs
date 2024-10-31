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
    /// Owin_UserRolesController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserRolesController : ControllerBase
    {
        private readonly IOwin_UserRolesUseCase _owin_UserRolesUseCase;
        private readonly Owin_UserRolesPresenter _owin_UserRolesPresenter;
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
        public Owin_UserRolesController(
            IOwin_UserRolesUseCase owin_UserRolesUseCase,
            Owin_UserRolesPresenter owin_UserRolesPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserRolesUseCase = owin_UserRolesUseCase;
            _owin_UserRolesPresenter = owin_UserRolesPresenter;
        }
        /// <summary>
        /// GetAllOwin_UserRoles
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserRoles()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.GetAll(new Owin_UserRolesRequest(new owin_userrolesEntity()), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserRoles
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserRoles([FromBody] owin_userrolesEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.GetAllPaged(new Owin_UserRolesRequest(request), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserRoles
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserRoles([FromBody] owin_userrolesEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.GetListView(new Owin_UserRolesRequest(request), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserRoles
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserRoles([FromBody] owin_userrolesEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.GetSingle(new Owin_UserRolesRequest(request), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserRoles
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserRoles([FromBody] owin_userrolesEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.Save(new Owin_UserRolesRequest(request), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserRoles
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserRoles([FromBody] owin_userrolesEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.Update(new Owin_UserRolesRequest(request), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserRoles
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserRoles")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserRoles([FromBody] owin_userrolesEntity request)
        {
            /*				 ModelState.Remove("userid");
				 ModelState.Remove("roleid");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRolesUseCase.Delete(new Owin_UserRolesRequest(request), _owin_UserRolesPresenter);
            return _owin_UserRolesPresenter.ContentResult;
        }
    }
}
