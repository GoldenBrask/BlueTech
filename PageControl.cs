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
    public partial class PageControl : Form
    {
        public PageControl()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            label1.Text = "Blue Tech !";
            label1.Font = new Font("Segoe UI", 38, FontStyle.Bold);
            label1.AutoSize = true;  // S'ajuste automatiquement au texte

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            PagePrincipaleA pagePrincipaleA = new PagePrincipaleA();  
            pagePrincipaleA.Show();               
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Blue Tech";
            label1.Font = new Font("Segoe UI", 38, FontStyle.Bold);
            label1.AutoSize = true;
        }
    }
}
