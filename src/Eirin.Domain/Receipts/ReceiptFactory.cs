namespace Eirin.Domain.Receipts
{
    /// <summary>
    /// 領収書Factory
    /// </summary>
    public class ReceiptFactory
    {
        /// <summary>
        /// 領収書を作成
        /// </summary>
        public Receipt Factory(string fromFilePath, DateTime billingDate, Price price, Issuer issuer, string memo)
        {
            var extension = Path.GetExtension(fromFilePath);

            throw new NotImplementedException();
        }
    }
}
