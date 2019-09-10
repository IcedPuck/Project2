﻿using System;
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
    [Activity(Label = "CustomerDetailPageActivity")]
    public class CustomerDetailPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var CustomerDetailPageBack = FindViewById<Button>(Resource.Id.CustomerDetailBack);
            var CustomerDetailPageSave = FindViewById<Button>(Resource.Id.CustomerDetailSave);
            CustomerDetailPageBack.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CustomerPageActivity));
            };
        }
    }
}