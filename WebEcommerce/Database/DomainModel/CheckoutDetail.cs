using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Database.DomainModel
{
    public class CheckoutDetail
    {
        public User User { get; set; }

        public List<Product> Products { get; set; }

        public CheckoutDetail()
        {
            Products = new List<Product>();
        }
    }
}
