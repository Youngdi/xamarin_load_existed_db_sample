using System;
using System.IO;
using Xamarin.Forms;
using Notes.Data;


namespace Notes
{
    public partial class App : Application
    {
        static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Notes.db");
                    var pathIsExist = File.Exists(path);
                    Console.WriteLine(pathIsExist);
                    Console.WriteLine("OOXX-222");

                    database = new NoteDatabase(path);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
