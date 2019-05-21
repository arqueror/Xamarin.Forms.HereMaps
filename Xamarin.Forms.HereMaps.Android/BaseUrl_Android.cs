using System;
using Xamarin.Forms;
using Xamarin.Forms.HereMaps.Android;

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace Xamarin.Forms.HereMaps.Android 
{
	public class BaseUrl_Android : IBaseUrl 
	{
		public string Get () 
		{
			return "file:///android_asset/";
		}
	}
}