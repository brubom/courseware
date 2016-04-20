using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Albumprinter.Customers.WebRestService.Domain
{
    public class Order
    {

        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
