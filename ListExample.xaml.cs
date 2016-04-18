using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamTrain1
{	
	public partial class ListExample : ContentPage
	{	
		public ListExample()
		{
			InitializeComponent ();

			this.BindingContext = new [] { "a", "b", "c" , "d", "e"};
		}

		void OnItemTapped (object sender, ItemTappedEventArgs e) {
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			((ListView)sender).SelectedItem = null; // de-select the row
		}
	}
}