﻿using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;

namespace New_Project
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LoginPage);
            var Login = FindViewById(Resource.Id.Login);
            Login.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(HomeActivity));
            };
             var Reg = FindViewById(Resource.Id.Reg);
             Reg.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(RegisterActivity));
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}