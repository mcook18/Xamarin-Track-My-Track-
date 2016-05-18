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
            SetContentView(Resource.Layout.Menu);//displays to menu axml

            ImageButton toProfile = FindViewById<ImageButton>(Resource.Id.ProfileIB);
            toProfile.Click += delegate
            {
                StartActivity(typeof(Track.Resources.values.Profile));
                Android.Widget.Toast.MakeText(this, "Going to your profile!", Android.Widget.ToastLength.Short).Show();
            };

            ImageButton toStopwatch = FindViewById<ImageButton>(Resource.Id.StopwIB);
            toStopwatch.Click += delegate
            {
                StartActivity(typeof(Track.Resources.values.Stopwatch));
                Android.Widget.Toast.MakeText(this, "Going to the stopwatch!", Android.Widget.ToastLength.Short).Show();
            };

            ImageButton toTimer = FindViewById<ImageButton>(Resource.Id.TimerIB);
            toTimer.Click += delegate
            {
                StartActivity(typeof(Track.Resources.values.Timer));
                Android.Widget.Toast.MakeText(this, "Going to the timer!", Android.Widget.ToastLength.Short).Show();
            };

            //ImageButton toSettings = FindViewById<ImageButton>(Resource.Id.Settings);
            //toSettings.Click += delegate
            //{
            //    SetContentView(Resource.Layout.Settings);//takes to settings page
            //    Android.Widget.Toast.MakeText(this, "Going to the settings!", Android.Widget.ToastLength.Short).Show();
            //};
            ImageButton toAdd= FindViewById<ImageButton>(Resource.Id.AddmoreIB);
            toTimer.Click += delegate
            {
                StartActivity(typeof(Track.Resources.values.Add));
                Android.Widget.Toast.MakeText(this, "Going to the Add page!", Android.Widget.ToastLength.Short).Show();
            };

            ImageButton toRecords = FindViewById<ImageButton>(Resource.Id.RecordsIB);
            toTimer.Click += delegate
            {
                StartActivity(typeof(Track.Resources.values.Records));
                Android.Widget.Toast.MakeText(this, "Going to the Records page!", Android.Widget.ToastLength.Short).Show();
            };
            // Create your application here
        }
    }
}