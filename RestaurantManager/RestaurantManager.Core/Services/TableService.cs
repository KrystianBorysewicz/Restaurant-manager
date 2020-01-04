using MongoDB.Driver;
using RestaurantManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Services
{
    public class TableService
    {
        private readonly IMongoCollection<Table> _tables;
        public TableService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _tables = database.GetCollection<Table>(settings.CollectionName);
                
        }
        public T Gett<T>(IDatabaseSettings settings, FilterDefinition<T> filter)
        {
            var clientt = new MongoClient(settings.ConnectionString);
            var databaset = clientt.GetDatabase(settings.DatabaseName);
            var _tablest = databaset.GetCollection<T>(settings.CollectionName);
            return _tablest.Find(filter).FirstOrDefault();
        }
        public List<Table> GetAll() =>
            _tables.Find(table => true).ToList();
        public Table GetById(string id) =>
            _tables.Find(table => table.TableId == id).FirstOrDefault();
        public List<Table> GetByFloor(int floor) =>
            _tables.Find(table => table.Floor == floor).ToList();
        //public List<Table> GetByStatus(tableStatus status) =>
        //    _tables.Find(table => table.TableStatus == status).ToList();
        public Table Create(Table newTable)
        {
            _tables.InsertOne(newTable);
            return newTable;
        }
        public Table UpdateOne(string id, Table newTable)
        {
            _tables.ReplaceOne(table => table.TableId == id, newTable);
            return newTable;
        }
        public DeleteResult DeleteOne(string id) =>
            _tables.DeleteOne(table => table.TableId == id);
    }
}
