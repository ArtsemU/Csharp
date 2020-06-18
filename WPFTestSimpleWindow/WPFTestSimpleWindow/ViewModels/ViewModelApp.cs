using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPFTestSimpleWindow.ViewModels
{
    class ViewModelApp: INotifyPropertyChanged
    {
        private string _rightString;
        private string _leftSting; 
        private string _result;

        public string RightString
        {
            get { return _rightString; }
            set
            {
                _rightString = value;
                OnPropertyChanged(nameof(RightString));
            }
        }

        public string LeftSting
        {
            get { return _leftSting; }
            set
            {
                _leftSting = value;
                OnPropertyChanged(nameof(LeftSting));
            }
        }

        public string Result
        {
            get { return _leftSting + _rightString; }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
