using System.Collections.Generic;
using SQLite;

namespace CostAccounting
{
    public class LocalRepository
    {
        SQLiteConnection database;
        public LocalRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Item>();
        }
        public IEnumerable<Item> GetItems()
        {
            return database.Table<Item>().ToList();
        }
        public Item GetItem(int id)
        {
            return database.Get<Item>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Item>(id);
        }
        public int SaveItem(Item item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}