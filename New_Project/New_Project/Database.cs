using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace New_Project
{
    class Database
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public string Deadline { get; set; }
        public Database()
        {

        }
        public Database(string title, string location, string deadline)
        {
            Title = title;
            Location = location;
            Deadline = deadline;
        }
        public override string ToString()
        {
            return Title + ", " + Location + ", " + Deadline;
        }
    }
}