using notes.data;
using System;
using System.IO;
using Xamarin.Forms;

namespace notes
{
    public partial class App : Application
    {
        public static NoteDatabase CreatedDB;
        static NoteDatabase database;
        public App()
        {
            InitializeComponent();

            if (database == null)
            {
                CreatedDB = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
            }

            MainPage = new MainPage(CreatedDB);
        }
       
    }
}
