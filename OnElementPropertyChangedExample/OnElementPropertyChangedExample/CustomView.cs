using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OnElementPropertyChangedExample
{
    public class CustomView : View
    {
        public Color CustomBackgroundColor
        {
            get
            {
                return (Color)GetValue(CustomBackgroundColorProperty); 
            }
            set
            {
                SetValue(CustomBackgroundColorProperty, value);
            }
        }
        public BindableProperty CustomBackgroundColorProperty = BindableProperty.Create("CustomBackgroundColor", typeof(Color), typeof(CustomView), Color.Transparent);
    }
}
