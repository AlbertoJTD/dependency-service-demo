using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyServiceDemo.DependecyServices;
using DependencyServiceDemo.Droid.DependecyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidMessage))]
namespace DependencyServiceDemo.Droid.DependecyServices
{
	public class AndroidMessage : IPlatformMessage
	{
		public string GetMessage()
		{
			return "Hello from Android Platform";
		}
	}
}