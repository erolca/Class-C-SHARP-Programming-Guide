using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace NotifyPropertyChangedSample
{
    public class Car : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public Car(string plate, string driver)
        {
            _Plate = plate;
            _Driver = driver;
        }
        private string _Plate = string.Empty;
        public string Plate
        {
            get 
            { 
                return _Plate; 
            }
            set 
            {
                if (_Plate != value)
                {
                    _Plate = value;
                    NotifyPropertyChanged("Plate");
                }
            }
        }
        private string _Driver = string.Empty;
        public string Driver
        {
            get 
            { 
                return _Driver; 
            }
            set 
            {
                if (_Driver != value)
                {
                    _Driver = value;
                    NotifyPropertyChanged("Driver");
                }
            }
        }
        private int _CurrentSpeed = 0;
        public int CurrentSpeed
        {
            get 
            { 
                return _CurrentSpeed; 
            }
            set 
            {
                if (_CurrentSpeed != value)
                {
                    _CurrentSpeed = value;
                    NotifyPropertyChanged("CurrentSpeed");
                }
            }
        }



    }
}
