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
using System.Collections;
using System.IO;
using SQLite;

namespace New_Project
{
    [Activity(Label = "LoginPageActivity")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //path
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbTest.db3");
            base.OnCreate(bundle);
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

            //ListView Add
            Button Loading = FindViewById<Button>(Resource.Id.Loading);
            Loading.Click += delegate
            {
                TextView displayListView = FindViewById<TextView>(Resource.Id.listView1);
                var db = new SQLiteConnection(dbPath);

                var table = db.Table<Database>();
                foreach (var item in table)
                {
                    Database database = new Database(item.Title, item.Location, item.Deadline);
                    displayListView.Text += database + "\n";
                }
            };

        }
    }
}