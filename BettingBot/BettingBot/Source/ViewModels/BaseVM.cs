﻿using System.ComponentModel;
using BettingBot.Source.Common.UtilityClasses;

namespace BettingBot.Source.ViewModels
{
    public abstract class BaseVM : INotifyPropertyChanged, INotifyPropertyChangedUtils
    {
        public void SetPropertyAndNotify<T>(ref T field, T propVal, string propName)
        {
            if (Equals(field, propVal)) return;
            field = propVal;
            OnPropertyChanging(propName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanging(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
