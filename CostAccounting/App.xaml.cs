using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace CostAccounting
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "localCost.db";
        public static LocalRepository database;
        public static LocalRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new LocalRepository(
                    Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}