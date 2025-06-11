using System.Drawing;

namespace BlueTechAPP
{
    partial class PageLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SAdminBTN = new System.Windows.Forms.Button();
            this.AdminBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPagePrincipale = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1043, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SAdminBTN
            // 
            this.SAdminBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SAdminBTN.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SAdminBTN.Location = new System.Drawing.Point(171, 200);
            this.SAdminBTN.Name = "SAdminBTN";
            this.SAdminBTN.Size = new System.Drawing.Size(296, 95);
            this.SAdminBTN.TabIndex = 1;
            this.SAdminBTN.Text = "Super-Admin";
            this.SAdminBTN.UseVisualStyleBackColor = false;
            this.SAdminBTN.Click += new System.EventHandler(this.SAdminBTN_Click);
            // 
            // AdminBTN
            // 
            this.AdminBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdminBTN.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.AdminBTN.Location = new System.Drawing.Point(786, 200);
            this.AdminBTN.Name = "AdminBTN";
            this.AdminBTN.Size = new System.Drawing.Size(296, 105);
            this.AdminBTN.TabIndex = 2;
            this.AdminBTN.Text = "Admin";
            this.AdminBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AdminBTN.UseVisualStyleBackColor = false;
            this.AdminBTN.Click += new System.EventHandler(this.AdminBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(496, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelPagePrincipale
            // 
            this.panelPagePrincipale.Location = new System.Drawing.Point(2, 0);
            this.panelPagePrincipale.Name = "panelPagePrincipale";
            this.panelPagePrincipale.Size = new System.Drawing.Size(1288, 638);
            this.panelPagePrincipale.TabIndex = 4;
            this.panelPagePrincipale.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPagePrincipale_Paint);
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 638);
            this.Controls.Add(this.panelPagePrincipale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminBTN);
            this.Controls.Add(this.SAdminBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PageLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SAdminBTN;
        private System.Windows.Forms.Button AdminBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPagePrincipale;
    }
}

