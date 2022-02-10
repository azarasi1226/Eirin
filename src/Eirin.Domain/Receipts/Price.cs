using Eirin.Domain.Shared;

namespace Eirin.Domain.Receipts
{
    /// <summary>
    /// 金額
    /// </summary>
    public record Price
    {
        /// <summary>
        /// 値
        /// </summary>
        public int Value { get; }

        public Price(int value)
        {
            if(value <= 0)
            {
                throw new DomainException("金額には1以上を入力してください。");
            }

            Value = value;
        }
    }
}
