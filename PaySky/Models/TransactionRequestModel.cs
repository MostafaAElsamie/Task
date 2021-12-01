﻿using PaySky.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaySky.Models
{
    public class TransactionRequestModel : ITransactionRequestModel
    {
        public string ProcessingCode { get; set; }
        public string SystemTraceNr { get; set; }
        public string FunctionCode { get; set; }
        public string CardNo { get; set; }
        public string CardHolder { get; set; }
        public string AmountTrxn { get; set; }
        public string CurrencyCode { get; set; }

    }
}
