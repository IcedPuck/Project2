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
    [Activity(Label = "CoustomerDatailPageActivity")]
    public class CoustomerDatailPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CoustomerDetailPage);
            // Create your application here
            var Back = FindViewById(Resource.Id.CustomerDetailBack);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CustormerPageActivity));
            };
            var Save = FindViewById(Resource.Id.CustomerDetailSave);
            Save.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CustormerPageActivity));
            };
        }
    }
}