namespace Inventory
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            comboBox4 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tabPage2 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            dateTimePicker3 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker4 = new DateTimePicker();
            tabPage3 = new TabPage();
            checkedListBox2 = new CheckedListBox();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            button3 = new Button();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            comboBox3 = new ComboBox();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            button4 = new Button();
            textBox2 = new TextBox();
            label11 = new Label();
            dataGridView5 = new DataGridView();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            warehouseToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            addUnitToolStripMenuItem = new ToolStripMenuItem();
            removeUnitToolStripMenuItem = new ToolStripMenuItem();
            unitsToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem2 = new ToolStripMenuItem();
            updateToolStripMenuItem2 = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem3 = new ToolStripMenuItem();
            updateToolStripMenuItem3 = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem4 = new ToolStripMenuItem();
            updateToolStripMenuItem4 = new ToolStripMenuItem();
            permitsToolStripMenuItem = new ToolStripMenuItem();
            supplyPermitToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem5 = new ToolStripMenuItem();
            updateToolStripMenuItem5 = new ToolStripMenuItem();
            releasePermitToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem6 = new ToolStripMenuItem();
            updateToolStripMenuItem6 = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem7 = new ToolStripMenuItem();
            updateToolStripMenuItem7 = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(4, 30, 4, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1276, 580);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(comboBox4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1268, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All items";
            tabPage1.Enter += tabPage1_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 14);
            label12.Name = "label12";
            label12.Size = new Size(91, 21);
            label12.TabIndex = 7;
            label12.Text = "Warehouse";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(9, 38);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(267, 29);
            comboBox4.TabIndex = 6;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(62, 251);
            button1.Name = "button1";
            button1.Size = new Size(139, 44);
            button1.TabIndex = 5;
            button1.Text = "reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(282, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 525);
            dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(9, 199);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(267, 29);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 168);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 2;
            label2.Text = "to";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 86);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "from";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(9, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 29);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkedListBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(dateTimePicker3);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dateTimePicker4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1268, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items in warehouse";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(9, 126);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(249, 100);
            checkedListBox1.TabIndex = 15;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 95);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 14;
            label6.Text = "warehouse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 8);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 13;
            label5.Text = "item";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 29);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(62, 443);
            button2.Name = "button2";
            button2.Size = new Size(139, 44);
            button2.TabIndex = 11;
            button2.Text = "reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(283, 8);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(978, 525);
            dataGridView2.TabIndex = 10;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(9, 391);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 29);
            dateTimePicker3.TabIndex = 9;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 360);
            label3.Name = "label3";
            label3.Size = new Size(26, 21);
            label3.TabIndex = 8;
            label3.Text = "to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 278);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 7;
            label4.Text = "from";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Checked = false;
            dateTimePicker4.Location = new Point(9, 309);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(256, 29);
            dateTimePicker4.TabIndex = 6;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkedListBox2);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1268, 552);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "view 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(9, 125);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(249, 100);
            checkedListBox2.TabIndex = 25;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 94);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 24;
            label7.Text = "warehouse";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 7);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 23;
            label8.Text = "item";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(8, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 29);
            comboBox2.TabIndex = 22;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(283, 7);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(978, 525);
            dataGridView3.TabIndex = 20;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(comboBox3);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1268, 552);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "view 4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(8, 197);
            button3.Name = "button3";
            button3.Size = new Size(250, 41);
            button3.TabIndex = 29;
            button3.Text = "search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 29);
            textBox1.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 98);
            label10.Name = "label10";
            label10.Size = new Size(37, 21);
            label10.TabIndex = 27;
            label10.Text = "age";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 7);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 26;
            label9.Text = "warehouse";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(8, 46);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 29);
            comboBox3.TabIndex = 25;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(283, 7);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(978, 525);
            dataGridView4.TabIndex = 24;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1268, 552);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "view 5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(8, 120);
            button4.Name = "button4";
            button4.Size = new Size(250, 41);
            button4.TabIndex = 33;
            button4.Text = "search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 29);
            textBox2.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 21);
            label11.Name = "label11";
            label11.Size = new Size(37, 21);
            label11.TabIndex = 31;
            label11.Text = "age";
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(283, 7);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(978, 525);
            dataGridView5.TabIndex = 30;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 609);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1276, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, warehouseToolStripMenuItem, itemsToolStripMenuItem, unitsToolStripMenuItem, supplierToolStripMenuItem, customerToolStripMenuItem, permitsToolStripMenuItem, transferToolStripMenuItem, employeesToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1276, 26);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // warehouseToolStripMenuItem
            // 
            warehouseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, updateToolStripMenuItem });
            warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            warehouseToolStripMenuItem.Size = new Size(98, 20);
            warehouseToolStripMenuItem.Text = "&Warehouse";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(122, 22);
            createToolStripMenuItem.Text = "create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(122, 22);
            updateToolStripMenuItem.Text = "update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem1, updateToolStripMenuItem1, addUnitToolStripMenuItem, removeUnitToolStripMenuItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(56, 20);
            itemsToolStripMenuItem.Text = "&Items";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(154, 22);
            createToolStripMenuItem1.Text = "create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(154, 22);
            updateToolStripMenuItem1.Text = "update";
            updateToolStripMenuItem1.Click += updateToolStripMenuItem1_Click;
            // 
            // addUnitToolStripMenuItem
            // 
            addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            addUnitToolStripMenuItem.Size = new Size(154, 22);
            addUnitToolStripMenuItem.Text = "add unit";
            addUnitToolStripMenuItem.Click += addUnitToolStripMenuItem_Click;
            // 
            // removeUnitToolStripMenuItem
            // 
            removeUnitToolStripMenuItem.Name = "removeUnitToolStripMenuItem";
            removeUnitToolStripMenuItem.Size = new Size(154, 22);
            removeUnitToolStripMenuItem.Text = "remove unit";
            removeUnitToolStripMenuItem.Click += removeUnitToolStripMenuItem_Click;
            // 
            // unitsToolStripMenuItem
            // 
            unitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem2, updateToolStripMenuItem2 });
            unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            unitsToolStripMenuItem.Size = new Size(54, 20);
            unitsToolStripMenuItem.Text = "&Units";
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(122, 22);
            createToolStripMenuItem2.Text = "create";
            createToolStripMenuItem2.Click += createToolStripMenuItem2_Click;
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(122, 22);
            updateToolStripMenuItem2.Text = "update";
            updateToolStripMenuItem2.Click += updateToolStripMenuItem2_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem3, updateToolStripMenuItem3 });
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(77, 20);
            supplierToolStripMenuItem.Text = "&Supplier";
            // 
            // createToolStripMenuItem3
            // 
            createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            createToolStripMenuItem3.Size = new Size(122, 22);
            createToolStripMenuItem3.Text = "create";
            createToolStripMenuItem3.Click += createToolStripMenuItem3_Click;
            // 
            // updateToolStripMenuItem3
            // 
            updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            updateToolStripMenuItem3.Size = new Size(122, 22);
            updateToolStripMenuItem3.Text = "update";
            updateToolStripMenuItem3.Click += updateToolStripMenuItem3_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem4, updateToolStripMenuItem4 });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(84, 20);
            customerToolStripMenuItem.Text = "&Customer";
            // 
            // createToolStripMenuItem4
            // 
            createToolStripMenuItem4.Name = "createToolStripMenuItem4";
            createToolStripMenuItem4.Size = new Size(122, 22);
            createToolStripMenuItem4.Text = "create";
            createToolStripMenuItem4.Click += createToolStripMenuItem4_Click;
            // 
            // updateToolStripMenuItem4
            // 
            updateToolStripMenuItem4.Name = "updateToolStripMenuItem4";
            updateToolStripMenuItem4.Size = new Size(122, 22);
            updateToolStripMenuItem4.Text = "update";
            updateToolStripMenuItem4.Click += updateToolStripMenuItem4_Click;
            // 
            // permitsToolStripMenuItem
            // 
            permitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplyPermitToolStripMenuItem, releasePermitToolStripMenuItem });
            permitsToolStripMenuItem.Name = "permitsToolStripMenuItem";
            permitsToolStripMenuItem.Size = new Size(71, 20);
            permitsToolStripMenuItem.Text = "&Permits";
            // 
            // supplyPermitToolStripMenuItem
            // 
            supplyPermitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem5, updateToolStripMenuItem5 });
            supplyPermitToolStripMenuItem.Name = "supplyPermitToolStripMenuItem";
            supplyPermitToolStripMenuItem.Size = new Size(181, 22);
            supplyPermitToolStripMenuItem.Text = "Su&pply Permit";
            // 
            // createToolStripMenuItem5
            // 
            createToolStripMenuItem5.Name = "createToolStripMenuItem5";
            createToolStripMenuItem5.Size = new Size(122, 22);
            createToolStripMenuItem5.Text = "create";
            createToolStripMenuItem5.Click += createToolStripMenuItem5_Click;
            // 
            // updateToolStripMenuItem5
            // 
            updateToolStripMenuItem5.Name = "updateToolStripMenuItem5";
            updateToolStripMenuItem5.Size = new Size(122, 22);
            updateToolStripMenuItem5.Text = "update";
            updateToolStripMenuItem5.Click += updateToolStripMenuItem5_Click;
            // 
            // releasePermitToolStripMenuItem
            // 
            releasePermitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem6, updateToolStripMenuItem6 });
            releasePermitToolStripMenuItem.Name = "releasePermitToolStripMenuItem";
            releasePermitToolStripMenuItem.Size = new Size(181, 22);
            releasePermitToolStripMenuItem.Text = "&Release Permit";
            // 
            // createToolStripMenuItem6
            // 
            createToolStripMenuItem6.Name = "createToolStripMenuItem6";
            createToolStripMenuItem6.Size = new Size(122, 22);
            createToolStripMenuItem6.Text = "create";
            createToolStripMenuItem6.Click += createToolStripMenuItem6_Click;
            // 
            // updateToolStripMenuItem6
            // 
            updateToolStripMenuItem6.Name = "updateToolStripMenuItem6";
            updateToolStripMenuItem6.Size = new Size(122, 22);
            updateToolStripMenuItem6.Text = "update";
            updateToolStripMenuItem6.Click += updateToolStripMenuItem6_Click;
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(77, 20);
            transferToolStripMenuItem.Text = "&Transfer";
            transferToolStripMenuItem.Click += transferToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem7, updateToolStripMenuItem7 });
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(97, 20);
            employeesToolStripMenuItem.Text = "&Employees";
            // 
            // createToolStripMenuItem7
            // 
            createToolStripMenuItem7.Name = "createToolStripMenuItem7";
            createToolStripMenuItem7.Size = new Size(122, 22);
            createToolStripMenuItem7.Text = "create";
            createToolStripMenuItem7.Click += createToolStripMenuItem7_Click;
            // 
            // updateToolStripMenuItem7
            // 
            updateToolStripMenuItem7.Name = "updateToolStripMenuItem7";
            updateToolStripMenuItem7.Size = new Size(122, 22);
            updateToolStripMenuItem7.Text = "update";
            updateToolStripMenuItem7.Click += updateToolStripMenuItem7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1276, 631);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Inventory  System";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem warehouseToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private ToolStripMenuItem unitsToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem2;
        private ToolStripMenuItem updateToolStripMenuItem2;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem3;
        private ToolStripMenuItem updateToolStripMenuItem3;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem4;
        private ToolStripMenuItem updateToolStripMenuItem4;
        private ToolStripMenuItem permitsToolStripMenuItem;
        private ToolStripMenuItem supplyPermitToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem5;
        private ToolStripMenuItem updateToolStripMenuItem5;
        private ToolStripMenuItem releasePermitToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem6;
        private ToolStripMenuItem updateToolStripMenuItem6;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem7;
        private ToolStripMenuItem updateToolStripMenuItem7;
        private ToolStripMenuItem addUnitToolStripMenuItem;
        private ToolStripMenuItem removeUnitToolStripMenuItem;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private DateTimePicker dateTimePicker3;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker4;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private TabPage tabPage3;
        private CheckedListBox checkedListBox2;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
        private DataGridView dataGridView3;
        private TabPage tabPage4;
        private Button button3;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private ComboBox comboBox3;
        private DataGridView dataGridView4;
        private TabPage tabPage5;
        private Button button4;
        private TextBox textBox2;
        private Label label11;
        private DataGridView dataGridView5;
        private Label label12;
        private ComboBox comboBox4;
    }
}
