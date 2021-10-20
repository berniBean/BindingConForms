using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioFrameWork.Clases
{
    public class CTelefono : INotifyPropertyChanged
    {
        private string _nombre;
        private decimal _telefono;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotificarCambio(string nombreProp)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombreProp));
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                NotificarCambio("Nombre");
            }
        }

        public decimal Telefono
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
                NotificarCambio("Telefono");
            }
        }
    }
}
