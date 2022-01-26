using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using WebEcommerce.Database.DomainModel;
using Database.DomainModel;
using WebEcommerce.Models;

namespace WebEcommerce.Services
{
    public class UserService
    {
        public readonly IMongoDatabase _db;

        public UserService(IOptions<BookStoreDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            _db = mongoClient.GetDatabase(options.Value.DatabaseName);

        }

        public IMongoCollection<User> _User => _db.GetCollection<User>("user");

    }
}
