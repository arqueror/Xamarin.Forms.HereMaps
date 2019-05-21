using Xamarin.Forms;
using Foundation;
using Xamarin.Forms.HereMaps.iOS;
using Xamarin.Forms.HereMaps.iOS.Core;

[assembly: Dependency (typeof (BaseUrl_iOS))]

namespace Xamarin.Forms.HereMaps.iOS .Core
{
	public class BaseUrl_iOS : IBaseUrl 
	{
		public string Get () 
		{
			return NSBundle.MainBundle.BundlePath;
		}
	}
}