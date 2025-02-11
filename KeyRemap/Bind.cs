﻿using System.ComponentModel;
namespace KeyRemap
{
    public class Bind : INotifyPropertyChanged
    {
        public bool _bindEdit;
        public bool _bindDelete;
        public bool _keyBind;
        public bool _binderDelay;
        public bool _binderSettingsOpen;
        public bool _binderPause;
        public bool BinderPause
        {
            get
            {
                return _binderPause;
            }
            set
            {
                _binderPause = value;
                OnPropertyChanged(nameof(BinderPause));
            }
        }
        public bool BinderSettingsOpened
        {
            get
            {
                return _binderSettingsOpen;
            }
            set
            {
                _binderSettingsOpen = value;
                OnPropertyChanged(nameof(BinderSettingsOpened));
            }
        }
        public bool BinderDelay
        {
            get
            {
                return _binderDelay;
            }
            set
            {
                _binderDelay = value;
                OnPropertyChanged(nameof(BinderDelay));
            }
        }
        public bool BinderEdit {
            get
            {
                return _bindEdit;
            }
            set
            {
                _bindEdit = value;
                OnPropertyChanged(nameof(BinderEdit));
            }
        }
        public bool BinderDelete
        {
            get
            {
                return _bindDelete;
            }
            set
            {
                _bindDelete = value;
                OnPropertyChanged(nameof(BinderDelete));
            }
        }
        public bool BinderKey
        {
            get
            {
                return _keyBind;
            }
            set
            {
                _keyBind = value;
                OnPropertyChanged(nameof(BinderKey));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
