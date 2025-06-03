namespace Inventory.veiw
{
    partial class warehouse_update
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 302);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 28);
            comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 264);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "Manger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 14;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 206);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(419, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 109);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 27);
            textBox1.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(294, 396);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(137, 31);
            button2.TabIndex = 10;
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
            button1.Location = new Point(12, 396);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 31);
            button1.TabIndex = 9;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 28);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 18;
            label4.Text = "select warehouse";
            // 
            // warehouse_update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "warehouse_update";
            Text = "warehouse_update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private Label label4;
    }
}