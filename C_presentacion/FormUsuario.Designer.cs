
namespace C_presentacion
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.datatableUSER = new System.Windows.Forms.DataGridView();
            this.txtbuscarUSER = new System.Windows.Forms.TextBox();
            this.btnEliminarUSER = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditarUSER = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatableUSER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // datatableUSER
            // 
            this.datatableUSER.AllowUserToAddRows = false;
            this.datatableUSER.AllowUserToDeleteRows = false;
            this.datatableUSER.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datatableUSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatableUSER.Location = new System.Drawing.Point(67, 119);
            this.datatableUSER.Name = "datatableUSER";
            this.datatableUSER.ReadOnly = true;
            this.datatableUSER.Size = new System.Drawing.Size(700, 449);
            this.datatableUSER.TabIndex = 32;
            // 
            // txtbuscarUSER
            // 
            this.txtbuscarUSER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscarUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarUSER.Location = new System.Drawing.Point(307, 60);
            this.txtbuscarUSER.Name = "txtbuscarUSER";
            this.txtbuscarUSER.Size = new System.Drawing.Size(267, 19);
            this.txtbuscarUSER.TabIndex = 31;
            this.txtbuscarUSER.TextChanged += new System.EventHandler(this.txtbuscarUSER_TextChanged);
            // 
            // btnEliminarUSER
            // 
            this.btnEliminarUSER.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarUSER.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarUSER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUSER.BorderRadius = 7;
            this.btnEliminarUSER.ButtonText = "ELIMINAR";
            this.btnEliminarUSER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUSER.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarUSER.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarUSER.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarUSER.Iconimage")));
            this.btnEliminarUSER.Iconimage_right = null;
            this.btnEliminarUSER.Iconimage_right_Selected = null;
            this.btnEliminarUSER.Iconimage_Selected = null;
            this.btnEliminarUSER.IconMarginLeft = 0;
            this.btnEliminarUSER.IconMarginRight = 0;
            this.btnEliminarUSER.IconRightVisible = true;
            this.btnEliminarUSER.IconRightZoom = 0D;
            this.btnEliminarUSER.IconVisible = true;
            this.btnEliminarUSER.IconZoom = 90D;
            this.btnEliminarUSER.IsTab = false;
            this.btnEliminarUSER.Location = new System.Drawing.Point(619, 612);
            this.btnEliminarUSER.Name = "btnEliminarUSER";
            this.btnEliminarUSER.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarUSER.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarUSER.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarUSER.selected = false;
            this.btnEliminarUSER.Size = new System.Drawing.Size(159, 48);
            this.btnEliminarUSER.TabIndex = 34;
            this.btnEliminarUSER.Text = "ELIMINAR";
            this.btnEliminarUSER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUSER.Textcolor = System.Drawing.Color.White;
            this.btnEliminarUSER.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUSER.Click += new System.EventHandler(this.btnEliminarUSER_Click);
            // 
            // btnEditarUSER
            // 
            this.btnEditarUSER.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnEditarUSER.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarUSER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarUSER.BorderRadius = 7;
            this.btnEditarUSER.ButtonText = "EDITAR";
            this.btnEditarUSER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUSER.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarUSER.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarUSER.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditarUSER.Iconimage")));
            this.btnEditarUSER.Iconimage_right = null;
            this.btnEditarUSER.Iconimage_right_Selected = null;
            this.btnEditarUSER.Iconimage_Selected = null;
            this.btnEditarUSER.IconMarginLeft = 0;
            this.btnEditarUSER.IconMarginRight = 0;
            this.btnEditarUSER.IconRightVisible = true;
            this.btnEditarUSER.IconRightZoom = 0D;
            this.btnEditarUSER.IconVisible = true;
            this.btnEditarUSER.IconZoom = 90D;
            this.btnEditarUSER.IsTab = false;
            this.btnEditarUSER.Location = new System.Drawing.Point(424, 612);
            this.btnEditarUSER.Name = "btnEditarUSER";
            this.btnEditarUSER.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEditarUSER.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnEditarUSER.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarUSER.selected = false;
            this.btnEditarUSER.Size = new System.Drawing.Size(159, 48);
            this.btnEditarUSER.TabIndex = 33;
            this.btnEditarUSER.Text = "EDITAR";
            this.btnEditarUSER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUSER.Textcolor = System.Drawing.Color.White;
            this.btnEditarUSER.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUSER.Click += new System.EventHandler(this.btnEditarUSER_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::C_presentacion.Properties.Resources.icons8_busca_mas_50;
            this.pictureBox3.Location = new System.Drawing.Point(263, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_presentacion.Properties.Resources.rec;
            this.pictureBox2.Location = new System.Drawing.Point(210, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 705);
            this.Controls.Add(this.btnEliminarUSER);
            this.Controls.Add(this.btnEditarUSER);
            this.Controls.Add(this.datatableUSER);
            this.Controls.Add(this.txtbuscarUSER);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatableUSER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarUSER;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarUSER;
        private System.Windows.Forms.DataGridView datatableUSER;
        private System.Windows.Forms.TextBox txtbuscarUSER;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}