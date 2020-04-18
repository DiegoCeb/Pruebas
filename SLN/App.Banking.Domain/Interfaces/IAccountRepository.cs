using App.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccount();
    }
}
