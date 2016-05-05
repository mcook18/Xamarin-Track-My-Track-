using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

            Button startSW = FindViewById<Button>(Resource.Id.StartStopBT);

            Stopwatch stopwatch = new Stopwatch();
            //stopwatch.

            // Create your application here
        }
    }
}