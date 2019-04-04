using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GuideXamarinForms.ViewModels
{
    public class ConvertersViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        private string _name;
        private string _name1;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Name1
        {
            get => _name1;
            set => SetProperty(ref _name1, value);
        }


        public ConvertersViewModel()
        {
            Name = "tiago";
            Name1 = "pompeo";
        }

    }
}
