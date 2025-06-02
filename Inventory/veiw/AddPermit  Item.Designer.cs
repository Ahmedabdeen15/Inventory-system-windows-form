namespace Inventory.veiw
{
    partial class AddPermitItem
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
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 20;
            label2.Text = "quntity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 19;
            label1.Text = "Item";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 87);
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
            button2.Location = new Point(259, 302);
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
            button1.Location = new Point(12, 302);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 15;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 22;
            label3.Text = "Unit";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(364, 23);
            comboBox2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(11, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(364, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 178);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 25;
            label4.Text = "pruduction date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 26;
            label5.Text = "Expiration days";
            // 
            // AddPermitItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 344);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AddPermitItem";
            Text = "Add Item";
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
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
    }
}