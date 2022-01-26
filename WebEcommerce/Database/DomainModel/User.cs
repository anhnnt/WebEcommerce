﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Database.DomainModel
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; } 
        
        public string Email { get; set; }

        public string Phone { get; set; }

        public List<MongoDBRef> Cart { get; set; }

        public User()
        {
            Cart = new List<MongoDBRef>();
        }
    }
}
