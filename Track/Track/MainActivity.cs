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
            var editTextEM = FindViewById<EditText>(Resource.Id.ETemail);
            var editTextPW = FindViewById<EditText>(Resource.Id.ETpassword);
            var textView = FindViewById<TextView>(Resource.Id.textView);
            var textView2 = FindViewById<TextView>(Resource.Id.textView);
            var Changed = false;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button signUp = FindViewById<Button>(Resource.Id.SignupButton);
            signUp.Click += delegate{
                // SetContentView(Resource.Layout.SignUp);//displays signup page axml
                StartActivity(typeof(Track.Resources.SignUp));
                Android.Widget.Toast.MakeText(this, "Signing up!", Android.Widget.ToastLength.Short).Show(); //shows text for signing up
            };

            Button login = FindViewById<Button>(Resource.Id.LoginButton);
            login.Enabled = false;
             login.Click += delegate {
                if (Changed==true)
                // SetContentView(Resource.Layout.Menu);//takes to menu page
                StartActivity(typeof(Track.Resources.Menu));
                    Android.Widget.Toast.MakeText(this, "Logging in!", Android.Widget.ToastLength.Short).Show();
            
            };
            // I am seeing if we can get the edit text boxes set up and running before I write the PHP
           
            editTextEM.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
              {
                  Changed = true;
                  login.Enabled = true;
                  textView.Text = e.Text.ToString();
              };
            editTextPW.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                textView2.Text = e.Text.ToString();
            };

        }
    }
}

