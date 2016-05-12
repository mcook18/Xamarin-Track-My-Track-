using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Track.Resources.values
{
    [Activity(Label = "Stopwatch")]
    public class Stopwatch : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Stopwatch);//displays stopwatch axml
            bool on = false;//check for stopwatch working
            bool onCH = false; //check for chronometer working

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();//intializing to the stopwatch class
            Chronometer CH = FindViewById<Chronometer>(Resource.Id.chronometerS);//set the chronometer

            Button startSW = FindViewById<Button>(Resource.Id.StartStopBT);
            startSW.Click += delegate {
                stopWatch.Start();
                on = true;
                CH.Start();
                onCH = true;

            };

            Button pauseSW = FindViewById<Button>(Resource.Id.LapTimeBT);
            pauseSW.Click += delegate
            {
                if (on == true && onCH == true)
                {
                    
                    CH.Stop();
                }

            };
            Button stopSW = FindViewById<Button>(Resource.Id.StopB);
            stopSW.Click += delegate
            {
                if (on == true && onCH == true)
                {
                    stopWatch.Stop();
                    CH.Stop();
                }




            };

          
            //stopwatch.

            // Create your application here
        }
    }
}