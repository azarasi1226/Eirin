 namespace Eirin.Domain.Shared
{
    /// <summary>
    /// ドメイン層のException
    /// </summary>
    public class DomainException : Exception
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message"></param>
        public DomainException(string message)
            : base(message)
        {
        }
    }
}
