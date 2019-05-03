using Android.App;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using Android.Views;
using Android.Runtime;
using Android.Widget;
using System;

namespace ListView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private List<Person> mItems;
        private AbsListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mListView = FindViewById<AbsListView>(Resource.Id.myListView);

            mItems = new List<Person>
            {
                new Person() { FirstName = "Himanshu", LastName = "Chowdhary", Age = "25", Gender = "Male" },
                new Person() { FirstName = "Adyasha", LastName = "Das", Age = "24", Gender = "Female" },
                new Person() { FirstName = "Durga", LastName = "Chowdhary", Age = "56", Gender = "Female" }
            };

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);
            
            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;
            mListView.ItemLongClick += MListView_ItemLongClick;

            mListView.ItemClick += MListView_ItemClick2;

        }

        private void MListView_ItemClick2(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine("Second click");
        }

        private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            System.Console.WriteLine(mItems[e.Position].LastName);
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            System.Console.WriteLine(mItems[e.Position].FirstName);
        }
    }
}