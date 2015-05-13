namespace EmployeeInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employNameTextBox = new System.Windows.Forms.TextBox();
            this.employAddressTextBox = new System.Windows.Forms.TextBox();
            this.employEmailTextBox = new System.Windows.Forms.TextBox();
            this.employSalaryTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.employInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteEmployIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employInfoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // employNameTextBox
            // 
            this.employNameTextBox.Location = new System.Drawing.Point(94, 53);
            this.employNameTextBox.Name = "employNameTextBox";
            this.employNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.employNameTextBox.TabIndex = 4;
            // 
            // employAddressTextBox
            // 
            this.employAddressTextBox.Location = new System.Drawing.Point(94, 86);
            this.employAddressTextBox.Name = "employAddressTextBox";
            this.employAddressTextBox.Size = new System.Drawing.Size(205, 20);
            this.employAddressTextBox.TabIndex = 5;
            // 
            // employEmailTextBox
            // 
            this.employEmailTextBox.Location = new System.Drawing.Point(94, 116);
            this.employEmailTextBox.Name = "employEmailTextBox";
            this.employEmailTextBox.Size = new System.Drawing.Size(205, 20);
            this.employEmailTextBox.TabIndex = 6;
            // 
            // employSalaryTextBox
            // 
            this.employSalaryTextBox.Location = new System.Drawing.Point(94, 143);
            this.employSalaryTextBox.Name = "employSalaryTextBox";
            this.employSalaryTextBox.Size = new System.Drawing.Size(205, 20);
            this.employSalaryTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(217, 173);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 21);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showButton_Click);
            // 
            // employInfoDataGridView
            // 
            this.employInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.employInfoDataGridView.Location = new System.Drawing.Point(113, 272);
            this.employInfoDataGridView.Name = "employInfoDataGridView";
            this.employInfoDataGridView.RowHeadersVisible = false;
            this.employInfoDataGridView.Size = new System.Drawing.Size(505, 156);
            this.employInfoDataGridView.TabIndex = 10;
            this.employInfoDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Emplyee ID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Salary";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.empIDTextBox);
            this.groupBox1.Controls.Add(this.employAddressTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.employSalaryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.employEmailTextBox);
            this.groupBox1.Controls.Add(this.employNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Emplyee ID";
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(94, 24);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(205, 20);
            this.empIDTextBox.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.deleteEmployIDTextBox);
            this.groupBox3.Location = new System.Drawing.Point(350, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 98);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Employee";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(140, 63);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete Employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Emplyee ID";
            // 
            // deleteEmployIDTextBox
            // 
            this.deleteEmployIDTextBox.Location = new System.Drawing.Point(83, 32);
            this.deleteEmployIDTextBox.Name = "deleteEmployIDTextBox";
            this.deleteEmployIDTextBox.Size = new System.Drawing.Size(205, 20);
            this.deleteEmployIDTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employInfoDataGridView);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(419, 249);
            this.Name = "Form1";
            this.Text = "Employee Information UI";
            ((System.ComponentModel.ISupportInitialize)(this.employInfoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employNameTextBox;
        private System.Windows.Forms.TextBox employAddressTextBox;
        private System.Windows.Forms.TextBox employEmailTextBox;
        private System.Windows.Forms.TextBox employSalaryTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView employInfoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deleteEmployIDTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

