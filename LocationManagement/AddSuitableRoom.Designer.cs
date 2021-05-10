
namespace ABC_TimetableManagementSystem.LocationManagement
{
    partial class addSuitableRoom
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
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label suitableRoomLabel;
            System.Windows.Forms.Label groupIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSuitableRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.suitableTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suitableTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.SuitableTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.suitableRoomTextBox = new System.Windows.Forms.TextBox();
            this.groupIDTextBox = new System.Windows.Forms.TextBox();
            this.suitableTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagComboBox = new System.Windows.Forms.ComboBox();
            subjectLabel = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            suitableRoomLabel = new System.Windows.Forms.Label();
            groupIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectLabel.Location = new System.Drawing.Point(35, 113);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(67, 20);
            subjectLabel.TabIndex = 22;
            subjectLabel.Text = "Subject:";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagLabel.Location = new System.Drawing.Point(39, 168);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(40, 20);
            tagLabel.TabIndex = 24;
            tagLabel.Text = "Tag:";
            // 
            // suitableRoomLabel
            // 
            suitableRoomLabel.AutoSize = true;
            suitableRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            suitableRoomLabel.Location = new System.Drawing.Point(39, 227);
            suitableRoomLabel.Name = "suitableRoomLabel";
            suitableRoomLabel.Size = new System.Drawing.Size(118, 20);
            suitableRoomLabel.TabIndex = 26;
            suitableRoomLabel.Text = "Suitable Room:";
            // 
            // groupIDLabel
            // 
            groupIDLabel.AutoSize = true;
            groupIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupIDLabel.Location = new System.Drawing.Point(39, 281);
            groupIDLabel.Name = "groupIDLabel";
            groupIDLabel.Size = new System.Drawing.Size(79, 20);
            groupIDLabel.TabIndex = 28;
            groupIDLabel.Text = "Group ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new Suitable lecturehall / Lab";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Location = new System.Drawing.Point(28, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Lavender;
            this.btnDelete.Location = new System.Drawing.Point(120, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Lavender;
            this.btnAdd.Location = new System.Drawing.Point(43, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subject:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(501, 85);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(137, 26);
            this.textBoxSearch.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(649, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(750, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 34);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Select Suitable lecturehall / Lab";
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suitableTableBindingSource
            // 
            this.suitableTableBindingSource.DataMember = "SuitableTable";
            this.suitableTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // suitableTableTableAdapter
            // 
            this.suitableTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableTableAdapter = null;
            this.tableAdapterManager.RoomsTableTableAdapter = null;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.SubjectTableTableAdapter = null;
            this.tableAdapterManager.SuitableTableTableAdapter = this.suitableTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suitableTableBindingSource, "Subject", true));
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextBox.Location = new System.Drawing.Point(39, 135);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(157, 26);
            this.subjectTextBox.TabIndex = 23;
            // 
            // suitableRoomTextBox
            // 
            this.suitableRoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suitableTableBindingSource, "SuitableRoom", true));
            this.suitableRoomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitableRoomTextBox.Location = new System.Drawing.Point(43, 252);
            this.suitableRoomTextBox.Name = "suitableRoomTextBox";
            this.suitableRoomTextBox.Size = new System.Drawing.Size(153, 26);
            this.suitableRoomTextBox.TabIndex = 27;
            // 
            // groupIDTextBox
            // 
            this.groupIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suitableTableBindingSource, "GroupID", true));
            this.groupIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIDTextBox.Location = new System.Drawing.Point(43, 304);
            this.groupIDTextBox.Name = "groupIDTextBox";
            this.groupIDTextBox.Size = new System.Drawing.Size(153, 26);
            this.groupIDTextBox.TabIndex = 29;
            // 
            // suitableTableDataGridView
            // 
            this.suitableTableDataGridView.AutoGenerateColumns = false;
            this.suitableTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suitableTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.suitableTableDataGridView.DataSource = this.suitableTableBindingSource;
            this.suitableTableDataGridView.Location = new System.Drawing.Point(241, 125);
            this.suitableTableDataGridView.Name = "suitableTableDataGridView";
            this.suitableTableDataGridView.Size = new System.Drawing.Size(544, 279);
            this.suitableTableDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SuitableRoom";
            this.dataGridViewTextBoxColumn4.HeaderText = "SuitableRoom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GroupID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GroupID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tagComboBox
            // 
            this.tagComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suitableTableBindingSource, "Tag", true));
            this.tagComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagComboBox.FormattingEnabled = true;
            this.tagComboBox.Items.AddRange(new object[] {
            "Lab",
            "Lecture"});
            this.tagComboBox.Location = new System.Drawing.Point(43, 196);
            this.tagComboBox.Name = "tagComboBox";
            this.tagComboBox.Size = new System.Drawing.Size(121, 28);
            this.tagComboBox.TabIndex = 30;
            // 
            // addSuitableRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Controls.Add(this.tagComboBox);
            this.Controls.Add(this.suitableTableDataGridView);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(tagLabel);
            this.Controls.Add(suitableRoomLabel);
            this.Controls.Add(this.suitableRoomTextBox);
            this.Controls.Add(groupIDLabel);
            this.Controls.Add(this.groupIDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Name = "addSuitableRoom";
            this.Text = "AddSuitableRoom";
            this.Load += new System.EventHandler(this.addSuitableRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource suitableTableBindingSource;
        private ABC_databaseDataSetTableAdapters.SuitableTableTableAdapter suitableTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox suitableRoomTextBox;
        private System.Windows.Forms.TextBox groupIDTextBox;
        private System.Windows.Forms.DataGridView suitableTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox tagComboBox;
    }
}