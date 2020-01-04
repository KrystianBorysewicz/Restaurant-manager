using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class MongoCRUD
    {
        //MongoClient client;
        //private IDatabaseSettings _settings;
        private IMongoDatabase db;
        private IDatabaseSettings settings;
        public MongoCRUD(IDatabaseSettings _settings) 
        {
            this.settings = _settings;
            var client = new MongoClient(this.settings.ConnectionString);
            this.db = client.GetDatabase(this.settings.DatabaseName);
        }
        public T GetOne<T>(FilterDefinition<T> filter)
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            return collection.Find(filter).FirstOrDefault();
        }
        public List<T> GetAll<T>(Filter<T> filter) where T : class, new()
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            return collection.Find(filter).ToList();
        }
        public T CreateOne<T>(T newObject)
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            collection.InsertOne(newObject);
            return newObject;
        }
    }
}
    