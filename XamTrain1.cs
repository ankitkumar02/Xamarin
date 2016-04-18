using System;

using Xamarin.Forms;

namespace XamTrain1
{
	public class App : Application
	{
		public App ()
		{
			
			// The root page of your application
			MainPage = new NavigationPage(new View2ViewBinding());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

