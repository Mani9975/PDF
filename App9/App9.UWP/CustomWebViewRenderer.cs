using App9;
using App9.UWP;
using System;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace App9.UWP
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Source = new Uri(string.Format("ms-appx-web:///Assets/pdfjs/web/viewer.html?file={0}", string.Format("ms-appx-web:///Assets/Content/{0}", WebUtility.UrlEncode(customWebView.Uri))));
            }
        }
    }
}

