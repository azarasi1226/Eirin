using Eirin.Domain.Receipts;
using Eirin.Infrastructure.Shared;

namespace Eirin.Infrastructure.Receipts
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly ConnectionString _connectionString;
        public ReceiptRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        public Task DeleateAsync(ReceiptId id)
        {
            throw new NotImplementedException();
        }

        public Task<Receipt?> FindByIdAsync(ReceiptId id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Receipt receipt)
        {
            throw new NotImplementedException();
        }
    }
}
