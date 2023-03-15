using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Account
    {
        public int AccountId { get; set; }
        public string? AccountName { get; set; }
        public decimal Balance { get; set; }
    }
}
