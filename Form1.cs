namespace NuGetDebugSwitcher
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUpdatePackager_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSourcePackage.Text))
            {
                MessageBox.Show("Please select a Source Package.");
                return;
            }

            if (string.IsNullOrEmpty(txtTargetVersion.Text))
            {
                MessageBox.Show("Please select a Target Package.");
                return;
            }
            Version packageVersion;
            try
            {
                packageVersion = new Version(txtTargetVersion.Text);
            }
            catch
            {
                MessageBox.Show("Please use a correct Target Version syntax Major.Minor.Build.");
                return;

            }
            if (!Directory.Exists(txtModernizationDirectory.Text))
            {
                MessageBox.Show("Please select a Modernization Directory.");
                return;
            }

            txtOutput.Text = new PackageUpdateOperations().UpdatePackages(txtModernizationDirectory.Text, txtSourcePackage.Text, packageVersion);

        }

        private void btnAddSymLink_Click(object sender, EventArgs e)
        {
            Version packageVersion;
            try
            {
                packageVersion = new Version(txtNuGetPackageVersion.Text);
            }
            catch
            {
                MessageBox.Show("Please use a correct Nuget Version syntax Major.Minor.Build.");
                return;
            }

            if (!txtDebugProjRef.Text.EndsWith("\\bin\\Debug"))
            {
                MessageBox.Show("Please specify a Debug Project Directory Reference, ie ending in \\bin\\Debug.");
                return;
            }

            bool createNotRemove = ((Button)sender).Name == "btnAddSymLink";
            txtOutputDebug.Text = new SymLinkOperations().SymLink(txtSwitchProjectsToDebugDirectory.Text, txtNuGetPackage.Text, txtDebugProjRef.Text, packageVersion, createNotRemove);

        }

        private void btnSourceLanguageDir_Click(object sender, EventArgs e)
        {

        }
    }
}