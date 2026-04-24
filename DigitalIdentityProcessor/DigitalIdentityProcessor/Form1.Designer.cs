namespace DigitalIdentityProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            lblName = new Label();
            lblID = new Label();
            lblCitizen = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            cmbCitizenship = new ComboBox();
            btnValidate = new Button();
            lblResults = new Label();
            rtextOutput = new RichTextBox();
            btnGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 769);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblHeading.ForeColor = Color.Green;
            lblHeading.Location = new Point(645, 22);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(667, 47);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblName.Location = new Point(673, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(183, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Enter your name: ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblID.Location = new Point(673, 181);
            lblID.Name = "lblID";
            lblID.Size = new Size(138, 25);
            lblID.TabIndex = 3;
            lblID.Text = "Enter you ID:";
            // 
            // lblCitizen
            // 
            lblCitizen.AutoSize = true;
            lblCitizen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblCitizen.Location = new Point(673, 253);
            lblCitizen.Name = "lblCitizen";
            lblCitizen.Size = new Size(204, 25);
            lblCitizen.TabIndex = 4;
            lblCitizen.Text = "Coose your citizen: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(926, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 34);
            txtName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(926, 175);
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 34);
            txtID.TabIndex = 6;
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCitizenship.Font = new Font("Segoe UI", 12F);
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Location = new Point(926, 247);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(300, 36);
            cmbCitizenship.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Green;
            btnValidate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnValidate.Location = new Point(873, 322);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(225, 43);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 11F);
            lblResults.Location = new Point(748, 381);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 25);
            lblResults.TabIndex = 9;
            // 
            // rtextOutput
            // 
            rtextOutput.Font = new Font("Segoe UI", 11F);
            rtextOutput.Location = new Point(748, 427);
            rtextOutput.Name = "rtextOutput";
            rtextOutput.ReadOnly = true;
            rtextOutput.Size = new Size(452, 253);
            rtextOutput.TabIndex = 10;
            rtextOutput.Text = "";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Green;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerate.Location = new Point(873, 705);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(225, 43);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1402, 793);
            Controls.Add(btnGenerate);
            Controls.Add(rtextOutput);
            Controls.Add(lblResults);
            Controls.Add(btnValidate);
            Controls.Add(cmbCitizenship);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblCitizen);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Label lblName;
        private Label lblID;
        private Label lblCitizen;
        private TextBox txtName;
        private TextBox txtID;
        private ComboBox cmbCitizenship;
        private Button btnValidate;
        private Label lblResults;
        private RichTextBox rtextOutput;
        private Button btnGenerate;
    }
}
