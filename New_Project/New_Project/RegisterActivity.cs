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
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText mID;
        EditText mPassword;
        EditText mAddress;
        EditText mPhone;
        EditText mEmail;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Register);


            Button clickButton1 = FindViewById<Button>(Resource.Id.Register_button);
            mID = FindViewById<EditText>(Resource.Id.id_text);
            mPassword = FindViewById<EditText>(Resource.Id.password_text);
            mAddress = FindViewById<EditText>(Resource.Id.address_text);
            mPhone = FindViewById<EditText>(Resource.Id.phone_text);
            mEmail = FindViewById<EditText>(Resource.Id.email_text);

            clickButton1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Display));
                User user = new User()
                {

                    ID = mID.Text,
                    Password = mPassword.Text,
                    Address = mAddress.Text,
                    Phone = mPhone.Text,
                    Email = mEmail.Text
                };

                intent.PutExtra("User", JsonConvert.SerializeObject(user));

                StartActivity(intent);
            };

        }
    }
}