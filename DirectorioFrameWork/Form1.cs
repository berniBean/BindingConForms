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
        private List<CTelefono> colTfnos;
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            colTfnos = FactoriaTelefono.ObtenerColeccionCTelefono();
            bs = new BindingSource();
            bs.DataSource = colTfnos;
            lsTfnos.DataSource = bs;
            lsTfnos.DisplayMember = "Nombre";
            ctTfnosSelec.DataBindings.Add("Text", bs, "Telefono");
            
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            decimal tef = 0;
            if (ctNombre.Text.Length != 0 && ctTfno.Text.Length != 0 &&
                Decimal.TryParse(ctTfno.Text, out tef))
            {
                colTfnos.Add(FactoriaTelefono.CrearCTelefono(ctNombre.Text, tef));
                bs.Position = bs.Count;
                bs.CurrencyManager.Refresh();
            }

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            
            if (bs.Position < 0) return;
            colTfnos.RemoveAt(bs.Position);
            bs.CurrencyManager.Refresh();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            bool cambios = false;
            
            if(ctNombre.Text.Length != 0)
            {
                (bs.Current as CTelefono).Nombre = ctNombre.Text;
                cambios = true;
                
            }
            decimal tef = 0;
            if(ctTfno.Text.Length !=0 && Decimal.TryParse(ctTfno.Text, out tef))
            {
                (bs.Current as CTelefono).Telefono = tef;
                cambios = true;
            }

            if (cambios) bs.CurrencyManager.Refresh();
            
        }
    }
}
