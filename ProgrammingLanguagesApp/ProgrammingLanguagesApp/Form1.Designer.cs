namespace ProgrammingLanguagesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lstLanguages = new ListBox();
            titleLabel = new Label();
            panel1 = new Panel();
            lblStatus = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLanguage
            // 
            txtLanguage.Font = new Font("Segoe UI", 12F);
            txtLanguage.Location = new Point(167, 418);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.PlaceholderText = "Enter programming language";
            txtLanguage.Size = new Size(650, 34);
            txtLanguage.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(167, 475);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(5);
            btnAdd.Size = new Size(160, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(345, 475);
            btnRemove.Name = "btnRemove";
            btnRemove.Padding = new Padding(5);
            btnRemove.Size = new Size(160, 45);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstLanguages
            // 
            lstLanguages.Font = new Font("Segoe UI", 12F);
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(167, 115);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(650, 284);
            lstLanguages.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.Location = new Point(235, 64);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(504, 37);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "My Favourite Programming Language";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(txtLanguage);
            panel1.Controls.Add(lstLanguages);
            panel1.Location = new Point(149, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 605);
            panel1.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.Window;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.DarkGray;
            lblStatus.Location = new Point(167, 538);
            lblStatus.MaximumSize = new Size(650, 23);
            lblStatus.MinimumSize = new Size(20, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(20, 23);
            lblStatus.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 681);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "ProgrammingLanguagesApp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lstLanguages;
        private Label titleLabel;
        private Panel panel1;
        private Label lblStatus;
    }
}
