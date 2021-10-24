using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Mover la ventana

namespace App_almacen
{
    public partial class GUI_Principal : Form
    {
        private Timer ti;
        public GUI_Principal()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        //Mover ventana de login

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void GUI_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Iniciar reloj
        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblhora.Text = hoy.ToString("HH:mm:ss");
        }

        //Botones salir, minimizar, maximizar
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Botones ventana principal, apertura de GUI

        public void AddFormularios(Form formhijo)
        {
            if (this.panel_principal.Controls.Count > 0)    //Condicional para cerrar si el panel esta lleno
            {
                this.panel_principal.Controls.RemoveAt(0);
            }

            Form f = formhijo as Form;
            
            f.TopLevel = false;                       //Indicarle que no es de un nivel superior
            f.Dock = DockStyle.Fill;                  //Para que tome el tamaño del panel
            this.panel_principal.Controls.Add(f);     //Agg al panel
            this.panel_principal.Tag = f;             //Establecemos la intancia como controlador de datos de nuestro panel
            f.Show();                                 //Llamado para que se dibuje
        }
        private void btnempleados_Click_1(object sender, EventArgs e)
        {

            GUI_Empleados g_empleados = new GUI_Empleados();
            AddFormularios(g_empleados);
            
        }
        private void btnperfiles_Click(object sender, EventArgs e)
        {
            GUI_Perfiles g_perfiles = new GUI_Perfiles();
            AddFormularios(g_perfiles);
        }

        private void btnregistros_Click(object sender, EventArgs e)
        {
            GUI_Registros g_registros = new GUI_Registros();
            AddFormularios(g_registros);
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            GUI_Pedidos g_pedidos = new GUI_Pedidos();
            AddFormularios(g_pedidos);
        }

        private void btnpermisos_Click(object sender, EventArgs e)
        {
            GUI_Permisos g_permisos = new GUI_Permisos();
            AddFormularios(g_permisos);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            GUI_Informacion g_informacion = new GUI_Informacion();
            AddFormularios(g_informacion);
        }

        // Botones, salir, minimizar, maximizar
        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            GUI_Login g_login = new GUI_Login();
            g_login.Show();

            this.Hide();
            
        }
        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar2.Visible = true;
            btnmaximizar.Visible = false;
        }
        private void btnmaximizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar2.Visible = false;
            btnmaximizar.Visible = true;
        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Resto de elementos de la ventana principal
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void GUI_Principal_Load(object sender, EventArgs e)
        {

        }

        private void panel_titulo_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
