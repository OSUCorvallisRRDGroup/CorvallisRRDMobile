﻿
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

namespace CS419App
{
	[Activity (Label = "Settings")]			
	public class Settings : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//initialize everything
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Settings);






		}
	}
}

