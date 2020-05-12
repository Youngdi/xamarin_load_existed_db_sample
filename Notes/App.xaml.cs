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
                    var path = "";
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                        var libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
                        path = Path.Combine(libFolder, "Notes.db");
                        var pathIsExist = File.Exists(path);
                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                       path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Notes.db");

                    }

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
