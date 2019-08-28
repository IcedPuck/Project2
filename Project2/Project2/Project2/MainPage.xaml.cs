﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Project2
{
    public partial class MainPage : ContentPage
    {
        public IList<Task> Tasks { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Tasks = new List<Task>();
            Tasks.Add(new Task
            {
                Name = "Task 1",
                Location = "Australia",
                Customer = "Chris"
            });
            Tasks.Add(new Task
            {
                Name = "Task 2",
                Location = "Japan",
                Customer = "Frank"
            });
            Tasks.Add(new Task
            {
                Name = "Task 3",
                Location = "Australia",
                Customer = "Ocean"
            });
            Tasks.Add(new Task
            {
                Name = "Task 4",
                Location = "China",
                Customer = "Mark"
            });
            Tasks.Add(new Task
            {
                Name = "Task 5",
                Location = "Britain",
                Customer = "Arthur"
            });
            BindingContext = this;
        }
        void OnHomePageClicked(object sender, EventArgs e)
        {
        }
        void OnAddTaskPageClicked(object sender, EventArgs e)
        {
        }
        void OnCustomerPageClicked(object sender, EventArgs e)
        {
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
