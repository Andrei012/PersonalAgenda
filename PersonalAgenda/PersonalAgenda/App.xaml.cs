using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using PersonalAgenda.Data;

namespace PersonalAgenda
{
    public partial class App : Application
    {
        static AgendaDatabase database;

        public static AgendaDatabase Database()
        {
            if (database == null)
            {
                database = new
               AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "Notes.db3"));
            }
            return database;
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AgendaPage());
        }
    }

}