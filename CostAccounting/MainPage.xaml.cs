using Microcharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace CostAccounting
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry()
            {
                Color = Color.White,
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
