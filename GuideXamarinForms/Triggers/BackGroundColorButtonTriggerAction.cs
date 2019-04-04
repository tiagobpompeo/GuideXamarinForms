using System;
using Xamarin.Forms;

namespace GuideXamarinForms.Triggers
{
    public class BackGroundColorButtonTriggerAction : TriggerAction<Button>
    {
        protected override void Invoke(Button button)
        {
            if (button.BackgroundColor == Color.Green)
                button.BackgroundColor = Color.Red;
            else
                button.BackgroundColor = Color.Green;
        }
    }
}