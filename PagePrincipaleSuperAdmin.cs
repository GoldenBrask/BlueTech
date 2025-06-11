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
    public partial class PagePrincipaleSuperAdmin : UserControl
    {
        public PagePrincipaleSuperAdmin()
        {
            InitializeComponent();

            // occupe tout l'espace disponible et gestion du redimensionnement
            this.Dock = DockStyle.Fill;
            this.Resize += PagePrincipaleSuperAdmin_Resize;

            string[] BlueBox = { "Blue Box 1 : 11:BC:DE:24:FA", "Blue Box 2 : AC:B3:55:24:FF", "Blue Box 3 : A2:F8:30:FA:CC", "Blue Box 4 : AC:33:FF:AC:22" };
            comboBox1.Items.AddRange(BlueBox);



        }

        private void PagePrincipaleSuperAdmin_Load(object sender, EventArgs e)
        {

            label1.Text = "Blue Tech !";

            label2.Text = "Bienvenue 'nom super-admin'... !";



            label1.Font = new Font("Cooper Black", 50, FontStyle.Bold);
            label2.Font = new Font("Cooper Black", 30, FontStyle.Italic);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Cursor = Cursors.Hand;

            SelectBlueBoxSA.Click += SelectBlueBox_Click;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // retour à la page d'accueil
            if (this.Parent != null)
            {
                this.Parent.Controls.Clear();
                this.Parent.Hide();
            }
        }
        private string choixBlueBox;

        private void SelectBlueBox_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // Enregistrer la sélection pour l'utiliser ultérieurement 
                choixBlueBox = comboBox1.SelectedItem.ToString();



                UC_PageControle uc = new UC_PageControle();

                // Vider le panel et afficher le nouveau contrôle



            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une BlueBox !");
            }

        }

        private void PagePrincipaleSuperAdmin_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.Width - label1.Width) / 2;
            pictureBox1.Left = this.Width - pictureBox1.Width - 20;
            comboBox1.Left = (this.Width - comboBox1.Width) / 2;
            SelectBlueBoxSA.Left = (this.Width - SelectBlueBoxSA.Width) / 2;
            label2.Left = (this.Width - label2.Width) / 2;
        }
    }
}
