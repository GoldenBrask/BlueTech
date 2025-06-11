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

            SelectBlueBoxSA.Click += SelectBlueBox_Click;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
