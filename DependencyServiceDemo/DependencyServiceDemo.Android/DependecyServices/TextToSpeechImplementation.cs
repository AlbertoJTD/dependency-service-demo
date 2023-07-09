using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using DependencyServiceDemo.DependecyServices;
using DependencyServiceDemo.Droid.DependecyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace DependencyServiceDemo.Droid.DependecyServices
{
	public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
		private TextToSpeech speaker;
		private string toSpeak;

		public void OnInit([GeneratedEnum] OperationResult status)
		{
			speaker.Speak(toSpeak, QueueMode.Flush, null, null);
		}

		public void Speak(string text)
		{
			toSpeak = text;

			if (speaker == null)
			{
				speaker = new TextToSpeech(Forms.Context, this);
			}
            else
            {
				speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
	}
}