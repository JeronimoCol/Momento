using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly3.Models
{
    public class MovieCustomers
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}