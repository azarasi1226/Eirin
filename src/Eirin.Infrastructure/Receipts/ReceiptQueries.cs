namespace Eirin.Infrastructure.Receipts
{
    /// <summary>
    /// 領収書Queries
    /// </summary>
    internal class ReceiptQueries
    {
        /// <summary>
        /// テーブル名
        /// </summary>
        public static readonly string TableName = "Receipts";

        /// <summary>
        /// テーブル作成SQL
        /// </summary>
        public static string CreateTableSQL =
@$"
CREATE TABLE [IF NOT EXISTS] {TableName} (
    id                TEXT PRIMARY KEY,
    registration_date TEXT NOT NULL,
    file_hash         TEXT NOT NULL,
    file_Path         TEXT NOT NULL,
    billing_date      TEXT NOT NULL,
    price             INTEGER NOT NULL,
    issuer            TEXT NOTNULL,
    memo              TEXT
) [WITHOUT ROWID]

";

        /// <summary>
        ///  登録SQL
        /// </summary>
        public static string InsertSQL =
@$"
INSERT INTO {TableName} (
    @Id, 
    @RegistrationDate, 
    @FileHash, 
    @FilePath, 
    @BillingDate, 
    @Price, 
    @Issuer, 
    @Memo
)";

        /// <summary>
        /// 更新SQLd
        /// </summary>
        public static string UpdateSQL =
@$"
UPDATE {TableName}
SET
    billing_date      = @BillingDate,
    price             = @Price,
    issuer            = @Issuer,
    memo              = @Memo
WHERE
";

        /// <summary>
        /// 削除SQL
        /// </summary>
        public static string DeleteSQL =
@$"
DELETE FROM {TableName} 
WHERE
    Id = @Id
";
    }
}
