namespace RestaurantManager.Core.Models
{
    public interface IDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}