using Test.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Test.Interface
{
    public interface ICustomer
    {
        IMongoCollection<Customer> Customers { get; }
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(string id);
        void Create(Customer Customer);
        void Update(string _id, Customer Customer);
        void Delete(string Name);

    }
}
