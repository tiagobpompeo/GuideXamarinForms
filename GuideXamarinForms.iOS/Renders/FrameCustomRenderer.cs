using System;
using CoreGraphics;
using GuideXamarinForms.CustomRenders;
using GuideXamarinForms.iOS.Renders;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(FrameCustom), typeof(FrameCustomRenderer))]
namespace GuideXamarinForms.iOS.Renders
{
    public class FrameCustomRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            // Update shadow to match better material design standards of elevation
            Layer.ShadowColor = UIColor.LightGray.CGColor;
            Layer.CornerRadius = 2;
            Layer.MasksToBounds = false;
            Layer.ShadowOffset = new CGSize(-2, 0);
            Layer.ShadowRadius = 5;
            Layer.ShadowOpacity = 0.4f;

            //Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;

        }
    }
}