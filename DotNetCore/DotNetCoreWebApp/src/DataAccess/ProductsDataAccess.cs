using System.Collections.Generic;
using Models;
using MongoDB.Driver;

namespace DotNetCoreWebApp.DataAccess
{
    public class ProductsDataAccess
    {
        private MongoClient _client;
        private MongoServer _server;
        private MongoDatabase _database;

        public ProductsDataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _database = _server.GetDatabase("EmployeeDB");
        }


        public IEnumerable<Product> GetProducts()
        {
            return _database.GetCollection<Product>("Products").FindAll();
        }


    }
}
