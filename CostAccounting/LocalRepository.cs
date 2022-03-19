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

        public IEnumerable<Category> GetCategories()
        {
            return database.Table<Category>().ToList();
        }
        public Category GetCategory(int id)
        {
            return database.Get<Category>(id);
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

        public int SaveCategory(Category category)
        {
            if (category.Id != 0)
            {
                database.Update(category);
                return category.Id;
            }
            else
            {
                return database.Insert(category);
            }
        }
    }
}