using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace notes
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date_set { get; set; }
        public DateTime Date_update { get; set; }
    }
}
