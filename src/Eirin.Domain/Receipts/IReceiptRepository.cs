namespace Eirin.Domain.Receipts
{
    /// <summary>
    /// 領収書レポジトリIF
    /// </summary>
    public interface IReceiptRepository
    {
        /// <summary>
        /// Id検索
        /// </summary>
        public Task<Receipt?> FindByIdAsync(ReceiptId id);

        /// <summary>
        /// 保存
        /// </summary>
        public Task UpdateAsync(Receipt receipt);

        /// <summary>
        /// 更新
        /// </summary>
        public Task InsertAsync(Receipt receipt);

        /// <summary>
        /// 削除
        /// </summary>
        public Task DeleateAsync(ReceiptId id);
    }
}
