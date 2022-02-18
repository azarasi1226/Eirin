using Eirin.Domain.Receipts;
using Eirin.Infrastructure.Receipts;
using Eirin.Infrastructure.Shared;
using Eirin.UseCase.Receipts;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

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
            s_serviceCollection.AddScoped(e => new ConnectionString() {Value = @"C:\Test.sqlite" });
            s_serviceCollection.AddScoped<IReceiptRepository, ReceiptRepository>();
            s_serviceCollection.AddScoped<CreateReceiptUseCase>();
        }
    }
}