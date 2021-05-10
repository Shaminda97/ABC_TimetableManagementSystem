
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
            System.Windows.Forms.Label room_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genarateTimetable));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lecturerTab = new System.Windows.Forms.TabPage();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.locationTab = new System.Windows.Forms.TabPage();
            this.roomsTableDataGridView = new System.Windows.Forms.DataGridView();
            this.room_NumberTextBox = new System.Windows.Forms.TextBox();
            this.searchRoomtextBox = new System.Windows.Forms.TextBox();
            this.searchRoombutton = new System.Windows.Forms.Button();
            this.roomsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.roomsTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.RoomsTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.selectRoomButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            room_NumberLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.locationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
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
            // locationTab
            // 
            this.locationTab.Controls.Add(this.selectRoomButton);
            this.locationTab.Controls.Add(this.searchRoombutton);
            this.locationTab.Controls.Add(this.searchRoomtextBox);
            this.locationTab.Controls.Add(room_NumberLabel);
            this.locationTab.Controls.Add(this.room_NumberTextBox);
            this.locationTab.Controls.Add(this.roomsTableDataGridView);
            this.locationTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTab.Location = new System.Drawing.Point(4, 25);
            this.locationTab.Name = "locationTab";
            this.locationTab.Padding = new System.Windows.Forms.Padding(3);
            this.locationTab.Size = new System.Drawing.Size(789, 382);
            this.locationTab.TabIndex = 2;
            this.locationTab.Text = "Location";
            this.locationTab.UseVisualStyleBackColor = true;
            // 
            // roomsTableDataGridView
            // 
            this.roomsTableDataGridView.AutoGenerateColumns = false;
            this.roomsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.roomsTableDataGridView.DataSource = this.roomsTableBindingSource;
            this.roomsTableDataGridView.Location = new System.Drawing.Point(15, 97);
            this.roomsTableDataGridView.Name = "roomsTableDataGridView";
            this.roomsTableDataGridView.Size = new System.Drawing.Size(285, 79);
            this.roomsTableDataGridView.TabIndex = 0;
            // 
            // room_NumberLabel
            // 
            room_NumberLabel.AutoSize = true;
            room_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            room_NumberLabel.Location = new System.Drawing.Point(16, 189);
            room_NumberLabel.Name = "room_NumberLabel";
            room_NumberLabel.Size = new System.Drawing.Size(116, 20);
            room_NumberLabel.TabIndex = 1;
            room_NumberLabel.Text = "Room Number:";
            // 
            // room_NumberTextBox
            // 
            this.room_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsTableBindingSource, "Room_Number", true));
            this.room_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_NumberTextBox.Location = new System.Drawing.Point(134, 186);
            this.room_NumberTextBox.Name = "room_NumberTextBox";
            this.room_NumberTextBox.ReadOnly = true;
            this.room_NumberTextBox.Size = new System.Drawing.Size(101, 26);
            this.room_NumberTextBox.TabIndex = 2;
            // 
            // searchRoomtextBox
            // 
            this.searchRoomtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRoomtextBox.Location = new System.Drawing.Point(15, 59);
            this.searchRoomtextBox.Name = "searchRoomtextBox";
            this.searchRoomtextBox.Size = new System.Drawing.Size(101, 26);
            this.searchRoomtextBox.TabIndex = 5;
            // 
            // searchRoombutton
            // 
            this.searchRoombutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRoombutton.Location = new System.Drawing.Point(137, 59);
            this.searchRoombutton.Name = "searchRoombutton";
            this.searchRoombutton.Size = new System.Drawing.Size(76, 31);
            this.searchRoombutton.TabIndex = 6;
            this.searchRoombutton.Text = "search";
            this.searchRoombutton.UseVisualStyleBackColor = true;
            this.searchRoombutton.Click += new System.EventHandler(this.searchRoombutton_Click);
            // 
            // roomsTableBindingSource
            // 
            this.roomsTableBindingSource.DataMember = "RoomsTable";
            this.roomsTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.LecturesDrtailsTableAdapter = null;
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
            // selectRoomButton
            // 
            this.selectRoomButton.BackColor = System.Drawing.Color.LimeGreen;
            this.selectRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoomButton.ForeColor = System.Drawing.SystemColors.Control;
            this.selectRoomButton.Location = new System.Drawing.Point(20, 244);
            this.selectRoomButton.Name = "selectRoomButton";
            this.selectRoomButton.Size = new System.Drawing.Size(213, 31);
            this.selectRoomButton.TabIndex = 7;
            this.selectRoomButton.Text = "Select Room";
            this.selectRoomButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Room_Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room_Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RoomType";
            this.dataGridViewTextBoxColumn4.HeaderText = "RoomType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            this.locationTab.ResumeLayout(false);
            this.locationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lecturerTab;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.TabPage locationTab;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource roomsTableBindingSource;
        private ABC_databaseDataSetTableAdapters.RoomsTableTableAdapter roomsTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox room_NumberTextBox;
        private System.Windows.Forms.DataGridView roomsTableDataGridView;
        private System.Windows.Forms.Button searchRoombutton;
        private System.Windows.Forms.TextBox searchRoomtextBox;
        private System.Windows.Forms.Button selectRoomButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}