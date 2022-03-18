using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ChartEntry = Microcharts.ChartEntry;

namespace CostAccounting
{
    public partial class MainPage : ContentPage
    {
        DatePicker datePicker; 

        
        public MainPage()
        {
            InitializeComponent();

            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now.AddDays(5),
                MinimumDate = DateTime.Now.AddDays(-5)
            };

            datePicker.DateSelected += datePicker_DateSelected;


            List<ChartEntry> entries = new List<ChartEntry>
            {
                new ChartEntry(200)
                {
                    Color = SKColor.Parse("#FF1493")
                },
                new ChartEntry(300)
                {
                    Color = SKColor.Parse("#FF2222")
                },
            };

            Chart1.Chart = new DonutChart { Entries = entries };
        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }
    }
}