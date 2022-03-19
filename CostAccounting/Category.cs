using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CostAccounting
{
    [Table("Categories")]
    public class Category
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {

        }
    }
}
