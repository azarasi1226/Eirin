

using NUlid;

namespace Reimu.Domain.Shared
{
    /// <summary>
    /// Idの基底クラス
    /// </summary>
    public abstract record IdBase
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected IdBase()
        {
            Id = Ulid.NewUlid().ToString();
        }

        /// <summary>
        /// 再構成コンストラクタ
        /// </summary>
        protected IdBase(string value)
        {
            Id = value;
        }
    }
}
