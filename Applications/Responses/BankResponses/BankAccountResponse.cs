using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Responses.BankResponses
{
    public class BankAccountResponse
    {
        public string AccountType { get; set; }
        public Guid UserId { get; set; }
        public string AccountNumber { get; set; }

    }
}
