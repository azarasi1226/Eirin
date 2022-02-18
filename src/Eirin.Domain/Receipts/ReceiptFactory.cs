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


            //ファイルパス
            using (FileStream fs = new FileStream(filePath, FileMode.Open , FileAccess.Read))
            {
                return Receipt.Create(fs, billingDate, price, issuer, memo);
            }
        }
    }
}
