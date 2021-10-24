
namespace App_almacen
{
    partial class GUI_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Empleados));
            this.lb_empleados = new System.Windows.Forms.Label();
            this.panel_emple_btn = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.panel_emple_ingreso = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_empleado = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lb_correo = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_tdocumento = new System.Windows.Forms.Label();
            this.lb_ndocumento = new System.Windows.Forms.Label();
            this.txt_tdocumento = new System.Windows.Forms.TextBox();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_emple_btn.SuspendLayout();
            this.panel_emple_ingreso.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_empleados
            // 
            this.lb_empleados.AutoSize = true;
            this.lb_empleados.BackColor = System.Drawing.Color.Transparent;
            this.lb_empleados.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empleados.ForeColor = System.Drawing.Color.LightGray;
            this.lb_empleados.Location = new System.Drawing.Point(312, 8);
            this.lb_empleados.Name = "lb_empleados";
            this.lb_empleados.Size = new System.Drawing.Size(171, 33);
            this.lb_empleados.TabIndex = 27;
            this.lb_empleados.Text = "EMPLEADOS";
            // 
            // panel_emple_btn
            // 
            this.panel_emple_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_emple_btn.AutoSize = true;
            this.panel_emple_btn.Controls.Add(this.btn_eliminar);
            this.panel_emple_btn.Controls.Add(this.btn_regresar);
            this.panel_emple_btn.Controls.Add(this.btn_modificar);
            this.panel_emple_btn.Controls.Add(this.btn_nuevo);
            this.panel_emple_btn.Controls.Add(this.lb_empleados);
            this.panel_emple_btn.Location = new System.Drawing.Point(0, 4);
            this.panel_emple_btn.Name = "panel_emple_btn";
            this.panel_emple_btn.Size = new System.Drawing.Size(796, 95);
            this.panel_emple_btn.TabIndex = 28;
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
            this.btn_eliminar.TabIndex = 36;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
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
            this.btn_regresar.Location = new System.Drawing.Point(767, 0);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(26, 25);
            this.btn_regresar.TabIndex = 35;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
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
            // panel_emple_ingreso
            // 
            this.panel_emple_ingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_emple_ingreso.Controls.Add(this.textBox2);
            this.panel_emple_ingreso.Controls.Add(this.textBox1);
            this.panel_emple_ingreso.Controls.Add(this.btn_buscar);
            this.panel_emple_ingreso.Controls.Add(this.panel1);
            this.panel_emple_ingreso.Controls.Add(this.id_empleado);
            this.panel_emple_ingreso.Controls.Add(this.textBox5);
            this.panel_emple_ingreso.Controls.Add(this.label2);
            this.panel_emple_ingreso.Controls.Add(this.txt_telefono);
            this.panel_emple_ingreso.Controls.Add(this.lb_telefono);
            this.panel_emple_ingreso.Controls.Add(this.txt_correo);
            this.panel_emple_ingreso.Controls.Add(this.txt_apellido);
            this.panel_emple_ingreso.Controls.Add(this.lb_correo);
            this.panel_emple_ingreso.Controls.Add(this.lb_nombre);
            this.panel_emple_ingreso.Controls.Add(this.lb_tdocumento);
            this.panel_emple_ingreso.Controls.Add(this.lb_ndocumento);
            this.panel_emple_ingreso.Controls.Add(this.txt_tdocumento);
            this.panel_emple_ingreso.Controls.Add(this.lb_apellido);
            this.panel_emple_ingreso.Controls.Add(this.txt_nombre);
            this.panel_emple_ingreso.Location = new System.Drawing.Point(0, 94);
            this.panel_emple_ingreso.Name = "panel_emple_ingreso";
            this.panel_emple_ingreso.Size = new System.Drawing.Size(796, 166);
            this.panel_emple_ingreso.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(139, 84);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 19);
            this.textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(188, 59);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 43;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_buscar.Location = new System.Drawing.Point(513, 126);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(238, 31);
            this.btn_buscar.TabIndex = 32;
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
            // id_empleado
            // 
            this.id_empleado.AutoSize = true;
            this.id_empleado.BackColor = System.Drawing.Color.Transparent;
            this.id_empleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_empleado.ForeColor = System.Drawing.Color.LightGray;
            this.id_empleado.Location = new System.Drawing.Point(7, 82);
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Size = new System.Drawing.Size(132, 22);
            this.id_empleado.TabIndex = 42;
            this.id_empleado.Text = "ID generado:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.LightGray;
            this.textBox5.Location = new System.Drawing.Point(202, 137);
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
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Buscar por nombre:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.LightGray;
            this.txt_telefono.Location = new System.Drawing.Point(492, 59);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(294, 19);
            this.txt_telefono.TabIndex = 39;
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lb_telefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono.ForeColor = System.Drawing.Color.LightGray;
            this.lb_telefono.Location = new System.Drawing.Point(397, 57);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(92, 22);
            this.lb_telefono.TabIndex = 38;
            this.lb_telefono.Text = "Télefono:";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.LightGray;
            this.txt_correo.Location = new System.Drawing.Point(492, 35);
            this.txt_correo.MaxLength = 10;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(294, 19);
            this.txt_correo.TabIndex = 37;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.LightGray;
            this.txt_apellido.Location = new System.Drawing.Point(492, 10);
            this.txt_apellido.MaxLength = 10;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(294, 19);
            this.txt_apellido.TabIndex = 36;
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.BackColor = System.Drawing.Color.Transparent;
            this.lb_correo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.ForeColor = System.Drawing.Color.LightGray;
            this.lb_correo.Location = new System.Drawing.Point(397, 33);
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(78, 22);
            this.lb_correo.TabIndex = 34;
            this.lb_correo.Text = "Correo:";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.Color.LightGray;
            this.lb_nombre.Location = new System.Drawing.Point(7, 8);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(89, 22);
            this.lb_nombre.TabIndex = 31;
            this.lb_nombre.Text = "Nombre:";
            // 
            // lb_tdocumento
            // 
            this.lb_tdocumento.AutoSize = true;
            this.lb_tdocumento.BackColor = System.Drawing.Color.Transparent;
            this.lb_tdocumento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tdocumento.ForeColor = System.Drawing.Color.LightGray;
            this.lb_tdocumento.Location = new System.Drawing.Point(7, 32);
            this.lb_tdocumento.Name = "lb_tdocumento";
            this.lb_tdocumento.Size = new System.Drawing.Size(195, 22);
            this.lb_tdocumento.TabIndex = 30;
            this.lb_tdocumento.Text = "Tipo de documento:";
            // 
            // lb_ndocumento
            // 
            this.lb_ndocumento.AutoSize = true;
            this.lb_ndocumento.BackColor = System.Drawing.Color.Transparent;
            this.lb_ndocumento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ndocumento.ForeColor = System.Drawing.Color.LightGray;
            this.lb_ndocumento.Location = new System.Drawing.Point(7, 57);
            this.lb_ndocumento.Name = "lb_ndocumento";
            this.lb_ndocumento.Size = new System.Drawing.Size(181, 22);
            this.lb_ndocumento.TabIndex = 32;
            this.lb_ndocumento.Text = "N° de documento:";
            // 
            // txt_tdocumento
            // 
            this.txt_tdocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_tdocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tdocumento.ForeColor = System.Drawing.Color.LightGray;
            this.txt_tdocumento.Location = new System.Drawing.Point(198, 35);
            this.txt_tdocumento.MaxLength = 10;
            this.txt_tdocumento.Name = "txt_tdocumento";
            this.txt_tdocumento.Size = new System.Drawing.Size(190, 19);
            this.txt_tdocumento.TabIndex = 31;
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lb_apellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apellido.ForeColor = System.Drawing.Color.LightGray;
            this.lb_apellido.Location = new System.Drawing.Point(397, 8);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(89, 22);
            this.lb_apellido.TabIndex = 32;
            this.lb_apellido.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nombre.Location = new System.Drawing.Point(94, 10);
            this.txt_nombre.MaxLength = 10;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(294, 19);
            this.txt_nombre.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 242);
            this.panel2.TabIndex = 30;
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
            // GUI_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_emple_ingreso);
            this.Controls.Add(this.panel_emple_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Empleados";
            this.Text = "GUI_Empleados";
            this.Load += new System.EventHandler(this.GUI_Empleados_Load);
            this.panel_emple_btn.ResumeLayout(false);
            this.panel_emple_btn.PerformLayout();
            this.panel_emple_ingreso.ResumeLayout(false);
            this.panel_emple_ingreso.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_empleados;
        private System.Windows.Forms.Panel panel_emple_btn;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panel_emple_ingreso;
        private System.Windows.Forms.Label lb_ndocumento;
        private System.Windows.Forms.TextBox txt_tdocumento;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_tdocumento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_correo;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label id_empleado;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}