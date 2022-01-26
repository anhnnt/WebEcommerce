using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Test.Interface;
using Test.Models;

namespace Test.Data
{
    public class CustomerDBContext : ICustomer
    {

        public readonly IMongoDatabase _db;

        public CustomerDBContext(IOptions<BookStoreDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            _db = mongoClient.GetDatabase(options.Value.DatabaseName);

        }

        public IMongoCollection<Customer> Customers => _db.GetCollection<Customer>("customer");

        //private readonly IMongoCollection<Customer> Customers;
        // public CustomerDBContext(IOptions<BookStoreDatabaseSettings> options)
        // {var mongoClient = new MongoClient(options.Value.ConnectionString);
        // Customers = mongoClient.GetDatabase(options.Value.DatabaseName).GetCollection<Customer>(options.Value.CustomerCollectionName);}

        public IEnumerable<Customer> GetAllCustomers()
        {
            return Customers.Find(a => true).ToList();
        }

        public Customer GetCustomer(string id)
        {
            var customerdetail = Customers.Find(m => m.Id == id).FirstOrDefault();
            return customerdetail;
        }
        public void Create(Customer customer)
        {
            Customers.InsertOne(customer);
        }

        public void Update(string _id, Customer customer)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.Id, _id);
            var update = Builders<Customer>.Update
                .Set("customername", customer.Username)
                .Set("Email", customer.Email)
                .Set("Password", customer.Password);
            Customers.UpdateOne(filter, update);
        }

        public void Delete(string _id)
        {
            var filter = Builders<Customer>.Filter.Eq(c => c.Id, _id);
            Customers.DeleteOne(filter);
        }
    }
}
