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

namespace Assessment2_Task3
{
    [Activity(Label = "MainMenu")]
    public class MainMenu : Activity
    {
        TextView username;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            username = FindViewById<TextView>(Resource.Id.lblDear);
            username.Text = Intent.GetStringExtra("AccName");


            // Create your application here
        }
    }
}