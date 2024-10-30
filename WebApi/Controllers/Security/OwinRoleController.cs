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
    /// Owin_RoleController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Owin_RoleController : ControllerBase
    {
        private readonly IOwin_RoleUseCase _owin_RoleUseCase;
        private readonly Owin_RolePresenter _owin_RolePresenter;
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
        public Owin_RoleController(
            IOwin_RoleUseCase owin_RoleUseCase,
            Owin_RolePresenter owin_RolePresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _owin_RoleUseCase = owin_RoleUseCase;
            _owin_RolePresenter = owin_RolePresenter;
        }

        /// <summary>
        /// GetAllOwin_Role
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllOwin_Role()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.GetAll(new Owin_RoleRequest(new owin_roleEntity()), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedOwin_Role
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedOwin_Role([FromBody] owin_roleEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.GetAllPaged(new Owin_RoleRequest(request), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewOwin_Role
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewOwin_Role([FromBody] owin_roleEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.GetListView(new Owin_RoleRequest(request), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleOwin_Role
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleOwin_Role([FromBody] owin_roleEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.GetSingle(new Owin_RoleRequest(request), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }

        /// <summary>
        /// AddOwin_Role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddOwin_Role([FromBody] owin_roleEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.Save(new Owin_RoleRequest(request), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }

        /// <summary>
        /// UpdateOwin_Role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditOwin_Role([FromBody] owin_roleEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.Update(new Owin_RoleRequest(request), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }

        /// <summary>
        /// DeleteOwin_Role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteOwin_Role")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteOwin_Role([FromBody] owin_roleEntity request)
        {
            /*				 ModelState.Remove("roleid");
				 ModelState.Remove("rolename");
				 ModelState.Remove("description");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _owin_RoleUseCase.Delete(new Owin_RoleRequest(request), _owin_RolePresenter);
            return _owin_RolePresenter.ContentResult;
        }
    }
}
