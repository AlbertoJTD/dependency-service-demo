using AVFoundation;
using DependencyServiceDemo.DependecyServices;
using DependencyServiceDemo.iOS.DependecyServices;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace DependencyServiceDemo.iOS.DependecyServices
{
	internal class TextToSpeechImplementation : ITextToSpeech
	{
		public void Speak(string text)
		{
			var speechSynthesizer = new AVSpeechSynthesizer();
			var speechUtterance = new AVSpeechUtterance(text)
			{
				Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
				Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
				Volume = 0.5f,
				PitchMultiplier = 1.0f
			};

			speechSynthesizer.SpeakUtterance(speechUtterance);
		}
	}
}