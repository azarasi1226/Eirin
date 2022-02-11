using Dapper;
using Microsoft.Data.Sqlite;

namespace Eirin.Infrastructure.Shared
{

    /// <summary>
    /// レポジトリベース
    /// </summary>
    public class RepositoryBase
    {
        private ConnectionString _connectionString;

        /// <summary>
        /// コネクション
        /// </summary>
        public SqliteConnection Connection
        {
            get
            {
                return new SqliteConnection(_connectionString.Value);
            }
        }

        public RepositoryBase(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// テーブルの存在確認
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <returns></returns>
        protected bool ExistsTable(string tableName)
        {
            var sql =
@"
SELECT 
    COUNT(*)
FROM 
    sqlite_master 
WHERE 
    type = 'table’ 
    AND name = @TableName
";

            using (var con = Connection)
            {
                var count = con.QueryFirst<int>(sql, new
                {
                    TableName = tableName
                });

                if (count == 1)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
