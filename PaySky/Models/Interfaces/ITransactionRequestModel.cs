namespace PaySky.Models.Interfaces
{
    public interface ITransactionRequestModel
    {
        string AmountTrxn { get; set; }
        string CardHolder { get; set; }
        string CardNo { get; set; }
        string CurrencyCode { get; set; }
        string FunctionCode { get; set; }
        string ProcessingCode { get; set; }
        string SystemTraceNr { get; set; }
    }
}