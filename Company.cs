
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
using Android.Graphics;
using System.Net;

namespace CS419App
{
	[Activity (Label = "Company", Icon = "@drawable/icon")]			
	public class Company : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//initialize everything
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Company);

			//fields to fill in
			ImageView companyMap = FindViewById<ImageView> (Resource.Id.companyMap);	
			string address = "";
			var imageBitmap = GetImageBitmapFromUrl("https://maps.googleapis.com/maps/api/staticmap?center=" + address + "&zoom=13&size=600x300&maptype=roadmap");
			companyMap.SetImageBitmap(imageBitmap);

			TextView companyName = FindViewById<TextView> (Resource.Id.companyName);
			Button goToSite = FindViewById<Button> (Resource.Id.goToSite);
			TextView companyAddress = FindViewById<TextView> (Resource.Id.companyAddress);
			TextView companyPhone = FindViewById<TextView> (Resource.Id.companyPhone);
			TextView companyHours = FindViewById<TextView> (Resource.Id.companyHours);
		}

		private Bitmap GetImageBitmapFromUrl(string url)
		{
			Bitmap imageBitmap = null;

			using (var webClient = new WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}

			return imageBitmap;
		}
	}
}

