using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace WinodwSize
{
    public class Button : INotifyPropertyChanged
    {
        public Thickness ButtonMargin { get; }
        public Button(int l, int t, int r, int b)
        {
            ButtonMargin = new Thickness(l, t, r, b);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        private bool isState;
        public bool IsState
        {
            get
            {
                return isState;
            }
            set
            {
                isState = value;
                OnPropertyChanged("IsState");
            }
        }
    }
}
