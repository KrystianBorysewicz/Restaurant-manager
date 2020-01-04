using MongoDB.Driver;
using RestaurantManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Services
{
    public class ClassService
    {
        MongoClient client;
        IDatabaseSettings _settings;
        public ClassService(IDatabaseSettings settings)
        {
            this._settings = settings;

        }
        public T Get<T>(IDatabaseSettings settings, FilterDefinition<T> filter)
        {
            var clientt = new MongoClient(settings.ConnectionString);
            var databaset = clientt.GetDatabase(settings.DatabaseName);
            var _tablest = databaset.GetCollection<T>(settings.CollectionName);
            return _tablest.Find(filter).FirstOrDefault();
        }
    }
}
