using BlueTechAPP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTechAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Resize += Form1_Resize;

            panelPagePrincipale.Hide();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = "Blue Tech !";


            label1.Font = new Font("Cooper Black", 50, FontStyle.Bold);
            label2.Font = new Font("Cooper Black", 30, FontStyle.Italic);

            SAdminBTN.Click += SAdminBTN_Click;
            AdminBTN.Click += AdminBTN_Click;


        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Exemple : label1 occupe 80% de la largeur
            label1.Width = (int)(this.ClientSize.Width * 0.8);
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            // Redimensionner la taille de la police (optionnel mais stylé)
            float tailleTexte = this.ClientSize.Width / 30f;
            label1.Font = new Font("Cooper Black", tailleTexte, FontStyle.Bold);

            // Redimensionner la PictureBox
            pictureBox1.Width = (int)(this.ClientSize.Width * 0.2);
            pictureBox1.Height = (int)(this.ClientSize.Height * 0.1);
            pictureBox1.Left = this.ClientSize.Width - pictureBox1.Width - 20;

            // Ajuster la taille du panel
            panelPagePrincipale.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 200);

            // Redimensionner les boutons
            int boutonLargeur = this.ClientSize.Width / 4;
            SAdminBTN.Size = new Size(boutonLargeur, 90);
            AdminBTN.Size = new Size(boutonLargeur, 90);

            SAdminBTN.Left = 80;
            AdminBTN.Left = this.ClientSize.Width - boutonLargeur - 30;

            SAdminBTN.Top = this.ClientSize.Height - SAdminBTN.Height - 450;
            AdminBTN.Top = SAdminBTN.Top;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            /* PagePrincipaleA f2 = new PagePrincipaleA();
             f2.Show();     // Ouvre la nouvelle fenêtre
             this.Hide();
            */
            panelPagePrincipale.Show();
            panelPagePrincipale.Controls.Clear();

            PagePrincipaleAdmin page = new PagePrincipaleAdmin();

            // Remplir tout le panel
            page.Dock = DockStyle.Fill;

            // Ajoute la page au panel
            panelPagePrincipale.Controls.Add(page);


        }
        private void SAdminBTN_Click(object sender, EventArgs e)
        {
            /* PagePrincipaleA f2 = new PagePrincipaleA();
             f2.Show();     // Ouvre la nouvelle fenêtre
             this.Hide();
            */
            panelPagePrincipale.Show();
            panelPagePrincipale.Controls.Clear();

            PagePrincipaleSuperAdmin page = new PagePrincipaleSuperAdmin();

            // Remplir tout le panel
            page.Dock = DockStyle.Fill;

            // Ajoute la page au panel
            panelPagePrincipale.Controls.Add(page);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "Blue Tech !";
            label1.Font = new Font("Segoe UI", 38, FontStyle.Bold);
            label1.AutoSize = true;  // S'ajuste automatiquement au texte

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            panelPagePrincipale.Hide();


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SAdminBTN = new System.Windows.Forms.Button();
            this.AdminBTN = new System.Windows.Forms.Button();
            this.panelPagePrincipale = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(513, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Blue Tech";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1028, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 71);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(169, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vous êtes...";
            // 
            // SAdminBTN
            // 
            this.SAdminBTN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SAdminBTN.Location = new System.Drawing.Point(195, 309);
            this.SAdminBTN.Name = "SAdminBTN";
            this.SAdminBTN.Size = new System.Drawing.Size(287, 64);
            this.SAdminBTN.TabIndex = 28;
            this.SAdminBTN.Text = "Super Admin";
            this.SAdminBTN.UseVisualStyleBackColor = false;
            // 
            // AdminBTN
            // 
            this.AdminBTN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AdminBTN.Location = new System.Drawing.Point(734, 309);
            this.AdminBTN.Name = "AdminBTN";
            this.AdminBTN.Size = new System.Drawing.Size(287, 64);
            this.AdminBTN.TabIndex = 29;
            this.AdminBTN.Text = "Admin";
            this.AdminBTN.UseVisualStyleBackColor = false;
            // 
            // panelPagePrincipale
            // 
            this.panelPagePrincipale.Location = new System.Drawing.Point(2, 1);
            this.panelPagePrincipale.Name = "panelPagePrincipale";
            this.panelPagePrincipale.Size = new System.Drawing.Size(1275, 619);
            this.panelPagePrincipale.TabIndex = 30;
            this.panelPagePrincipale.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPagePrincipale_Paint);
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1272, 619);
            this.Controls.Add(this.panelPagePrincipale);
            this.Controls.Add(this.AdminBTN);
            this.Controls.Add(this.SAdminBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelPagePrincipale_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}