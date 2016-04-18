using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamTrain1
{	
	public partial class ListExample2 : ContentPage
	{	
		public ListExample2 ()
		{
			InitializeComponent ();
			createListView ();

		}

		public void createListView(){
			List<ListItem> listView = new List<ListItem> ();
			listView.Add (new ListItem(){
				Name = "Ankit",
				Age = 23
			});
			listView.Add (new ListItem(){
				Name = "Ankit",
				Age = 23
			});
			lstView.ItemsSource = listView;
		}

		public class ListItem {
			public string Name { get; set;}
			public int Age { get; set;}
		}
			
	}
}

