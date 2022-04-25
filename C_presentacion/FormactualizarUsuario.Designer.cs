
namespace C_presentacion
{
    partial class FormactualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormactualizarUsuario));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_nacimiento2 = new System.Windows.Forms.DateTimePicker();
            this.comboboxtipo2 = new System.Windows.Forms.ComboBox();
            this.txtCrearpass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcrearuser2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLastNameUser2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameUser2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGuardaruser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(466, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "TIPO DE USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(65, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "FECHA DE NACIMINIENTO:";
            // 
            // Fecha_nacimiento2
            // 
            this.Fecha_nacimiento2.CalendarFont = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_nacimiento2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fecha_nacimiento2.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.Fecha_nacimiento2.CustomFormat = "yyyy-MM-dd";
            this.Fecha_nacimiento2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_nacimiento2.Location = new System.Drawing.Point(66, 268);
            this.Fecha_nacimiento2.Name = "Fecha_nacimiento2";
            this.Fecha_nacimiento2.Size = new System.Drawing.Size(117, 20);
            this.Fecha_nacimiento2.TabIndex = 42;
            // 
            // comboboxtipo2
            // 
            this.comboboxtipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxtipo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxtipo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboboxtipo2.FormattingEnabled = true;
            this.comboboxtipo2.Items.AddRange(new object[] {
            "Administrador",
            "General"});
            this.comboboxtipo2.Location = new System.Drawing.Point(470, 265);
            this.comboboxtipo2.Name = "comboboxtipo2";
            this.comboboxtipo2.Size = new System.Drawing.Size(213, 29);
            this.comboboxtipo2.TabIndex = 41;
            // 
            // txtCrearpass2
            // 
            this.txtCrearpass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCrearpass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearpass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCrearpass2.HintForeColor = System.Drawing.Color.Empty;
            this.txtCrearpass2.HintText = "";
            this.txtCrearpass2.isPassword = false;
            this.txtCrearpass2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCrearpass2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCrearpass2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCrearpass2.LineThickness = 4;
            this.txtCrearpass2.Location = new System.Drawing.Point(276, 506);
            this.txtCrearpass2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCrearpass2.Name = "txtCrearpass2";
            this.txtCrearpass2.Size = new System.Drawing.Size(281, 40);
            this.txtCrearpass2.TabIndex = 40;
            this.txtCrearpass2.Text = "CONTRASEÑA:";
            this.txtCrearpass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCrearpass2.Enter += new System.EventHandler(this.txtCrearpass2_Enter);
            this.txtCrearpass2.Leave += new System.EventHandler(this.txtCrearpass2_Leave);
            // 
            // txtcrearuser2
            // 
            this.txtcrearuser2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcrearuser2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrearuser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcrearuser2.HintForeColor = System.Drawing.Color.Empty;
            this.txtcrearuser2.HintText = "";
            this.txtcrearuser2.isPassword = false;
            this.txtcrearuser2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcrearuser2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcrearuser2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcrearuser2.LineThickness = 4;
            this.txtcrearuser2.Location = new System.Drawing.Point(276, 392);
            this.txtcrearuser2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcrearuser2.Name = "txtcrearuser2";
            this.txtcrearuser2.Size = new System.Drawing.Size(273, 40);
            this.txtcrearuser2.TabIndex = 39;
            this.txtcrearuser2.Text = "USUARIO:";
            this.txtcrearuser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcrearuser2.Enter += new System.EventHandler(this.txtcrearuser2_Enter);
            this.txtcrearuser2.Leave += new System.EventHandler(this.txtcrearuser2_Leave);
            // 
            // txtLastNameUser2
            // 
            this.txtLastNameUser2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameUser2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastNameUser2.HintForeColor = System.Drawing.Color.Empty;
            this.txtLastNameUser2.HintText = "";
            this.txtLastNameUser2.isPassword = false;
            this.txtLastNameUser2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLastNameUser2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLastNameUser2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLastNameUser2.LineThickness = 4;
            this.txtLastNameUser2.Location = new System.Drawing.Point(470, 110);
            this.txtLastNameUser2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLastNameUser2.Name = "txtLastNameUser2";
            this.txtLastNameUser2.Size = new System.Drawing.Size(289, 40);
            this.txtLastNameUser2.TabIndex = 38;
            this.txtLastNameUser2.Text = "APELLIDO:";
            this.txtLastNameUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastNameUser2.Enter += new System.EventHandler(this.txtLastNameUser2_Enter);
            this.txtLastNameUser2.Leave += new System.EventHandler(this.txtLastNameUser2_Leave);
            // 
            // txtNameUser2
            // 
            this.txtNameUser2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUser2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameUser2.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameUser2.HintText = "";
            this.txtNameUser2.isPassword = false;
            this.txtNameUser2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNameUser2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNameUser2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNameUser2.LineThickness = 4;
            this.txtNameUser2.Location = new System.Drawing.Point(69, 110);
            this.txtNameUser2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNameUser2.Name = "txtNameUser2";
            this.txtNameUser2.Size = new System.Drawing.Size(289, 40);
            this.txtNameUser2.TabIndex = 37;
            this.txtNameUser2.Text = "NOMBRE:";
            this.txtNameUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameUser2.Enter += new System.EventHandler(this.txtNameUser2_Enter);
            this.txtNameUser2.Leave += new System.EventHandler(this.txtNameUser2_Leave);
            // 
            // btnGuardaruser
            // 
            this.btnGuardaruser.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardaruser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardaruser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardaruser.BorderRadius = 7;
            this.btnGuardaruser.ButtonText = "GUARDAR";
            this.btnGuardaruser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardaruser.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardaruser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardaruser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardaruser.Iconimage")));
            this.btnGuardaruser.Iconimage_right = null;
            this.btnGuardaruser.Iconimage_right_Selected = null;
            this.btnGuardaruser.Iconimage_Selected = null;
            this.btnGuardaruser.IconMarginLeft = 0;
            this.btnGuardaruser.IconMarginRight = 0;
            this.btnGuardaruser.IconRightVisible = true;
            this.btnGuardaruser.IconRightZoom = 0D;
            this.btnGuardaruser.IconVisible = true;
            this.btnGuardaruser.IconZoom = 90D;
            this.btnGuardaruser.IsTab = false;
            this.btnGuardaruser.Location = new System.Drawing.Point(571, 610);
            this.btnGuardaruser.Name = "btnGuardaruser";
            this.btnGuardaruser.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardaruser.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardaruser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardaruser.selected = false;
            this.btnGuardaruser.Size = new System.Drawing.Size(208, 48);
            this.btnGuardaruser.TabIndex = 45;
            this.btnGuardaruser.Text = "GUARDAR";
            this.btnGuardaruser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardaruser.Textcolor = System.Drawing.Color.White;
            this.btnGuardaruser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaruser.Click += new System.EventHandler(this.btnGuardaruser_Click);
            // 
            // botonsalir
            // 
            this.botonsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonsalir.Location = new System.Drawing.Point(788, 10);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(29, 35);
            this.botonsalir.TabIndex = 46;
            this.botonsalir.Text = "X";
            this.botonsalir.UseVisualStyleBackColor = true;
            this.botonsalir.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // FormactualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 705);
            this.Controls.Add(this.botonsalir);
            this.Controls.Add(this.btnGuardaruser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha_nacimiento2);
            this.Controls.Add(this.comboboxtipo2);
            this.Controls.Add(this.txtCrearpass2);
            this.Controls.Add(this.txtcrearuser2);
            this.Controls.Add(this.txtLastNameUser2);
            this.Controls.Add(this.txtNameUser2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormactualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormactualizarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker Fecha_nacimiento2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardaruser;
        private System.Windows.Forms.Button botonsalir;
        public System.Windows.Forms.ComboBox comboboxtipo2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCrearpass2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtcrearuser2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtLastNameUser2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNameUser2;
    }
}