using System;
using SaturdayMP.XPlugins.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using GuideXamarinForms.CustomControls;
using GuideXamarinForms.iOS.Renders;

[assembly: ExportRenderer(typeof(CheckBoxs), typeof(CheckBoxRenderer))]
namespace GuideXamarinForms.iOS.Renders
{
    public class CheckBoxRenderer : ViewRenderer<CheckBoxs, BEMCheckBox>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CheckBoxs> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var checkBox = new BEMCheckBox();
                ConfigStyle(checkBox);

                SetNativeControl(checkBox);
            }

            if (e.NewElement != null)
            {
                Control.On = e.NewElement.Checked;
                Control.ValueChanged += OnCheckChanged;
            }

            if (e.OldElement != null)
            {
                Control.ValueChanged -= OnCheckChanged;
            }
        }

        private static void ConfigStyle(BEMCheckBox checkBox)
        {
            var checkboxColor = Color.Green.ToUIColor();
            checkBox.BoxType = BEMBoxType.Square;
            checkBox.OnAnimationType = BEMAnimationType.Fill;
            checkBox.OffAnimationType = BEMAnimationType.Fill;
            checkBox.AnimationDuration = 0.2f;
            checkBox.OnFillColor = checkboxColor;
            checkBox.OnTintColor = checkboxColor;
            checkBox.OnCheckColor = Color.White.ToUIColor();
        }

        private void OnCheckChanged(object sender, EventArgs e)
            => Element.Checked = Control.On;
    }
}