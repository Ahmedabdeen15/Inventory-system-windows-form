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
            tabPage2 = new TabPage();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(4, 30, 4, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 493);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1033, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1033, 465);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 509);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1041, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Font = new Font("Rockwell", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, warehouseToolStripMenuItem, itemsToolStripMenuItem, unitsToolStripMenuItem, supplierToolStripMenuItem, customerToolStripMenuItem, permitsToolStripMenuItem, transferToolStripMenuItem, employeesToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1041, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 19);
            // 
            // warehouseToolStripMenuItem
            // 
            warehouseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, updateToolStripMenuItem });
            warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            warehouseToolStripMenuItem.Size = new Size(90, 19);
            warehouseToolStripMenuItem.Text = "&Warehouse";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(118, 22);
            createToolStripMenuItem.Text = "create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(118, 22);
            updateToolStripMenuItem.Text = "update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem1, updateToolStripMenuItem1, addUnitToolStripMenuItem, removeUnitToolStripMenuItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(56, 19);
            itemsToolStripMenuItem.Text = "&Items";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(150, 22);
            createToolStripMenuItem1.Text = "create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(150, 22);
            updateToolStripMenuItem1.Text = "update";
            updateToolStripMenuItem1.Click += updateToolStripMenuItem1_Click;
            // 
            // addUnitToolStripMenuItem
            // 
            addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            addUnitToolStripMenuItem.Size = new Size(150, 22);
            addUnitToolStripMenuItem.Text = "add unit";
            addUnitToolStripMenuItem.Click += addUnitToolStripMenuItem_Click;
            // 
            // removeUnitToolStripMenuItem
            // 
            removeUnitToolStripMenuItem.Name = "removeUnitToolStripMenuItem";
            removeUnitToolStripMenuItem.Size = new Size(150, 22);
            removeUnitToolStripMenuItem.Text = "remove unit";
            removeUnitToolStripMenuItem.Click += removeUnitToolStripMenuItem_Click;
            // 
            // unitsToolStripMenuItem
            // 
            unitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem2, updateToolStripMenuItem2 });
            unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            unitsToolStripMenuItem.Size = new Size(53, 19);
            unitsToolStripMenuItem.Text = "&Units";
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(118, 22);
            createToolStripMenuItem2.Text = "create";
            createToolStripMenuItem2.Click += createToolStripMenuItem2_Click;
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(118, 22);
            updateToolStripMenuItem2.Text = "update";
            updateToolStripMenuItem2.Click += updateToolStripMenuItem2_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem3, updateToolStripMenuItem3 });
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(73, 19);
            supplierToolStripMenuItem.Text = "&Supplier";
            // 
            // createToolStripMenuItem3
            // 
            createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            createToolStripMenuItem3.Size = new Size(118, 22);
            createToolStripMenuItem3.Text = "create";
            createToolStripMenuItem3.Click += createToolStripMenuItem3_Click;
            // 
            // updateToolStripMenuItem3
            // 
            updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            updateToolStripMenuItem3.Size = new Size(118, 22);
            updateToolStripMenuItem3.Text = "update";
            updateToolStripMenuItem3.Click += updateToolStripMenuItem3_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem4, updateToolStripMenuItem4 });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(82, 19);
            customerToolStripMenuItem.Text = "&Customer";
            // 
            // createToolStripMenuItem4
            // 
            createToolStripMenuItem4.Name = "createToolStripMenuItem4";
            createToolStripMenuItem4.Size = new Size(118, 22);
            createToolStripMenuItem4.Text = "create";
            createToolStripMenuItem4.Click += createToolStripMenuItem4_Click;
            // 
            // updateToolStripMenuItem4
            // 
            updateToolStripMenuItem4.Name = "updateToolStripMenuItem4";
            updateToolStripMenuItem4.Size = new Size(118, 22);
            updateToolStripMenuItem4.Text = "update";
            updateToolStripMenuItem4.Click += updateToolStripMenuItem4_Click;
            // 
            // permitsToolStripMenuItem
            // 
            permitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplyPermitToolStripMenuItem, releasePermitToolStripMenuItem });
            permitsToolStripMenuItem.Name = "permitsToolStripMenuItem";
            permitsToolStripMenuItem.Size = new Size(71, 19);
            permitsToolStripMenuItem.Text = "&Permits";
            // 
            // supplyPermitToolStripMenuItem
            // 
            supplyPermitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem5, updateToolStripMenuItem5 });
            supplyPermitToolStripMenuItem.Name = "supplyPermitToolStripMenuItem";
            supplyPermitToolStripMenuItem.Size = new Size(180, 22);
            supplyPermitToolStripMenuItem.Text = "Su&pply Permit";
            // 
            // createToolStripMenuItem5
            // 
            createToolStripMenuItem5.Name = "createToolStripMenuItem5";
            createToolStripMenuItem5.Size = new Size(118, 22);
            createToolStripMenuItem5.Text = "create";
            createToolStripMenuItem5.Click += createToolStripMenuItem5_Click;
            // 
            // updateToolStripMenuItem5
            // 
            updateToolStripMenuItem5.Name = "updateToolStripMenuItem5";
            updateToolStripMenuItem5.Size = new Size(118, 22);
            updateToolStripMenuItem5.Text = "update";
            updateToolStripMenuItem5.Click += updateToolStripMenuItem5_Click;
            // 
            // releasePermitToolStripMenuItem
            // 
            releasePermitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem6, updateToolStripMenuItem6 });
            releasePermitToolStripMenuItem.Name = "releasePermitToolStripMenuItem";
            releasePermitToolStripMenuItem.Size = new Size(180, 22);
            releasePermitToolStripMenuItem.Text = "&Release Permit";
            // 
            // createToolStripMenuItem6
            // 
            createToolStripMenuItem6.Name = "createToolStripMenuItem6";
            createToolStripMenuItem6.Size = new Size(180, 22);
            createToolStripMenuItem6.Text = "create";
            createToolStripMenuItem6.Click += createToolStripMenuItem6_Click;
            // 
            // updateToolStripMenuItem6
            // 
            updateToolStripMenuItem6.Name = "updateToolStripMenuItem6";
            updateToolStripMenuItem6.Size = new Size(180, 22);
            updateToolStripMenuItem6.Text = "update";
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(75, 19);
            transferToolStripMenuItem.Text = "&Transfer";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem7, updateToolStripMenuItem7 });
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(90, 19);
            employeesToolStripMenuItem.Text = "&Employees";
            // 
            // createToolStripMenuItem7
            // 
            createToolStripMenuItem7.Name = "createToolStripMenuItem7";
            createToolStripMenuItem7.Size = new Size(118, 22);
            createToolStripMenuItem7.Text = "create";
            createToolStripMenuItem7.Click += createToolStripMenuItem7_Click;
            // 
            // updateToolStripMenuItem7
            // 
            updateToolStripMenuItem7.Name = "updateToolStripMenuItem7";
            updateToolStripMenuItem7.Size = new Size(118, 22);
            updateToolStripMenuItem7.Text = "update";
            updateToolStripMenuItem7.Click += updateToolStripMenuItem7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1041, 531);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Inventory  System";
            tabControl1.ResumeLayout(false);
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
    }
}
