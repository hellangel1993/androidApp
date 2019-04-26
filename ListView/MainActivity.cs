using Android.App;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using Android.Views;
using Android.Runtime;
using Android.Widget;

namespace ListView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private List<string> mItems;
        private AbsListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mListView = FindViewById<AbsListView>(Resource.Id.myListView);

            mItems = new List<string>();
            mItems.Add("Himanshu");
            mItems.Add("James");
            mItems.Add("Sonu");

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            string indexecrTest = adapter.mItems[1];
            mListView.Adapter = adapter;

        }
    }
}