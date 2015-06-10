using System;

using Xamarin.Forms;

namespace CS419App
{
	public class Settings1 : ContentPage
	{
		public Settings1 ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


