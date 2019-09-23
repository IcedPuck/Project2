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
    [Activity(Label = "PublishActivity")]
    public class PublishActivity : Activity
    {
    
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Publish);
            

            //path
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbTest.db3");
            EditText title = FindViewById<EditText>(Resource.Id.Title);
            EditText location = FindViewById<EditText>(Resource.Id.Location);
            EditText deadline = FindViewById<EditText>(Resource.Id.Deadline);

            var Back = FindViewById(Resource.Id.PublishBack);
            Back.Click += (object sender, System.EventArgs e) =>
            {
                this.StartActivity(typeof(HomeActivity));
            };

            // Create your application here
            var Submit = FindViewById(Resource.Id.PublishSubmit);
            Submit.Click += (object sender, EventArgs e) =>
            {
                var Title = title.Text;
                var Location = location.Text;
                var Deadline = deadline.Text;
                //database
                var database = new SQLiteConnection(dbPath);
                //change screen
                database.CreateTable<Database>();
                Database database1 = new Database(Title, Location, Deadline);
                database.Insert(database1);

                this.StartActivity(typeof(HomeActivity));
            };

        }
    }
}