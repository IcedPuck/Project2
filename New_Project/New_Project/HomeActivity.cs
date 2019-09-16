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
    [Activity(Label = "LoginPageActivity")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            // Create your application here
            var Add = FindViewById(Resource.Id.AddButton);
            var Customer = FindViewById(Resource.Id.CustomerButton);
            Add.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(PublishActivity));
            };
            Customer.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CustormerPageActivity));
            };
        }
    }
}