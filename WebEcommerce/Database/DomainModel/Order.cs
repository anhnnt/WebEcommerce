using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using WebEcommerce.Database.DomainModel;

namespace Database.DomainModel
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public List<Cart> CartItem { get; set; }

        public Order()
        {
            CartItem = new List<Cart>();
        }
    }
}
