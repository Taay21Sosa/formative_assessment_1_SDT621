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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(645, 22);
            label1.Name = "label1";
            label1.Size = new Size(667, 47);
            label1.TabIndex = 1;
            label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(673, 108);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 2;
            label2.Text = "Enter your name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(673, 181);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 3;
            label3.Text = "Enter you ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(673, 253);
            label4.Name = "label4";
            label4.Size = new Size(204, 25);
            label4.TabIndex = 4;
            label4.Text = "Coose your citizen: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(926, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(926, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 34);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(926, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 36);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(825, 320);
            button1.Name = "button1";
            button1.Size = new Size(225, 43);
            button1.TabIndex = 8;
            button1.Text = "Validate";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(748, 381);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 11F);
            richTextBox1.Location = new Point(748, 427);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 253);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(885, 716);
            button2.Name = "button2";
            button2.Size = new Size(225, 43);
            button2.TabIndex = 11;
            button2.Text = "Generate Profile";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1402, 793);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}
