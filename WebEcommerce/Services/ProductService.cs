using MongoDB.Driver;
using Database.DomainModel;
using Microsoft.Extensions.Options;


namespace WebEcommerce.Services
{
    public class ProductService
    {
        public readonly IMongoDatabase _db;

        public ProductService(IOptions<BookStoreDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            _db = mongoClient.GetDatabase(options.Value.DatabaseName);

        }

        public IMongoCollection<Product> _products => _db.GetCollection<Product>("product");

        public IEnumerable<Product> GetAllProducts()
        {
            return _products.Find(a => true).ToList();
        }

        public IEnumerable<Product> SearchProduct(string name)
        {
            var filter = Builders<Product>.Filter.Where(s => s.Model!.Contains(name));
            var products = _products.Find(filter);

            return products.ToList();
        }

        public IEnumerable<Product> SortHighPrice()
        {
            return _products.Find(a => true).SortByDescending(i=>i.Price).ToList();
        }

        public IEnumerable<Product> SortLowPrice()
        {
            return _products.Find(a => true).SortBy(i => i.Price).ToList();
        }

        public Product GetProduct(string id)
        {
            var Productdetail = _products.Find(m => m.Id == id).FirstOrDefault();
            return Productdetail;
        }
        public void Create(Product Product)
        {
            _products.InsertOne(Product);
        }

        public void Update(string _id, Product product)
        {
            //var filter = Builders<Product>.Filter.Eq(c => c.Id, _id);
            var filter = Builders<Product>.Filter.Eq("Id", product.Id);
            var update = Builders<Product>.Update
                .Set("Brand", product.Brand)
                .Set("Model", product.Model)
                .Set("Price", product.Price)
                .Set("Model", product.Model)
                .Set("OS", product.OS)
                .Set("ReleasedYear", product.ReleasedYear);
            _products.UpdateOne(filter, update);
        }

        public void Delete(string _id)
        {
            var filter = Builders<Product>.Filter.Eq(c => c.Id, _id);
            _products.DeleteOne(filter);
        }

    }
}
