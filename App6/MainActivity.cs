using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace App6
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView textNumber;
        int number;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            textNumber = FindViewById<TextView>(Resource.Id.textView1);          
            FindViewById<Button>(Resource.Id.button1).Click += (o, e) =>
                {
                    textNumber.Text = (++number).ToString();
                    

                };
            FindViewById<TextView>(Resource.Id.textView1).TextChanged += (o, e) =>
            {
                FindViewById<Button>(Resource.Id.button1).Text = "Go to this Number "+(1 + Convert.ToInt32(textNumber.Text)).ToString();
                FindViewById<Button>(Resource.Id.button2).Text = "Go to this Number "+(Convert.ToInt32(textNumber.Text)-1).ToString();
            };
            
            FindViewById<Button>(Resource.Id.button2).Click += (o, e) =>
            {
                textNumber.Text = (--number).ToString();
                
                
            };
            FindViewById<Button>(Resource.Id.button3).Click += (o, e) =>
            {                
                FindViewById<TextView>(Resource.Id.textView1).Text = 0.ToString();
                number = 0;
                FindViewById<Button>(Resource.Id.button1).Text = "Go Up";
                FindViewById<Button>(Resource.Id.button2).Text = "Go Down";
            };
        }
    }
}