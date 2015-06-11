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
	[Activity (Label = "Categories", Icon = "@drawable/icon")]			
	public class Categories : ListActivity
	{
		string[] items;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			items = new string[] { "Appliances","Books","Cell Phones","Food","Furniture","Home Electronics","Office Equipment","Vehicles" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
		}

		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			//get text that was clicked on
			var item = items[position];

			//change to appropriate view
			StartActivity(typeof(Companies));


		}
	}
}