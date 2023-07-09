using DependencyServiceDemo.DependecyServices;
using DependencyServiceDemo.iOS.DependecyServices;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSMessage))]
namespace DependencyServiceDemo.iOS.DependecyServices
{
	internal class iOSMessage : IPlatformMessage
	{
		public string GetMessage()
		{
			return "Hello from iOS Platform";
		}
	}
}