using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaySky.Models;
using Microsoft.AspNetCore.Authorization;
using PaySky.Models.Interfaces;

namespace PaySky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        private readonly ITransactionRequestModel _iTransactionRequestModel;
        private readonly ITransactionResponseModel _iTransactionResponseModel;

        public GatewayController(ITransactionRequestModel iTransactionRequestModel,
            ITransactionResponseModel iTransactionResponseModel)
        {
            _iTransactionRequestModel = iTransactionRequestModel;
            _iTransactionResponseModel = iTransactionResponseModel;
        }
        [HttpPost]
        [Authorize]
        [Route("Gateway")]
        public async Task<IActionResult> Gateway(TransactionRequestModel tModel)
        {
            _iTransactionResponseModel.ResponseCode = "00";
            _iTransactionResponseModel.Message = "Success";
            _iTransactionResponseModel.ApprovalCode = "123123";
            _iTransactionResponseModel.DateTime = "201502261200";
            return Ok( _iTransactionResponseModel);
        }
    }
}
