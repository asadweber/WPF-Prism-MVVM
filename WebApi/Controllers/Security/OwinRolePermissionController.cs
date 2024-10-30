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
    /// Owin_RolePermissionController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_RolePermissionController : ControllerBase
    {
        private readonly IOwin_RolePermissionUseCase _owin_RolePermissionUseCase;
        private readonly Owin_RolePermissionPresenter _owin_RolePermissionPresenter;
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
        public Owin_RolePermissionController(
            IOwin_RolePermissionUseCase owin_RolePermissionUseCase,
            Owin_RolePermissionPresenter owin_RolePermissionPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_RolePermissionUseCase = owin_RolePermissionUseCase;
            _owin_RolePermissionPresenter = owin_RolePermissionPresenter;
        }

        /// <summary>
        /// GetAllOwin_RolePermission
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_RolePermission()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.GetAll(new Owin_RolePermissionRequest(new owin_rolepermissionEntity()), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_RolePermission
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_RolePermission([FromBody] owin_rolepermissionEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.GetAllPaged(new Owin_RolePermissionRequest(request), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_RolePermission
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_RolePermission([FromBody] owin_rolepermissionEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.GetListView(new Owin_RolePermissionRequest(request), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_RolePermission
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_RolePermission([FromBody] owin_rolepermissionEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.GetSingle(new Owin_RolePermissionRequest(request), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_RolePermission
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_RolePermission([FromBody] owin_rolepermissionEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.Save(new Owin_RolePermissionRequest(request), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_RolePermission
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_RolePermission([FromBody] owin_rolepermissionEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.Update(new Owin_RolePermissionRequest(request), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_RolePermission
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_RolePermission")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_RolePermission([FromBody] owin_rolepermissionEntity request)
        {
            /*				 ModelState.Remove("rolepremissionid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("formactionid");
				 ModelState.Remove("medicalresult");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RolePermissionUseCase.Delete(new Owin_RolePermissionRequest(request), _owin_RolePermissionPresenter);
            return _owin_RolePermissionPresenter.ContentResult;
        }
    }
}
