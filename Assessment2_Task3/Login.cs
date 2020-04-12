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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class Login : Activity
    {
        Button btnLogin;
        Button btnSignUp;
        EditText etAccName;
        EditText etPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            etAccName = FindViewById<EditText>(Resource.Id.etAccName);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            btnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            btnLogin.Click += (Sender, e) =>
            {
                Intent MainMenuIntent = new Intent(this, typeof(MainMenu));
                MainMenuIntent.PutExtra("AccName", etAccName.Text);
                MainMenuIntent.PutExtra("Password", etPassword.Text);
                StartActivity(MainMenuIntent);
            };

            btnSignUp.Click += (Sender, e) =>
            {
                Intent RegisterIntent = new Intent(this, typeof(SignUp));
                StartActivity(RegisterIntent);
            };

            // Create your application here
        }
    }
}