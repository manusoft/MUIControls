namespace MUITesting
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.muiProgressBar1 = new MUIControls.muiProgressBar();
            this.muiComboBox4 = new MUIControls.muiComboBox();
            this.muiComboBox3 = new MUIControls.muiComboBox();
            this.muiComboBox1 = new MUIControls.muiComboBox();
            this.muiCheckBox3 = new MUIControls.muiCheckBox();
            this.muiCheckBox2 = new MUIControls.muiCheckBox();
            this.muiCheckBox1 = new MUIControls.muiCheckBox();
            this.muiButton3 = new MUIControls.muiButton();
            this.muiButton2 = new MUIControls.muiButton();
            this.muiButton1 = new MUIControls.muiButton();
            this.muiProgressBar2 = new MUIControls.muiProgressBar();
            this.muiComboBox5 = new MUIControls.muiComboBox();
            this.muiComboBox6 = new MUIControls.muiComboBox();
            this.muiComboBox2 = new MUIControls.muiComboBox();
            this.muiCheckBox4 = new MUIControls.muiCheckBox();
            this.muiCheckBox5 = new MUIControls.muiCheckBox();
            this.muiCheckBox6 = new MUIControls.muiCheckBox();
            this.muiButton4 = new MUIControls.muiButton();
            this.muiButton5 = new MUIControls.muiButton();
            this.muiButton6 = new MUIControls.muiButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.muiProgressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.muiComboBox4);
            this.splitContainer1.Panel1.Controls.Add(this.muiComboBox3);
            this.splitContainer1.Panel1.Controls.Add(this.muiComboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.muiCheckBox3);
            this.splitContainer1.Panel1.Controls.Add(this.muiCheckBox2);
            this.splitContainer1.Panel1.Controls.Add(this.muiCheckBox1);
            this.splitContainer1.Panel1.Controls.Add(this.muiButton3);
            this.splitContainer1.Panel1.Controls.Add(this.muiButton2);
            this.splitContainer1.Panel1.Controls.Add(this.muiButton1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.splitContainer1.Panel2.Controls.Add(this.muiProgressBar2);
            this.splitContainer1.Panel2.Controls.Add(this.muiComboBox5);
            this.splitContainer1.Panel2.Controls.Add(this.muiComboBox6);
            this.splitContainer1.Panel2.Controls.Add(this.muiComboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.muiCheckBox4);
            this.splitContainer1.Panel2.Controls.Add(this.muiCheckBox5);
            this.splitContainer1.Panel2.Controls.Add(this.muiCheckBox6);
            this.splitContainer1.Panel2.Controls.Add(this.muiButton4);
            this.splitContainer1.Panel2.Controls.Add(this.muiButton5);
            this.splitContainer1.Panel2.Controls.Add(this.muiButton6);
            this.splitContainer1.Size = new System.Drawing.Size(984, 464);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(14, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(426, 210);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUI Controls";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muiProgressBar1
            // 
            this.muiProgressBar1.ChannelColor = System.Drawing.Color.LightBlue;
            this.muiProgressBar1.ChannelHeight = 10;
            this.muiProgressBar1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.muiProgressBar1.ForeColor = System.Drawing.Color.White;
            this.muiProgressBar1.Location = new System.Drawing.Point(14, 156);
            this.muiProgressBar1.Name = "muiProgressBar1";
            this.muiProgressBar1.Size = new System.Drawing.Size(466, 23);
            this.muiProgressBar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.muiProgressBar1.SliderHeight = 10;
            this.muiProgressBar1.TabIndex = 19;
            this.muiProgressBar1.Value = 50;
            // 
            // muiComboBox4
            // 
            this.muiComboBox4.BackColor = System.Drawing.Color.White;
            this.muiComboBox4.BorderColor = System.Drawing.Color.RoyalBlue;
            this.muiComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muiComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muiComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.muiComboBox4.FormattingEnabled = true;
            this.muiComboBox4.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.muiComboBox4.Location = new System.Drawing.Point(330, 113);
            this.muiComboBox4.Name = "muiComboBox4";
            this.muiComboBox4.SelectionColor = System.Drawing.Color.DeepSkyBlue;
            this.muiComboBox4.Size = new System.Drawing.Size(150, 26);
            this.muiComboBox4.TabIndex = 17;
            this.muiComboBox4.UnderlinedStyle = true;
            // 
            // muiComboBox3
            // 
            this.muiComboBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiComboBox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.muiComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muiComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muiComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.muiComboBox3.FormattingEnabled = true;
            this.muiComboBox3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.muiComboBox3.Location = new System.Drawing.Point(172, 113);
            this.muiComboBox3.Name = "muiComboBox3";
            this.muiComboBox3.SelectionColor = System.Drawing.Color.Teal;
            this.muiComboBox3.Size = new System.Drawing.Size(150, 26);
            this.muiComboBox3.TabIndex = 16;
            this.muiComboBox3.UnderlinedStyle = false;
            // 
            // muiComboBox1
            // 
            this.muiComboBox1.BackColor = System.Drawing.Color.White;
            this.muiComboBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.muiComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muiComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muiComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.muiComboBox1.FormattingEnabled = true;
            this.muiComboBox1.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.muiComboBox1.Location = new System.Drawing.Point(14, 113);
            this.muiComboBox1.Name = "muiComboBox1";
            this.muiComboBox1.SelectionColor = System.Drawing.Color.DeepSkyBlue;
            this.muiComboBox1.Size = new System.Drawing.Size(150, 26);
            this.muiComboBox1.TabIndex = 15;
            this.muiComboBox1.UnderlinedStyle = false;
            this.muiComboBox1.SelectedIndexChanged += new System.EventHandler(this.muiComboBox1_SelectedIndexChanged);
            // 
            // muiCheckBox3
            // 
            this.muiCheckBox3.AutoSize = true;
            this.muiCheckBox3.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.muiCheckBox3.Location = new System.Drawing.Point(330, 62);
            this.muiCheckBox3.MinimumSize = new System.Drawing.Size(0, 21);
            this.muiCheckBox3.Name = "muiCheckBox3";
            this.muiCheckBox3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.muiCheckBox3.Size = new System.Drawing.Size(120, 21);
            this.muiCheckBox3.TabIndex = 14;
            this.muiCheckBox3.Text = "muiCheckBox3";
            this.muiCheckBox3.UnCheckedColor = System.Drawing.Color.CornflowerBlue;
            this.muiCheckBox3.UseVisualStyleBackColor = true;
            // 
            // muiCheckBox2
            // 
            this.muiCheckBox2.AutoSize = true;
            this.muiCheckBox2.CheckedColor = System.Drawing.Color.Orange;
            this.muiCheckBox2.Location = new System.Drawing.Point(172, 62);
            this.muiCheckBox2.MinimumSize = new System.Drawing.Size(0, 21);
            this.muiCheckBox2.Name = "muiCheckBox2";
            this.muiCheckBox2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.muiCheckBox2.Size = new System.Drawing.Size(120, 21);
            this.muiCheckBox2.TabIndex = 13;
            this.muiCheckBox2.Text = "muiCheckBox2";
            this.muiCheckBox2.UnCheckedColor = System.Drawing.Color.Orange;
            this.muiCheckBox2.UseVisualStyleBackColor = true;
            // 
            // muiCheckBox1
            // 
            this.muiCheckBox1.AutoSize = true;
            this.muiCheckBox1.CheckedColor = System.Drawing.Color.Black;
            this.muiCheckBox1.Location = new System.Drawing.Point(14, 62);
            this.muiCheckBox1.MinimumSize = new System.Drawing.Size(0, 21);
            this.muiCheckBox1.Name = "muiCheckBox1";
            this.muiCheckBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.muiCheckBox1.Size = new System.Drawing.Size(120, 21);
            this.muiCheckBox1.TabIndex = 12;
            this.muiCheckBox1.Text = "muiCheckBox1";
            this.muiCheckBox1.UnCheckedColor = System.Drawing.Color.Black;
            this.muiCheckBox1.UseVisualStyleBackColor = true;
            // 
            // muiButton3
            // 
            this.muiButton3.BackColor = System.Drawing.Color.White;
            this.muiButton3.BorderColor = System.Drawing.Color.Teal;
            this.muiButton3.BorderRadius = 15;
            this.muiButton3.BorderSize = 2;
            this.muiButton3.FlatAppearance.BorderSize = 0;
            this.muiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton3.ForeColor = System.Drawing.Color.Black;
            this.muiButton3.Location = new System.Drawing.Point(330, 13);
            this.muiButton3.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton3.Name = "muiButton3";
            this.muiButton3.Size = new System.Drawing.Size(150, 30);
            this.muiButton3.TabIndex = 11;
            this.muiButton3.Text = "muiButton3";
            this.muiButton3.UseVisualStyleBackColor = false;
            // 
            // muiButton2
            // 
            this.muiButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiButton2.BorderColor = System.Drawing.Color.Teal;
            this.muiButton2.BorderRadius = 15;
            this.muiButton2.BorderSize = 1;
            this.muiButton2.FlatAppearance.BorderSize = 0;
            this.muiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton2.ForeColor = System.Drawing.Color.White;
            this.muiButton2.Location = new System.Drawing.Point(172, 13);
            this.muiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton2.Name = "muiButton2";
            this.muiButton2.Size = new System.Drawing.Size(150, 30);
            this.muiButton2.TabIndex = 10;
            this.muiButton2.Text = "muiButton2";
            this.muiButton2.UseVisualStyleBackColor = false;
            // 
            // muiButton1
            // 
            this.muiButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.muiButton1.BorderColor = System.Drawing.Color.Silver;
            this.muiButton1.BorderRadius = 0;
            this.muiButton1.BorderSize = 1;
            this.muiButton1.FlatAppearance.BorderSize = 0;
            this.muiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton1.ForeColor = System.Drawing.Color.Black;
            this.muiButton1.Location = new System.Drawing.Point(14, 13);
            this.muiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton1.Name = "muiButton1";
            this.muiButton1.Size = new System.Drawing.Size(150, 30);
            this.muiButton1.TabIndex = 9;
            this.muiButton1.Text = "muiButton1";
            this.muiButton1.UseVisualStyleBackColor = false;
            // 
            // muiProgressBar2
            // 
            this.muiProgressBar2.ChannelColor = System.Drawing.Color.CadetBlue;
            this.muiProgressBar2.ChannelHeight = 10;
            this.muiProgressBar2.ForeBackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiProgressBar2.ForeColor = System.Drawing.Color.Black;
            this.muiProgressBar2.Location = new System.Drawing.Point(11, 156);
            this.muiProgressBar2.Name = "muiProgressBar2";
            this.muiProgressBar2.Size = new System.Drawing.Size(466, 12);
            this.muiProgressBar2.SliderColor = System.Drawing.Color.LimeGreen;
            this.muiProgressBar2.SliderHeight = 10;
            this.muiProgressBar2.TabIndex = 20;
            this.muiProgressBar2.Value = 50;
            // 
            // muiComboBox5
            // 
            this.muiComboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.muiComboBox5.BorderColor = System.Drawing.Color.RoyalBlue;
            this.muiComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muiComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muiComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.muiComboBox5.ForeColor = System.Drawing.Color.White;
            this.muiComboBox5.FormattingEnabled = true;
            this.muiComboBox5.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.muiComboBox5.Location = new System.Drawing.Point(329, 113);
            this.muiComboBox5.Name = "muiComboBox5";
            this.muiComboBox5.SelectionColor = System.Drawing.Color.LightSeaGreen;
            this.muiComboBox5.Size = new System.Drawing.Size(150, 26);
            this.muiComboBox5.TabIndex = 19;
            this.muiComboBox5.UnderlinedStyle = true;
            // 
            // muiComboBox6
            // 
            this.muiComboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.muiComboBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.muiComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muiComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muiComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.muiComboBox6.ForeColor = System.Drawing.Color.White;
            this.muiComboBox6.FormattingEnabled = true;
            this.muiComboBox6.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.muiComboBox6.Location = new System.Drawing.Point(171, 113);
            this.muiComboBox6.Name = "muiComboBox6";
            this.muiComboBox6.SelectionColor = System.Drawing.Color.LightSeaGreen;
            this.muiComboBox6.Size = new System.Drawing.Size(150, 26);
            this.muiComboBox6.TabIndex = 18;
            this.muiComboBox6.UnderlinedStyle = false;
            // 
            // muiComboBox2
            // 
            this.muiComboBox2.BackColor = System.Drawing.Color.Orange;
            this.muiComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.muiComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muiComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muiComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.muiComboBox2.ForeColor = System.Drawing.Color.White;
            this.muiComboBox2.FormattingEnabled = true;
            this.muiComboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.muiComboBox2.Location = new System.Drawing.Point(13, 113);
            this.muiComboBox2.Name = "muiComboBox2";
            this.muiComboBox2.SelectionColor = System.Drawing.Color.LightSeaGreen;
            this.muiComboBox2.Size = new System.Drawing.Size(150, 26);
            this.muiComboBox2.TabIndex = 15;
            this.muiComboBox2.UnderlinedStyle = false;
            // 
            // muiCheckBox4
            // 
            this.muiCheckBox4.AutoSize = true;
            this.muiCheckBox4.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.muiCheckBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.muiCheckBox4.Location = new System.Drawing.Point(329, 62);
            this.muiCheckBox4.MinimumSize = new System.Drawing.Size(0, 21);
            this.muiCheckBox4.Name = "muiCheckBox4";
            this.muiCheckBox4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.muiCheckBox4.Size = new System.Drawing.Size(120, 21);
            this.muiCheckBox4.TabIndex = 14;
            this.muiCheckBox4.Text = "muiCheckBox4";
            this.muiCheckBox4.UnCheckedColor = System.Drawing.Color.CornflowerBlue;
            this.muiCheckBox4.UseVisualStyleBackColor = true;
            // 
            // muiCheckBox5
            // 
            this.muiCheckBox5.AutoSize = true;
            this.muiCheckBox5.CheckedColor = System.Drawing.Color.Orange;
            this.muiCheckBox5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.muiCheckBox5.Location = new System.Drawing.Point(171, 62);
            this.muiCheckBox5.MinimumSize = new System.Drawing.Size(0, 21);
            this.muiCheckBox5.Name = "muiCheckBox5";
            this.muiCheckBox5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.muiCheckBox5.Size = new System.Drawing.Size(120, 21);
            this.muiCheckBox5.TabIndex = 13;
            this.muiCheckBox5.Text = "muiCheckBox5";
            this.muiCheckBox5.UnCheckedColor = System.Drawing.Color.Orange;
            this.muiCheckBox5.UseVisualStyleBackColor = true;
            // 
            // muiCheckBox6
            // 
            this.muiCheckBox6.AutoSize = true;
            this.muiCheckBox6.CheckedColor = System.Drawing.Color.Teal;
            this.muiCheckBox6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.muiCheckBox6.Location = new System.Drawing.Point(13, 62);
            this.muiCheckBox6.MinimumSize = new System.Drawing.Size(0, 21);
            this.muiCheckBox6.Name = "muiCheckBox6";
            this.muiCheckBox6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.muiCheckBox6.Size = new System.Drawing.Size(120, 21);
            this.muiCheckBox6.TabIndex = 12;
            this.muiCheckBox6.Text = "muiCheckBox6";
            this.muiCheckBox6.UnCheckedColor = System.Drawing.Color.Teal;
            this.muiCheckBox6.UseVisualStyleBackColor = true;
            // 
            // muiButton4
            // 
            this.muiButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.muiButton4.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.muiButton4.BorderRadius = 15;
            this.muiButton4.BorderSize = 2;
            this.muiButton4.FlatAppearance.BorderSize = 0;
            this.muiButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton4.ForeColor = System.Drawing.Color.White;
            this.muiButton4.Location = new System.Drawing.Point(329, 13);
            this.muiButton4.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton4.Name = "muiButton4";
            this.muiButton4.Size = new System.Drawing.Size(150, 30);
            this.muiButton4.TabIndex = 11;
            this.muiButton4.Text = "muiButton4";
            this.muiButton4.UseVisualStyleBackColor = false;
            // 
            // muiButton5
            // 
            this.muiButton5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiButton5.BorderColor = System.Drawing.Color.Transparent;
            this.muiButton5.BorderRadius = 15;
            this.muiButton5.BorderSize = 1;
            this.muiButton5.FlatAppearance.BorderSize = 0;
            this.muiButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton5.ForeColor = System.Drawing.Color.White;
            this.muiButton5.Location = new System.Drawing.Point(171, 13);
            this.muiButton5.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton5.Name = "muiButton5";
            this.muiButton5.Size = new System.Drawing.Size(150, 30);
            this.muiButton5.TabIndex = 10;
            this.muiButton5.Text = "muiButton5";
            this.muiButton5.UseVisualStyleBackColor = false;
            // 
            // muiButton6
            // 
            this.muiButton6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiButton6.BorderColor = System.Drawing.Color.Transparent;
            this.muiButton6.BorderRadius = 0;
            this.muiButton6.BorderSize = 1;
            this.muiButton6.FlatAppearance.BorderSize = 0;
            this.muiButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton6.ForeColor = System.Drawing.Color.White;
            this.muiButton6.Location = new System.Drawing.Point(13, 13);
            this.muiButton6.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton6.Name = "muiButton6";
            this.muiButton6.Size = new System.Drawing.Size(150, 30);
            this.muiButton6.TabIndex = 9;
            this.muiButton6.Text = "muiButton6";
            this.muiButton6.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUI Controls Tetsing";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MUIControls.muiComboBox muiComboBox4;
        private MUIControls.muiComboBox muiComboBox3;
        private MUIControls.muiComboBox muiComboBox1;
        private MUIControls.muiCheckBox muiCheckBox3;
        private MUIControls.muiCheckBox muiCheckBox2;
        private MUIControls.muiCheckBox muiCheckBox1;
        private MUIControls.muiButton muiButton3;
        private MUIControls.muiButton muiButton2;
        private MUIControls.muiButton muiButton1;
        private MUIControls.muiComboBox muiComboBox5;
        private MUIControls.muiComboBox muiComboBox6;
        private MUIControls.muiComboBox muiComboBox2;
        private MUIControls.muiCheckBox muiCheckBox4;
        private MUIControls.muiCheckBox muiCheckBox5;
        private MUIControls.muiCheckBox muiCheckBox6;
        private MUIControls.muiButton muiButton4;
        private MUIControls.muiButton muiButton5;
        private MUIControls.muiButton muiButton6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MUIControls.muiProgressBar muiProgressBar1;
        private MUIControls.muiProgressBar muiProgressBar2;
    }
}

