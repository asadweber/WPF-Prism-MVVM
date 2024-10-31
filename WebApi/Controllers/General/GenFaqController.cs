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
    /// Gen_FaqController
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class Gen_FaqController : ControllerBase
    {
        private readonly IGen_FaqUseCase _gen_FaqUseCase;
        private readonly Gen_FaqPresenter _gen_FaqPresenter;
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
        public Gen_FaqController(
            IGen_FaqUseCase gen_FaqUseCase,
            Gen_FaqPresenter gen_FaqPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _gen_FaqUseCase = gen_FaqUseCase;
            _gen_FaqPresenter = gen_FaqPresenter;
        }

        /// <summary>
        /// GetAllGen_Faq
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllGen_Faq()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.GetAll(new Gen_FaqRequest(new gen_faqEntity()), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedGen_Faq
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedGen_Faq([FromBody] gen_faqEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.GetAllPaged(new Gen_FaqRequest(request), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewGen_Faq
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewGen_Faq([FromBody] gen_faqEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.GetListView(new Gen_FaqRequest(request), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleGen_Faq
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleGen_Faq([FromBody] gen_faqEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.GetSingle(new Gen_FaqRequest(request), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }

        /// <summary>
        /// AddGen_Faq
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> AddGen_Faq([FromBody] gen_faqEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.Save(new Gen_FaqRequest(request), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateGen_Faq
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("EditGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> EditGen_Faq([FromBody] gen_faqEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.Update(new Gen_FaqRequest(request), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteGen_Faq
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteGen_Faq")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteGen_Faq([FromBody] gen_faqEntity request)
        {
            /*				 ModelState.Remove("faqid");
				 ModelState.Remove("faqcategoryid");
				 ModelState.Remove("questions");
				 ModelState.Remove("answers");
				 ModelState.Remove("questionsen");
				 ModelState.Remove("answersen");
				 ModelState.Remove("tags");
				 ModelState.Remove("urls");
*/
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _gen_FaqUseCase.Delete(new Gen_FaqRequest(request), _gen_FaqPresenter);
            return _gen_FaqPresenter.ContentResult;
        }
    }
}
