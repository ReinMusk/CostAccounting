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
        List<ChartEntry> entries = new List<ChartEntry>
        {
            new ChartEntry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "January",
                ValueLabel = "200"
            }
        };
        public MainPage()
        {
            InitializeComponent();

            Chart1.Chart = new DonutChart { Entries = entries };
        }
    }
}
