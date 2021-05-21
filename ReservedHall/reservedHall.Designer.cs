
namespace ABC_TimetableManagementSystem.ReservedHall
{
    partial class reservedHall
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
            System.Windows.Forms.Label hallNoLabel;
            System.Windows.Forms.Label selectDayLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservedHall));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hallNoTextBox = new System.Windows.Forms.TextBox();
            this.reservedHallArrangementTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.selectDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reservedHallArrangementTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reservedHallArrangementTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.ReservedHallArrangementTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            hallNoLabel = new System.Windows.Forms.Label();
            selectDayLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservedHallArrangementTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservedHallArrangementTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hallNoLabel
            // 
            hallNoLabel.AutoSize = true;
            hallNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hallNoLabel.Location = new System.Drawing.Point(13, 75);
            hallNoLabel.Name = "hallNoLabel";
            hallNoLabel.Size = new System.Drawing.Size(63, 15);
            hallNoLabel.TabIndex = 12;
            hallNoLabel.Text = "Hall No :";
            // 
            // selectDayLabel
            // 
            selectDayLabel.AutoSize = true;
            selectDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            selectDayLabel.Location = new System.Drawing.Point(13, 133);
            selectDayLabel.Name = "selectDayLabel";
            selectDayLabel.Size = new System.Drawing.Size(83, 15);
            selectDayLabel.TabIndex = 14;
            selectDayLabel.Text = "Select Day :";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startTimeLabel.Location = new System.Drawing.Point(13, 189);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(81, 15);
            startTimeLabel.TabIndex = 16;
            startTimeLabel.Text = "Start Time :";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.Location = new System.Drawing.Point(13, 252);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(76, 15);
            endTimeLabel.TabIndex = 18;
            endTimeLabel.Text = "End Time :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 91);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(28, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(46, 40);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(324, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timetable Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(370, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institute";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(hallNoLabel);
            this.panel2.Controls.Add(this.hallNoTextBox);
            this.panel2.Controls.Add(selectDayLabel);
            this.panel2.Controls.Add(this.selectDayDateTimePicker);
            this.panel2.Controls.Add(startTimeLabel);
            this.panel2.Controls.Add(this.startTimeTextBox);
            this.panel2.Controls.Add(endTimeLabel);
            this.panel2.Controls.Add(this.endTimeTextBox);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 387);
            this.panel2.TabIndex = 2;
            // 
            // hallNoTextBox
            // 
            this.hallNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservedHallArrangementTableBindingSource, "HallNo", true));
            this.hallNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallNoTextBox.Location = new System.Drawing.Point(156, 75);
            this.hallNoTextBox.Name = "hallNoTextBox";
            this.hallNoTextBox.Size = new System.Drawing.Size(222, 21);
            this.hallNoTextBox.TabIndex = 13;
            // 
            // reservedHallArrangementTableBindingSource
            // 
            this.reservedHallArrangementTableBindingSource.DataMember = "ReservedHallArrangementTable";
            this.reservedHallArrangementTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDayDateTimePicker
            // 
            this.selectDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservedHallArrangementTableBindingSource, "SelectDay", true));
            this.selectDayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDayDateTimePicker.Location = new System.Drawing.Point(156, 133);
            this.selectDayDateTimePicker.Name = "selectDayDateTimePicker";
            this.selectDayDateTimePicker.Size = new System.Drawing.Size(222, 21);
            this.selectDayDateTimePicker.TabIndex = 15;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservedHallArrangementTableBindingSource, "StartTime", true));
            this.startTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeTextBox.Location = new System.Drawing.Point(156, 189);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(222, 21);
            this.startTimeTextBox.TabIndex = 17;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservedHallArrangementTableBindingSource, "EndTime", true));
            this.endTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeTextBox.Location = new System.Drawing.Point(156, 249);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(222, 21);
            this.endTimeTextBox.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(269, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Session";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Reserved Hall Arrangments";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.reservedHallArrangementTableDataGridView);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(467, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 387);
            this.panel3.TabIndex = 3;
            // 
            // reservedHallArrangementTableDataGridView
            // 
            this.reservedHallArrangementTableDataGridView.AutoGenerateColumns = false;
            this.reservedHallArrangementTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservedHallArrangementTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservedHallArrangementTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.reservedHallArrangementTableDataGridView.DataSource = this.reservedHallArrangementTableBindingSource;
            this.reservedHallArrangementTableDataGridView.Location = new System.Drawing.Point(19, 75);
            this.reservedHallArrangementTableDataGridView.Name = "reservedHallArrangementTableDataGridView";
            this.reservedHallArrangementTableDataGridView.Size = new System.Drawing.Size(473, 220);
            this.reservedHallArrangementTableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HallNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "HallNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SelectDay";
            this.dataGridViewTextBoxColumn3.HeaderText = "SelectDay";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(293, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(113, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 47);
            this.button3.TabIndex = 0;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reservedHallArrangementTableTableAdapter
            // 
            this.reservedHallArrangementTableTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ReservedHallArrangementTableTableAdapter = this.reservedHallArrangementTableTableAdapter;
            this.tableAdapterManager.RoomsTableTableAdapter = null;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.SubjectTableTableAdapter = null;
            this.tableAdapterManager.SuitableTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkingDaysandHoursTableTableAdapter = null;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(347, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(38, 28);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(222, 39);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(119, 26);
            this.textBoxSearch.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Search Hall No :";
            // 
            // reservedHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "reservedHall";
            this.Text = "reservedHall";
            this.Load += new System.EventHandler(this.reservedHall_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservedHallArrangementTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservedHallArrangementTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBack;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource reservedHallArrangementTableBindingSource;
        private ABC_databaseDataSetTableAdapters.ReservedHallArrangementTableTableAdapter reservedHallArrangementTableTableAdapter;
        private System.Windows.Forms.TextBox hallNoTextBox;
        private System.Windows.Forms.DateTimePicker selectDayDateTimePicker;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView reservedHallArrangementTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
    }
}