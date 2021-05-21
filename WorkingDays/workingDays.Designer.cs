
namespace ABC_TimetableManagementSystem
{
    partial class workingDays
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
            System.Windows.Forms.Label noOfWorkingDaysLabel;
            System.Windows.Forms.Label workingDaysLabel;
            System.Windows.Forms.Label workingTimePerDaysLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workingDays));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noOfWorkingDaysComboBox = new System.Windows.Forms.ComboBox();
            this.workingDaysandHoursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.workingDaysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.workingTimePerDaysComboBox = new System.Windows.Forms.ComboBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.workingDaysandHoursTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.WorkingDaysandHoursTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            noOfWorkingDaysLabel = new System.Windows.Forms.Label();
            workingDaysLabel = new System.Windows.Forms.Label();
            workingTimePerDaysLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingDaysandHoursTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // noOfWorkingDaysLabel
            // 
            noOfWorkingDaysLabel.AutoSize = true;
            noOfWorkingDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noOfWorkingDaysLabel.Location = new System.Drawing.Point(11, 107);
            noOfWorkingDaysLabel.Name = "noOfWorkingDaysLabel";
            noOfWorkingDaysLabel.Size = new System.Drawing.Size(142, 15);
            noOfWorkingDaysLabel.TabIndex = 6;
            noOfWorkingDaysLabel.Text = "No Of Working Days :";
            // 
            // workingDaysLabel
            // 
            workingDaysLabel.AutoSize = true;
            workingDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workingDaysLabel.Location = new System.Drawing.Point(11, 172);
            workingDaysLabel.Name = "workingDaysLabel";
            workingDaysLabel.Size = new System.Drawing.Size(102, 15);
            workingDaysLabel.TabIndex = 8;
            workingDaysLabel.Text = "Working Days :";
            // 
            // workingTimePerDaysLabel
            // 
            workingTimePerDaysLabel.AutoSize = true;
            workingTimePerDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workingTimePerDaysLabel.Location = new System.Drawing.Point(11, 300);
            workingTimePerDaysLabel.Name = "workingTimePerDaysLabel";
            workingTimePerDaysLabel.Size = new System.Drawing.Size(164, 15);
            workingTimePerDaysLabel.TabIndex = 10;
            workingTimePerDaysLabel.Text = "Working Time Per Days :";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(11, 62);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(96, 15);
            employeeIDLabel.TabIndex = 12;
            employeeIDLabel.Text = "Employee ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 89);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(23, 18);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(38, 40);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timetable Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABC Institute";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(noOfWorkingDaysLabel);
            this.panel2.Controls.Add(this.noOfWorkingDaysComboBox);
            this.panel2.Controls.Add(workingDaysLabel);
            this.panel2.Controls.Add(this.workingDaysCheckedListBox);
            this.panel2.Controls.Add(workingTimePerDaysLabel);
            this.panel2.Controls.Add(this.workingTimePerDaysComboBox);
            this.panel2.Controls.Add(employeeIDLabel);
            this.panel2.Controls.Add(this.employeeIDTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 383);
            this.panel2.TabIndex = 2;
            // 
            // noOfWorkingDaysComboBox
            // 
            this.noOfWorkingDaysComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workingDaysandHoursTableBindingSource, "NoOfWorkingDays", true));
            this.noOfWorkingDaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfWorkingDaysComboBox.FormattingEnabled = true;
            this.noOfWorkingDaysComboBox.Items.AddRange(new object[] {
            "1 day",
            "2 days",
            "3 days",
            "4 days",
            "5 days",
            "6 days",
            "7 days"});
            this.noOfWorkingDaysComboBox.Location = new System.Drawing.Point(216, 104);
            this.noOfWorkingDaysComboBox.Name = "noOfWorkingDaysComboBox";
            this.noOfWorkingDaysComboBox.Size = new System.Drawing.Size(211, 23);
            this.noOfWorkingDaysComboBox.TabIndex = 7;
            // 
            // workingDaysandHoursTableBindingSource
            // 
            this.workingDaysandHoursTableBindingSource.DataMember = "WorkingDaysandHoursTable";
            this.workingDaysandHoursTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workingDaysCheckedListBox
            // 
            this.workingDaysCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workingDaysandHoursTableBindingSource, "WorkingDays", true));
            this.workingDaysCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingDaysCheckedListBox.FormattingEnabled = true;
            this.workingDaysCheckedListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.workingDaysCheckedListBox.Location = new System.Drawing.Point(216, 172);
            this.workingDaysCheckedListBox.Name = "workingDaysCheckedListBox";
            this.workingDaysCheckedListBox.Size = new System.Drawing.Size(211, 116);
            this.workingDaysCheckedListBox.TabIndex = 9;
            // 
            // workingTimePerDaysComboBox
            // 
            this.workingTimePerDaysComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workingDaysandHoursTableBindingSource, "WorkingTimePerDays", true));
            this.workingTimePerDaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingTimePerDaysComboBox.FormattingEnabled = true;
            this.workingTimePerDaysComboBox.Items.AddRange(new object[] {
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours"});
            this.workingTimePerDaysComboBox.Location = new System.Drawing.Point(216, 297);
            this.workingTimePerDaysComboBox.Name = "workingTimePerDaysComboBox";
            this.workingTimePerDaysComboBox.Size = new System.Drawing.Size(211, 23);
            this.workingTimePerDaysComboBox.TabIndex = 11;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workingDaysandHoursTableBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextBox.Location = new System.Drawing.Point(216, 59);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(211, 21);
            this.employeeIDTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Working Days and Hours";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(542, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 383);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(92, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(92, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workingDaysandHoursTableTableAdapter
            // 
            this.workingDaysandHoursTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddaSessionTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableTableAdapter = null;
            this.tableAdapterManager.LecturesDrtailsTableAdapter = null;
            this.tableAdapterManager.NonAvaiableTimesTableTableAdapter = null;
            this.tableAdapterManager.NonOverLappingTableTableAdapter = null;
            this.tableAdapterManager.NotAvailableTimesTableAdapter = null;
            this.tableAdapterManager.NotAvailabliTimesTableAdapter = null;
            this.tableAdapterManager.ParallelSessionTableTableAdapter = null;
            this.tableAdapterManager.ReservedHallArrangementTableTableAdapter = null;
            this.tableAdapterManager.RoomsTableTableAdapter = null;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.SubjectTableTableAdapter = null;
            this.tableAdapterManager.SuitableTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkingDaysandHoursTableTableAdapter = this.workingDaysandHoursTableTableAdapter;
            // 
            // workingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "workingDays";
            this.Text = " working days and hours";
            this.Load += new System.EventHandler(this.workingDays_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingDaysandHoursTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource workingDaysandHoursTableBindingSource;
        private ABC_databaseDataSetTableAdapters.WorkingDaysandHoursTableTableAdapter workingDaysandHoursTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox noOfWorkingDaysComboBox;
        private System.Windows.Forms.CheckedListBox workingDaysCheckedListBox;
        private System.Windows.Forms.ComboBox workingTimePerDaysComboBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
    }
}