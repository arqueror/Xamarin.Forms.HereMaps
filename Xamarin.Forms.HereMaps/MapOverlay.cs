using Xamarin.Forms;

namespace Xamarin.Forms.HereMaps
{
    public interface IBaseUrl { string Get(); }

    public class MapOverlay : ContentPage
    {
        public MapOverlay()
        {
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
<head>
    <meta name='viewport' content='initial-scale =1.0, width = device - width' />
            <script src = 'mapsjs-core.js'
            type= 'text/javascript' charset= 'utf-8'></script>
  
      <script src ='mapsjs-service.js'
            type ='text/javascript' charset ='utf-8'></script>
  </head>
<body>
    <div style='width:100%;height:100%' id='mapContainer'></div>
    <script>

            
                    // Initialize the platform object:
                    var platform = new H.service.Platform({
                    'app_id': 'ChvFIQFI5V4DMUUP1Vi1',
                    'app_code': 'MGIlBIYjv2eSp8JL4D8UMA',
                    useHTTPS: true
                });

                // Obtain the default map types from the platform object
                var maptypes = platform.createDefaultLayers();

                // Instantiate (and display) a map object:
                var map = new H.Map(
                    document.getElementById('mapContainer'),
                    maptypes.normal.map,
                    {
                        zoom: 10,
                        center: { lng: 13.4, lat: 52.51 }
                    });

             

            </script>
</body>
</html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;
            browser.HorizontalOptions = LayoutOptions.Fill;
            browser.VerticalOptions = LayoutOptions.Fill;

            Grid mainContainer = new Grid();
            mainContainer.Children.Add(browser);
            mainContainer.Padding = new Thickness(0);
            Content = mainContainer;
        }
    }
}
