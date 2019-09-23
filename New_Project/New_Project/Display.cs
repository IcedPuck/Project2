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
using Newtonsoft.Json;


namespace New_Project
{
    [Activity(Label = "Display")]
    public class Display : Activity
    {
        TextView nID;
        TextView nPassword;
        TextView nAddress;
        TextView nPhone;
        TextView nEmail;
        User mInformation;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Display);
            // Create your application here

            var Login1 = FindViewById(Resource.Id.Login);
            Login1.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(HomeActivity));
            };

            nID = FindViewById<TextView>(Resource.Id.txt_id);
            nPassword = FindViewById<TextView>(Resource.Id.txt_password);
            nAddress = FindViewById<TextView>(Resource.Id.txt_address);
            nPhone = FindViewById<TextView>(Resource.Id.txt_phone);
            nEmail = FindViewById<TextView>(Resource.Id.txt_email);


            mInformation = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            nID.Text = mInformation.ID;
            nPassword.Text = mInformation.Password;
            nAddress.Text = mInformation.Address;
            nPhone.Text = mInformation.Phone;
            nEmail.Text = mInformation.Email;

            
        }
    }
}