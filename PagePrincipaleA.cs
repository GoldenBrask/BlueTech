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
    public partial class PagePrincipaleA : Form
    {
        public PagePrincipaleA()
        {
            InitializeComponent();
        }

        private void PagePrincipaleA_Load(object sender, EventArgs e)
          
        {


            label2.Text = "Bienvenue 'nom admin'... !";
            label2.Font = new Font("Segoe UI", 28, FontStyle.Italic);
            label2.AutoSize = true;  // S'ajuste automatiquement au texte



            label1.Text = "Blue Tech !";
            label1.Font = new Font("Segoe UI", 38, FontStyle.Bold);
            label1.AutoSize = true;  // S'ajuste automatiquement au texte

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
    
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void panelPagePrincipale_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
