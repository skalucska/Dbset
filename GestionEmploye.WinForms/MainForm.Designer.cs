
namespace GestionEmploye.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pan_header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_listEmploye = new System.Windows.Forms.Panel();
            this.listBox_employes = new System.Windows.Forms.ListBox();
            this.pan_rafraichir = new System.Windows.Forms.Panel();
            this.rafraichir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.enregistrer = new System.Windows.Forms.Button();
            this.check_estPiloteDeLigne = new System.Windows.Forms.CheckBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.lab_role = new System.Windows.Forms.Label();
            this.dtp_dateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.lab_dateEmbauche = new System.Windows.Forms.Label();
            this.lab_nom = new System.Windows.Forms.Label();
            this.lab_prenom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.bs_employes = new System.Windows.Forms.BindingSource(this.components);
            this.pan_header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_listEmploye.SuspendLayout();
            this.pan_rafraichir.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employes)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_header
            // 
            this.pan_header.BackColor = System.Drawing.Color.OrangeRed;
            this.pan_header.Controls.Add(this.panel1);
            this.pan_header.Controls.Add(this.label1);
            this.pan_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_header.Location = new System.Drawing.Point(0, 0);
            this.pan_header.Name = "pan_header";
            this.pan_header.Size = new System.Drawing.Size(800, 121);
            this.pan_header.TabIndex = 0;
            this.pan_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 121);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des employés\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pan_listEmploye
            // 
            this.pan_listEmploye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_listEmploye.Controls.Add(this.listBox_employes);
            this.pan_listEmploye.Controls.Add(this.pan_rafraichir);
            this.pan_listEmploye.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_listEmploye.Location = new System.Drawing.Point(0, 121);
            this.pan_listEmploye.Name = "pan_listEmploye";
            this.pan_listEmploye.Size = new System.Drawing.Size(200, 329);
            this.pan_listEmploye.TabIndex = 1;
            this.pan_listEmploye.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listBox_employes
            // 
            this.listBox_employes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_employes.FormattingEnabled = true;
            this.listBox_employes.ItemHeight = 15;
            this.listBox_employes.Location = new System.Drawing.Point(0, 87);
            this.listBox_employes.Name = "listBox_employes";
            this.listBox_employes.Size = new System.Drawing.Size(198, 240);
            this.listBox_employes.TabIndex = 1;
            this.listBox_employes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pan_rafraichir
            // 
            this.pan_rafraichir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_rafraichir.Controls.Add(this.rafraichir);
            this.pan_rafraichir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_rafraichir.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_rafraichir.Location = new System.Drawing.Point(0, 0);
            this.pan_rafraichir.Name = "pan_rafraichir";
            this.pan_rafraichir.Size = new System.Drawing.Size(198, 87);
            this.pan_rafraichir.TabIndex = 0;
            // 
            // rafraichir
            // 
            this.rafraichir.BackColor = System.Drawing.Color.Silver;
            this.rafraichir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rafraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rafraichir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rafraichir.Location = new System.Drawing.Point(0, 0);
            this.rafraichir.Name = "rafraichir";
            this.rafraichir.Size = new System.Drawing.Size(196, 85);
            this.rafraichir.TabIndex = 0;
            this.rafraichir.Text = "Rafraîchir";
            this.rafraichir.UseVisualStyleBackColor = false;
            this.rafraichir.Click += new System.EventHandler(this.button_refresh_clik);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enregistrer);
            this.panel3.Controls.Add(this.check_estPiloteDeLigne);
            this.panel3.Controls.Add(this.cb_role);
            this.panel3.Controls.Add(this.lab_role);
            this.panel3.Controls.Add(this.dtp_dateEmbauche);
            this.panel3.Controls.Add(this.lab_dateEmbauche);
            this.panel3.Controls.Add(this.lab_nom);
            this.panel3.Controls.Add(this.lab_prenom);
            this.panel3.Controls.Add(this.tb_nom);
            this.panel3.Controls.Add(this.tb_prenom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 329);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // enregistrer
            // 
            this.enregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.enregistrer.Location = new System.Drawing.Point(39, 290);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(81, 27);
            this.enregistrer.TabIndex = 10;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // check_estPiloteDeLigne
            // 
            this.check_estPiloteDeLigne.AutoSize = true;
            this.check_estPiloteDeLigne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check_estPiloteDeLigne.Location = new System.Drawing.Point(40, 251);
            this.check_estPiloteDeLigne.Name = "check_estPiloteDeLigne";
            this.check_estPiloteDeLigne.Size = new System.Drawing.Size(120, 21);
            this.check_estPiloteDeLigne.TabIndex = 9;
            this.check_estPiloteDeLigne.Text = "Pilote de Ligne";
            this.check_estPiloteDeLigne.UseVisualStyleBackColor = true;
            this.check_estPiloteDeLigne.CheckedChanged += new System.EventHandler(this.checkBox_estPiloteDeLigne_CheckedChanged);
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(41, 211);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(200, 23);
            this.cb_role.TabIndex = 8;
            this.cb_role.SelectedIndexChanged += new System.EventHandler(this.comboBox_role_SelectedIndexChanged);
            // 
            // lab_role
            // 
            this.lab_role.AutoSize = true;
            this.lab_role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_role.Location = new System.Drawing.Point(41, 191);
            this.lab_role.Name = "lab_role";
            this.lab_role.Size = new System.Drawing.Size(35, 17);
            this.lab_role.TabIndex = 7;
            this.lab_role.Text = "Role";
            // 
            // dtp_dateEmbauche
            // 
            this.dtp_dateEmbauche.Location = new System.Drawing.Point(40, 158);
            this.dtp_dateEmbauche.Name = "dtp_dateEmbauche";
            this.dtp_dateEmbauche.Size = new System.Drawing.Size(200, 23);
            this.dtp_dateEmbauche.TabIndex = 5;
            // 
            // lab_dateEmbauche
            // 
            this.lab_dateEmbauche.AutoSize = true;
            this.lab_dateEmbauche.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_dateEmbauche.Location = new System.Drawing.Point(38, 134);
            this.lab_dateEmbauche.Name = "lab_dateEmbauche";
            this.lab_dateEmbauche.Size = new System.Drawing.Size(116, 17);
            this.lab_dateEmbauche.TabIndex = 4;
            this.lab_dateEmbauche.Text = "Date d\'embauche";
            this.lab_dateEmbauche.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab_nom
            // 
            this.lab_nom.AutoSize = true;
            this.lab_nom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_nom.Location = new System.Drawing.Point(37, 71);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(38, 17);
            this.lab_nom.TabIndex = 3;
            this.lab_nom.Text = "Nom";
            // 
            // lab_prenom
            // 
            this.lab_prenom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_prenom.Location = new System.Drawing.Point(36, 8);
            this.lab_prenom.Name = "lab_prenom";
            this.lab_prenom.Size = new System.Drawing.Size(56, 17);
            this.lab_prenom.TabIndex = 2;
            this.lab_prenom.Text = "Prénom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(40, 96);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(401, 23);
            this.tb_nom.TabIndex = 1;
            this.tb_nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(39, 31);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(401, 23);
            this.tb_prenom.TabIndex = 0;
            this.tb_prenom.TextChanged += new System.EventHandler(this.prenom_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pan_listEmploye);
            this.Controls.Add(this.pan_header);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pan_header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_listEmploye.ResumeLayout(false);
            this.pan_rafraichir.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_header;
        private System.Windows.Forms.Panel pan_listEmploye;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button rafraichir;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Panel pan_rafraichir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_dateEmbauche;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.Label lab_prenom;
        private System.Windows.Forms.DateTimePicker dtp_dateEmbauche;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.CheckBox check_estPiloteDeLigne;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label lab_role;
        private System.Windows.Forms.BindingSource bs_employes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_employes;
    }
}

