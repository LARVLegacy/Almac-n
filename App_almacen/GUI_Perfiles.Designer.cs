
namespace App_almacen
{
    partial class GUI_Perfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Perfiles));
            this.panel_perfiles_btn = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lb_perfiles = new System.Windows.Forms.Label();
            this.panel_perfiles_ingreso = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lb_id_perfil = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lb_empleado = new System.Windows.Forms.Label();
            this.txt_acceso = new System.Windows.Forms.TextBox();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.lb_acceso = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_perfiles_btn.SuspendLayout();
            this.panel_perfiles_ingreso.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_perfiles_btn
            // 
            this.panel_perfiles_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_perfiles_btn.AutoSize = true;
            this.panel_perfiles_btn.Controls.Add(this.btn_regresar);
            this.panel_perfiles_btn.Controls.Add(this.btn_eliminar);
            this.panel_perfiles_btn.Controls.Add(this.btn_modificar);
            this.panel_perfiles_btn.Controls.Add(this.btn_nuevo);
            this.panel_perfiles_btn.Controls.Add(this.lb_perfiles);
            this.panel_perfiles_btn.Location = new System.Drawing.Point(-1, 2);
            this.panel_perfiles_btn.Name = "panel_perfiles_btn";
            this.panel_perfiles_btn.Size = new System.Drawing.Size(796, 95);
            this.panel_perfiles_btn.TabIndex = 29;
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
            // lb_perfiles
            // 
            this.lb_perfiles.AutoSize = true;
            this.lb_perfiles.BackColor = System.Drawing.Color.Transparent;
            this.lb_perfiles.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_perfiles.ForeColor = System.Drawing.Color.LightGray;
            this.lb_perfiles.Location = new System.Drawing.Point(335, 7);
            this.lb_perfiles.Name = "lb_perfiles";
            this.lb_perfiles.Size = new System.Drawing.Size(119, 33);
            this.lb_perfiles.TabIndex = 27;
            this.lb_perfiles.Text = "PERFILES";
            // 
            // panel_perfiles_ingreso
            // 
            this.panel_perfiles_ingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_perfiles_ingreso.Controls.Add(this.btn_buscar);
            this.panel_perfiles_ingreso.Controls.Add(this.panel1);
            this.panel_perfiles_ingreso.Controls.Add(this.textBox8);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_id_perfil);
            this.panel_perfiles_ingreso.Controls.Add(this.textBox5);
            this.panel_perfiles_ingreso.Controls.Add(this.label2);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_usuario);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_empleado);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_acceso);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_contrasena);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_acceso);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_contrasena);
            this.panel_perfiles_ingreso.Controls.Add(this.lb_usuario);
            this.panel_perfiles_ingreso.Controls.Add(this.txt_empleado);
            this.panel_perfiles_ingreso.Location = new System.Drawing.Point(-1, 103);
            this.panel_perfiles_ingreso.Name = "panel_perfiles_ingreso";
            this.panel_perfiles_ingreso.Size = new System.Drawing.Size(796, 166);
            this.panel_perfiles_ingreso.TabIndex = 30;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_buscar.Location = new System.Drawing.Point(525, 103);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(238, 31);
            this.btn_buscar.TabIndex = 44;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.LightGray;
            this.textBox8.Location = new System.Drawing.Point(532, 34);
            this.textBox8.MaxLength = 10;
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '*';
            this.textBox8.Size = new System.Drawing.Size(252, 19);
            this.textBox8.TabIndex = 43;
            this.textBox8.UseSystemPasswordChar = true;
            // 
            // lb_id_perfil
            // 
            this.lb_id_perfil.AutoSize = true;
            this.lb_id_perfil.BackColor = System.Drawing.Color.Transparent;
            this.lb_id_perfil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_perfil.ForeColor = System.Drawing.Color.LightGray;
            this.lb_id_perfil.Location = new System.Drawing.Point(394, 35);
            this.lb_id_perfil.Name = "lb_id_perfil";
            this.lb_id_perfil.Size = new System.Drawing.Size(132, 22);
            this.lb_id_perfil.TabIndex = 42;
            this.lb_id_perfil.Text = "ID generado:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.LightGray;
            this.textBox5.Location = new System.Drawing.Point(202, 115);
            this.textBox5.MaxLength = 10;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 19);
            this.textBox5.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Buscar por nombre:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_usuario.Location = new System.Drawing.Point(492, 10);
            this.txt_usuario.MaxLength = 10;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(294, 19);
            this.txt_usuario.TabIndex = 36;
            // 
            // lb_empleado
            // 
            this.lb_empleado.AutoSize = true;
            this.lb_empleado.BackColor = System.Drawing.Color.Transparent;
            this.lb_empleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empleado.ForeColor = System.Drawing.Color.LightGray;
            this.lb_empleado.Location = new System.Drawing.Point(7, 8);
            this.lb_empleado.Name = "lb_empleado";
            this.lb_empleado.Size = new System.Drawing.Size(108, 22);
            this.lb_empleado.TabIndex = 31;
            this.lb_empleado.Text = "Empleado:";
            // 
            // txt_acceso
            // 
            this.txt_acceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_acceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_acceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_acceso.ForeColor = System.Drawing.Color.LightGray;
            this.txt_acceso.Location = new System.Drawing.Point(155, 59);
            this.txt_acceso.MaxLength = 10;
            this.txt_acceso.Name = "txt_acceso";
            this.txt_acceso.PasswordChar = '*';
            this.txt_acceso.Size = new System.Drawing.Size(233, 19);
            this.txt_acceso.TabIndex = 33;
            this.txt_acceso.UseSystemPasswordChar = true;
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.lb_contrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.ForeColor = System.Drawing.Color.LightGray;
            this.lb_contrasena.Location = new System.Drawing.Point(7, 32);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(124, 22);
            this.lb_contrasena.TabIndex = 30;
            this.lb_contrasena.Text = "Contraseña:";
            // 
            // lb_acceso
            // 
            this.lb_acceso.AutoSize = true;
            this.lb_acceso.BackColor = System.Drawing.Color.Transparent;
            this.lb_acceso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acceso.ForeColor = System.Drawing.Color.LightGray;
            this.lb_acceso.Location = new System.Drawing.Point(7, 57);
            this.lb_acceso.Name = "lb_acceso";
            this.lb_acceso.Size = new System.Drawing.Size(154, 22);
            this.lb_acceso.TabIndex = 32;
            this.lb_acceso.Text = "Tipo de acceso:";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.ForeColor = System.Drawing.Color.LightGray;
            this.txt_contrasena.Location = new System.Drawing.Point(130, 35);
            this.txt_contrasena.MaxLength = 10;
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(258, 19);
            this.txt_contrasena.TabIndex = 31;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lb_usuario.Location = new System.Drawing.Point(397, 8);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(80, 22);
            this.lb_usuario.TabIndex = 32;
            this.lb_usuario.Text = "Usuario:";
            // 
            // txt_empleado
            // 
            this.txt_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empleado.ForeColor = System.Drawing.Color.LightGray;
            this.txt_empleado.Location = new System.Drawing.Point(94, 10);
            this.txt_empleado.MaxLength = 10;
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(294, 19);
            this.txt_empleado.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-1, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 233);
            this.panel2.TabIndex = 31;
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
            // GUI_Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_perfiles_ingreso);
            this.Controls.Add(this.panel_perfiles_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Perfiles";
            this.Text = "GUI_Perfiles";
            this.panel_perfiles_btn.ResumeLayout(false);
            this.panel_perfiles_btn.PerformLayout();
            this.panel_perfiles_ingreso.ResumeLayout(false);
            this.panel_perfiles_ingreso.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_perfiles_btn;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label lb_perfiles;
        private System.Windows.Forms.Panel panel_perfiles_ingreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lb_empleado;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.Label lb_id_perfil;
        private System.Windows.Forms.TextBox txt_acceso;
        private System.Windows.Forms.Label lb_acceso;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_regresar;
    }
}