using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CostAccounting
{
    [Table("ViewItems")]
    public class ViewItem
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Sum { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
    }
}
