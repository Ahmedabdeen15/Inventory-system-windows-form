﻿namespace Inventory.veiw
{
    partial class CustomerUpdate
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 23);
            comboBox1.TabIndex = 74;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 73;
            label7.Text = "Choose the Customer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 338);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 72;
            label6.Text = "Website";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 282);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 71;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 230);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 70;
            label4.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 170);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 69;
            label3.Text = "Fax";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 365);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(309, 23);
            textBox6.TabIndex = 68;
            textBox6.Validating += textBox6_Validating;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(309, 23);
            textBox5.TabIndex = 67;
            textBox5.Validating += textBox5_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 248);
            textBox4.MaxLength = 11;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(312, 23);
            textBox4.TabIndex = 66;
            textBox4.Validating += textBox4_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 23);
            textBox3.TabIndex = 65;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 130);
            textBox2.MaxLength = 9;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 64;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 63;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(204, 416);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 62;
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
            button1.Location = new Point(12, 416);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 61;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 60;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 59;
            label1.Text = "Name";
            // 
            // CustomerUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(comboBox1);
            Controls.Add(label7);
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
            Name = "CustomerUpdate";
            Text = "CustomerUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}