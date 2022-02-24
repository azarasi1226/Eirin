using Eirin.Domain.Receipts;

namespace Eirin.UseCase.Receipts
{
    public class ReadReceiptUseCase
    {
        private IReceiptRepository _repository;

        public ReadReceiptUseCase(IReceiptRepository repository)
        {
            _repository = repository;
        }
    }
}
