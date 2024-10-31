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
    /// Gen_NewsCategoryController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_NewsCategoryController : ControllerBase
    {
        private readonly IGen_NewsCategoryUseCase _gen_NewsCategoryUseCase;
        private readonly Gen_NewsCategoryPresenter _gen_NewsCategoryPresenter;
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
        public Gen_NewsCategoryController(
            IGen_NewsCategoryUseCase gen_NewsCategoryUseCase,
            Gen_NewsCategoryPresenter gen_NewsCategoryPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_NewsCategoryUseCase = gen_NewsCategoryUseCase;
            _gen_NewsCategoryPresenter = gen_NewsCategoryPresenter;
        }

        /// <summary>
        /// GetAllGen_NewsCategory
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_NewsCategory()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.GetAll(new Gen_NewsCategoryRequest(new gen_newscategoryEntity()), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_NewsCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_NewsCategory([FromBody] gen_newscategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.GetAllPaged(new Gen_NewsCategoryRequest(request), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_NewsCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_NewsCategory([FromBody] gen_newscategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.GetListView(new Gen_NewsCategoryRequest(request), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_NewsCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_NewsCategory([FromBody] gen_newscategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.GetSingle(new Gen_NewsCategoryRequest(request), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_NewsCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_NewsCategory([FromBody] gen_newscategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.Save(new Gen_NewsCategoryRequest(request), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_NewsCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_NewsCategory([FromBody] gen_newscategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.Update(new Gen_NewsCategoryRequest(request), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_NewsCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_NewsCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_NewsCategory([FromBody] gen_newscategoryEntity request)
        {
            /*				 ModelState.Remove("newscategoryid");
				 ModelState.Remove("newscategoryar");
				 ModelState.Remove("newscategory");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_NewsCategoryUseCase.Delete(new Gen_NewsCategoryRequest(request), _gen_NewsCategoryPresenter);
            return _gen_NewsCategoryPresenter.ContentResult;
        }
    }
}
