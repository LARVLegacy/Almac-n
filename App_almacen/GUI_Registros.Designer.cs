
namespace App_almacen
{
    partial class GUI_Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Registros));
            this.panel_emple_btn = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lb_registros = new System.Windows.Forms.Label();
            this.panel_emple_ingreso = new System.Windows.Forms.Panel();
            this.txt_id_registro = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lb_detalle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_precio = new System.Windows.Forms.Label();
            this.cbox_subcategoria = new System.Windows.Forms.ComboBox();
            this.cbox_categoria = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.id_registro = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stock_max = new System.Windows.Forms.TextBox();
            this.lb_stock_max = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lb_stock_min = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_subcategoria = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_emple_btn.SuspendLayout();
            this.panel_emple_ingreso.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_emple_btn
            // 
            this.panel_emple_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_emple_btn.AutoSize = true;
            this.panel_emple_btn.Controls.Add(this.btn_regresar);
            this.panel_emple_btn.Controls.Add(this.btn_eliminar);
            this.panel_emple_btn.Controls.Add(this.btn_modificar);
            this.panel_emple_btn.Controls.Add(this.btn_nuevo);
            this.panel_emple_btn.Controls.Add(this.lb_registros);
            this.panel_emple_btn.Location = new System.Drawing.Point(-1, 1);
            this.panel_emple_btn.Name = "panel_emple_btn";
            this.panel_emple_btn.Size = new System.Drawing.Size(796, 91);
            this.panel_emple_btn.TabIndex = 29;
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
            this.btn_regresar.Location = new System.Drawing.Point(770, 3);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(26, 25);
            this.btn_regresar.TabIndex = 34;
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
            // lb_registros
            // 
            this.lb_registros.AutoSize = true;
            this.lb_registros.BackColor = System.Drawing.Color.Transparent;
            this.lb_registros.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registros.ForeColor = System.Drawing.Color.LightGray;
            this.lb_registros.Location = new System.Drawing.Point(312, 8);
            this.lb_registros.Name = "lb_registros";
            this.lb_registros.Size = new System.Drawing.Size(151, 33);
            this.lb_registros.TabIndex = 27;
            this.lb_registros.Text = "REGISTROS";
            // 
            // panel_emple_ingreso
            // 
            this.panel_emple_ingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_emple_ingreso.Controls.Add(this.txt_id_registro);
            this.panel_emple_ingreso.Controls.Add(this.txt_nombre);
            this.panel_emple_ingreso.Controls.Add(this.richTextBox1);
            this.panel_emple_ingreso.Controls.Add(this.lb_detalle);
            this.panel_emple_ingreso.Controls.Add(this.textBox1);
            this.panel_emple_ingreso.Controls.Add(this.lb_precio);
            this.panel_emple_ingreso.Controls.Add(this.cbox_subcategoria);
            this.panel_emple_ingreso.Controls.Add(this.cbox_categoria);
            this.panel_emple_ingreso.Controls.Add(this.btn_buscar);
            this.panel_emple_ingreso.Controls.Add(this.id_registro);
            this.panel_emple_ingreso.Controls.Add(this.textBox5);
            this.panel_emple_ingreso.Controls.Add(this.label2);
            this.panel_emple_ingreso.Controls.Add(this.txt_stock_max);
            this.panel_emple_ingreso.Controls.Add(this.lb_stock_max);
            this.panel_emple_ingreso.Controls.Add(this.txt_correo);
            this.panel_emple_ingreso.Controls.Add(this.txt_cantidad);
            this.panel_emple_ingreso.Controls.Add(this.lb_stock_min);
            this.panel_emple_ingreso.Controls.Add(this.lb_categoria);
            this.panel_emple_ingreso.Controls.Add(this.lb_subcategoria);
            this.panel_emple_ingreso.Controls.Add(this.lb_nombre);
            this.panel_emple_ingreso.Controls.Add(this.lb_cantidad);
            this.panel_emple_ingreso.Location = new System.Drawing.Point(-1, 91);
            this.panel_emple_ingreso.Name = "panel_emple_ingreso";
            this.panel_emple_ingreso.Size = new System.Drawing.Size(796, 238);
            this.panel_emple_ingreso.TabIndex = 34;
            // 
            // txt_id_registro
            // 
            this.txt_id_registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_id_registro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_registro.ForeColor = System.Drawing.Color.LightGray;
            this.txt_id_registro.Location = new System.Drawing.Point(135, 90);
            this.txt_id_registro.MaxLength = 10;
            this.txt_id_registro.Name = "txt_id_registro";
            this.txt_id_registro.Size = new System.Drawing.Size(253, 19);
            this.txt_id_registro.TabIndex = 52;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nombre.Location = new System.Drawing.Point(102, 68);
            this.txt_nombre.MaxLength = 10;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(286, 19);
            this.txt_nombre.TabIndex = 51;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(92, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 96);
            this.richTextBox1.TabIndex = 50;
            this.richTextBox1.Text = "";
            // 
            // lb_detalle
            // 
            this.lb_detalle.AutoSize = true;
            this.lb_detalle.BackColor = System.Drawing.Color.Transparent;
            this.lb_detalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detalle.ForeColor = System.Drawing.Color.LightGray;
            this.lb_detalle.Location = new System.Drawing.Point(7, 113);
            this.lb_detalle.Name = "lb_detalle";
            this.lb_detalle.Size = new System.Drawing.Size(79, 22);
            this.lb_detalle.TabIndex = 49;
            this.lb_detalle.Text = "Detalle:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(468, 89);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 19);
            this.textBox1.TabIndex = 48;
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.BackColor = System.Drawing.Color.Transparent;
            this.lb_precio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precio.ForeColor = System.Drawing.Color.LightGray;
            this.lb_precio.Location = new System.Drawing.Point(397, 87);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(71, 22);
            this.lb_precio.TabIndex = 47;
            this.lb_precio.Text = "Precio:";
            // 
            // cbox_subcategoria
            // 
            this.cbox_subcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbox_subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_subcategoria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_subcategoria.ForeColor = System.Drawing.Color.LightGray;
            this.cbox_subcategoria.FormattingEnabled = true;
            this.cbox_subcategoria.Items.AddRange(new object[] {
            "Inflamables",
            "No inflamables",
            "Eléctricas",
            "No eléctricas",
            "Tubería de PVC",
            "Tubería metálica",
            "Accesorios",
            "Electrónicos",
            "Inmuebles"});
            this.cbox_subcategoria.Location = new System.Drawing.Point(152, 35);
            this.cbox_subcategoria.Name = "cbox_subcategoria";
            this.cbox_subcategoria.Size = new System.Drawing.Size(236, 24);
            this.cbox_subcategoria.TabIndex = 46;
            // 
            // cbox_categoria
            // 
            this.cbox_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbox_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_categoria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_categoria.ForeColor = System.Drawing.Color.LightGray;
            this.cbox_categoria.FormattingEnabled = true;
            this.cbox_categoria.Items.AddRange(new object[] {
            "Químicos",
            "Herramientas",
            "Insumos",
            "Oficina"});
            this.cbox_categoria.Location = new System.Drawing.Point(122, 8);
            this.cbox_categoria.Name = "cbox_categoria";
            this.cbox_categoria.Size = new System.Drawing.Size(266, 24);
            this.cbox_categoria.TabIndex = 45;
            this.cbox_categoria.SelectedIndexChanged += new System.EventHandler(this.cbox_categoria_SelectedIndexChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_buscar.Location = new System.Drawing.Point(525, 207);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(238, 31);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // id_registro
            // 
            this.id_registro.AutoSize = true;
            this.id_registro.BackColor = System.Drawing.Color.Transparent;
            this.id_registro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_registro.ForeColor = System.Drawing.Color.LightGray;
            this.id_registro.Location = new System.Drawing.Point(7, 87);
            this.id_registro.Name = "id_registro";
            this.id_registro.Size = new System.Drawing.Size(132, 22);
            this.id_registro.TabIndex = 42;
            this.id_registro.Text = "ID generado:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.LightGray;
            this.textBox5.Location = new System.Drawing.Point(202, 219);
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
            this.label2.Location = new System.Drawing.Point(7, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Buscar por nombre:";
            // 
            // txt_stock_max
            // 
            this.txt_stock_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_stock_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stock_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_max.ForeColor = System.Drawing.Color.LightGray;
            this.txt_stock_max.Location = new System.Drawing.Point(537, 65);
            this.txt_stock_max.MaxLength = 10;
            this.txt_stock_max.Name = "txt_stock_max";
            this.txt_stock_max.Size = new System.Drawing.Size(249, 19);
            this.txt_stock_max.TabIndex = 39;
            // 
            // lb_stock_max
            // 
            this.lb_stock_max.AutoSize = true;
            this.lb_stock_max.BackColor = System.Drawing.Color.Transparent;
            this.lb_stock_max.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stock_max.ForeColor = System.Drawing.Color.LightGray;
            this.lb_stock_max.Location = new System.Drawing.Point(397, 63);
            this.lb_stock_max.Name = "lb_stock_max";
            this.lb_stock_max.Size = new System.Drawing.Size(141, 22);
            this.lb_stock_max.TabIndex = 38;
            this.lb_stock_max.Text = "Stock máximo:";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.LightGray;
            this.txt_correo.Location = new System.Drawing.Point(537, 42);
            this.txt_correo.MaxLength = 10;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(249, 19);
            this.txt_correo.TabIndex = 37;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.LightGray;
            this.txt_cantidad.Location = new System.Drawing.Point(507, 10);
            this.txt_cantidad.MaxLength = 10;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(279, 19);
            this.txt_cantidad.TabIndex = 36;
            // 
            // lb_stock_min
            // 
            this.lb_stock_min.AutoSize = true;
            this.lb_stock_min.BackColor = System.Drawing.Color.Transparent;
            this.lb_stock_min.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stock_min.ForeColor = System.Drawing.Color.LightGray;
            this.lb_stock_min.Location = new System.Drawing.Point(397, 40);
            this.lb_stock_min.Name = "lb_stock_min";
            this.lb_stock_min.Size = new System.Drawing.Size(134, 22);
            this.lb_stock_min.TabIndex = 34;
            this.lb_stock_min.Text = "Stock mínimo:";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.BackColor = System.Drawing.Color.Transparent;
            this.lb_categoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.ForeColor = System.Drawing.Color.LightGray;
            this.lb_categoria.Location = new System.Drawing.Point(7, 8);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(109, 22);
            this.lb_categoria.TabIndex = 31;
            this.lb_categoria.Text = "Categoria:";
            // 
            // lb_subcategoria
            // 
            this.lb_subcategoria.AutoSize = true;
            this.lb_subcategoria.BackColor = System.Drawing.Color.Transparent;
            this.lb_subcategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subcategoria.ForeColor = System.Drawing.Color.LightGray;
            this.lb_subcategoria.Location = new System.Drawing.Point(7, 40);
            this.lb_subcategoria.Name = "lb_subcategoria";
            this.lb_subcategoria.Size = new System.Drawing.Size(149, 22);
            this.lb_subcategoria.TabIndex = 30;
            this.lb_subcategoria.Text = "Sub-Categoria:";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.Color.LightGray;
            this.lb_nombre.Location = new System.Drawing.Point(7, 65);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(89, 22);
            this.lb_nombre.TabIndex = 32;
            this.lb_nombre.Text = "Nombre:";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_cantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.LightGray;
            this.lb_cantidad.Location = new System.Drawing.Point(397, 8);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(104, 22);
            this.lb_cantidad.TabIndex = 32;
            this.lb_cantidad.Text = "Cantidad:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-1, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 169);
            this.panel2.TabIndex = 35;
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
            // GUI_Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_emple_ingreso);
            this.Controls.Add(this.panel_emple_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Registros";
            this.Text = "GUI_Registros";
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

        private System.Windows.Forms.Panel panel_emple_btn;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label lb_registros;
        private System.Windows.Forms.Panel panel_emple_ingreso;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label id_registro;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stock_max;
        private System.Windows.Forms.Label lb_stock_max;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lb_stock_min;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label lb_subcategoria;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_categoria;
        private System.Windows.Forms.ComboBox cbox_subcategoria;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lb_detalle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_precio;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox txt_id_registro;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}