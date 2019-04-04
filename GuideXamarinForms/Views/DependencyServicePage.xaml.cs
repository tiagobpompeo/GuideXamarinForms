using System;
using System.Collections.Generic;
using GuideXamarinForms.Interfaces;
using Xamarin.Forms;

namespace GuideXamarinForms.Views
{
    public partial class DependencyServicePage : ContentPage
    {
        public DependencyServicePage()
        {
            InitializeComponent();

        }

        public void PlayMyAudio(object sender, EventArgs args)
        {
            //https://github.com/juniandotnet/xamarin-audio-player
            //https://audioboom.com/posts/5766044-follow-up-305.mp3
            //nao quero usar dependencias e quero rodar videos https://github.com/martijn00/XamarinMediaManager
            DependencyService.Get<IAudio>().Play("followup305.mp3");
        }
    }
}
