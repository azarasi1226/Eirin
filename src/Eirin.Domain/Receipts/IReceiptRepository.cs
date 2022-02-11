namespace Eirin.Domain.Receipts
{
    public interface IReceiptRepository
    {
        /// <summary>
        /// Id検索
        /// </summary>
        public Task<Receipt?> FindByIdAsync(ReceiptId id);

        /// <summary>
        /// 保存
        /// </summary>
        public Task SaveAsync(Receipt receipt);

        /// <summary>
        /// 削除
        /// </summary>
        public Task DeleateAsync(ReceiptId id);
    }
}
