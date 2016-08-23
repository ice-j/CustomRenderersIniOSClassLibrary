using OnElementPropertyChangedExample;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace OnElementPropertyChangedCustomRenderers
{
    public class CustomViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
                SetNativeControl(new UIView());
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "CustomBackgroundColor")
                Control.BackgroundColor = (Element as CustomView).CustomBackgroundColor.ToUIColor();
        }
    }
}
