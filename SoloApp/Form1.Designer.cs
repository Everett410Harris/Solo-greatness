namespace SoloApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bookedLabel = new System.Windows.Forms.Label();
            this.bookedCb = new System.Windows.Forms.ComboBox();
            this.mileageTb = new System.Windows.Forms.TextBox();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.colorTb = new System.Windows.Forms.TextBox();
            this.engineTypeCb = new System.Windows.Forms.ComboBox();
            this.yearCb = new System.Windows.Forms.ComboBox();
            this.modelTb = new System.Windows.Forms.TextBox();
            this.makeCb = new System.Windows.Forms.ComboBox();
            this.licensePlateTb = new System.Windows.Forms.TextBox();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchTb);
            this.panel2.Location = new System.Drawing.Point(22, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 74);
            this.panel2.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(793, 17);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(179, 44);
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(387, 17);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(342, 44);
            this.searchTb.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(12, 716);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1339, 97);
            this.panel3.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.addNewBtn);
            this.panel5.Controls.Add(this.displayBtn);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Controls.Add(this.resetBtn);
            this.panel5.Controls.Add(this.exitBtn);
            this.panel5.Location = new System.Drawing.Point(22, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1296, 74);
            this.panel5.TabIndex = 1;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(20, 13);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(211, 44);
            this.addNewBtn.TabIndex = 26;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(270, 13);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(237, 44);
            this.displayBtn.TabIndex = 25;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(546, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(237, 44);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(822, 13);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(216, 44);
            this.resetBtn.TabIndex = 23;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1077, 13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(202, 44);
            this.exitBtn.TabIndex = 22;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bookedLabel);
            this.panel4.Controls.Add(this.bookedCb);
            this.panel4.Controls.Add(this.mileageTb);
            this.panel4.Controls.Add(this.typeCb);
            this.panel4.Controls.Add(this.colorTb);
            this.panel4.Controls.Add(this.engineTypeCb);
            this.panel4.Controls.Add(this.yearCb);
            this.panel4.Controls.Add(this.modelTb);
            this.panel4.Controls.Add(this.makeCb);
            this.panel4.Controls.Add(this.licensePlateTb);
            this.panel4.Controls.Add(this.licensePlateLabel);
            this.panel4.Controls.Add(this.makeLabel);
            this.panel4.Controls.Add(this.typeLabel);
            this.panel4.Controls.Add(this.mileageLabel);
            this.panel4.Controls.Add(this.modelLabel);
            this.panel4.Controls.Add(this.yearLabel);
            this.panel4.Controls.Add(this.colorLabel);
            this.panel4.Controls.Add(this.engineTypeLabel);
            this.panel4.Location = new System.Drawing.Point(26, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1325, 248);
            this.panel4.TabIndex = 12;
            // 
            // bookedLabel
            // 
            this.bookedLabel.AutoSize = true;
            this.bookedLabel.Location = new System.Drawing.Point(952, 187);
            this.bookedLabel.Name = "bookedLabel";
            this.bookedLabel.Size = new System.Drawing.Size(140, 38);
            this.bookedLabel.TabIndex = 20;
            this.bookedLabel.Text = "Booked";
            // 
            // bookedCb
            // 
            this.bookedCb.FormattingEnabled = true;
            this.bookedCb.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.bookedCb.Location = new System.Drawing.Point(1103, 184);
            this.bookedCb.Name = "bookedCb";
            this.bookedCb.Size = new System.Drawing.Size(219, 46);
            this.bookedCb.TabIndex = 19;
            // 
            // mileageTb
            // 
            this.mileageTb.Location = new System.Drawing.Point(1103, 11);
            this.mileageTb.Name = "mileageTb";
            this.mileageTb.Size = new System.Drawing.Size(219, 44);
            this.mileageTb.TabIndex = 18;
            // 
            // typeCb
            // 
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Items.AddRange(new object[] {
            "",
            "Frieght",
            "Van",
            "Sprinter",
            "SUV",
            "Sedan"});
            this.typeCb.Location = new System.Drawing.Point(1103, 100);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(219, 46);
            this.typeCb.TabIndex = 17;
            // 
            // colorTb
            // 
            this.colorTb.Location = new System.Drawing.Point(696, 189);
            this.colorTb.Name = "colorTb";
            this.colorTb.Size = new System.Drawing.Size(219, 44);
            this.colorTb.TabIndex = 16;
            // 
            // engineTypeCb
            // 
            this.engineTypeCb.FormattingEnabled = true;
            this.engineTypeCb.Items.AddRange(new object[] {
            "",
            "Diesiel",
            "Electric",
            "Gasoline"});
            this.engineTypeCb.Location = new System.Drawing.Point(696, 100);
            this.engineTypeCb.Name = "engineTypeCb";
            this.engineTypeCb.Size = new System.Drawing.Size(219, 46);
            this.engineTypeCb.TabIndex = 15;
            // 
            // yearCb
            // 
            this.yearCb.FormattingEnabled = true;
            this.yearCb.Items.AddRange(new object[] {
            "",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.yearCb.Location = new System.Drawing.Point(696, 14);
            this.yearCb.Name = "yearCb";
            this.yearCb.Size = new System.Drawing.Size(219, 46);
            this.yearCb.TabIndex = 14;
            // 
            // modelTb
            // 
            this.modelTb.Location = new System.Drawing.Point(245, 186);
            this.modelTb.Name = "modelTb";
            this.modelTb.Size = new System.Drawing.Size(219, 44);
            this.modelTb.TabIndex = 13;
            // 
            // makeCb
            // 
            this.makeCb.FormattingEnabled = true;
            this.makeCb.Items.AddRange(new object[] {
            "",
            "Mercedes",
            "Ford",
            "Tesla",
            "Toyota",
            "BMW",
            "Chevrolet"});
            this.makeCb.Location = new System.Drawing.Point(245, 100);
            this.makeCb.Name = "makeCb";
            this.makeCb.Size = new System.Drawing.Size(219, 46);
            this.makeCb.TabIndex = 12;
            // 
            // licensePlateTb
            // 
            this.licensePlateTb.Location = new System.Drawing.Point(245, 14);
            this.licensePlateTb.Name = "licensePlateTb";
            this.licensePlateTb.Size = new System.Drawing.Size(219, 44);
            this.licensePlateTb.TabIndex = 11;
            // 
            // licensePlateLabel
            // 
            this.licensePlateLabel.AutoSize = true;
            this.licensePlateLabel.Location = new System.Drawing.Point(7, 14);
            this.licensePlateLabel.Name = "licensePlateLabel";
            this.licensePlateLabel.Size = new System.Drawing.Size(232, 38);
            this.licensePlateLabel.TabIndex = 2;
            this.licensePlateLabel.Text = "License Plate";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(7, 103);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(107, 38);
            this.makeLabel.TabIndex = 3;
            this.makeLabel.Text = "Make";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(982, 103);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(96, 38);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(952, 14);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(145, 38);
            this.mileageLabel.TabIndex = 8;
            this.mileageLabel.Text = "Mileage";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(7, 192);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(120, 38);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Model";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(472, 14);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(94, 38);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(472, 197);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(108, 38);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Text = "Color";
            // 
            // engineTypeLabel
            // 
            this.engineTypeLabel.AutoSize = true;
            this.engineTypeLabel.Location = new System.Drawing.Point(472, 108);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(218, 38);
            this.engineTypeLabel.TabIndex = 6;
            this.engineTypeLabel.Text = "Engine Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1363, 825);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button searchBtn;
        private TextBox searchTb;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel5;
        private Button addNewBtn;
        private Button displayBtn;
        private Button deleteBtn;
        private Button resetBtn;
        private Button exitBtn;
        private Panel panel4;
        private ComboBox bookedCb;
        private TextBox mileageTb;
        private ComboBox typeCb;
        private TextBox colorTb;
        private ComboBox engineTypeCb;
        private ComboBox yearCb;
        private TextBox modelTb;
        private ComboBox makeCb;
        private TextBox licensePlateTb;
        private Label licensePlateLabel;
        private Label makeLabel;
        private Label typeLabel;
        private Label mileageLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label colorLabel;
        private Label engineTypeLabel;
        private Label bookedLabel;
    }
}