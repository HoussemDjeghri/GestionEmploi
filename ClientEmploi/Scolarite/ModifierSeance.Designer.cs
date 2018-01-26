namespace ClientEmploi
{
    partial class ModifierSeance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierSeance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.annlerAjoutBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ajouterSeaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CreneauDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.salleDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 60);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier Séance";
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(1, 61);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(506, 386);
            this.panel10.TabIndex = 48;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.annlerAjoutBtn);
            this.panel8.Controls.Add(this.ajouterSeaBtn);
            this.panel8.Location = new System.Drawing.Point(1, 254);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(589, 58);
            this.panel8.TabIndex = 49;
            // 
            // annlerAjoutBtn
            // 
            this.annlerAjoutBtn.ActiveBorderThickness = 1;
            this.annlerAjoutBtn.ActiveCornerRadius = 5;
            this.annlerAjoutBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.annlerAjoutBtn.ActiveForecolor = System.Drawing.Color.DimGray;
            this.annlerAjoutBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.annlerAjoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.annlerAjoutBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.annlerAjoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("annlerAjoutBtn.BackgroundImage")));
            this.annlerAjoutBtn.ButtonText = "Annuler";
            this.annlerAjoutBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.annlerAjoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annlerAjoutBtn.ForeColor = System.Drawing.Color.White;
            this.annlerAjoutBtn.IdleBorderThickness = 1;
            this.annlerAjoutBtn.IdleCornerRadius = 5;
            this.annlerAjoutBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.annlerAjoutBtn.IdleForecolor = System.Drawing.SystemColors.GrayText;
            this.annlerAjoutBtn.IdleLineColor = System.Drawing.Color.Gray;
            this.annlerAjoutBtn.Location = new System.Drawing.Point(386, 5);
            this.annlerAjoutBtn.Margin = new System.Windows.Forms.Padding(5);
            this.annlerAjoutBtn.Name = "annlerAjoutBtn";
            this.annlerAjoutBtn.Size = new System.Drawing.Size(89, 44);
            this.annlerAjoutBtn.TabIndex = 16;
            this.annlerAjoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.annlerAjoutBtn.Click += new System.EventHandler(this.annlerAjoutBtn_Click);
            // 
            // ajouterSeaBtn
            // 
            this.ajouterSeaBtn.ActiveBorderThickness = 1;
            this.ajouterSeaBtn.ActiveCornerRadius = 5;
            this.ajouterSeaBtn.ActiveFillColor = System.Drawing.Color.Teal;
            this.ajouterSeaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ajouterSeaBtn.ActiveLineColor = System.Drawing.Color.Teal;
            this.ajouterSeaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouterSeaBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ajouterSeaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajouterSeaBtn.BackgroundImage")));
            this.ajouterSeaBtn.ButtonText = "Modifier";
            this.ajouterSeaBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajouterSeaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterSeaBtn.ForeColor = System.Drawing.Color.White;
            this.ajouterSeaBtn.IdleBorderThickness = 1;
            this.ajouterSeaBtn.IdleCornerRadius = 5;
            this.ajouterSeaBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.ajouterSeaBtn.IdleForecolor = System.Drawing.Color.White;
            this.ajouterSeaBtn.IdleLineColor = System.Drawing.Color.Teal;
            this.ajouterSeaBtn.Location = new System.Drawing.Point(485, 5);
            this.ajouterSeaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ajouterSeaBtn.Name = "ajouterSeaBtn";
            this.ajouterSeaBtn.Size = new System.Drawing.Size(91, 44);
            this.ajouterSeaBtn.TabIndex = 15;
            this.ajouterSeaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ajouterSeaBtn.Click += new System.EventHandler(this.ajouterSeaBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 196);
            this.panel2.TabIndex = 50;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.panel9.Controls.Add(this.CreneauDrop);
            this.panel9.Location = new System.Drawing.Point(233, 68);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(181, 30);
            this.panel9.TabIndex = 62;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // CreneauDrop
            // 
            this.CreneauDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreneauDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.CreneauDrop.BorderRadius = 20;
            this.CreneauDrop.DisabledColor = System.Drawing.Color.LightGray;
            this.CreneauDrop.ForeColor = System.Drawing.Color.Black;
            this.CreneauDrop.Items = new string[0];
            this.CreneauDrop.Location = new System.Drawing.Point(2, 1);
            this.CreneauDrop.Name = "CreneauDrop";
            this.CreneauDrop.NomalColor = System.Drawing.Color.White;
            this.CreneauDrop.onHoverColor = System.Drawing.Color.WhiteSmoke;
            this.CreneauDrop.selectedIndex = -1;
            this.CreneauDrop.Size = new System.Drawing.Size(178, 28);
            this.CreneauDrop.TabIndex = 3;
            this.CreneauDrop.onItemSelected += new System.EventHandler(this.CreneauDrop_onItemSelected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(152, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Creneau";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(21, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(397, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Veuillez choisir le creneau et la salle que vous voullez";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.panel7.Controls.Add(this.salleDrop);
            this.panel7.Location = new System.Drawing.Point(233, 118);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(181, 30);
            this.panel7.TabIndex = 59;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // salleDrop
            // 
            this.salleDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salleDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.salleDrop.BorderRadius = 20;
            this.salleDrop.DisabledColor = System.Drawing.Color.LightGray;
            this.salleDrop.Enabled = false;
            this.salleDrop.ForeColor = System.Drawing.Color.Black;
            this.salleDrop.Items = new string[0];
            this.salleDrop.Location = new System.Drawing.Point(2, 1);
            this.salleDrop.Name = "salleDrop";
            this.salleDrop.NomalColor = System.Drawing.Color.White;
            this.salleDrop.onHoverColor = System.Drawing.Color.WhiteSmoke;
            this.salleDrop.selectedIndex = -1;
            this.salleDrop.Size = new System.Drawing.Size(178, 28);
            this.salleDrop.TabIndex = 3;
            this.salleDrop.onItemSelected += new System.EventHandler(this.salleDrop_onItemSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(184, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Salle";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ModifierSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(591, 313);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifierSeance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterSeanceForm2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuThinButton2 annlerAjoutBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ajouterSeaBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuDropdown CreneauDrop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuDropdown salleDrop;
        private System.Windows.Forms.Label label7;
    }
}