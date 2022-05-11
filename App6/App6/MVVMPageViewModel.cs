using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App6
{
    public class MVVMPageViewModel : INotifyPropertyChanged
    {
        private DateTime _fechaActual;

        public MVVMPageViewModel()
        {

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.FechaActual = DateTime.Now;
                return true;
            });

        }
        private float _rotation;

        public float Rotation
        {
            get { return _rotation; }
            set {

                if (_rotation != value)
                {
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
                            new PropertyChangedEventArgs("Rotation"));
                    }
                    _rotation = value;
                }
            }
        }

        public DateTime FechaActual
        {
            get { return _fechaActual; }
            set { 
                if (_fechaActual != value) {
                    if (PropertyChanged != null){
                        PropertyChanged(this,
                            new PropertyChangedEventArgs("FechaActual"));
                    }
                    _fechaActual = value;
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
