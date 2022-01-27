using MongoDB.Driver;
using Database.DomainModel;
using Microsoft.Extensions.Options;

namespace WebEcommerce.Services
{
    public class CategoryService
    {
        public readonly IMongoDatabase _db;

        public CategoryService(IOptions<BookStoreDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            _db = mongoClient.GetDatabase(options.Value.DatabaseName);

        }

        public IMongoCollection<Category> _categories => _db.GetCollection<Category>("category");

        public IEnumerable<Category> GetAllCategories()
        {
            return _categories.Find(a => true).ToList();
        }

        public void Create(Category category)
        {
            _categories.InsertOne(category);
        }

        public Category GetCategory(string id)
        {
            var Categorydetail = _categories.Find(m => m.Id == id).FirstOrDefault();
            return Categorydetail;
        }
    }
}
