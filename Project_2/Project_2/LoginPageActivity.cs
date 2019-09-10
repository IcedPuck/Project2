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
    [Activity(Label = "LoginPageActivity")]
    public class LoginPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var Login = FindViewById<Button>(Resource.Id.Login);
            Login.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(MainActivity));
            };
            // Create your application here
        }
    }
}