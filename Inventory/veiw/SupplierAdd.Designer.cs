namespace Inventory.veiw
{
    partial class SupplierAdd
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(204, 397);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 32;
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
            button1.Location = new Point(12, 397);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 31;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 30;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 29;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 85);
            textBox2.MaxLength = 9;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 34;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 23);
            textBox3.TabIndex = 35;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 203);
            textBox4.MaxLength = 11;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(312, 23);
            textBox4.TabIndex = 36;
            textBox4.Validating += textBox4_Validating;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(309, 23);
            textBox5.TabIndex = 37;
            textBox5.Validating += textBox5_Validating;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 320);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(309, 23);
            textBox6.TabIndex = 38;
            textBox6.Validating += textBox6_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 39;
            label3.Text = "Fax";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 185);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 40;
            label4.Text = "Mobile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 237);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 293);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 42;
            label6.Text = "Website";
            // 
            // SupplierAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SupplierAdd";
            Text = "SupplierAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}