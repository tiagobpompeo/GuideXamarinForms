using System;
using Xamarin.Forms;

namespace GuideXamarinForms.CustomControls
{
    public class ImageCustomRender : Image
    {
        public static readonly BindableProperty TipoProperty = BindableProperty.Create(nameof(Tipo), typeof(string), typeof(ImageCustomRender), string.Empty);//regra
        public static readonly BindableProperty ValorProperty = BindableProperty.Create(nameof(ValorSaida), typeof(string), typeof(ImageCustomRender), string.Empty);//regra

        public string Tipo
        {
            get { return (string)GetValue(TipoProperty); }
            set { SetValue(TipoProperty, value); }
        }

        public string ValorSaida
        {
            get { return (string)GetValue(ValorProperty); }
            set { SetValue(ValorProperty, value); }
        }
    }
}
