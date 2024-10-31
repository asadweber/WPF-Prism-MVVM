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
    /// Gen_UsefulLinkCategoryController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_UsefulLinkCategoryController : ControllerBase
    {
        private readonly IGen_UsefulLinkCategoryUseCase _gen_UsefulLinkCategoryUseCase;
        private readonly Gen_UsefulLinkCategoryPresenter _gen_UsefulLinkCategoryPresenter;
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
        public Gen_UsefulLinkCategoryController(
            IGen_UsefulLinkCategoryUseCase gen_UsefulLinkCategoryUseCase,
            Gen_UsefulLinkCategoryPresenter gen_UsefulLinkCategoryPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_UsefulLinkCategoryUseCase = gen_UsefulLinkCategoryUseCase;
            _gen_UsefulLinkCategoryPresenter = gen_UsefulLinkCategoryPresenter;
        }

        /// <summary>
        /// GetAllGen_UsefulLinkCategory
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_UsefulLinkCategory()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.GetAll(new Gen_UsefulLinkCategoryRequest(new gen_usefullinkcategoryEntity()), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_UsefulLinkCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_UsefulLinkCategory([FromBody] gen_usefullinkcategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.GetAllPaged(new Gen_UsefulLinkCategoryRequest(request), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_UsefulLinkCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_UsefulLinkCategory([FromBody] gen_usefullinkcategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.GetListView(new Gen_UsefulLinkCategoryRequest(request), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_UsefulLinkCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_UsefulLinkCategory([FromBody] gen_usefullinkcategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.GetSingle(new Gen_UsefulLinkCategoryRequest(request), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_UsefulLinkCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_UsefulLinkCategory([FromBody] gen_usefullinkcategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.Save(new Gen_UsefulLinkCategoryRequest(request), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_UsefulLinkCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_UsefulLinkCategory([FromBody] gen_usefullinkcategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.Update(new Gen_UsefulLinkCategoryRequest(request), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_UsefulLinkCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_UsefulLinkCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_UsefulLinkCategory([FromBody] gen_usefullinkcategoryEntity request)
        {
            /*				 ModelState.Remove("usefullinkcategoryid");
				 ModelState.Remove("usefullinkcategory");
				 ModelState.Remove("usefullinkcategoryar");
				 ModelState.Remove("usefullinkcategorydescription");
				 ModelState.Remove("usefullinkcategorydescriptionar");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_UsefulLinkCategoryUseCase.Delete(new Gen_UsefulLinkCategoryRequest(request), _gen_UsefulLinkCategoryPresenter);
            return _gen_UsefulLinkCategoryPresenter.ContentResult;
        }
    }
}
