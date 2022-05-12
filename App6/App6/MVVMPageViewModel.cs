using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App6
{
    public class MVVMPageViewModel : INotifyPropertyChanged
    {
        private DateTime _fechaActual;

        public ICommand GirarLabel { get; set; }

        public MVVMPageViewModel()
        {

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.FechaActual = DateTime.Now;
                return true;
            });

            GirarLabel = new Command(
                execute: () =>
                {
                    Rotation += 90;
                },
                canExecute: () =>
                {
                    return Rotation > 0;
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
                        ((Command)GirarLabel).ChangeCanExecute();
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
