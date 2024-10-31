using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.Interfaces.UseCases;
using Microsoft.AspNetCore.Authorization;
using WebApi.Extensions;
using BDO.Core.DataAccessObjects.Models;
using Web.Core.Frame.Presenters;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace Web.Api.Controllers
{
    /// <summary>
    /// TranLoginController
    /// </summary>
    [NonController]
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class TranLoginController : ControllerBase
    {
        private readonly ITran_LoginUseCase _tran_LoginUseCase;
        private readonly Tran_LoginPresenter _tran_LoginPresenter;
        private readonly AuthSettings _authSettings;

        /// <summary>
        /// _configuration
        /// </summary>
        public IConfiguration _configuration { get; }

        /// <summary>
        /// TranLoginController
        /// </summary>
        /// <param name="tran_LoginUseCase"></param>
        /// <param name="tran_LoginPresenter"></param>
        /// <param name="authSettings"></param>
        public TranLoginController(
            ITran_LoginUseCase tran_LoginUseCase,
            Tran_LoginPresenter tran_LoginPresenter,
            IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
            _tran_LoginUseCase = tran_LoginUseCase;
            _tran_LoginPresenter = tran_LoginPresenter;
        }


        /// <summary>
        /// GetAllTranLogin
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllTranLogin()
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.GetAll(new Tran_LoginRequest(new tran_loginEntity()), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }

        /// <summary>
        /// GetAllPagedTranLogin
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetAllPagedTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetAllPagedTranLogin([FromBody] tran_loginEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.GetAllPaged(new Tran_LoginRequest(request), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }

        /// <summary>
        /// GetListViewTranLogin
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetListViewTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetListViewTranLogin([FromBody] tran_loginEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.GetListView(new Tran_LoginRequest(request), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }

        /// <summary>
        /// GetSingleTranLogin
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetSingleTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> GetSingleTranLogin([FromBody] tran_loginEntity request)
        {
            //if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.GetSingle(new Tran_LoginRequest(request), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }

        /// <summary>
        /// SaveTranLogin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("SaveTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> SaveTranLogin([FromBody] tran_loginEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.Save(new Tran_LoginRequest(request), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }

        /// <summary>
        /// UpdateTranLogin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("UpdateTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> UpdateTranLogin([FromBody] tran_loginEntity request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.Update(new Tran_LoginRequest(request), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }

        /// <summary>
        /// DeleteTranLogin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("DeleteTranLogin")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<ActionResult> DeleteTranLogin([FromBody] tran_loginEntity request)
        {
            ModelState.Remove("PriorityName");
            ModelState.Remove("PriorityOrder");
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _tran_LoginUseCase.Delete(new Tran_LoginRequest(request), _tran_LoginPresenter);
            return _tran_LoginPresenter.ContentResult;
        }
    }
}
