using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace App6
{
    public class ViewCommandsPageViewModel : INotifyPropertyChanged
    {
        public ICommand CommandGeneral { get; set; }

        private string _mensaje;

        public ViewCommandsPageViewModel()
        {
            this.Mensaje = "Titulo";
            CommandGeneral = new Command<string>(
                 execute: (parametro) =>
                 {
                     Mensaje = parametro;
                 },
                canExecute: (parametro) =>
                {
                    return true;
                });
        }

        public string Mensaje
        {
            get { return _mensaje; }
            set
            {
                //if (_mensaje != value)
                {
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
                            new PropertyChangedEventArgs("Mensaje"));
                    }
                    _mensaje = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
