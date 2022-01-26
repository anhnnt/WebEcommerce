using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using Database.DomainModel;

namespace WebEcommerce.Database.DomainModel
{
    public class Cart
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public MongoDBRef User { get; set; }

        public List<MongoDBRef> Product { get; set; }

        public string Status { get; set; }

        public int Quantity { get; set; }
        
        public int ItemQuantity { get; set; }

        public double Total { get; set; }

        public Cart ()
        {
            Product = new List<MongoDBRef>();
        }
    }
}
