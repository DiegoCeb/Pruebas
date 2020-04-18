using System;
using System.Collections.Generic;
using System.Text;

namespace App.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AcoountType { get; set; }

        public decimal AcoountBalance { get; set; }
    }
}
