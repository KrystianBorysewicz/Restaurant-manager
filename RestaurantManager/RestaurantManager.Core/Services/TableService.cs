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
        }

        public List<Table> GetAll() =>
            _tables.Find(table => true).ToList();
        public Table GetById(int id) =>
            _tables.Find(table => table.tableId == id).FirstOrDefault();
        public Table Create(Table newTable)
        {
            _tables.InsertOne(newTable);
            return newTable;
        }
        public Table UpdateOne(int id, Table newTable)
        {
            _tables.ReplaceOne(table => table.tableId == id, newTable);
            return newTable;
        }
    }
}
