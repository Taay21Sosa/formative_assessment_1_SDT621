
namespace ProgrammingLanguagesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * The method captures the text box input and adds it to the ListBox
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string inputLanguage = txtLanguage.Text.Trim();

            // Ensures there is no empty input
            if (string.IsNullOrEmpty(inputLanguage))
            {
                MessageBox.Show("Input cannot be empty. Please enter a programming language.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent duplicate languages from being create/enter (case - insensitive check)
            foreach (string lang in lstLanguages.Items)
            {
                if (lang.Equals(inputLanguage, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"'{inputLanguage}' is already exists in the system.",
                                    "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            lstLanguages.Items.Add(inputLanguage);

            // Clean up UI for the next entry
            txtLanguage.Clear();
            lblStatus.Text = $"Added {inputLanguage} at {DateTime.Now}";
        }

        /*
         * The method checks if an item is selected and then removes that specific object from the ListBox.
         */
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if a programming language has actually been selected
            if (lstLanguages.SelectedIndex != -1)
            {
                object selectedLang = lstLanguages.SelectedItem;
                lstLanguages.Items.Remove(selectedLang);
                lblStatus.Text = $"Removed {selectedLang} at {DateTime.Now}";
            }
            else
            {
                MessageBox.Show("Please select a language from the list to remove.",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
