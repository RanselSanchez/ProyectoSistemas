
namespace C_presentacion
{
    partial class Formprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formprincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.Panel();
            this.lbltema = new System.Windows.Forms.Label();
            this.wrapper = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnusuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnregistros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnvisitas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.top.SuspendLayout();
            this.wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnusuario);
            this.panel1.Controls.Add(this.btncrear);
            this.panel1.Controls.Add(this.btnregistros);
            this.panel1.Controls.Add(this.btnvisitas);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 744);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.lbltipo);
            this.panel4.Controls.Add(this.lblusuario);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 191);
            this.panel4.TabIndex = 0;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltipo.Location = new System.Drawing.Point(55, 159);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(96, 19);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Administrador";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusuario.Location = new System.Drawing.Point(42, 138);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(127, 21);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Ransel Sanchez";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.SystemColors.Highlight;
            this.top.Controls.Add(this.lbltema);
            this.top.Controls.Add(this.pictureBox2);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(220, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(830, 39);
            this.top.TabIndex = 1;
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltema.Location = new System.Drawing.Point(10, 7);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(151, 25);
            this.lbltema.TabIndex = 3;
            this.lbltema.Text = "Menu principal";
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wrapper.Controls.Add(this.pictureBox3);
            this.wrapper.Controls.Add(this.label1);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(220, 39);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(830, 705);
            this.wrapper.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(107, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::C_presentacion.Properties.Resources.descarga__1_;
            this.pictureBox3.Location = new System.Drawing.Point(15, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(803, 425);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_presentacion.Properties.Resources.Salir;
            this.pictureBox2.Location = new System.Drawing.Point(787, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.Activecolor = System.Drawing.SystemColors.Highlight;
            this.btnusuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuario.BorderRadius = 0;
            this.btnusuario.ButtonText = "USUARIOS";
            this.btnusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusuario.DisabledColor = System.Drawing.Color.White;
            this.btnusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnusuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnusuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnusuario.Iconimage")));
            this.btnusuario.Iconimage_right = null;
            this.btnusuario.Iconimage_right_Selected = null;
            this.btnusuario.Iconimage_Selected = null;
            this.btnusuario.IconMarginLeft = 0;
            this.btnusuario.IconMarginRight = 0;
            this.btnusuario.IconRightVisible = true;
            this.btnusuario.IconRightZoom = 0D;
            this.btnusuario.IconVisible = true;
            this.btnusuario.IconZoom = 80D;
            this.btnusuario.IsTab = false;
            this.btnusuario.Location = new System.Drawing.Point(10, 481);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Normalcolor = System.Drawing.SystemColors.HighlightText;
            this.btnusuario.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnusuario.OnHoverTextColor = System.Drawing.Color.AliceBlue;
            this.btnusuario.selected = false;
            this.btnusuario.Size = new System.Drawing.Size(200, 48);
            this.btnusuario.TabIndex = 4;
            this.btnusuario.Text = "USUARIOS";
            this.btnusuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuario.Textcolor = System.Drawing.Color.Black;
            this.btnusuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btncrear
            // 
            this.btncrear.Activecolor = System.Drawing.SystemColors.Highlight;
            this.btncrear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btncrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncrear.BorderRadius = 0;
            this.btncrear.ButtonText = "CREAR USUARIO";
            this.btncrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrear.DisabledColor = System.Drawing.Color.White;
            this.btncrear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncrear.Iconcolor = System.Drawing.Color.Transparent;
            this.btncrear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncrear.Iconimage")));
            this.btncrear.Iconimage_right = null;
            this.btncrear.Iconimage_right_Selected = null;
            this.btncrear.Iconimage_Selected = null;
            this.btncrear.IconMarginLeft = 0;
            this.btncrear.IconMarginRight = 0;
            this.btncrear.IconRightVisible = true;
            this.btncrear.IconRightZoom = 0D;
            this.btncrear.IconVisible = true;
            this.btncrear.IconZoom = 80D;
            this.btncrear.IsTab = false;
            this.btncrear.Location = new System.Drawing.Point(10, 389);
            this.btncrear.Name = "btncrear";
            this.btncrear.Normalcolor = System.Drawing.SystemColors.HighlightText;
            this.btncrear.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btncrear.OnHoverTextColor = System.Drawing.Color.AliceBlue;
            this.btncrear.selected = false;
            this.btncrear.Size = new System.Drawing.Size(200, 48);
            this.btncrear.TabIndex = 3;
            this.btncrear.Text = "CREAR USUARIO";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Textcolor = System.Drawing.Color.Black;
            this.btncrear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnregistros
            // 
            this.btnregistros.Activecolor = System.Drawing.SystemColors.Highlight;
            this.btnregistros.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnregistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistros.BorderRadius = 0;
            this.btnregistros.ButtonText = "REGISTROS";
            this.btnregistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistros.DisabledColor = System.Drawing.Color.White;
            this.btnregistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnregistros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnregistros.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnregistros.Iconimage")));
            this.btnregistros.Iconimage_right = null;
            this.btnregistros.Iconimage_right_Selected = null;
            this.btnregistros.Iconimage_Selected = null;
            this.btnregistros.IconMarginLeft = 0;
            this.btnregistros.IconMarginRight = 0;
            this.btnregistros.IconRightVisible = true;
            this.btnregistros.IconRightZoom = 0D;
            this.btnregistros.IconVisible = true;
            this.btnregistros.IconZoom = 80D;
            this.btnregistros.IsTab = false;
            this.btnregistros.Location = new System.Drawing.Point(10, 304);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Normalcolor = System.Drawing.SystemColors.HighlightText;
            this.btnregistros.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnregistros.OnHoverTextColor = System.Drawing.Color.AliceBlue;
            this.btnregistros.selected = false;
            this.btnregistros.Size = new System.Drawing.Size(200, 48);
            this.btnregistros.TabIndex = 2;
            this.btnregistros.Text = "REGISTROS";
            this.btnregistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistros.Textcolor = System.Drawing.Color.Black;
            this.btnregistros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click);
            // 
            // btnvisitas
            // 
            this.btnvisitas.Activecolor = System.Drawing.SystemColors.Highlight;
            this.btnvisitas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnvisitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvisitas.BorderRadius = 0;
            this.btnvisitas.ButtonText = "VISITAS";
            this.btnvisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvisitas.DisabledColor = System.Drawing.Color.White;
            this.btnvisitas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnvisitas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnvisitas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnvisitas.Iconimage")));
            this.btnvisitas.Iconimage_right = null;
            this.btnvisitas.Iconimage_right_Selected = null;
            this.btnvisitas.Iconimage_Selected = null;
            this.btnvisitas.IconMarginLeft = 0;
            this.btnvisitas.IconMarginRight = 0;
            this.btnvisitas.IconRightVisible = true;
            this.btnvisitas.IconRightZoom = 0D;
            this.btnvisitas.IconVisible = true;
            this.btnvisitas.IconZoom = 80D;
            this.btnvisitas.IsTab = false;
            this.btnvisitas.Location = new System.Drawing.Point(10, 220);
            this.btnvisitas.Name = "btnvisitas";
            this.btnvisitas.Normalcolor = System.Drawing.SystemColors.HighlightText;
            this.btnvisitas.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnvisitas.OnHoverTextColor = System.Drawing.Color.AliceBlue;
            this.btnvisitas.selected = false;
            this.btnvisitas.Size = new System.Drawing.Size(200, 48);
            this.btnvisitas.TabIndex = 1;
            this.btnvisitas.Text = "VISITAS";
            this.btnvisitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvisitas.Textcolor = System.Drawing.Color.Black;
            this.btnvisitas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisitas.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_presentacion.Properties.Resources.icons8_account_64;
            this.pictureBox1.Location = new System.Drawing.Point(31, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::C_presentacion.Properties.Resources.descarga;
            this.pictureBox4.Location = new System.Drawing.Point(3, 566);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(212, 115);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 744);
            this.Controls.Add(this.wrapper);
            this.Controls.Add(this.top);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formprincipal";
            this.Load += new System.EventHandler(this.Formprincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltema;
        private Bunifu.Framework.UI.BunifuFlatButton btnvisitas;
        private Bunifu.Framework.UI.BunifuFlatButton btnusuario;
        private Bunifu.Framework.UI.BunifuFlatButton btncrear;
        private Bunifu.Framework.UI.BunifuFlatButton btnregistros;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}