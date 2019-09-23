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
    class User
    {

        public string ID { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
    }
}