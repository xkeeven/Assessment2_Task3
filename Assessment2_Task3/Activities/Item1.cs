﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Assessment2_Task3.Activities;

namespace Assessment2_Task3
{
    [Activity(Label = "Item1")]
    public class Item1 : Activity
    {
        Button Back1,map1,function1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.item1);

            Back1 = FindViewById<Button>(Resource.Id.Back1);
            map1 = FindViewById<Button>(Resource.Id.map1);
            function1 = FindViewById<Button>(Resource.Id.function1);

            Back1.Click += (Sender, e) =>
            {
                Intent BackIntent1 = new Intent(this, typeof(MainMenu));
                StartActivity(BackIntent1);
            };

            map1.Click += (Sender, e) =>
            {
                Intent mapIntent1 = new Intent(this, typeof(location));
                StartActivity(mapIntent1);
            };

            function1.Click += (Sender, e) =>
            {
                Intent btnshareIntent = new Intent(this, typeof(share));
                StartActivity(btnshareIntent);
            };
        }
    }
}