using MongoDB.Bson;
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
        /// <summary>
        /// Returns all objects of type "T" found in the db where filter conditions are met.
        /// </summary>
        /// <typeparam name="T">Type of objects to return / search for</typeparam>
        /// <param name="filters"></param>
        /// <returns></returns>
        public List<T> GetAll<T>(Dictionary<string, object> filters) where T : class, new()
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            FilterDefinition<T> filter = FilterDefinition<T>.Empty;
            foreach (var x in filters)
            {
                if (typeof(T).GetProperty(x.Key) != null)
                    filter &= Builders<T>.Filter.Eq(x.Key, x.Value.ToString());
            }
            return collection.Find(filter).ToList();
        }
        public T CreateOne<T>(T newObject)
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            collection.InsertOne(newObject);
            return newObject;
        }
        public T DeleteOne<T>(T newObject)
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            FilterDefinition<T> filter = FilterDefinition<T>.Empty;
            var properties = typeof(T).GetProperties();
            foreach(var p in properties)
            {
                var v = newObject.GetType().GetProperty(p.Name).GetValue(newObject, null);
                if(v != null)
                    filter &= Builders<T>.Filter.Eq(p.Name, v);
            }
            collection.DeleteOne(filter);
            return newObject;
        }
        public T DeleteAll<T>(T newObject)
        {
            var collection = this.db.GetCollection<T>(this.settings.CollectionName);
            FilterDefinition<T> filter = FilterDefinition<T>.Empty;
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                var v = newObject.GetType().GetProperty(p.Name).GetValue(newObject, null);
                if (v != null)
                    filter &= Builders<T>.Filter.Eq(p.Name, v);
            }
            collection.DeleteMany(filter);
            return newObject;
        }
    }
}
    