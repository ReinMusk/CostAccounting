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
        //List<ChartEntry> entries = new List<ChartEntry>
        //{
        //    new ChartEntry(200)
        //    {
        //        Color = SKColor.Parse("#1B93BE"),
        //
        //    },
        //};


        List<ChartEntry> entries = new List<ChartEntry>
        {
            new ChartEntry(App.Database.GetCategory(1).Sum)
            {
                Color = SKColor.Parse("#1B93BE"),
        
            },
            new ChartEntry(App.Database.GetCategory(2).Sum)
            {
                Color = SKColor.Parse("#32BEA6"),
        
            },
            new ChartEntry(App.Database.GetCategory(3).Sum)
            {
                Color = SKColor.Parse("#D01F4D"),
        
            },
            new ChartEntry(App.Database.GetCategory(4).Sum)
            {
                Color = SKColor.Parse("#E8B11B"),
        
            },
            new ChartEntry(App.Database.GetCategory(5).Sum)
            {
                Color = SKColor.Parse("#9C1738"),
        
            },
            new ChartEntry(App.Database.GetCategory(6).Sum)
            {
                Color = SKColor.Parse("#F58667"),
        
            },
        };

        public MainPage()
        {
            InitializeComponent();

            //Save();

            Chart1.Chart = new DonutChart { Entries = entries };
        }

        private async void OnMagazTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNote(App.Database.GetCategory(1)));
        }
        private async void OnDosugTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNote(App.Database.GetCategory(2)));
        }
        private async void OnFoodTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNote(App.Database.GetCategory(3)));
        }
        private async void OnAutoTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNote(App.Database.GetCategory(4)));
        }
        private async void OnHealthTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNote(App.Database.GetCategory(5)));
        }
        private async void OnFamilyTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddNote(App.Database.GetCategory(6)));
        }
        public static void Save()
        {
            Category c1 = new Category
            {
                Name = "Продукты",
                Sum = 0
            };

            Category c2 = new Category
            {
                Name = "Досуг",
                Sum = 0
            };

            Category c3 = new Category
            {
                Name = "Кафе",
                Sum = 0
            };

            Category c4 = new Category
            {
                Name = "Транспорт",
                Sum = 0
            };

            Category c5 = new Category
            {
                Name = "Здоровье",
                Sum = 0
            };

            Category c6 = new Category
            {
                Name = "Семья и дом",
                Sum = 0
            };

            //App.Database.DeleteCategory(c1);

            App.Database.SaveCategory(c1);
            App.Database.SaveCategory(c2);
            App.Database.SaveCategory(c3);
            App.Database.SaveCategory(c4);
            App.Database.SaveCategory(c5);
            App.Database.SaveCategory(c6);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}