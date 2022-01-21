using System.Security.Cryptography;

namespace Eirin.Domain.Receipts
{
    /// <summary>
    /// ファイルのハッシュ値
    /// </summary>
    public record FileHash
    {
        private static readonly HashAlgorithm s_hashProvider = SHA256.Create();

        /// <summary>
        /// ハッシュ値
        /// </summary>
        public string HashValue { get; }

        private FileHash(FileStream fileStream)
        {
            var hashArry = s_hashProvider.ComputeHash(fileStream);
            HashValue = BitConverter.ToString(hashArry).ToLower().Replace("-", "");
        }
    
        private FileHash(string hash)
        {
            HashValue = hash;
        }

        /// <summary>
        /// 生成
        /// </summary>
        public static FileHash Create(FileStream fileStream)
        {
            return new FileHash(fileStream);
        }

        /// <summary>
        /// 再構成
        /// </summary>
        public static FileHash Reconstract(string hash)
        {
            return new FileHash(hash);
        }
    }
}
