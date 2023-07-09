using DependencyServiceDemo.DependecyServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServiceDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var service = DependencyService.Get<IPlatformMessage>();
			var message = service.GetMessage();

			await DisplayAlert("Service message", message, "Ok");
		}

		private void TextToSpeech(object sender, EventArgs e)
		{
			var service = DependencyService.Get<ITextToSpeech>();
			service.Speak("Hello world");
		}
	}
}
