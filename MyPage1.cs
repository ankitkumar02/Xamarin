using System;

using Xamarin.Forms;

namespace XamTrain1
{
	public class MyPage1 : ContentPage
	{
		Label lblMessage;
		int iClickCount =0;
		public MyPage1 ()
		{
			lblMessage = new Label ();
			Button btnExample = new Button { Text = "Ankit Click me" , HeightRequest = 40, BackgroundColor = Color.Black};
			Button btnNext = new Button { Text = "Next" };
			btnNext.Clicked += OnNextButtonClick;
			btnExample.Clicked += OnButtonClick;
			var vMainStack = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "UI interaction", XAlign = TextAlignment.Center },
					//new Label { Text = "UI interaction2", },
					lblMessage, btnExample, btnNext
				}
			};
			Content = vMainStack;
		}

		public void OnButtonClick(object sender, EventArgs args){
			iClickCount++;
			lblMessage.Text = "Clicked button" + iClickCount.ToString () + "times";
		}
		public void OnNextButtonClick(object sender, EventArgs args){
			Navigation.PushAsync (new GridPage ());
		}
	}
}


