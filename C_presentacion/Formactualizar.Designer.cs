
namespace C_presentacion
{
    partial class Formactualizar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formactualizar));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAULA2 = new System.Windows.Forms.ComboBox();
            this.combodepa2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hora_salida2 = new System.Windows.Forms.DateTimePicker();
            this.hora_entrada2 = new System.Windows.Forms.DateTimePicker();
            this.motivo_visita2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtcarrera2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombre2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcorreo2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtapellido2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcod2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGuardar2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(398, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "AULA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(54, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "DEPARTAMENTO:";
            // 
            // comboBoxAULA2
            // 
            this.comboBoxAULA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAULA2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAULA2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxAULA2.FormattingEnabled = true;
            this.comboBoxAULA2.Location = new System.Drawing.Point(400, 300);
            this.comboBoxAULA2.Name = "comboBoxAULA2";
            this.comboBoxAULA2.Size = new System.Drawing.Size(267, 29);
            this.comboBoxAULA2.TabIndex = 48;
            this.comboBoxAULA2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAULA2_SelectedIndexChanged);
            // 
            // combodepa2
            // 
            this.combodepa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodepa2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodepa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combodepa2.FormattingEnabled = true;
            this.combodepa2.Items.AddRange(new object[] {
            "Departamento A",
            "Departamento B",
            "Departamento C"});
            this.combodepa2.Location = new System.Drawing.Point(57, 300);
            this.combodepa2.Name = "combodepa2";
            this.combodepa2.Size = new System.Drawing.Size(213, 29);
            this.combodepa2.TabIndex = 47;
            this.combodepa2.SelectedIndexChanged += new System.EventHandler(this.combodepa2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(53, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "MOTIVO DE LA VISITA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(396, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "HORA DE SALIDA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(56, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "HORA DE ENTRADA:";
            // 
            // hora_salida2
            // 
            this.hora_salida2.CalendarFont = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_salida2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hora_salida2.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hora_salida2.CustomFormat = "yyyy-MM-dd";
            this.hora_salida2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora_salida2.Location = new System.Drawing.Point(400, 389);
            this.hora_salida2.Name = "hora_salida2";
            this.hora_salida2.Size = new System.Drawing.Size(117, 20);
            this.hora_salida2.TabIndex = 43;
            // 
            // hora_entrada2
            // 
            this.hora_entrada2.CalendarFont = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_entrada2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hora_entrada2.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hora_entrada2.CustomFormat = "yyyy-MM-dd";
            this.hora_entrada2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora_entrada2.Location = new System.Drawing.Point(57, 389);
            this.hora_entrada2.Name = "hora_entrada2";
            this.hora_entrada2.Size = new System.Drawing.Size(117, 20);
            this.hora_entrada2.TabIndex = 42;
            // 
            // motivo_visita2
            // 
            this.motivo_visita2.BorderColor = System.Drawing.Color.SeaGreen;
            this.motivo_visita2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo_visita2.Location = new System.Drawing.Point(56, 471);
            this.motivo_visita2.Multiline = true;
            this.motivo_visita2.Name = "motivo_visita2";
            this.motivo_visita2.Size = new System.Drawing.Size(478, 164);
            this.motivo_visita2.TabIndex = 41;
            // 
            // txtcarrera2
            // 
            this.txtcarrera2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcarrera2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarrera2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcarrera2.HintForeColor = System.Drawing.Color.Empty;
            this.txtcarrera2.HintText = "";
            this.txtcarrera2.isPassword = false;
            this.txtcarrera2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcarrera2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcarrera2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcarrera2.LineThickness = 4;
            this.txtcarrera2.Location = new System.Drawing.Point(60, 199);
            this.txtcarrera2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcarrera2.Name = "txtcarrera2";
            this.txtcarrera2.Size = new System.Drawing.Size(242, 33);
            this.txtcarrera2.TabIndex = 40;
            this.txtcarrera2.Text = "CARRERA:";
            this.txtcarrera2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcarrera2.Enter += new System.EventHandler(this.txtcarrera2_Enter);
            this.txtcarrera2.Leave += new System.EventHandler(this.txtcarrera2_Leave);
            // 
            // txtnombre2
            // 
            this.txtnombre2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre2.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombre2.HintText = "";
            this.txtnombre2.isPassword = false;
            this.txtnombre2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombre2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombre2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombre2.LineThickness = 4;
            this.txtnombre2.Location = new System.Drawing.Point(60, 120);
            this.txtnombre2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(242, 33);
            this.txtnombre2.TabIndex = 39;
            this.txtnombre2.Text = "NOMBRE:";
            this.txtnombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre2.Enter += new System.EventHandler(this.txtnombre2_Enter);
            this.txtnombre2.Leave += new System.EventHandler(this.txtnombre2_Leave);
            // 
            // txtcorreo2
            // 
            this.txtcorreo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcorreo2.HintForeColor = System.Drawing.Color.Empty;
            this.txtcorreo2.HintText = "";
            this.txtcorreo2.isPassword = false;
            this.txtcorreo2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcorreo2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcorreo2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcorreo2.LineThickness = 4;
            this.txtcorreo2.Location = new System.Drawing.Point(400, 199);
            this.txtcorreo2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcorreo2.Name = "txtcorreo2";
            this.txtcorreo2.Size = new System.Drawing.Size(381, 33);
            this.txtcorreo2.TabIndex = 38;
            this.txtcorreo2.Text = "CORREO:";
            this.txtcorreo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcorreo2.Enter += new System.EventHandler(this.txtcorreo2_Enter);
            this.txtcorreo2.Leave += new System.EventHandler(this.txtcorreo2_Leave);
            // 
            // txtapellido2
            // 
            this.txtapellido2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellido2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtapellido2.HintForeColor = System.Drawing.Color.Empty;
            this.txtapellido2.HintText = "";
            this.txtapellido2.isPassword = false;
            this.txtapellido2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtapellido2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtapellido2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtapellido2.LineThickness = 4;
            this.txtapellido2.Location = new System.Drawing.Point(400, 120);
            this.txtapellido2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(228, 33);
            this.txtapellido2.TabIndex = 37;
            this.txtapellido2.Text = "APELLIDO:";
            this.txtapellido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtapellido2.Enter += new System.EventHandler(this.txtapellido2_Enter);
            this.txtapellido2.Leave += new System.EventHandler(this.txtapellido2_Leave);
            // 
            // txtcod2
            // 
            this.txtcod2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcod2.Enabled = false;
            this.txtcod2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcod2.HintForeColor = System.Drawing.Color.Empty;
            this.txtcod2.HintText = "";
            this.txtcod2.isPassword = false;
            this.txtcod2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcod2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcod2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcod2.LineThickness = 4;
            this.txtcod2.Location = new System.Drawing.Point(60, 42);
            this.txtcod2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcod2.Name = "txtcod2";
            this.txtcod2.Size = new System.Drawing.Size(163, 33);
            this.txtcod2.TabIndex = 36;
            this.txtcod2.Text = "CODIGO:";
            this.txtcod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcod2.Enter += new System.EventHandler(this.txtcod2_Enter);
            this.txtcod2.Leave += new System.EventHandler(this.txtcod2_Leave);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar2.BorderRadius = 7;
            this.btnGuardar2.ButtonText = "GUARDAR";
            this.btnGuardar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar2.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar2.Iconimage")));
            this.btnGuardar2.Iconimage_right = null;
            this.btnGuardar2.Iconimage_right_Selected = null;
            this.btnGuardar2.Iconimage_Selected = null;
            this.btnGuardar2.IconMarginLeft = 0;
            this.btnGuardar2.IconMarginRight = 0;
            this.btnGuardar2.IconRightVisible = true;
            this.btnGuardar2.IconRightZoom = 0D;
            this.btnGuardar2.IconVisible = true;
            this.btnGuardar2.IconZoom = 90D;
            this.btnGuardar2.IsTab = false;
            this.btnGuardar2.Location = new System.Drawing.Point(659, 645);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar2.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar2.selected = false;
            this.btnGuardar2.Size = new System.Drawing.Size(159, 48);
            this.btnGuardar2.TabIndex = 51;
            this.btnGuardar2.Text = "GUARDAR";
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar2.Textcolor = System.Drawing.Color.White;
            this.btnGuardar2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_presentacion.Properties.Resources.Salir;
            this.pictureBox2.Location = new System.Drawing.Point(789, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Formactualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(830, 705);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAULA2);
            this.Controls.Add(this.combodepa2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hora_salida2);
            this.Controls.Add(this.hora_entrada2);
            this.Controls.Add(this.motivo_visita2);
            this.Controls.Add(this.txtcarrera2);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.txtcorreo2);
            this.Controls.Add(this.txtapellido2);
            this.Controls.Add(this.txtcod2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formactualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formactualizar";
            this.Load += new System.EventHandler(this.Formactualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxAULA2;
        public System.Windows.Forms.ComboBox combodepa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker hora_salida2;
        public System.Windows.Forms.DateTimePicker hora_entrada2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox motivo_visita2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcarrera2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcorreo2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtapellido2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcod2;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}