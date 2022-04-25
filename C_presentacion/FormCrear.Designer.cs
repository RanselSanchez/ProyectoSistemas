
namespace C_presentacion
{
    partial class FormCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrear));
            this.txtNameUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLastNameUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcrearuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCrearpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboboxtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnNuevouser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardaruser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameUser
            // 
            this.txtNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameUser.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameUser.HintText = "";
            this.txtNameUser.isPassword = false;
            this.txtNameUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNameUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNameUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNameUser.LineThickness = 4;
            this.txtNameUser.Location = new System.Drawing.Point(47, 67);
            this.txtNameUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(289, 40);
            this.txtNameUser.TabIndex = 0;
            this.txtNameUser.Text = "NOMBRE:";
            this.txtNameUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameUser.Enter += new System.EventHandler(this.txtNameUser_Enter);
            this.txtNameUser.Leave += new System.EventHandler(this.txtNameUser_Leave);
            // 
            // txtLastNameUser
            // 
            this.txtLastNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastNameUser.HintForeColor = System.Drawing.Color.Empty;
            this.txtLastNameUser.HintText = "";
            this.txtLastNameUser.isPassword = false;
            this.txtLastNameUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLastNameUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLastNameUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLastNameUser.LineThickness = 4;
            this.txtLastNameUser.Location = new System.Drawing.Point(448, 67);
            this.txtLastNameUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLastNameUser.Name = "txtLastNameUser";
            this.txtLastNameUser.Size = new System.Drawing.Size(289, 40);
            this.txtLastNameUser.TabIndex = 1;
            this.txtLastNameUser.Text = "APELLIDO:";
            this.txtLastNameUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastNameUser.Enter += new System.EventHandler(this.txtLastNameUser_Enter);
            this.txtLastNameUser.Leave += new System.EventHandler(this.txtLastNameUser_Leave);
            // 
            // txtcrearuser
            // 
            this.txtcrearuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcrearuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrearuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcrearuser.HintForeColor = System.Drawing.Color.Empty;
            this.txtcrearuser.HintText = "";
            this.txtcrearuser.isPassword = false;
            this.txtcrearuser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcrearuser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcrearuser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcrearuser.LineThickness = 4;
            this.txtcrearuser.Location = new System.Drawing.Point(254, 349);
            this.txtcrearuser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcrearuser.Name = "txtcrearuser";
            this.txtcrearuser.Size = new System.Drawing.Size(273, 40);
            this.txtcrearuser.TabIndex = 3;
            this.txtcrearuser.Text = "USUARIO:";
            this.txtcrearuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcrearuser.Enter += new System.EventHandler(this.txtcrearuser_Enter);
            this.txtcrearuser.Leave += new System.EventHandler(this.txtcrearuser_Leave);
            // 
            // txtCrearpass
            // 
            this.txtCrearpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCrearpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCrearpass.HintForeColor = System.Drawing.Color.Empty;
            this.txtCrearpass.HintText = "";
            this.txtCrearpass.isPassword = false;
            this.txtCrearpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCrearpass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCrearpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCrearpass.LineThickness = 4;
            this.txtCrearpass.Location = new System.Drawing.Point(254, 463);
            this.txtCrearpass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCrearpass.Name = "txtCrearpass";
            this.txtCrearpass.Size = new System.Drawing.Size(281, 40);
            this.txtCrearpass.TabIndex = 4;
            this.txtCrearpass.Text = "CONTRASEÑA:";
            this.txtCrearpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCrearpass.Enter += new System.EventHandler(this.txtCrearpass_Enter);
            this.txtCrearpass.Leave += new System.EventHandler(this.txtCrearpass_Leave);
            // 
            // comboboxtipo
            // 
            this.comboboxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxtipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboboxtipo.FormattingEnabled = true;
            this.comboboxtipo.Items.AddRange(new object[] {
            "Administrador",
            "General"});
            this.comboboxtipo.Location = new System.Drawing.Point(448, 222);
            this.comboboxtipo.Name = "comboboxtipo";
            this.comboboxtipo.Size = new System.Drawing.Size(213, 29);
            this.comboboxtipo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(43, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "FECHA DE NACIMINIENTO:";
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.CalendarFont = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_nacimiento.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fecha_nacimiento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.Fecha_nacimiento.CustomFormat = "yyyy-MM-dd";
            this.Fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_nacimiento.Location = new System.Drawing.Point(44, 225);
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.Size = new System.Drawing.Size(117, 20);
            this.Fecha_nacimiento.TabIndex = 32;
            // 
            // btnNuevouser
            // 
            this.btnNuevouser.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevouser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevouser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevouser.BorderRadius = 7;
            this.btnNuevouser.ButtonText = "NUEVO";
            this.btnNuevouser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevouser.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevouser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevouser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevouser.Iconimage")));
            this.btnNuevouser.Iconimage_right = null;
            this.btnNuevouser.Iconimage_right_Selected = null;
            this.btnNuevouser.Iconimage_Selected = null;
            this.btnNuevouser.IconMarginLeft = 0;
            this.btnNuevouser.IconMarginRight = 0;
            this.btnNuevouser.IconRightVisible = true;
            this.btnNuevouser.IconRightZoom = 0D;
            this.btnNuevouser.IconVisible = true;
            this.btnNuevouser.IconZoom = 90D;
            this.btnNuevouser.IsTab = false;
            this.btnNuevouser.Location = new System.Drawing.Point(421, 553);
            this.btnNuevouser.Name = "btnNuevouser";
            this.btnNuevouser.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevouser.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevouser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevouser.selected = false;
            this.btnNuevouser.Size = new System.Drawing.Size(216, 48);
            this.btnNuevouser.TabIndex = 35;
            this.btnNuevouser.Text = "NUEVO";
            this.btnNuevouser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevouser.Textcolor = System.Drawing.Color.White;
            this.btnNuevouser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevouser.Click += new System.EventHandler(this.btnNuevouser_Click);
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
            this.btnGuardaruser.Location = new System.Drawing.Point(128, 553);
            this.btnGuardaruser.Name = "btnGuardaruser";
            this.btnGuardaruser.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardaruser.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardaruser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardaruser.selected = false;
            this.btnGuardaruser.Size = new System.Drawing.Size(208, 48);
            this.btnGuardaruser.TabIndex = 34;
            this.btnGuardaruser.Text = "GUARDAR";
            this.btnGuardaruser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardaruser.Textcolor = System.Drawing.Color.White;
            this.btnGuardaruser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaruser.Click += new System.EventHandler(this.btnGuardaruser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(444, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "TIPO DE USUARIO:";
            // 
            // FormCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevouser);
            this.Controls.Add(this.btnGuardaruser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha_nacimiento);
            this.Controls.Add(this.comboboxtipo);
            this.Controls.Add(this.txtCrearpass);
            this.Controls.Add(this.txtcrearuser);
            this.Controls.Add(this.txtLastNameUser);
            this.Controls.Add(this.txtNameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrear";
            this.Text = "FormCrear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastNameUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcrearuser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCrearpass;
        private System.Windows.Forms.ComboBox comboboxtipo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker Fecha_nacimiento;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevouser;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardaruser;
        private System.Windows.Forms.Label label2;
    }
}