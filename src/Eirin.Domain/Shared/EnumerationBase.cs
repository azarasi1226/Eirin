using System.Reflection;

namespace Eirin.Domain.Shared
{
    /// <summary>
    /// 列挙型の基底クラス
    /// </summary>
    public abstract record EnumerationBase<T>
        where T : EnumerationBase<T>
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// 表示名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected EnumerationBase(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Id検索
        /// </summary>
        public static T FindById(int id)
        {
            var findData = GetAll()
                .FirstOrDefault(e => e.Id == id);

            if (findData is null)
            {
                throw new ArgumentException("Enumへの変換に失敗");
            }

            return findData;
        }

        /// <summary>
        /// すべての要素を取得
        /// </summary>
        public static IEnumerable<T> GetAll()
        {
            return typeof(T)
                .GetFields(
                    BindingFlags.Public |
                    BindingFlags.Static |
                    BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
