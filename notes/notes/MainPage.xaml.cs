﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using notes.data;

namespace notes
{
    public partial class MainPage : ContentPage
    {
        public List<Note> list = new List<Note>();
        public MainPage(NoteDatabase database)
        {
            InitializeComponent();
            Note note = new Note
            {
                Name = "Nakup",
                Text = "koupit krocana"
            };
            database.SaveNoteAsync(note);

            list = database.GetNotesAsync().Result;
            foreach(Note kok in list)
            {
                Console.WriteLine(kok.Name);
            }



        }
    }
}
