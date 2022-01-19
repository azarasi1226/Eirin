namespace Eirin.Domain.Shared
{
    /// <summary>
    /// 名前の基底クラス
    /// </summary>
    public abstract record NameBase
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected NameBase(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DomainException("名前が空です");
            }

            Name = value;
        }
    }
}
