using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Track
{
    [Activity(Label = "Track my Track", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       //int count = 1;
        //EditText = 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button login = FindViewById<Button>(Resource.Id.LoginButton);
            Android.Widget.Toast.MakeText(this, "Logging in!", Android.Widget.ToastLength.Short).Show();
            login.Click += delegate {
                SetContentView(Resource.Layout.Menu);//takes to menu page
            };

            Button signUp = FindViewById<Button>(Resource.Id.SignupButton);
            Android.Widget.Toast.MakeText(this, "Signing up!", Android.Widget.ToastLength.Short).Show(); //shows text for signing up
            signUp.Click += delegate
            {
                SetContentView(Resource.Layout.SignUp);//takes to signup page
            };
            
        }
    }
}

