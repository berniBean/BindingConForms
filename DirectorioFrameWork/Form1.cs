using DirectorioFrameWork.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorioFrameWork
{
    public partial class Form1 : Form
    {
        private BindingList<CTelefono> colTfnos;
        private CurrencyManager cm;
        public Form1()
        {
            InitializeComponent();
            colTfnos = FactoriaTelefono.ObtenerColeccionCTelefono();
            lsTfnos.DataSource = colTfnos;
            lsTfnos.DisplayMember = "Nombre";
            ctTfnosSelec.DataBindings.Add("Text", colTfnos, "Telefono");
            cm = lsTfnos.BindingContext[colTfnos] as CurrencyManager;
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            decimal tef = 0;
            if (ctNombre.Text.Length != 0 && ctTfno.Text.Length != 0 &&
                Decimal.TryParse(ctTfno.Text, out tef))
                colTfnos.Add(FactoriaTelefono.CrearCTelefono(ctNombre.Text, tef));
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            int pos = lsTfnos.SelectedIndex;
            if (pos < 0) return;
            colTfnos.RemoveAt(cm.Position);
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            int pos = lsTfnos.SelectedIndex;
            
            if(ctNombre.Text.Length != 0)
            {
                colTfnos[pos].Nombre = ctNombre.Text;
                
            }
            decimal tef = 0;
            if(ctTfno.Text.Length !=0 && Decimal.TryParse(ctTfno.Text, out tef))
            {
                colTfnos[pos].Telefono = tef;
                
            }
            
        }
    }
}
