using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.Dto.UseCaseRequests;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace WebApi.Controllers
{
    /// <summary>
    /// AuthController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationSignInManager<owin_userEntity> _userSignManager;
        private readonly ILoginUseCase _loginUseCase;
        private readonly LoginPresenter _loginPresenter;
        private readonly IExchangeRefreshTokenUseCase _exchangeRefreshTokenUseCase;
        private readonly ExchangeRefreshTokenPresenter _exchangeRefreshTokenPresenter;
        private readonly AuthSettings _authSettings;




        public IConfiguration _configuration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginUseCase"></param>
        /// <param name="loginPresenter"></param>
        /// <param name="exchangeRefreshTokenUseCase"></param>
        /// <param name="exchangeRefreshTokenPresenter"></param>
        /// <param name="userSignManager"></param>
        /// <param name="authSettings"></param>
        public AuthController(ILoginUseCase loginUseCase, LoginPresenter loginPresenter,
            IExchangeRefreshTokenUseCase exchangeRefreshTokenUseCase,
            ExchangeRefreshTokenPresenter exchangeRefreshTokenPresenter,
            IOptions<AuthSettings> authSettings,
             ApplicationSignInManager<owin_userEntity> userSignManager)
        {
            _loginUseCase = loginUseCase;
            _loginPresenter = loginPresenter;
            _exchangeRefreshTokenUseCase = exchangeRefreshTokenUseCase;
            _exchangeRefreshTokenPresenter = exchangeRefreshTokenPresenter;
            _authSettings = authSettings.Value;
            _userSignManager = userSignManager;
        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //[HttpPost("loginTest")]
        //public async Task<ActionResult> loginTest([FromBody] LoginRequest request)
        //{
        //    return _loginPresenter.ContentResult;
        //}


        // POST api/auth/login
        /// <summary>
        /// login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login")]

        public async Task<ActionResult> Login([FromBody] LoginRequest request)
        {
            var ipaddress = Request.HttpContext.Connection.RemoteIpAddress?.ToString();
            var result = await _userSignManager.CanSignInAsync(new owin_userEntity());
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _loginUseCase.Handle(new LoginRequest(request.UserName, request.Password, ipaddress ?? "127.0.0.1"), _loginPresenter);
            return _loginPresenter.ContentResult;
        }



        // POST api/auth/changepassword
        /// <summary>
        /// changepassword
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("changepassword")]

        public async Task<ActionResult> changepassword([FromBody] LoginRequest request)
        {
            var ipaddress = Request.HttpContext.Connection.RemoteIpAddress?.ToString();
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _loginUseCase.Handle(new LoginRequest(request.UserName, request.Password, ipaddress ?? "127.0.0.1"), _loginPresenter);
            return _loginPresenter.ContentResult;
        }


        // POST api/auth/refreshtoken
        /// <summary>
        /// refreshtoken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("refreshtoken")]
        public async Task<ActionResult> RefreshToken([FromBody] ExchangeRefreshTokenRequest request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            await _exchangeRefreshTokenUseCase.Handle(new ExchangeRefreshTokenRequest(request.AccessToken, request.RefreshToken, _authSettings.SecretKey, Request.HttpContext.Connection.RemoteIpAddress?.ToString()), _exchangeRefreshTokenPresenter);
            return _exchangeRefreshTokenPresenter.ContentResult;
        }
    }
}
