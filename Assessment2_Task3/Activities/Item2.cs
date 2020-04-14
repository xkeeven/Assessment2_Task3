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
    [Activity(Label = "Item2")]
    public class Item2 : Activity
    {
        Button Back2, map2, function2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.item2);

            Back2 = FindViewById<Button>(Resource.Id.Back2);
            map2 = FindViewById<Button>(Resource.Id.map2);
            function2 = FindViewById<Button>(Resource.Id.function2);

            Back2.Click += (Sender, e) =>
            {
                Intent BackIntent2 = new Intent(this, typeof(MainMenu));
                StartActivity(BackIntent2);
            };

            map2.Click += (Sender, e) =>
            {
                Intent mapIntent2 = new Intent(this, typeof(location));
                StartActivity(mapIntent2);
            };

            function2.Click += (Sender, e) =>
            {
                Intent btnshareIntent = new Intent(this, typeof(share));
                StartActivity(btnshareIntent);
            };
        }
    }
}