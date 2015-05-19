using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CS_419_App
{
    [Activity(Label = "Reuse and Recycle App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //buttons for app navigation
        Button _categories;
        Button _settings;

        //buttons to open links to Republic recycling
        Button _acceptedItems;
        Button _curbsideContainers;

        protected override void OnCreate(Bundle bundle)
        {
            //initialize everything
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            //get button objects
            _categories = FindViewById<Button>(Resource.Id.categories);
            _settings = FindViewById<Button>(Resource.Id.settings);
            _acceptedItems = FindViewById<Button>(Resource.Id.acceptedItems);
            _curbsideContainers = FindViewById<Button>(Resource.Id.curbsideContainers);

            //set button click events

        }

        //button events

    }
}

