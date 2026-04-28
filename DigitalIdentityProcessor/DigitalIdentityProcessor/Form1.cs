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
            // Check if a profile has been created via the Validate button first
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate an ID first before generating a profile.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate the formatted summary
            string validationStatus = currentProfile.ValidateID();
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            rtextOutput.Text = "===== DIGITAL CITIZEN SUMMARY =====\r\n" +
                              $"Full Name  : {currentProfile.FullName}\r\n" +
                              $"ID Number  : {currentProfile.ID}\r\n" +
                              $"Age        : {currentProfile.Age} years old\r\n" +
                              $"Citizenship: {currentProfile.CitizenshipStatus}\r\n" +
                              "------------------------------------\r\n" +
                              $"Validation   : {validationStatus}\r\n" +
                              $"Processed At : Home Affairs Digital Desk" +
                              $"Timestamp    : {timestamp}";
        }
    
    }
}
