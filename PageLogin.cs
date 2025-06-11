using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTechAPP
{
    public partial class PageLogin : Form
    {
        public PageLogin()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panelPagePrincipale_Paint(object sender, PaintEventArgs e)
        {


        }
    }}
