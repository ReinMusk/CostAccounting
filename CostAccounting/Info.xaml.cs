using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CostAccounting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Info : ContentPage
    {
        public Info()
        {
            this.BindingContext = this;

            InitializeComponent();

            this.BindingContext = this;
        }

        protected override void OnAppearing()
        {
            List.ItemsSource = App.Database.GetCategories();
            base.OnAppearing();
        }
    }
}