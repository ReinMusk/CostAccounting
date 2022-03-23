using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Essentials;

namespace CostAccounting
{
    [Table("Items")]
    public class Item
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [Indexed]
        public int CategoryId { get; set; }
        public float Sum { get; set; }
        public DateTime Date { get; set; }


        public Item()
        {

        }
    }
}