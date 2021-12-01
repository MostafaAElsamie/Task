using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaySky.Models.Interfaces
{
   public  interface ITransactionResponseModel
    {
        public string ResponseCode { get; set; }
        public string Message { get; set; }
        public string ApprovalCode { get; set; }
        public string DateTime { get; set; }
    }
}
