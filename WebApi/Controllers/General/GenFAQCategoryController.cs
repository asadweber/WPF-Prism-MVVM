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
    /// Gen_FAQCategoryController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_FAQCategoryController : ControllerBase
    {
        private readonly IGen_FAQCategoryUseCase _gen_FAQCategoryUseCase;
        private readonly Gen_FAQCategoryPresenter _gen_FAQCategoryPresenter;
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
        public Gen_FAQCategoryController(
            IGen_FAQCategoryUseCase gen_FAQCategoryUseCase,
            Gen_FAQCategoryPresenter gen_FAQCategoryPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_FAQCategoryUseCase = gen_FAQCategoryUseCase;
            _gen_FAQCategoryPresenter = gen_FAQCategoryPresenter;
        }

        /// <summary>
        /// GetAllGen_FAQCategory
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_FAQCategory()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.GetAll(new Gen_FAQCategoryRequest(new gen_faqcategoryEntity()), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_FAQCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_FAQCategory([FromBody] gen_faqcategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.GetAllPaged(new Gen_FAQCategoryRequest(request), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_FAQCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_FAQCategory([FromBody] gen_faqcategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.GetListView(new Gen_FAQCategoryRequest(request), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_FAQCategory
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_FAQCategory([FromBody] gen_faqcategoryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.GetSingle(new Gen_FAQCategoryRequest(request), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_FAQCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_FAQCategory([FromBody] gen_faqcategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.Save(new Gen_FAQCategoryRequest(request), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_FAQCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_FAQCategory([FromBody] gen_faqcategoryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.Update(new Gen_FAQCategoryRequest(request), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_FAQCategory
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_FAQCategory")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_FAQCategory([FromBody] gen_faqcategoryEntity request)
        {
            /*				 ModelState.Remove("faqcategoryid");
				 ModelState.Remove("faqcategory");
				 ModelState.Remove("faqcategoryen");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FAQCategoryUseCase.Delete(new Gen_FAQCategoryRequest(request), _gen_FAQCategoryPresenter);
            return _gen_FAQCategoryPresenter.ContentResult;
        }
    }
}
