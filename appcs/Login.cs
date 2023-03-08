using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appcs
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        private EditText usernameEditText;
        private EditText passwordEditText;
        private Button loginButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login_activity);

            usernameEditText = FindViewById<EditText>(Resource.Id.usernameEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
            loginButton = FindViewById<Button>(Resource.Id.loginButton);

            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameEditText.Text;
            string password = passwordEditText.Text;

            if (username == "admin" && password == "admin123")
            {
                StartActivity(typeof(MainActivity));
            }
            else
            {
                Toast.MakeText(this, "Usuario o contraseña invalidos", ToastLength.Short).Show();
            }
        }
    }
}