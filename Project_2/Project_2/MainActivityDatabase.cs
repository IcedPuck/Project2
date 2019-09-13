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

namespace Project_2
{
    class MainActivityDatabase
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string TaskName { get; set; }
        public MainActivityDatabase(string name, string phone, string task)
        {
            Name = name;
            PhoneNumber = phone;
            TaskName = task;
        }
        public MainActivityDatabase()
        {

        }
        public override string ToString()
        {
            return Name + "  " + PhoneNumber + "  " + TaskName;
        }
    }
}