namespace WindowsFormsApp2
{
    partial class Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.tbxfrom = new System.Windows.Forms.TextBox();
            this.tbxto = new System.Windows.Forms.TextBox();
            this.btnswitch = new System.Windows.Forms.Button();
            this.lblfrom = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerb = new System.Windows.Forms.Button();
            this.lblto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxdisplay1 = new System.Windows.Forms.ListBox();
            this.dgrhide = new System.Windows.Forms.DataGridView();
            this.lbxdisplay2 = new System.Windows.Forms.ListBox();
            this.btnoptions = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrhide)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxfrom
            // 
            this.tbxfrom.Location = new System.Drawing.Point(10, 70);
            this.tbxfrom.Multiline = true;
            this.tbxfrom.Name = "tbxfrom";
            this.tbxfrom.Size = new System.Drawing.Size(198, 28);
            this.tbxfrom.TabIndex = 0;
            this.tbxfrom.TextChanged += new System.EventHandler(this.Tbxfrom_TextChanged);
            this.tbxfrom.Enter += new System.EventHandler(this.Tbxfrom_Enter);
            this.tbxfrom.Leave += new System.EventHandler(this.Tbxfrom_Leave);
            this.tbxfrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbxfrom_MouseDown);
            // 
            // tbxto
            // 
            this.tbxto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxto.Location = new System.Drawing.Point(294, 70);
            this.tbxto.Multiline = true;
            this.tbxto.Name = "tbxto";
            this.tbxto.Size = new System.Drawing.Size(198, 28);
            this.tbxto.TabIndex = 1;
            this.tbxto.TextChanged += new System.EventHandler(this.Tbxto_TextChanged);
            this.tbxto.Enter += new System.EventHandler(this.Tbxto_Enter);
            this.tbxto.Leave += new System.EventHandler(this.Tbxto_Leave);
            this.tbxto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbxto_MouseDown);
            // 
            // btnswitch
            // 
            this.btnswitch.BackColor = System.Drawing.SystemColors.Window;
            this.btnswitch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnswitch.FlatAppearance.BorderSize = 0;
            this.btnswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnswitch.ForeColor = System.Drawing.Color.Red;
            this.btnswitch.Location = new System.Drawing.Point(215, 69);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(73, 29);
            this.btnswitch.TabIndex = 2;
            this.btnswitch.Text = "↔";
            this.btnswitch.UseVisualStyleBackColor = false;
            this.btnswitch.Click += new System.EventHandler(this.Btnswitch_Click);
            // 
            // lblfrom
            // 
            this.lblfrom.BackColor = System.Drawing.SystemColors.Window;
            this.lblfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(294, 124);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(59, 20);
            this.lblfrom.TabIndex = 3;
            this.lblfrom.Text = "Abfahrt  ";
            this.lblfrom.Click += new System.EventHandler(this.Label1_Click);
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(167, 103);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(25, 13);
            this.time.TabIndex = 6;
            this.time.Text = "Zeit";
            // 
            // from
            // 
            this.from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(6, 51);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(26, 13);
            this.from.TabIndex = 11;
            this.from.Text = "Von";
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(291, 51);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(33, 13);
            this.to.TabIndex = 12;
            this.to.Text = "Nach";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum";
            // 
            // btnVerb
            // 
            this.btnVerb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerb.BackColor = System.Drawing.Color.Red;
            this.btnVerb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerb.Location = new System.Drawing.Point(359, 103);
            this.btnVerb.Name = "btnVerb";
            this.btnVerb.Size = new System.Drawing.Size(133, 41);
            this.btnVerb.TabIndex = 14;
            this.btnVerb.Text = "Verbindung suchen →";
            this.btnVerb.UseVisualStyleBackColor = false;
            this.btnVerb.Click += new System.EventHandler(this.BtnVerb_Click);
            // 
            // lblto
            // 
            this.lblto.BackColor = System.Drawing.SystemColors.Window;
            this.lblto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(294, 103);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(59, 21);
            this.lblto.TabIndex = 15;
            this.lblto.Text = "Ankunft";
            this.lblto.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(9, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(483, 1);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // lbxdisplay1
            // 
            this.lbxdisplay1.FormattingEnabled = true;
            this.lbxdisplay1.Location = new System.Drawing.Point(9, 103);
            this.lbxdisplay1.Name = "lbxdisplay1";
            this.lbxdisplay1.Size = new System.Drawing.Size(198, 95);
            this.lbxdisplay1.TabIndex = 17;
            this.lbxdisplay1.SelectedIndexChanged += new System.EventHandler(this.Lbxdisplay1_SelectedIndexChanged);
            this.lbxdisplay1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LbxAnzeige_MouseDown);
            // 
            // dgrhide
            // 
            this.dgrhide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrhide.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrhide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrhide.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtszeit});
            this.dgrhide.Location = new System.Drawing.Point(10, 162);
            this.dgrhide.Name = "dgrhide";
            this.dgrhide.Size = new System.Drawing.Size(482, 299);
            this.dgrhide.TabIndex = 18;
            this.dgrhide.Visible = false;
            this.dgrhide.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrhide_CellContentClick);
            // 
            // lbxdisplay2
            // 
            this.lbxdisplay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxdisplay2.FormattingEnabled = true;
            this.lbxdisplay2.Location = new System.Drawing.Point(294, 103);
            this.lbxdisplay2.Name = "lbxdisplay2";
            this.lbxdisplay2.Size = new System.Drawing.Size(198, 95);
            this.lbxdisplay2.TabIndex = 19;
            this.lbxdisplay2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbxdisplay2_MouseDown);
            // 
            // btnoptions
            // 
            this.btnoptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnoptions.BackColor = System.Drawing.Color.White;
            this.btnoptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnoptions.BackgroundImage")));
            this.btnoptions.ForeColor = System.Drawing.Color.Red;
            this.btnoptions.Location = new System.Drawing.Point(467, 9);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(25, 25);
            this.btnoptions.TabIndex = 20;
            this.btnoptions.UseVisualStyleBackColor = false;
            this.btnoptions.Click += new System.EventHandler(this.Btnoptions_Click);
            // 
            // titel
            // 
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(4, 9);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(259, 36);
            this.titel.TabIndex = 21;
            this.titel.Text = "SBB App";
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(9, 119);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(198, 20);
            this.dtpdate.TabIndex = 22;
            // 
            // dtptime
            // 
            this.dtptime.Location = new System.Drawing.Point(213, 119);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(75, 20);
            this.dtptime.TabIndex = 23;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Column1";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(504, 471);
            this.Controls.Add(this.lbxdisplay1);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.btnoptions);
            this.Controls.Add(this.lbxdisplay2);
            this.Controls.Add(this.dgrhide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.btnVerb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.btnswitch);
            this.Controls.Add(this.tbxto);
            this.Controls.Add(this.tbxfrom);
            this.Name = "Mainform";
            this.Text = "SBB App";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrhide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxfrom;
        private System.Windows.Forms.TextBox tbxto;
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerb;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxdisplay1;
        private System.Windows.Forms.DataGridView dgrhide;
        private System.Windows.Forms.ListBox lbxdisplay2;
        private System.Windows.Forms.Button btnoptions;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
    }
}

