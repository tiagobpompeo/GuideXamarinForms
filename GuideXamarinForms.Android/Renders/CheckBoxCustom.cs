using System;
using Android.Content;
using Android.Widget;
using GuideXamarinForms.CustomControls;
using GuideXamarinForms.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CheckBoxs), typeof(CheckBoxCustom))]
namespace GuideXamarinForms.Droid.Renders
{
    public class CheckBoxCustom : ViewRenderer<CheckBoxs, CheckBox>
    {
        public CheckBoxCustom(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CheckBoxs> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var control = new Android.Widget.CheckBox(this.Context)
                {
                    ScaleX = 1.4f,
                    ScaleY = 1.4f
                };
                this.SetNativeControl(control);
            }
            if (e.NewElement != null)
            {
                Control.Checked = e.NewElement.Checked;
                Control.CheckedChange += OnCheckChanged;

            }

            if (e.OldElement != null)
            {
                Control.CheckedChange -= OnCheckChanged;
            }

        }

        private void OnCheckChanged(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Element.Checked = e.IsChecked;
        }
    }
}