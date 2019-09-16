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
    [Activity(Label = "PublishActivity")]
    public class PublishActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Publish);
            var Back = FindViewById(Resource.Id.PublishBack);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(HomeActivity));
            };
            // Create your application here
            var Title = FindViewById(Resource.Id.Title);
            var Description = FindViewById(Resource.Id.Description);
            var Location = FindViewById(Resource.Id.Location);
            var Deadline = FindViewById(Resource.Id.Deadline);
            var PublishSubmit = FindViewById(Resource.Id.PublishSubmit);
        }
    }
}