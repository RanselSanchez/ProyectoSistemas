
namespace C_presentacion
{
    partial class Formvisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formvisita));
            this.txtcod = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtapellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcarrera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.motivo_visita = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.hora_entrada = new System.Windows.Forms.DateTimePicker();
            this.hora_salida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxAULA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtcod
            // 
            this.txtcod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcod.HintForeColor = System.Drawing.Color.Empty;
            this.txtcod.HintText = "";
            this.txtcod.isPassword = false;
            this.txtcod.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcod.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcod.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcod.LineThickness = 4;
            this.txtcod.Location = new System.Drawing.Point(49, 46);
            this.txtcod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(163, 33);
            this.txtcod.TabIndex = 15;
            this.txtcod.Text = "CODIGO:";
            this.txtcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcod.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.txtcod.Enter += new System.EventHandler(this.txtcod_Enter);
            this.txtcod.Leave += new System.EventHandler(this.txtcod_Leave);
            // 
            // txtapellido
            // 
            this.txtapellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtapellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtapellido.HintText = "";
            this.txtapellido.isPassword = false;
            this.txtapellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtapellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txtapellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtapellido.LineThickness = 4;
            this.txtapellido.Location = new System.Drawing.Point(389, 124);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(228, 33);
            this.txtapellido.TabIndex = 16;
            this.txtapellido.Text = "APELLIDO:";
            this.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtapellido.Enter += new System.EventHandler(this.txtapellido_Enter);
            this.txtapellido.Leave += new System.EventHandler(this.txtapellido_Leave);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtcorreo.HintText = "";
            this.txtcorreo.isPassword = false;
            this.txtcorreo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcorreo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcorreo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcorreo.LineThickness = 4;
            this.txtcorreo.Location = new System.Drawing.Point(389, 203);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(381, 33);
            this.txtcorreo.TabIndex = 17;
            this.txtcorreo.Text = "CORREO:";
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombre.HintText = "";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombre.LineThickness = 4;
            this.txtnombre.Location = new System.Drawing.Point(49, 124);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(242, 33);
            this.txtnombre.TabIndex = 18;
            this.txtnombre.Text = "NOMBRE:";
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtcarrera
            // 
            this.txtcarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcarrera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcarrera.HintForeColor = System.Drawing.Color.Empty;
            this.txtcarrera.HintText = "";
            this.txtcarrera.isPassword = false;
            this.txtcarrera.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcarrera.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcarrera.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcarrera.LineThickness = 4;
            this.txtcarrera.Location = new System.Drawing.Point(49, 203);
            this.txtcarrera.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(242, 33);
            this.txtcarrera.TabIndex = 19;
            this.txtcarrera.Text = "CARRERA:";
            this.txtcarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcarrera.Enter += new System.EventHandler(this.txtcarrera_Enter);
            this.txtcarrera.Leave += new System.EventHandler(this.txtcarrera_Leave);
            // 
            // motivo_visita
            // 
            this.motivo_visita.BorderColor = System.Drawing.Color.SeaGreen;
            this.motivo_visita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo_visita.Location = new System.Drawing.Point(45, 475);
            this.motivo_visita.Multiline = true;
            this.motivo_visita.Name = "motivo_visita";
            this.motivo_visita.Size = new System.Drawing.Size(478, 164);
            this.motivo_visita.TabIndex = 24;
            // 
            // hora_entrada
            // 
            this.hora_entrada.CalendarFont = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_entrada.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hora_entrada.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hora_entrada.CustomFormat = "yyyy-MM-dd";
            this.hora_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora_entrada.Location = new System.Drawing.Point(46, 393);
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.Size = new System.Drawing.Size(117, 20);
            this.hora_entrada.TabIndex = 25;
            // 
            // hora_salida
            // 
            this.hora_salida.CalendarFont = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_salida.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hora_salida.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hora_salida.CustomFormat = "yyyy-MM-dd";
            this.hora_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora_salida.Location = new System.Drawing.Point(389, 393);
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.Size = new System.Drawing.Size(117, 20);
            this.hora_salida.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(45, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "HORA DE ENTRADA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(385, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "HORA DE SALIDA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(42, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "MOTIVO DE LA VISITA:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Departamento A",
            "Departamento B",
            "Departamento C"});
            this.comboBox1.Location = new System.Drawing.Point(46, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 29);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxAULA
            // 
            this.comboBoxAULA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAULA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAULA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxAULA.FormattingEnabled = true;
            this.comboBoxAULA.Location = new System.Drawing.Point(389, 304);
            this.comboBoxAULA.Name = "comboBoxAULA";
            this.comboBoxAULA.Size = new System.Drawing.Size(267, 29);
            this.comboBoxAULA.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(43, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "DEPARTAMENTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(387, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "AULA:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 7;
            this.btnNuevo.ButtonText = "NUEVO";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 90D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(656, 645);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(146, 48);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(480, 645);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(159, 48);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Formvisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxAULA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hora_salida);
            this.Controls.Add(this.hora_entrada);
            this.Controls.Add(this.motivo_visita);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formvisita";
            this.Text = "Formvisita";
            this.Load += new System.EventHandler(this.Formvisita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker hora_entrada;
        public System.Windows.Forms.DateTimePicker hora_salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcod;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtapellido;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcorreo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcarrera;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox motivo_visita;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBoxAULA;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
    }
}