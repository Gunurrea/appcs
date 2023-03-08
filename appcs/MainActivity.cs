using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.DrawerLayout.Widget;
using appcs;
using System;


public class MainActivity : Activity
{
    private Button logoutButton;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetContentView(Resource.Layout.main_activity);

        logoutButton = FindViewById<Button>(Resource.Id.logoutButton);

        logoutButton.Click += LogoutButton_Click;
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        Finish();
    }
}