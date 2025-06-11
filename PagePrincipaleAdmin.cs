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
    public partial class PagePrincipaleAdmin : UserControl
    {
        public PagePrincipaleAdmin()
        {
            InitializeComponent();

            // permet d'occuper tout l'espace disponible dans le parent
            this.Dock = DockStyle.Fill;
            this.Resize += PagePrincipaleAdmin_Resize;

            string[] BlueBox = { "Blue Box 1", "Blue Box 2", "Blue Box 3", "Blue Box 4" };
            comboBox1.Items.AddRange(BlueBox);

            // curseur en forme de main sur le bouton Accueil
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void PagePrincipale_Load(object sender, EventArgs e)

        {
            label1.Text = "Blue Tech !";

            label1.Font = new Font("Cooper Black", 50, FontStyle.Bold);
            label2.Font = new Font("Cooper Black", 30, FontStyle.Italic);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            label2.Text = "Bienvenue 'nom admin'... !";
         
      

            SelectBlueBoxA.Text = "Sélectionner la BlueBox ";
            SelectBlueBoxA.Click += SelectBlueBox_Click;

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

        private void panelPagePrincipale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PagePrincipaleAdmin_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.Width - label1.Width) / 2;
            pictureBox1.Left = this.Width - pictureBox1.Width - 20;
            comboBox1.Left = (this.Width - comboBox1.Width) / 2;
            SelectBlueBoxA.Left = (this.Width - SelectBlueBoxA.Width) / 2;
            label2.Left = (this.Width - label2.Width) / 2;
        }
    }
}
