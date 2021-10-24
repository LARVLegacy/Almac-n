using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_almacen
{
    public partial class GUI_Registros : Form
    {
        public GUI_Registros()
        {
            InitializeComponent();
        }

        private void cbox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
