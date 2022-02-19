using Eirin.UseCase.Receipts;
using Microsoft.Extensions.DependencyInjection;

namespace Eirin.Test.Shared
{
    public class TestBase
    {
        private readonly static ServiceCollection s_serviceCollection = new ServiceCollection();

        /// <summary>
        /// サービスプロバイダー
        /// </summary>
        public static ServiceProvider ServiceProvider
        {
            get 
            { 
                return s_serviceCollection.BuildServiceProvider(); 
            }
        }
        static TestBase()
        {
          //  s_serviceCollection.AddScoped<IReceiptRepository, ReceiptRepository>();
            s_serviceCollection.AddScoped<CreateReceiptUseCase>();
        }
    }
}