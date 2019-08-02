using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AutoFitSample
{
    public class ExtScrollView : ScrollView
    {
        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            (this.Content as StackLayout).Children[2].HeightRequest = height;
            base.LayoutChildren(x, y, width, height);
        }

    }
}
