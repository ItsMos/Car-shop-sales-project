namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.ordersTab = new System.Windows.Forms.Button();
            this.inventoryTab = new System.Windows.Forms.Button();
            this.dashboardTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesomeIcons.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.tileBorderBottom = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesomeIcons.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newCarMake = new System.Windows.Forms.TextBox();
            this.newCarPrice = new System.Windows.Forms.TextBox();
            this.newCarName = new System.Windows.Forms.TextBox();
            this.newCarType = new System.Windows.Forms.ComboBox();
            this.carGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.dequeueBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton2)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.ordersPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.ordersTab);
            this.panel1.Controls.Add(this.inventoryTab);
            this.panel1.Controls.Add(this.dashboardTab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 443);
            this.panel1.TabIndex = 0;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.indicator.Location = new System.Drawing.Point(0, 138);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(5, 100);
            this.indicator.TabIndex = 1;
            // 
            // ordersTab
            // 
            this.ordersTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersTab.FlatAppearance.BorderSize = 0;
            this.ordersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersTab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ordersTab.Location = new System.Drawing.Point(0, 340);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(200, 100);
            this.ordersTab.TabIndex = 2;
            this.ordersTab.Text = "Orders";
            this.ordersTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ordersTab.UseVisualStyleBackColor = true;
            this.ordersTab.Click += new System.EventHandler(this.ordersTab_Click);
            // 
            // inventoryTab
            // 
            this.inventoryTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryTab.FlatAppearance.BorderSize = 0;
            this.inventoryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryTab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inventoryTab.Location = new System.Drawing.Point(0, 238);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(200, 100);
            this.inventoryTab.TabIndex = 2;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inventoryTab.UseVisualStyleBackColor = true;
            this.inventoryTab.Click += new System.EventHandler(this.inventoryTab_Click);
            // 
            // dashboardTab
            // 
            this.dashboardTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardTab.FlatAppearance.BorderSize = 0;
            this.dashboardTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardTab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboardTab.Location = new System.Drawing.Point(0, 138);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Size = new System.Drawing.Size(200, 100);
            this.dashboardTab.TabIndex = 2;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dashboardTab.UseVisualStyleBackColor = true;
            this.dashboardTab.Click += new System.EventHandler(this.dashboardTab_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 92);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19F);
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARS";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.totalLabel.Location = new System.Drawing.Point(99, 30);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 36);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.totalLabel);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(31, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 146);
            this.panel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconType = FontAwesomeIcons.IconType.Car;
            this.iconButton1.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iconButton1.Location = new System.Drawing.Point(3, 30);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(90, 90);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.TabStop = false;
            this.iconButton1.ToolTipText = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(99, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cars in inventory";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 19);
            this.panel4.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.closeBtn.Location = new System.Drawing.Point(558, -2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 21);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tileBorderBottom
            // 
            this.tileBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.tileBorderBottom.Location = new System.Drawing.Point(34, 245);
            this.tileBorderBottom.Name = "tileBorderBottom";
            this.tileBorderBottom.Size = new System.Drawing.Size(223, 5);
            this.tileBorderBottom.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.salesLabel);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(281, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 146);
            this.panel5.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconType = FontAwesomeIcons.IconType.ShoppingCart;
            this.iconButton2.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iconButton2.Location = new System.Drawing.Point(3, 30);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(90, 90);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.TabStop = false;
            this.iconButton2.ToolTipText = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(107, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sales";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.salesLabel.Location = new System.Drawing.Point(99, 30);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(31, 36);
            this.salesLabel.TabIndex = 1;
            this.salesLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Overview";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.panel6.Location = new System.Drawing.Point(283, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 5);
            this.panel6.TabIndex = 3;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.label7);
            this.dashboardPanel.Controls.Add(this.panel6);
            this.dashboardPanel.Controls.Add(this.panel3);
            this.dashboardPanel.Controls.Add(this.tileBorderBottom);
            this.dashboardPanel.Controls.Add(this.panel5);
            this.dashboardPanel.Location = new System.Drawing.Point(233, 54);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(534, 338);
            this.dashboardPanel.TabIndex = 4;
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._25400811_1990470917858064_374148922_o;
            this.inventoryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventoryPanel.Controls.Add(this.groupBox2);
            this.inventoryPanel.Controls.Add(this.carGrid);
            this.inventoryPanel.Controls.Add(this.label8);
            this.inventoryPanel.Location = new System.Drawing.Point(201, 55);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(774, 511);
            this.inventoryPanel.TabIndex = 5;
            this.inventoryPanel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.addNewBtn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.newCarMake);
            this.groupBox2.Controls.Add(this.newCarPrice);
            this.groupBox2.Controls.Add(this.newCarName);
            this.groupBox2.Controls.Add(this.newCarType);
            this.groupBox2.Location = new System.Drawing.Point(19, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new car";
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(452, 44);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(61, 29);
            this.addNewBtn.TabIndex = 9;
            this.addNewBtn.Text = "Add";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(373, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(235, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Car Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(120, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Car Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(16, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Car Make";
            // 
            // newCarMake
            // 
            this.newCarMake.Location = new System.Drawing.Point(8, 44);
            this.newCarMake.Name = "newCarMake";
            this.newCarMake.Size = new System.Drawing.Size(100, 27);
            this.newCarMake.TabIndex = 4;
            // 
            // newCarPrice
            // 
            this.newCarPrice.Location = new System.Drawing.Point(347, 44);
            this.newCarPrice.Name = "newCarPrice";
            this.newCarPrice.Size = new System.Drawing.Size(100, 27);
            this.newCarPrice.TabIndex = 7;
            // 
            // newCarName
            // 
            this.newCarName.Location = new System.Drawing.Point(114, 44);
            this.newCarName.Name = "newCarName";
            this.newCarName.Size = new System.Drawing.Size(100, 27);
            this.newCarName.TabIndex = 5;
            // 
            // newCarType
            // 
            this.newCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newCarType.FormattingEnabled = true;
            this.newCarType.Items.AddRange(new object[] {
            "Sedan",
            "Coupe",
            "SUV",
            "Hatchback",
            "Truck"});
            this.newCarType.Location = new System.Drawing.Point(220, 44);
            this.newCarType.Name = "newCarType";
            this.newCarType.Size = new System.Drawing.Size(121, 29);
            this.newCarType.TabIndex = 6;
            // 
            // carGrid
            // 
            this.carGrid.AllowUserToAddRows = false;
            this.carGrid.AllowUserToDeleteRows = false;
            this.carGrid.AllowUserToOrderColumns = true;
            this.carGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGrid.Location = new System.Drawing.Point(17, 44);
            this.carGrid.Name = "carGrid";
            this.carGrid.ReadOnly = true;
            this.carGrid.Size = new System.Drawing.Size(518, 214);
            this.carGrid.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(29, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Store Inventory";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orders Queue";
            // 
            // ordersPanel
            // 
            this.ordersPanel.Controls.Add(this.dequeueBtn);
            this.ordersPanel.Controls.Add(this.groupBox1);
            this.ordersPanel.Controls.Add(this.lstOrders);
            this.ordersPanel.Controls.Add(this.label2);
            this.ordersPanel.Location = new System.Drawing.Point(234, 56);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(534, 338);
            this.ordersPanel.TabIndex = 4;
            this.ordersPanel.Visible = false;
            // 
            // dequeueBtn
            // 
            this.dequeueBtn.Location = new System.Drawing.Point(231, 263);
            this.dequeueBtn.Name = "dequeueBtn";
            this.dequeueBtn.Size = new System.Drawing.Size(234, 33);
            this.dequeueBtn.TabIndex = 3;
            this.dequeueBtn.Text = "Complete order (Dequeue)";
            this.dequeueBtn.UseVisualStyleBackColor = true;
            this.dequeueBtn.Click += new System.EventHandler(this.dequeueBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.groupBox1.Location = new System.Drawing.Point(231, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Order";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(82, 62);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 32);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Car ID:";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 21;
            this.lstOrders.Location = new System.Drawing.Point(99, 82);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(108, 214);
            this.lstOrders.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(788, 443);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.inventoryPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.closeBtn_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton2)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ordersPanel.ResumeLayout(false);
            this.ordersPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboardTab;
        private System.Windows.Forms.Button inventoryTab;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label closeBtn;
        private FontAwesomeIcons.IconButton iconButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel tileBorderBottom;
        private System.Windows.Forms.Panel panel5;
        private FontAwesomeIcons.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ordersTab;
        private System.Windows.Forms.DataGridView carGrid;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dequeueBtn;
        private System.Windows.Forms.TextBox newCarName;
        private System.Windows.Forms.TextBox newCarMake;
        private System.Windows.Forms.ComboBox newCarType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newCarPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addNewBtn;
    }
}

