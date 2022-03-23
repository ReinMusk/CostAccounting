using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using ChartEntry = Microcharts.ChartEntry;

namespace CostAccounting
{
    public partial class MainPage : ContentPage
    {
        List<ChartEntry> entries = new List<ChartEntry>
        {
            new ChartEntry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                
            }
        };

        public MainPage()
        {
            InitializeComponent();

            Chart1.Chart = new DonutChart { Entries = entries };

        }
        private async void OnDosugTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNotePage(App.Database.GetCategory(2)));
        }
        public static void Save()
        {
            Category c1 = new Category
            {
                Name = "magaz"
            };

            Category c2 = new Category
            {
                Name = "film"
            };

            Category c3 = new Category
            {
                Name = "food"
            };

            Category c4 = new Category
            {
                Name = "auto"
            };

            Category c5 = new Category
            {
                Name = "health"
            };

            Category c6 = new Category
            {
                Name = "family"
            };

            App.Database.DeleteCategory(c1);

            App.Database.SaveCategory(c1);
            App.Database.SaveCategory(c2);
            App.Database.SaveCategory(c3);
            App.Database.SaveCategory(c4);
            App.Database.SaveCategory(c5);
            App.Database.SaveCategory(c6);
        }
    }
}