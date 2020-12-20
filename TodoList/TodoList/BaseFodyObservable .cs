﻿using System.ComponentModel;
namespace TodoList 
{
    public abstract class BaseFodyObservable : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore
    }
}
