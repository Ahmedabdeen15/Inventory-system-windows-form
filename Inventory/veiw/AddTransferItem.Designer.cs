namespace Inventory.veiw
{
    partial class AddTransferItem
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
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 71);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 51;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 71);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 50;
            label8.Text = "ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 211);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 49;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 164);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 48;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 211);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 47;
            label4.Text = "Production date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 164);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 46;
            label3.Text = "Quntity in storage : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 36);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(415, 28);
            comboBox1.TabIndex = 45;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 97);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 44;
            label2.Text = "quntity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 43;
            label1.Text = "choose Item";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 121);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 27);
            textBox1.TabIndex = 42;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(297, 295);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(137, 31);
            button2.TabIndex = 41;
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
            button1.Location = new Point(15, 295);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 31);
            button1.TabIndex = 40;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(167, 253);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 53;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 253);
            label10.Name = "label10";
            label10.Size = new Size(118, 20);
            label10.TabIndex = 52;
            label10.Text = "Exptitation days:";
            // 
            // AddTransferItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 344);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddTransferItem";
            Text = "AddTransferItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label9;
        private Label label10;
    }
}