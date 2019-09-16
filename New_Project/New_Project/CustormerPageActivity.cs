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
    [Activity(Label = "CustormerPageActivity")]
    public class CustormerPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CustomerPage);
            // Create your application here
            var Back = FindViewById(Resource.Id.CustomerBack);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(HomeActivity));
            };
            var CustomerDeatail = FindViewById(Resource.Id.CustomerDetail);
            var Password = FindViewById(Resource.Id.Password);
            var Task = FindViewById(Resource.Id.Task);
            var Logout = FindViewById(Resource.Id.Logout);
            CustomerDeatail.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CoustomerDatailPageActivity));
            };
            Password.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(PasswordActivity));
            };
            //Task.Click += (object sender, System.EventArgs e) =>
            //{
            //    this.StartActivity(typeof());
            //};
            Logout.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(MainActivity));
            };
        }
    }
}