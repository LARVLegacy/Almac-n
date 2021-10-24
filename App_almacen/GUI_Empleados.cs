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
    public partial class GUI_Empleados : Form
    {
        public GUI_Empleados()
        {
            InitializeComponent();
        }

        private void GUI_Empleados_Load(object sender, EventArgs e)
        {

        }
        // Botones
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
