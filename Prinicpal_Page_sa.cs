public partial class BlueBoxControlForm : Form
{
    private bool isActive = false;
    private bool isSaveEnabled = false;

    public BlueBoxControlForm()
    {
        InitializeComponent();
        UpdateStatus();
    }

    private void btnActiverDesactiver_Click(object sender, EventArgs e)
    {
        isActive = !isActive;
        MessageBox.Show(isActive ? "Blue Box activée" : "Blue Box désactivée");
        UpdateStatus();
    }

    private void btnAfficherDonnees_Click(object sender, EventArgs e)
    {
        // À remplacer par la logique de récupération réelle
        MessageBox.Show("Affichage des données scannées (ex: couleurs, texte...)");
    }

    private void btnSauvegarde_Click(object sender, EventArgs e)
    {
        isSaveEnabled = !isSaveEnabled;
        MessageBox.Show(isSaveEnabled ? "Sauvegarde activée" : "Sauvegarde désactivée");
        UpdateStatus();
    }

    private void btnConsulterFonctionnalite_Click(object sender, EventArgs e)
    {
        // Placeholder pour consulter l'état
        MessageBox.Show("Fonctionnalité Blue Box : OK / En maintenance...");
    }

    private void btnAppliquerFrequence_Click(object sender, EventArgs e)
    {
        int interval = (int)numericUpDownScanFrequency.Value;
        MessageBox.Show($"Fréquence de scan définie à {interval} secondes");
        // Appliquer cette fréquence à la Blue Box
    }

    private void UpdateStatus()
    {
        btnActiverDesactiver.Text = isActive ? "Désactiver" : "Activer";
        btnSauvegarde.Text = isSaveEnabled ? "Désactiver Sauvegarde" : "Activer Sauvegarde";
    }
}