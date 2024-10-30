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
    /// Gen_ImageGallaryController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_ImageGallaryController : ControllerBase
    {
        private readonly IGen_ImageGallaryUseCase _gen_ImageGallaryUseCase;
        private readonly Gen_ImageGallaryPresenter _gen_ImageGallaryPresenter;
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
        public Gen_ImageGallaryController(
            IGen_ImageGallaryUseCase gen_ImageGallaryUseCase,
            Gen_ImageGallaryPresenter gen_ImageGallaryPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_ImageGallaryUseCase = gen_ImageGallaryUseCase;
            _gen_ImageGallaryPresenter = gen_ImageGallaryPresenter;
        }

        /// <summary>
        /// GetAllGen_ImageGallary
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_ImageGallary()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.GetAll(new Gen_ImageGallaryRequest(new gen_imagegallaryEntity()), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_ImageGallary
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_ImageGallary([FromBody] gen_imagegallaryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.GetAllPaged(new Gen_ImageGallaryRequest(request), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_ImageGallary
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_ImageGallary([FromBody] gen_imagegallaryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.GetListView(new Gen_ImageGallaryRequest(request), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_ImageGallary
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_ImageGallary([FromBody] gen_imagegallaryEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.GetSingle(new Gen_ImageGallaryRequest(request), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_ImageGallary
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_ImageGallary([FromBody] gen_imagegallaryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.Save(new Gen_ImageGallaryRequest(request), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_ImageGallary
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_ImageGallary([FromBody] gen_imagegallaryEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.Update(new Gen_ImageGallaryRequest(request), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_ImageGallary
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_ImageGallary")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_ImageGallary([FromBody] gen_imagegallaryEntity request)
        {
            /*				 ModelState.Remove("imagegallaryid");
				 ModelState.Remove("imagegallarycategoryid");
				 ModelState.Remove("imagepath");
				 ModelState.Remove("imagetype");
				 ModelState.Remove("imageextension");
				 ModelState.Remove("imagename");
				 ModelState.Remove("headingtextar");
				 ModelState.Remove("headingtext");
				 ModelState.Remove("bodytextar");
				 ModelState.Remove("bodytext");
				 ModelState.Remove("isslider");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_ImageGallaryUseCase.Delete(new Gen_ImageGallaryRequest(request), _gen_ImageGallaryPresenter);
            return _gen_ImageGallaryPresenter.ContentResult;
        }
    }
}
