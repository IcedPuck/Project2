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
    [Activity(Label = "PasswordActivity")]
    public class PasswordActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PasswordPage);
            // Create your application here
            var Back = FindViewById(Resource.Id.PasswordBack);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(CustormerPageActivity));
            };
            var OldPassword = FindViewById(Resource.Id.OldPassword);
            var ValiadtePassword = FindViewById(Resource.Id.ValidatePassword);
            var NewPassword = FindViewById(Resource.Id.NewPassword);
            var Submit = FindViewById(Resource.Id.PasspwordSubmit);
        }
    }
}