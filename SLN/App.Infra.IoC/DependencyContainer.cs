using App.Banking.Application.Interfaces;
using App.Banking.Application.Services;
using App.Banking.Data.Context;
using App.Banking.Data.Repository;
using App.Banking.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace App.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain Bus

            // Subscriptions

            //Commands

            //Domain Event

            //Application services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddDbContext<BankingDbContext>();
        }

    }
}
