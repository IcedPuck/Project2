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
    [Activity(Label = "CustomerPageActivity")]
    public class CustomerPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var Back = FindViewById<Button>(Resource.Id.CustomerBack);
            var CustomerDetail = FindViewById<Button>(Resource.Id.CustomerDetail);
            var Password = FindViewById<Button>(Resource.Id.Password);
            var CustomerLogout = FindViewById<Button>(Resource.Id.CustomerLogout);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(MainActivity));
            };
            CustomerDetail.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CustomerDetailPageActivity));
            };
            Password.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(PasswordPageActivity));
            };
            CustomerLogout.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(LoginPageActivity));
            };

            // Create your application here
        }
    }
}