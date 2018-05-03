namespace Pull_the_Trigger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericMinTime = new System.Windows.Forms.NumericUpDown();
            this.numericMaxTime = new System.Windows.Forms.NumericUpDown();
            this.numericSetTime = new System.Windows.Forms.NumericUpDown();
            this.labelMinTime = new System.Windows.Forms.Label();
            this.labelMaxTime = new System.Windows.Forms.Label();
            this.labelSetupTime = new System.Windows.Forms.Label();
            this.radio5bar = new System.Windows.Forms.RadioButton();
            this.radio3bar = new System.Windows.Forms.RadioButton();
            this.listBoxOptions5 = new System.Windows.Forms.ListBox();
            this.buttonAddTo5List = new System.Windows.Forms.Button();
            this.buttonClear5List = new System.Windows.Forms.Button();
            this.dataGridView5Bar = new System.Windows.Forms.DataGridView();
            this.checkBoxTimeCall = new System.Windows.Forms.CheckBox();
            this.dataGridView3Bar = new System.Windows.Forms.DataGridView();
            this.buttonClear3List = new System.Windows.Forms.Button();
            this.buttonAddTo3List = new System.Windows.Forms.Button();
            this.listBoxOptions3 = new System.Windows.Forms.ListBox();
            this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSetTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMinTime
            // 
            this.numericMinTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMinTime.Location = new System.Drawing.Point(95, 15);
            this.numericMinTime.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericMinTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMinTime.Name = "numericMinTime";
            this.numericMinTime.Size = new System.Drawing.Size(74, 26);
            this.numericMinTime.TabIndex = 0;
            this.numericMinTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericMaxTime
            // 
            this.numericMaxTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMaxTime.Location = new System.Drawing.Point(95, 41);
            this.numericMaxTime.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericMaxTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMaxTime.Name = "numericMaxTime";
            this.numericMaxTime.Size = new System.Drawing.Size(74, 26);
            this.numericMaxTime.TabIndex = 1;
            this.numericMaxTime.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericSetTime
            // 
            this.numericSetTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSetTime.Location = new System.Drawing.Point(95, 67);
            this.numericSetTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSetTime.Name = "numericSetTime";
            this.numericSetTime.Size = new System.Drawing.Size(74, 26);
            this.numericSetTime.TabIndex = 2;
            this.numericSetTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelMinTime
            // 
            this.labelMinTime.AutoSize = true;
            this.labelMinTime.Location = new System.Drawing.Point(15, 20);
            this.labelMinTime.Name = "labelMinTime";
            this.labelMinTime.Size = new System.Drawing.Size(74, 13);
            this.labelMinTime.TabIndex = 3;
            this.labelMinTime.Text = "Minimum Time";
            // 
            // labelMaxTime
            // 
            this.labelMaxTime.AutoSize = true;
            this.labelMaxTime.Location = new System.Drawing.Point(12, 47);
            this.labelMaxTime.Name = "labelMaxTime";
            this.labelMaxTime.Size = new System.Drawing.Size(77, 13);
            this.labelMaxTime.TabIndex = 4;
            this.labelMaxTime.Text = "Maximum Time";
            // 
            // labelSetupTime
            // 
            this.labelSetupTime.AutoSize = true;
            this.labelSetupTime.Location = new System.Drawing.Point(28, 73);
            this.labelSetupTime.Name = "labelSetupTime";
            this.labelSetupTime.Size = new System.Drawing.Size(61, 13);
            this.labelSetupTime.TabIndex = 5;
            this.labelSetupTime.Text = "Setup Time";
            // 
            // radio5bar
            // 
            this.radio5bar.AutoSize = true;
            this.radio5bar.Location = new System.Drawing.Point(290, 73);
            this.radio5bar.Name = "radio5bar";
            this.radio5bar.Size = new System.Drawing.Size(49, 17);
            this.radio5bar.TabIndex = 8;
            this.radio5bar.TabStop = true;
            this.radio5bar.Text = "5-bar";
            this.radio5bar.UseVisualStyleBackColor = true;
            // 
            // radio3bar
            // 
            this.radio3bar.AutoSize = true;
            this.radio3bar.Location = new System.Drawing.Point(208, 73);
            this.radio3bar.Name = "radio3bar";
            this.radio3bar.Size = new System.Drawing.Size(49, 17);
            this.radio3bar.TabIndex = 9;
            this.radio3bar.TabStop = true;
            this.radio3bar.Text = "3-bar";
            this.radio3bar.UseVisualStyleBackColor = true;
            // 
            // listBoxOptions5
            // 
            this.listBoxOptions5.FormattingEnabled = true;
            this.listBoxOptions5.Items.AddRange(new object[] {
            "Wall",
            "Lane",
            "Bounce",
            "Shot"});
            this.listBoxOptions5.Location = new System.Drawing.Point(208, 134);
            this.listBoxOptions5.Name = "listBoxOptions5";
            this.listBoxOptions5.Size = new System.Drawing.Size(138, 56);
            this.listBoxOptions5.TabIndex = 10;
            this.listBoxOptions5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOptions5_MouseDoubleClick);
            // 
            // buttonAddTo5List
            // 
            this.buttonAddTo5List.Location = new System.Drawing.Point(236, 196);
            this.buttonAddTo5List.Name = "buttonAddTo5List";
            this.buttonAddTo5List.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTo5List.TabIndex = 11;
            this.buttonAddTo5List.Text = "Add to List";
            this.buttonAddTo5List.UseVisualStyleBackColor = true;
            this.buttonAddTo5List.Click += new System.EventHandler(this.buttonAddTo5List_Click);
            // 
            // buttonClear5List
            // 
            this.buttonClear5List.Location = new System.Drawing.Point(236, 225);
            this.buttonClear5List.Name = "buttonClear5List";
            this.buttonClear5List.Size = new System.Drawing.Size(75, 23);
            this.buttonClear5List.TabIndex = 12;
            this.buttonClear5List.Text = "Clear List";
            this.buttonClear5List.UseVisualStyleBackColor = true;
            this.buttonClear5List.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView5Bar
            // 
            this.dataGridView5Bar.AllowUserToAddRows = false;
            this.dataGridView5Bar.AllowUserToDeleteRows = false;
            this.dataGridView5Bar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5Bar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Option,
            this.Weight});
            this.dataGridView5Bar.Location = new System.Drawing.Point(18, 112);
            this.dataGridView5Bar.Name = "dataGridView5Bar";
            this.dataGridView5Bar.RowHeadersVisible = false;
            this.dataGridView5Bar.Size = new System.Drawing.Size(174, 150);
            this.dataGridView5Bar.TabIndex = 13;
            // 
            // checkBoxTimeCall
            // 
            this.checkBoxTimeCall.AutoSize = true;
            this.checkBoxTimeCall.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTimeCall.Location = new System.Drawing.Point(245, 15);
            this.checkBoxTimeCall.Name = "checkBoxTimeCall";
            this.checkBoxTimeCall.Size = new System.Drawing.Size(94, 17);
            this.checkBoxTimeCall.TabIndex = 14;
            this.checkBoxTimeCall.Text = "Call Time After";
            this.checkBoxTimeCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTimeCall.UseVisualStyleBackColor = true;
            // 
            // dataGridView3Bar
            // 
            this.dataGridView3Bar.AllowUserToAddRows = false;
            this.dataGridView3Bar.AllowUserToDeleteRows = false;
            this.dataGridView3Bar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3Bar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3Bar.Location = new System.Drawing.Point(18, 278);
            this.dataGridView3Bar.Name = "dataGridView3Bar";
            this.dataGridView3Bar.RowHeadersVisible = false;
            this.dataGridView3Bar.Size = new System.Drawing.Size(174, 199);
            this.dataGridView3Bar.TabIndex = 18;
            // 
            // buttonClear3List
            // 
            this.buttonClear3List.Location = new System.Drawing.Point(236, 446);
            this.buttonClear3List.Name = "buttonClear3List";
            this.buttonClear3List.Size = new System.Drawing.Size(75, 23);
            this.buttonClear3List.TabIndex = 17;
            this.buttonClear3List.Text = "Clear List";
            this.buttonClear3List.UseVisualStyleBackColor = true;
            this.buttonClear3List.Click += new System.EventHandler(this.buttonClear3List_Click);
            // 
            // buttonAddTo3List
            // 
            this.buttonAddTo3List.Location = new System.Drawing.Point(236, 417);
            this.buttonAddTo3List.Name = "buttonAddTo3List";
            this.buttonAddTo3List.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTo3List.TabIndex = 16;
            this.buttonAddTo3List.Text = "Add to List";
            this.buttonAddTo3List.UseVisualStyleBackColor = true;
            this.buttonAddTo3List.Click += new System.EventHandler(this.buttonAddTo3List_Click);
            // 
            // listBoxOptions3
            // 
            this.listBoxOptions3.FormattingEnabled = true;
            this.listBoxOptions3.Items.AddRange(new object[] {
            "Pull",
            "Push",
            "Straight",
            "Short",
            "Tuck",
            "Middle",
            "Spray",
            "Long",
            "Slice"});
            this.listBoxOptions3.Location = new System.Drawing.Point(208, 290);
            this.listBoxOptions3.Name = "listBoxOptions3";
            this.listBoxOptions3.Size = new System.Drawing.Size(138, 121);
            this.listBoxOptions3.TabIndex = 15;
            this.listBoxOptions3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOptions3_MouseDoubleClick);
            // 
            // Option
            // 
            this.Option.HeaderText = "Option";
            this.Option.Name = "Option";
            this.Option.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Option";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 492);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(117, 492);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 20;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(262, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 26);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Wait time";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(236, 492);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 23;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 527);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dataGridView3Bar);
            this.Controls.Add(this.buttonClear3List);
            this.Controls.Add(this.buttonAddTo3List);
            this.Controls.Add(this.listBoxOptions3);
            this.Controls.Add(this.checkBoxTimeCall);
            this.Controls.Add(this.dataGridView5Bar);
            this.Controls.Add(this.buttonClear5List);
            this.Controls.Add(this.buttonAddTo5List);
            this.Controls.Add(this.listBoxOptions5);
            this.Controls.Add(this.radio3bar);
            this.Controls.Add(this.radio5bar);
            this.Controls.Add(this.labelSetupTime);
            this.Controls.Add(this.labelMaxTime);
            this.Controls.Add(this.labelMinTime);
            this.Controls.Add(this.numericSetTime);
            this.Controls.Add(this.numericMaxTime);
            this.Controls.Add(this.numericMinTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pull the Trigger!";
            ((System.ComponentModel.ISupportInitialize)(this.numericMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSetTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericMinTime;
        private System.Windows.Forms.NumericUpDown numericMaxTime;
        private System.Windows.Forms.NumericUpDown numericSetTime;
        private System.Windows.Forms.Label labelMinTime;
        private System.Windows.Forms.Label labelMaxTime;
        private System.Windows.Forms.Label labelSetupTime;
        private System.Windows.Forms.RadioButton radio5bar;
        private System.Windows.Forms.RadioButton radio3bar;
        private System.Windows.Forms.ListBox listBoxOptions5;
        private System.Windows.Forms.Button buttonAddTo5List;
        private System.Windows.Forms.Button buttonClear5List;
        private System.Windows.Forms.DataGridView dataGridView5Bar;
        private System.Windows.Forms.CheckBox checkBoxTimeCall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridView dataGridView3Bar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonClear3List;
        private System.Windows.Forms.Button buttonAddTo3List;
        private System.Windows.Forms.ListBox listBoxOptions3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAbout;
    }
}

