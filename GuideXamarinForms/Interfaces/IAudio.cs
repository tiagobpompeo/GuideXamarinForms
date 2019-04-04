using System;
namespace GuideXamarinForms.Interfaces
{
    public interface IAudio
    {
        void Play(string pathToAudioFile);
        void Play();
        void Pause();
        Action OnFinishedPlaying { get; set; }
    }
}
