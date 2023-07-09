using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyServiceDemo.DependecyServices
{
	public interface ITextToSpeech
	{
		void Speak(string text);
	}
}
