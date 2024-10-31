using AutoMapper.Configuration;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ApiModels;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;

namespace WebApi.Controllers
{
	/// <summary>
	/// Export Import Utility
	/// </summary>
	[Authorize(Policy = "allowAllApiPolicy")]
	[Route("api/[controller]")]
	[ApiController]
	public class ExportImportController : ControllerBase
    {
        private readonly IRegisterUserExportImportUseCase _registeruserexportimportusecase;
        private readonly RegisterUserExportImportPresenter _registeruserexportimportpresenter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registeruserexportimportusecase"></param>
        public ExportImportController(IRegisterUserExportImportUseCase registeruserexportimportusecase, RegisterUserExportImportPresenter registeruserexportimportpresenter)
        {
            _registeruserexportimportusecase = registeruserexportimportusecase;
            _registeruserexportimportpresenter = registeruserexportimportpresenter;
        }
        
        /// <summary>
        /// Process to Export JSON
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("export")]
        public async Task<ActionResult> ExportPost([FromBody] RegisterUserExportImportRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _registeruserexportimportusecase.Export(request, _registeruserexportimportpresenter);
            return _registeruserexportimportpresenter.ContentResult;
        }
        /// <summary>
        /// Process to Import JSON
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("import")]
        public async Task<ActionResult> ImportPost([FromBody] RegisterUserExportImportRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           await _registeruserexportimportusecase.Import(request, _registeruserexportimportpresenter);
            return _registeruserexportimportpresenter.ContentResult;
        }


		[HttpPost]
		[Route("GetAllBatch")]
		public async Task<ActionResult> GetAllBatch()
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			await _registeruserexportimportusecase.GetAllBatch( _registeruserexportimportpresenter);
			return new JsonResult(_registeruserexportimportpresenter.Result);
		}

	}
   
}
