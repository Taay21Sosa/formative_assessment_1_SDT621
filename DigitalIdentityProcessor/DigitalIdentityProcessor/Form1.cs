using DigitalIdentityProcessor.Models;

namespace DigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        private CitizenProfile? currentProfile;

        public Form1()
        {
            InitializeComponent();

            // Populate the ComboBox to ensure it contains options items
            cmbCitizenship.Items.Add("South African");
            cmbCitizenship.Items.Add("Permanent Resident");
            cmbCitizenship.Items.Add("Visitor");

            // Automatically select the first item
            cmbCitizenship.SelectedIndex = 0;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Basic UI validation before processing
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbCitizenship.SelectedItem == null)
            {
                MessageBox.Show("Please ensure Name and Citizenship are filled in, and try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem.ToString() ?? string.Empty;

            currentProfile = new CitizenProfile(name, id, citizenship);

            string validationResults = currentProfile.ValidateID();
            lblResults.Text = validationResults;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
