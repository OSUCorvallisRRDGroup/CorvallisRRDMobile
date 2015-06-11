using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CS419App
{
	[Activity (Label = "Corvallis Reuse and Repair Directory", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//initialize everything
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			//buttons on form
			Button categories = FindViewById<Button> (Resource.Id.categories);	
			Button settings = FindViewById<Button> (Resource.Id.settings);	
			Button allaccepted = FindViewById<Button> (Resource.Id.allaccepted);	
			Button curbside = FindViewById<Button> (Resource.Id.curbside);	

			//hook up button click events
			categories.Click += delegate {  
				StartActivity(typeof(Categories));
			};
			settings.Click += delegate {  
				StartActivity(typeof(Settings));
			};
			allaccepted.Click += delegate {
				var uri = Android.Net.Uri.Parse ("http://site.republicservices.com/site/corvallis-or/en/documents/corvallisrecycledepot.pdf");
				var intent = new Intent (Intent.ActionView, uri); 
				StartActivity (intent);     
			};
			curbside.Click += delegate {
				var uri = Android.Net.Uri.Parse ("http://site.republicservices.com/site/corvallis-or/en/documents/detailedrecyclingguide.pdf");
				var intent = new Intent (Intent.ActionView, uri); 
				StartActivity (intent);     
			};
		}
	}
}


