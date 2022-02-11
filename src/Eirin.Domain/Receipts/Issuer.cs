using Eirin.Domain.Shared;

namespace Eirin.Domain.Receipts
{
    /// <summary>
    /// 発行者
    /// </summary>
    public record Issuer
    {
        public string Value { get; set; }

        public Issuer(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DomainException("発行者は必ず入力してください");
            }
        }
    }
}
