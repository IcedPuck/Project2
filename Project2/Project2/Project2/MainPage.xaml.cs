using System;
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
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Task selectedItem = e.SelectedItem as Task;
        }
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Task TappedItem = e.Item as Task;
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

        private void SearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
        }
    }
}
