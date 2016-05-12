using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Systems;
using System.Net;
using Android.Media;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;
using System.IO;

namespace Track
{
    [Activity(Label = "Track my Track", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;
        //EditText =
        private async System.Threading.Tasks.Task<string> FetchDatabaseAsync(string url)
        {
            // Create an HTTP web request using the URL:
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            
            request.Method = "SEND";

            // Send the request to the server and wait for the response:
            var response = await request.GetRequestStreamAsync();
            {
                // Get a stream representation of the HTTP web response:
              
                   
                    // Use this stream to build a JSON document object:
                   string doc = await Task.Run(() => new StreamReader(response).ReadToEnd());
                    Console.Out.WriteLine("Response: {0}", doc.ToString());

                    // Return the JSON document:
                    return doc;
                } }
        private void ParseAndDisplay(string UsPw)
        {

        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var editTextEM = FindViewById<EditText>(Resource.Id.ETemail);
            var editTextPW = FindViewById<EditText>(Resource.Id.ETpassword);
          
 
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
             login.Click += async delegate
             {
                 // SetContentView(Resource.Layout.Menu);//takes to menu page
                 StartActivity(typeof(Track.Resources.Menu));
                 Android.Widget.Toast.MakeText(this, "Logging in!", ToastLength.Short).Show();
                 string url = "http://trackmytrack.azurewebsites.net/login.php?uname=" + editTextEM.Text + "&pwd=" + editTextPW.Text;
                 string UsPw = await FetchDatabaseAsync(url);
                 //ParseAndDisplay(UsPw);
             };
            // Takes the username and password and sends a web request with our URL, then waits for a response.
           
                
             
            editTextEM.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
              {
                  if (editTextEM.Text.Length > 0 && editTextPW.Text.Length > 0)
                    login.Enabled = true;
                 
              };
            editTextPW.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                if (editTextEM.Text.Length > 0 && editTextPW.Text.Length > 0)
                    login.Enabled = true;
                
            };
            
            }
        }

    }
    

