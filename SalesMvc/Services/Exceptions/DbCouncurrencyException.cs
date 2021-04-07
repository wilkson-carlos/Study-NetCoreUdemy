using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvc.Services.Exceptions
{
    public class DbCouncurrencyException : ApplicationException
    {
        public DbCouncurrencyException(string message) : base(message)
        {

        }
    }
}
