
namespace ABC_TimetableManagementSystem.GenarateTimetable
{
    partial class genarateTimetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genarateTimetable));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lecturerTab = new System.Windows.Forms.TabPage();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.suitableTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.roomsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.RoomsTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.suitableTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.SuitableTableTableAdapter();
            this.suitableTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchRoom = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.locationTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableDataGridView)).BeginInit();
            this.locationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lecturerTab);
            this.tabControl1.Controls.Add(this.studentTab);
            this.tabControl1.Controls.Add(this.locationTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // lecturerTab
            // 
            this.lecturerTab.Location = new System.Drawing.Point(4, 25);
            this.lecturerTab.Name = "lecturerTab";
            this.lecturerTab.Padding = new System.Windows.Forms.Padding(3);
            this.lecturerTab.Size = new System.Drawing.Size(789, 382);
            this.lecturerTab.TabIndex = 0;
            this.lecturerTab.Text = "Lecturer";
            this.lecturerTab.UseVisualStyleBackColor = true;
            // 
            // studentTab
            // 
            this.studentTab.Location = new System.Drawing.Point(4, 25);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentTab.Size = new System.Drawing.Size(789, 382);
            this.studentTab.TabIndex = 1;
            this.studentTab.Text = "Student";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(38, 39);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Time tables";
            // 
            // suitableTableBindingSource
            // 
            this.suitableTableBindingSource.DataMember = "SuitableTable";
            this.suitableTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableBindingSource
            // 
            this.roomsTableBindingSource.DataMember = "RoomsTable";
            this.roomsTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // roomsTableTableAdapter
            // 
            this.roomsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddaSessionTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableTableAdapter = null;
            this.tableAdapterManager.LecturesDetailsTableAdapter = null;
            this.tableAdapterManager.ManageSessionTableTableAdapter = null;
            this.tableAdapterManager.NonAvaiableTimesTableTableAdapter = null;
            this.tableAdapterManager.NonOverLappingTableTableAdapter = null;
            this.tableAdapterManager.NotAvailableTimesTableAdapter = null;
            this.tableAdapterManager.NotAvailabliTimesTableAdapter = null;
            this.tableAdapterManager.ParallelSessionTableTableAdapter = null;
            this.tableAdapterManager.ReservedHallArrangementTableTableAdapter = null;
            this.tableAdapterManager.RoomsTableTableAdapter = this.roomsTableTableAdapter;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.SubjectTableTableAdapter = null;
            this.tableAdapterManager.SuitableTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkingDaysandHoursTableTableAdapter = null;
            // 
            // suitableTableTableAdapter
            // 
            this.suitableTableTableAdapter.ClearBeforeFill = true;
            // 
            // suitableTableDataGridView
            // 
            this.suitableTableDataGridView.AutoGenerateColumns = false;
            this.suitableTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suitableTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.suitableTableDataGridView.DataSource = this.suitableTableBindingSource;
            this.suitableTableDataGridView.Location = new System.Drawing.Point(129, 118);
            this.suitableTableDataGridView.Name = "suitableTableDataGridView";
            this.suitableTableDataGridView.ReadOnly = true;
            this.suitableTableDataGridView.Size = new System.Drawing.Size(468, 136);
            this.suitableTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GroupID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GroupID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SuitableRoom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Room number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booked Lecture hall / Labs";
            // 
            // textBoxSearchRoom
            // 
            this.textBoxSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchRoom.Location = new System.Drawing.Point(223, 77);
            this.textBoxSearchRoom.Name = "textBoxSearchRoom";
            this.textBoxSearchRoom.Size = new System.Drawing.Size(120, 31);
            this.textBoxSearchRoom.TabIndex = 2;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(362, 76);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(95, 35);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // locationTab
            // 
            this.locationTab.AutoScroll = true;
            this.locationTab.Controls.Add(this.Searchbutton);
            this.locationTab.Controls.Add(this.textBoxSearchRoom);
            this.locationTab.Controls.Add(this.label2);
            this.locationTab.Controls.Add(this.suitableTableDataGridView);
            this.locationTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTab.Location = new System.Drawing.Point(4, 25);
            this.locationTab.Name = "locationTab";
            this.locationTab.Padding = new System.Windows.Forms.Padding(3);
            this.locationTab.Size = new System.Drawing.Size(789, 382);
            this.locationTab.TabIndex = 2;
            this.locationTab.Text = "Location";
            this.locationTab.UseVisualStyleBackColor = true;
            // 
            // genarateTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControl1);
            this.Name = "genarateTimetable";
            this.Text = "genarateTimetable";
            this.Load += new System.EventHandler(this.genarateTimetable_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableDataGridView)).EndInit();
            this.locationTab.ResumeLayout(false);
            this.locationTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lecturerTab;
        private System.Windows.Forms.TabPage studentTab;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource roomsTableBindingSource;
        private ABC_databaseDataSetTableAdapters.RoomsTableTableAdapter roomsTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource suitableTableBindingSource;
        private ABC_databaseDataSetTableAdapters.SuitableTableTableAdapter suitableTableTableAdapter;
        private System.Windows.Forms.TabPage locationTab;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox textBoxSearchRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView suitableTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}