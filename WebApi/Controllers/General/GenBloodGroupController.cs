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
    /// Gen_BloodGroupController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_BloodGroupController : ControllerBase
    {
        private readonly IGen_BloodGroupUseCase _gen_BloodGroupUseCase;
        private readonly Gen_BloodGroupPresenter _gen_BloodGroupPresenter;
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
        public Gen_BloodGroupController(
            IGen_BloodGroupUseCase gen_BloodGroupUseCase,
            Gen_BloodGroupPresenter gen_BloodGroupPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_BloodGroupUseCase = gen_BloodGroupUseCase;
            _gen_BloodGroupPresenter = gen_BloodGroupPresenter;
        }

        /// <summary>
        /// GetAllGen_BloodGroup
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_BloodGroup()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.GetAll(new Gen_BloodGroupRequest(new gen_bloodgroupEntity()), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_BloodGroup
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_BloodGroup([FromBody] gen_bloodgroupEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.GetAllPaged(new Gen_BloodGroupRequest(request), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_BloodGroup
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_BloodGroup([FromBody] gen_bloodgroupEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.GetListView(new Gen_BloodGroupRequest(request), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_BloodGroup
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_BloodGroup([FromBody] gen_bloodgroupEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.GetSingle(new Gen_BloodGroupRequest(request), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_BloodGroup
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_BloodGroup([FromBody] gen_bloodgroupEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.Save(new Gen_BloodGroupRequest(request), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_BloodGroup
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_BloodGroup([FromBody] gen_bloodgroupEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.Update(new Gen_BloodGroupRequest(request), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_BloodGroup
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_BloodGroup")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_BloodGroup([FromBody] gen_bloodgroupEntity request)
        {
            /*				 ModelState.Remove("bloodgroupid");
				 ModelState.Remove("bloodgroup");
				 ModelState.Remove("bloodgroupeng");
				 ModelState.Remove("remarks");
				 ModelState.Remove("migrationinfo");
				 ModelState.Remove("migrationtable");
				 ModelState.Remove("migrationtext");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_BloodGroupUseCase.Delete(new Gen_BloodGroupRequest(request), _gen_BloodGroupPresenter);
            return _gen_BloodGroupPresenter.ContentResult;
        }
    }
}
