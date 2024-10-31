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
    /// Gen_ImageGallaryCategoryController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_ImageGallaryCategoryController : ControllerBase
    {
        private readonly IGen_ImageGallaryCategoryUseCase _gen_ImageGallaryCategoryUseCase;
        private readonly Gen_ImageGallaryCategoryPresenter _gen_ImageGallaryCategoryPresenter;
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
        public Gen_ImageGallaryCategoryController(
            IGen_ImageGallaryCategoryUseCase gen_ImageGallaryCategoryUseCase,
            Gen_ImageGallaryCategoryPresenter gen_ImageGallaryCategoryPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_ImageGallaryCategoryUseCase = gen_ImageGallaryCategoryUseCase;
            _gen_ImageGallaryCategoryPresenter = gen_ImageGallaryCategoryPresenter;
        }

        /// <summary>
        /// GetAllGen_ImageGallaryCategory
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_ImageGallaryCategory()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.GetAll(new Gen_ImageGallaryCategoryRequest(new gen_imagegallarycategoryEntity()), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_ImageGallaryCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_ImageGallaryCategory([FromBody] gen_imagegallarycategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.GetAllPaged(new Gen_ImageGallaryCategoryRequest(request), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_ImageGallaryCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_ImageGallaryCategory([FromBody] gen_imagegallarycategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.GetListView(new Gen_ImageGallaryCategoryRequest(request), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_ImageGallaryCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_ImageGallaryCategory([FromBody] gen_imagegallarycategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.GetSingle(new Gen_ImageGallaryCategoryRequest(request), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_ImageGallaryCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_ImageGallaryCategory([FromBody] gen_imagegallarycategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.Save(new Gen_ImageGallaryCategoryRequest(request), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_ImageGallaryCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_ImageGallaryCategory([FromBody] gen_imagegallarycategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.Update(new Gen_ImageGallaryCategoryRequest(request), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_ImageGallaryCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_ImageGallaryCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_ImageGallaryCategory([FromBody] gen_imagegallarycategoryEntity request)
        {
            /*				 ModelState.Remove("imagegallarycategoryid");
				 ModelState.Remove("imagegallarycategory");
				 ModelState.Remove("descriptions");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryCategoryUseCase.Delete(new Gen_ImageGallaryCategoryRequest(request), _gen_ImageGallaryCategoryPresenter);
            return _gen_ImageGallaryCategoryPresenter.ContentResult;
        }
    }
}
