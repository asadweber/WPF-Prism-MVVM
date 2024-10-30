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
    /// Owin_UserRoleController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_UserRoleController : ControllerBase
    {
        private readonly IOwin_UserRoleUseCase _owin_UserRoleUseCase;
        private readonly Owin_UserRolePresenter _owin_UserRolePresenter;
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
        public Owin_UserRoleController(
            IOwin_UserRoleUseCase owin_UserRoleUseCase,
            Owin_UserRolePresenter owin_UserRolePresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_UserRoleUseCase = owin_UserRoleUseCase;
            _owin_UserRolePresenter = owin_UserRolePresenter;
        }

        /// <summary>
        /// GetAllOwin_UserRole
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_UserRole()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.GetAll(new Owin_UserRoleRequest(new owin_userroleEntity()), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_UserRole
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_UserRole([FromBody] owin_userroleEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.GetAllPaged(new Owin_UserRoleRequest(request), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_UserRole
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_UserRole([FromBody] owin_userroleEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.GetListView(new Owin_UserRoleRequest(request), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_UserRole
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_UserRole([FromBody] owin_userroleEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.GetSingle(new Owin_UserRoleRequest(request), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_UserRole
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_UserRole([FromBody] owin_userroleEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.Save(new Owin_UserRoleRequest(request), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_UserRole
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_UserRole([FromBody] owin_userroleEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.Update(new Owin_UserRoleRequest(request), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_UserRole
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_UserRole")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_UserRole([FromBody] owin_userroleEntity request)
        {
            /*				 ModelState.Remove("userroleid");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("roleid");
				 ModelState.Remove("isenable");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_UserRoleUseCase.Delete(new Owin_UserRoleRequest(request), _owin_UserRolePresenter);
            return _owin_UserRolePresenter.ContentResult;
        }
    }
}
