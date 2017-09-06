using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Map
{
    class TipOne : INotifyPropertyChanged
    {
        private String _numberroom;
        public String NumberRoom
        {
            get
            {
                return _numberroom;
            }
            set
            {
                _numberroom = value;
                OnPropertyChange("NumberRoom");
            }
        }
        private String _nameroom;
        public String NameRoom
        {
            get
            {
                return _nameroom;
            }
            set
            {
                _nameroom = value;
                OnPropertyChange("AdressRoom");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange(String propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }

        }
        public TipOne(String _numroom, String _adressroom)
        {
            NameRoom = _numroom;
            NameRoom = _adressroom;
        }
    }
}

