using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using WebEcommerce.Database.DomainModel;
using Database.DomainModel;
using WebEcommerce.Models;
using WebEcommerce.Services;

namespace WebEcommerce.Services
{
    public class CartService
    {
        public readonly IMongoDatabase _db;

        public CartService(IOptions<BookStoreDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            _db = mongoClient.GetDatabase(options.Value.DatabaseName);

        }

        public IMongoCollection<Cart> _Cart => _db.GetCollection<Cart>("cart");
        public IMongoCollection<User> _User => _db.GetCollection<User>("user");

        public Cart OpenCart(string id)
        {
            var filter = Builders<Cart>.Filter.And(Builders<Cart>.Filter.Eq("User", new MongoDBRef("user", id)), Builders<Cart>.Filter.Eq("Status", "opened"));

            var orders = _Cart.Find(filter).ToList();

            if (orders.Count == 0)
                return null;
            else
                return orders.First();
        }

        public User GetUser(string email)
        {
            var filter = Builders<User>.Filter.Eq("Email", email);

            return _User.Find(filter).First();
        }

        public void AddUpdateOrder(Cart cart, string email, string addupdate)
        {

            if (addupdate.Equals("add"))
            {

                User user = GetUser(email);
                cart.User = new MongoDBRef("users", user.Id);

                _Cart.InsertOne(cart);

                user.Cart.Add(new MongoDBRef("cart", cart.Id));

                var update = Builders<User>.Update.Set("Orders", user.Cart);
                var filter = Builders<User>.Filter.Eq("Email", email);

                _User.UpdateOne(filter, update);
            }
            else
            {
                var update = Builders<Cart>.Update.Set("Products", cart.Product);
                var filter = Builders<Cart>.Filter.Eq("_id", cart.Id);

                _Cart.UpdateOne(filter, update);
            }
        }

        public void CloseCart(Cart cart)
        {
            var update = Builders<Cart>.Update.Set("Status", "closed");
            var filter = Builders<Cart>.Filter.Eq("_id", cart.Id);

            _Cart.UpdateOne(filter, update);
        }

        public void RemoveProduct(Cart cart)
        {

            var update = Builders<Cart>.Update.Set("Product", cart.Product);
            var filter = Builders<Cart>.Filter.Eq("_id", cart.Id);

            _Cart.UpdateOne(filter, update);
        }

        public void DeleteOrder(ObjectId id)
        {

            var filter = Builders<Cart>.Filter.Eq("_id", id);

            _Cart.DeleteOne(filter);
        }
    }
}
