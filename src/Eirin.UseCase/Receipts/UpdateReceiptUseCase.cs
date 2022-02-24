using Eirin.Domain.Receipts;

namespace Eirin.UseCase.Receipts
{
    public class UpdateReceiptUseCase
    {
        private IReceiptRepository _repository;

        public UpdateReceiptUseCase(IReceiptRepository repository)
        {
            _repository = repository;
        }
    }
}
