namespace Eirin.Domain.Receipts
{
    /// <summary>
    /// 領収書
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// 領収書Id
        /// </summary>
        public ReceiptId Id { get; }

        /// <summary>
        /// 登録日
        /// </summary>
        public DateTime RegistrationDate { get; }

        /// <summary>
        /// ファイルのハッシュ値
        /// </summary>
        public FileHash FileHash { get; }

        /// <summary>
        /// ファイルパス
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// 請求日
        /// </summary>
        public DateTime BillingDate { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public long Price { get; set; }

        /// <summary>
        /// 請求元
        /// </summary>
        public string BillingSource { get; set; }

        private Receipt(ReceiptId id, DateTime registrationDate, FileHash filehash, string filePath, DateTime billingDate, long price, string billingSource)
        {
            Id = id;
            RegistrationDate = registrationDate;
            FileHash = filehash;
            FilePath = filePath;
            BillingDate = billingDate;
            Price = price;
            BillingSource = billingSource;
        }

        /// <summary>
        /// 生成
        /// </summary>
        public static Receipt Create(FileStream fileStream, DateTime billingDate, long price, string billingSource)
        {
            var id = new ReceiptId();
            var registrationDate = DateTime.Now;
            var fileHash = FileHash.Create(fileStream);

            return new Receipt(id, registrationDate, fileHash, null, billingDate, price, billingSource);
        }

        /// <summary>
        /// 再構成
        /// </summary>
        public static Receipt Reconstract(ReceiptId id, DateTime registrationDate, FileHash filehash, string filePath, DateTime billingDate, long price, string billingSource)
        {
            return new Receipt(id, registrationDate, filehash, filePath, billingDate, price, billingSource);
        }
    }
}
