
namespace App_almacen
{
    partial class GUI_Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Pedidos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_perfiles_ingreso = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_id_pedido = new System.Windows.Forms.TextBox();
            this.lb_id_pedido = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.lb_empleado = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel_perfiles_btn = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lb_pedidos = new System.Windows.Forms.Label();
            this.TxtBox_listado = new System.Windows.Forms.RichTextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lb_lista_pedido = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel_perfiles_ingreso.SuspendLayout();
            this.panel_perfiles_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 202);
            this.panel2.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Información mostrada:";
            // 
            // panel_perfiles_ingreso
            // 
            this.panel_perfiles_ingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_perfiles_ingreso.Controls.Add(this.lb_lista_pedido);
            this.panel_perfiles_ingreso.Controls.Add(this.btn_agregar);
            this.panel_perfiles_ingreso.Controls.Add(this.TxtBox_listado);
            this.panel_perfiles_ingreso.Controls.Add(this.btn_buscar);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_id_pedido);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_id_pedido);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_buscar);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_buscar);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_empleado);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_nombre);
            this.panel_perfiles_ingreso.Location = new System.Drawing.Point(0, 108);
            this.panel_perfiles_ingreso.Name = "panel_perfiles_ingreso";
            this.panel_perfiles_ingreso.Size = new System.Drawing.Size(796, 197);
            this.panel_perfiles_ingreso.TabIndex = 33;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_buscar.Location = new System.Drawing.Point(510, 60);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(238, 31);
            this.btn_buscar.TabIndex = 44;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // txt_id_pedido
            // 
            this.txt_id_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_id_pedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_pedido.ForeColor = System.Drawing.Color.LightGray;
            this.txt_id_pedido.Location = new System.Drawing.Point(136, 11);
            this.txt_id_pedido.MaxLength = 10;
            this.txt_id_pedido.Name = "txt_id_pedido";
            this.txt_id_pedido.PasswordChar = '*';
            this.txt_id_pedido.Size = new System.Drawing.Size(350, 19);
            this.txt_id_pedido.TabIndex = 43;
            this.txt_id_pedido.UseSystemPasswordChar = true;
            // 
            // lb_id_pedido
            // 
            this.lb_id_pedido.AutoSize = true;
            this.lb_id_pedido.BackColor = System.Drawing.Color.Transparent;
            this.lb_id_pedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_pedido.ForeColor = System.Drawing.Color.LightGray;
            this.lb_id_pedido.Location = new System.Drawing.Point(7, 7);
            this.lb_id_pedido.Name = "lb_id_pedido";
            this.lb_id_pedido.Size = new System.Drawing.Size(132, 22);
            this.lb_id_pedido.TabIndex = 42;
            this.lb_id_pedido.Text = "ID generado:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.txt_buscar.Location = new System.Drawing.Point(192, 60);
            this.txt_buscar.MaxLength = 10;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(294, 19);
            this.txt_buscar.TabIndex = 41;
            // 
            // lb_buscar
            // 
            this.lb_buscar.AutoSize = true;
            this.lb_buscar.BackColor = System.Drawing.Color.Transparent;
            this.lb_buscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.lb_buscar.Location = new System.Drawing.Point(7, 58);
            this.lb_buscar.Name = "lb_buscar";
            this.lb_buscar.Size = new System.Drawing.Size(189, 22);
            this.lb_buscar.TabIndex = 40;
            this.lb_buscar.Text = "Buscar por nombre:";
            // 
            // lb_empleado
            // 
            this.lb_empleado.AutoSize = true;
            this.lb_empleado.BackColor = System.Drawing.Color.Transparent;
            this.lb_empleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empleado.ForeColor = System.Drawing.Color.LightGray;
            this.lb_empleado.Location = new System.Drawing.Point(7, 32);
            this.lb_empleado.Name = "lb_empleado";
            this.lb_empleado.Size = new System.Drawing.Size(108, 22);
            this.lb_empleado.TabIndex = 31;
            this.lb_empleado.Text = "Empleado:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nombre.Location = new System.Drawing.Point(112, 34);
            this.txt_nombre.MaxLength = 10;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(374, 19);
            this.txt_nombre.TabIndex = 31;
            // 
            // panel_perfiles_btn
            // 
            this.panel_perfiles_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_perfiles_btn.AutoSize = true;
            this.panel_perfiles_btn.Controls.Add(this.btn_regresar);
            this.panel_perfiles_btn.Controls.Add(this.btn_eliminar);
            this.panel_perfiles_btn.Controls.Add(this.btn_modificar);
            this.panel_perfiles_btn.Controls.Add(this.btn_nuevo);
            this.panel_perfiles_btn.Controls.Add(this.lb_pedidos);
            this.panel_perfiles_btn.Location = new System.Drawing.Point(0, 7);
            this.panel_perfiles_btn.Name = "panel_perfiles_btn";
            this.panel_perfiles_btn.Size = new System.Drawing.Size(796, 95);
            this.panel_perfiles_btn.TabIndex = 32;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_regresar.BackgroundImage")));
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_regresar.Location = new System.Drawing.Point(770, 0);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(26, 25);
            this.btn_regresar.TabIndex = 45;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_eliminar.Location = new System.Drawing.Point(525, 44);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(261, 40);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_modificar.Location = new System.Drawing.Point(267, 44);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(261, 40);
            this.btn_modificar.TabIndex = 31;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_nuevo.Location = new System.Drawing.Point(11, 44);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(261, 40);
            this.btn_nuevo.TabIndex = 30;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // lb_pedidos
            // 
            this.lb_pedidos.AutoSize = true;
            this.lb_pedidos.BackColor = System.Drawing.Color.Transparent;
            this.lb_pedidos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pedidos.ForeColor = System.Drawing.Color.LightGray;
            this.lb_pedidos.Location = new System.Drawing.Point(335, 7);
            this.lb_pedidos.Name = "lb_pedidos";
            this.lb_pedidos.Size = new System.Drawing.Size(127, 33);
            this.lb_pedidos.TabIndex = 27;
            this.lb_pedidos.Text = "PEDIDOS";
            this.lb_pedidos.Click += new System.EventHandler(this.lb_perfiles_Click);
            // 
            // TxtBox_listado
            // 
            this.TxtBox_listado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TxtBox_listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_listado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_listado.ForeColor = System.Drawing.Color.LightGray;
            this.TxtBox_listado.Location = new System.Drawing.Point(192, 85);
            this.TxtBox_listado.Name = "TxtBox_listado";
            this.TxtBox_listado.Size = new System.Drawing.Size(294, 96);
            this.TxtBox_listado.TabIndex = 51;
            this.TxtBox_listado.Text = "";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_agregar.Location = new System.Drawing.Point(510, 150);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(238, 31);
            this.btn_agregar.TabIndex = 52;
            this.btn_agregar.Text = "Agregar a la lista";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // lb_lista_pedido
            // 
            this.lb_lista_pedido.AutoSize = true;
            this.lb_lista_pedido.BackColor = System.Drawing.Color.Transparent;
            this.lb_lista_pedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lista_pedido.ForeColor = System.Drawing.Color.LightGray;
            this.lb_lista_pedido.Location = new System.Drawing.Point(7, 80);
            this.lb_lista_pedido.Name = "lb_lista_pedido";
            this.lb_lista_pedido.Size = new System.Drawing.Size(183, 22);
            this.lb_lista_pedido.TabIndex = 53;
            this.lb_lista_pedido.Text = "Listado del pedido:";
            // 
            // GUI_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_perfiles_ingreso);
            this.Controls.Add(this.panel_perfiles_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Pedidos";
            this.Text = "GUI_Pedidos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_perfiles_ingreso.ResumeLayout(false);
            this.panel_perfiles_ingreso.PerformLayout();
            this.panel_perfiles_btn.ResumeLayout(false);
            this.panel_perfiles_btn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_perfiles_ingreso;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_id_pedido;
        private System.Windows.Forms.Label lb_id_pedido;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lb_buscar;
        private System.Windows.Forms.Label lb_empleado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel_perfiles_btn;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label lb_pedidos;
        private System.Windows.Forms.RichTextBox TxtBox_listado;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lb_lista_pedido;
    }
}