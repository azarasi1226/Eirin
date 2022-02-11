using Dapper;
using Eirin.Domain.Receipts;
using Eirin.Infrastructure.Shared;

namespace Eirin.Infrastructure.Receipts
{
    public class ReceiptRepository : RepositoryBase, IReceiptRepository
    {

        public ReceiptRepository(ConnectionString connectionString)
            : base(connectionString)
        {
            if(!ExistsTable(ReceiptQueries.TableName))
            {
                CreateTable();
            }
        }

        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <returns></returns>
        private void CreateTable()
        {
            using (var con = Connection)
            {
                con.Execute(ReceiptQueries.CreateTableSQL);
            }
        }

        public async Task DeleateAsync(ReceiptId id)
        {
            using (var con = Connection)
            {
                await con.ExecuteAsync(ReceiptQueries.DeleteSQL, new
                {
                    Id = id.Id 
                });
            }
        }

        public async Task<Receipt?> FindByIdAsync(ReceiptId id)
        {
            return null;
        }

        public async Task InsertAsync(Receipt receipt)
        {
            using (var con = Connection)
            {
                await con.ExecuteAsync(ReceiptQueries.InsertSQL, new
                {
                    Id = receipt.Id.Id,
                    RegistrationDate = receipt.RegistrationDate,
                    Filehash = receipt.FileHash.HashValue,
                    FilePath = receipt.FilePath,
                    BillingDate = receipt.BillingDate,
                    Price = receipt.Price.Value,
                    Issuer = receipt.Issuer.Value,
                    Memo = receipt.Memo,
                });
            }
        }

        public async Task UpdateAsync(Receipt receipt)
        {
            using (var con = Connection)
            {
                await con.ExecuteAsync(ReceiptQueries.UpdateSQL, new
                {
                    BillingDate = receipt.BillingDate,
                    Price = receipt.Price.Value,
                    Issuer = receipt.Issuer.Value,
                    Memo = receipt.Memo,
                });
            }
        }
    }
}
