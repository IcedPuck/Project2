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
    [Activity(Label = "PublishActivity")]
    public class PublishActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var Back = FindViewById<Button>(Resource.Id.Back);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(MainActivity));
            };
            var PublishSubmit = FindViewById<Button>(Resource.Id.PublishSubmit);
        }
    }
}