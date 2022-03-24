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
            database.CreateTable<Category>();
            database.CreateTable<ViewItem>();
            

            //database.DropTable<Item>();
            //database.DropTable<Category>();
            //database.DropTable<ViewItem>();

        }
        public IEnumerable<ViewItem> GetViewItems()
        {
            return database.Table<ViewItem>().ToList();
        }
        public ViewItem GetViewItem(int id)
        {
            return database.Get<ViewItem>(id);
        }

        public int SaveViewItem(ViewItem item)
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

        public int DeleteCategory(int id)
        {
            return database.Delete<Category>(id);
        }

        public int DeleteCategory(Category cat)
        {
            return database.Delete<Category>(cat.Id);
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