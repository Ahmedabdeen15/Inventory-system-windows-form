namespace Inventory.veiw
{
    partial class ItemUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 20;
            label2.Text = "Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 19;
            label1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 23);
            textBox1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(259, 238);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 16;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(12, 238);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 15;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 22;
            label3.Text = "Choose item";
            // 
            // ItemUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 279);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ItemUpdate";
            Text = "ItemUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label3;
    }
}