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

namespace Track.Resources
{
    [Activity(Label = "Menu")]
    public class Menu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ImageButton toProfile = FindViewById<ImageButton>(Resource.Id.ProfileIB);
            toProfile.Click += delegate
            {
                SetContentView(Resource.Layout.Profile);//takes to profile page
                Android.Widget.Toast.MakeText(this, "Going to your profile!", Android.Widget.ToastLength.Short).Show();
            };

            ImageButton toStopwatch = FindViewById<ImageButton>(Resource.Id.StopwIB);
            toStopwatch.Click += delegate
            {
                SetContentView(Resource.Layout.Stopwatch);//takes to stopwatch page
                Android.Widget.Toast.MakeText(this, "Going to the stopwatch!", Android.Widget.ToastLength.Short).Show();
            };

            ImageButton toTimer = FindViewById<ImageButton>(Resource.Id.TimerIB);
            toTimer.Click += delegate
            {
                SetContentView(Resource.Layout.Timer);//takes to timer page
                Android.Widget.Toast.MakeText(this, "Going to the timer!", Android.Widget.ToastLength.Short).Show();
            };

            ImageButton toSettings = FindViewById<ImageButton>(Resource.Id.Settings);
            toSettings.Click += delegate
            {
                SetContentView(Resource.Layout.Settings);//takes to settings page
                Android.Widget.Toast.MakeText(this, "Going to the settings!", Android.Widget.ToastLength.Short).Show();
            };

          
            // Create your application here
        }
    }
}