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
    [Activity(Label = "SignUp")]
    public class SignUp : Activity
    {
        Button btnConfirm;
        EditText etFirstName;
        EditText etLastName;
        EditText etPhone;
        EditText etAddress;
        EditText etCountry;
        EditText etPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SignUp);

            btnConfirm = FindViewById<Button>(Resource.Id.btnConfirm);
            etFirstName = FindViewById<EditText>(Resource.Id.etFirstName);
            etLastName = FindViewById<EditText>(Resource.Id.etLastName);
            etPhone = FindViewById<EditText>(Resource.Id.etPhone);
            etAddress = FindViewById<EditText>(Resource.Id.etAddress);
            etCountry = FindViewById<EditText>(Resource.Id.etCountry);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);


            btnConfirm.Click += (Sender, e) =>
            {
                Intent LoginIntent = new Intent(this, typeof(Login));
                StartActivity(LoginIntent);
            };

            // Create your application here
        }
    }
}