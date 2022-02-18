using Eirin.Domain.Receipts;

namespace Eirin.UseCase.Receipts
{
    public class CreateReceiptUseCase
    {
        private IReceiptRepository _repository;

        CreateReceiptUseCase(IReceiptRepository repository)
        {
            _repository = repository;
        }

        public void Handle(string filePath, DateTime billingDate, int price, string issuer, string? memo)
        {
        }
    }
}
