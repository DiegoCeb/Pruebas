using App.Banking.Data.Context;
using App.Banking.Domain.Interfaces;
using App.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccount()
        {
            return _ctx.Accounts;
        }
    }
}
