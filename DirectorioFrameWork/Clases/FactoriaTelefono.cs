using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioFrameWork.Clases
{
    public class FactoriaTelefono
    {
        private static BindingList<CTelefono> _telefonos;
        
        public static CTelefono CrearCTelefono(string nom, decimal tfn)
        {
            CTelefono tfno = new CTelefono();
            tfno.Nombre = nom;
            tfno.Telefono = tfn;
            return tfno;
        }

        public static BindingList<CTelefono> ObtenerColeccionCTelefono()
        {
            _telefonos = new BindingList<CTelefono>();

            Random rnd = new Random();

            for(int i=0; i < 10; i++)
            {
                _telefonos.Add(CrearCTelefono("Persona " + i, rnd.Next(636000000, 636999999)));
            }

            return _telefonos;
        }
    }
}
