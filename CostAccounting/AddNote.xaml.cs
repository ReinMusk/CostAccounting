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
    public partial class AddNote : ContentPage
    {
        public Category Category { get; set; }
        public AddNote(Category category)
        {
            InitializeComponent();

            title.Text = category.Name;
            Category = category;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            

        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Sum = float.Parse(sum_txt.Text),
                CategoryId = Category.Id,
                Date = DateTime.Now,
            };

            App.Database.SaveItem(item);

            ViewItem viewItem = new ViewItem
            {
                Sum = sum_txt.Text,
                Category = App.Database.GetCategory(item.Id).Name,
                Date = item.Date,
            };
            

            Category.Sum += item.Sum;
            
            App.Database.SaveViewItem(viewItem);
            App.Database.SaveCategory(Category);

            await Navigation.PushAsync(new MainPage());
        }
    }
}