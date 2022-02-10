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
        public Price Price { get; set; }

        /// <summary>
        /// 発行者
        /// </summary>
        public Issuer Issuer { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        public string Memo { get; set; }

        private Receipt(ReceiptId id, DateTime registrationDate, FileHash filehash, string filePath, DateTime billingDate, Price price, Issuer issuer, string memo)
        {
            Id = id;
            RegistrationDate = registrationDate;
            FileHash = filehash;
            FilePath = filePath;
            BillingDate = billingDate;
            Price = price;
            Issuer = issuer;
            Memo = memo;
        }

        /// <summary>
        /// 生成
        /// </summary>
        public static Receipt Create(FileStream fileStream, DateTime billingDate, Price price, Issuer issuer, string memo)
        {
            var id = new ReceiptId();
            var registrationDate = DateTime.Now;
            var fileHash = FileHash.Create(fileStream);

            return new Receipt(id, registrationDate, fileHash, null, billingDate, price, issuer, memo);
        }

        /// <summary>
        /// 再構成
        /// </summary>
        public static Receipt Reconstract(ReceiptId id, DateTime registrationDate, FileHash filehash, string filePath, DateTime billingDate, Price price, Issuer issuer, string memo)
        {
            return new Receipt(id, registrationDate, filehash, filePath, billingDate, price, issuer, memo);
        }
    }
}
