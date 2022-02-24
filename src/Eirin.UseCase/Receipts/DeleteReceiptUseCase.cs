using Eirin.Domain.Receipts;

namespace Eirin.UseCase.Receipts
{
    public class DeleteReceiptUseCase
    {
        private IReceiptRepository _repository;

        public DeleteReceiptUseCase(IReceiptRepository repository)
        {
            _repository = repository;
        }
    }
}
