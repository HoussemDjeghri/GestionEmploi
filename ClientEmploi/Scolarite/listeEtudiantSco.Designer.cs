namespace ClientEmploi
{
    partial class listeEtudiantSco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeEtudiantSco));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupeDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.niveauDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listeEtud = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 62);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(144)))), ((int)(((byte)(147)))));
            this.label11.Location = new System.Drawing.Point(44, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = " Liste des étudiants";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterBtn, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 66);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // filterBtn
            // 
            this.filterBtn.ActiveBorderThickness = 1;
            this.filterBtn.ActiveCornerRadius = 5;
            this.filterBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.filterBtn.ActiveForecolor = System.Drawing.Color.White;
            this.filterBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.filterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.filterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterBtn.BackgroundImage")));
            this.filterBtn.ButtonText = "Afficher liste";
            this.filterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.IdleBorderThickness = 1;
            this.filterBtn.IdleCornerRadius = 5;
            this.filterBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.filterBtn.IdleForecolor = System.Drawing.Color.White;
            this.filterBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.filterBtn.Location = new System.Drawing.Point(775, 9);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(5);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(181, 47);
            this.filterBtn.TabIndex = 7;
            this.filterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.panel4.Controls.Add(this.groupeDrop);
            this.panel4.Location = new System.Drawing.Point(491, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 37);
            this.panel4.TabIndex = 6;
            // 
            // groupeDrop
            // 
            this.groupeDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupeDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.groupeDrop.BorderRadius = 20;
            this.groupeDrop.DisabledColor = System.Drawing.Color.Gainsboro;
            this.groupeDrop.Enabled = false;
            this.groupeDrop.ForeColor = System.Drawing.Color.Black;
            this.groupeDrop.Items = new string[0];
            this.groupeDrop.Location = new System.Drawing.Point(2, 2);
            this.groupeDrop.Name = "groupeDrop";
            this.groupeDrop.NomalColor = System.Drawing.Color.White;
            this.groupeDrop.onHoverColor = System.Drawing.Color.WhiteSmoke;
            this.groupeDrop.selectedIndex = -1;
            this.groupeDrop.Size = new System.Drawing.Size(216, 34);
            this.groupeDrop.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.panel3.Controls.Add(this.niveauDrop);
            this.panel3.Location = new System.Drawing.Point(135, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 37);
            this.panel3.TabIndex = 5;
            // 
            // niveauDrop
            // 
            this.niveauDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.niveauDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.niveauDrop.BorderRadius = 20;
            this.niveauDrop.DisabledColor = System.Drawing.Color.Gray;
            this.niveauDrop.ForeColor = System.Drawing.Color.Black;
            this.niveauDrop.Items = new string[0];
            this.niveauDrop.Location = new System.Drawing.Point(2, 2);
            this.niveauDrop.Name = "niveauDrop";
            this.niveauDrop.NomalColor = System.Drawing.Color.White;
            this.niveauDrop.onHoverColor = System.Drawing.Color.WhiteSmoke;
            this.niveauDrop.selectedIndex = -1;
            this.niveauDrop.Size = new System.Drawing.Size(216, 34);
            this.niveauDrop.TabIndex = 3;
            this.niveauDrop.onItemSelected += new System.EventHandler(this.niveauDrop_onItemSelected);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listeEtud);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 489);
            this.panel2.TabIndex = 2;
            // 
            // listeEtud
            // 
            this.listeEtud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.listeEtud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listeEtud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom});
            this.listeEtud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeEtud.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeEtud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(144)))), ((int)(((byte)(147)))));
            this.listeEtud.HideSelection = false;
            this.listeEtud.Location = new System.Drawing.Point(0, 0);
            this.listeEtud.Name = "listeEtud";
            this.listeEtud.Size = new System.Drawing.Size(1013, 489);
            this.listeEtud.TabIndex = 0;
            this.listeEtud.UseCompatibleStateImageBehavior = false;
            this.listeEtud.View = System.Windows.Forms.View.Details;
            this.listeEtud.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listeEtud.SelectedIndexChanged += new System.EventHandler(this.listeEtud_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 506;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 507;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(414, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 66);
            this.label13.TabIndex = 19;
            this.label13.Text = "Groupe";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(63, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 66);
            this.label12.TabIndex = 20;
            this.label12.Text = "Niveau";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listeEtudiantSco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listeEtudiantSco";
            this.Text = "listeEtudiant";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDropdown niveauDrop;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDropdown groupeDrop;
        private Bunifu.Framework.UI.BunifuThinButton2 filterBtn;
        private System.Windows.Forms.ListView listeEtud;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}