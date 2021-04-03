
namespace ABC_TimetableManagementSystem.LocationManagement
{
    partial class locationManagement
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label building_NameLabel;
            System.Windows.Forms.Label room_NumberLabel;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label roomTypeLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locationManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.roomsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.building_NameTextBox = new System.Windows.Forms.TextBox();
            this.room_NumberTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.roomsTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.RoomsTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            building_NameLabel = new System.Windows.Forms.Label();
            room_NumberLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            roomTypeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(18, 88);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 21;
            idLabel.Text = "Id:";
            // 
            // building_NameLabel
            // 
            building_NameLabel.AutoSize = true;
            building_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            building_NameLabel.Location = new System.Drawing.Point(18, 117);
            building_NameLabel.Name = "building_NameLabel";
            building_NameLabel.Size = new System.Drawing.Size(115, 20);
            building_NameLabel.TabIndex = 23;
            building_NameLabel.Text = "Building Name:";
            // 
            // room_NumberLabel
            // 
            room_NumberLabel.AutoSize = true;
            room_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            room_NumberLabel.Location = new System.Drawing.Point(18, 169);
            room_NumberLabel.Name = "room_NumberLabel";
            room_NumberLabel.Size = new System.Drawing.Size(116, 20);
            room_NumberLabel.TabIndex = 25;
            room_NumberLabel.Text = "Room Number:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capacityLabel.Location = new System.Drawing.Point(20, 297);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(74, 20);
            capacityLabel.TabIndex = 29;
            capacityLabel.Text = "Capacity:";
            // 
            // roomTypeLabel1
            // 
            roomTypeLabel1.AutoSize = true;
            roomTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomTypeLabel1.Location = new System.Drawing.Point(20, 230);
            roomTypeLabel1.Name = "roomTypeLabel1";
            roomTypeLabel1.Size = new System.Drawing.Size(94, 20);
            roomTypeLabel1.TabIndex = 30;
            roomTypeLabel1.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new Lecture hall/ Lab";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(16, 374);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 29);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(109, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 29);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(22, 409);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 29);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Registerd Lectue halls / Labs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search Room";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(531, 94);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(119, 26);
            this.textBoxSearch.TabIndex = 16;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(656, 94);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(38, 28);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(749, 91);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(28, 31);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(1, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(33, 34);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsTableBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(51, 85);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(52, 26);
            this.idTextBox.TabIndex = 22;
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
            // building_NameTextBox
            // 
            this.building_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsTableBindingSource, "Building_Name", true));
            this.building_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.building_NameTextBox.Location = new System.Drawing.Point(21, 140);
            this.building_NameTextBox.Name = "building_NameTextBox";
            this.building_NameTextBox.Size = new System.Drawing.Size(172, 26);
            this.building_NameTextBox.TabIndex = 24;
            // 
            // room_NumberTextBox
            // 
            this.room_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsTableBindingSource, "Room_Number", true));
            this.room_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_NumberTextBox.Location = new System.Drawing.Point(21, 192);
            this.room_NumberTextBox.Name = "room_NumberTextBox";
            this.room_NumberTextBox.Size = new System.Drawing.Size(172, 26);
            this.room_NumberTextBox.TabIndex = 26;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsTableBindingSource, "Capacity", true));
            this.capacityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTextBox.Location = new System.Drawing.Point(22, 321);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 26);
            this.capacityTextBox.TabIndex = 30;
            // 
            // roomsTableDataGridView
            // 
            this.roomsTableDataGridView.AutoGenerateColumns = false;
            this.roomsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.roomsTableDataGridView.DataSource = this.roomsTableBindingSource;
            this.roomsTableDataGridView.Location = new System.Drawing.Point(235, 128);
            this.roomsTableDataGridView.Name = "roomsTableDataGridView";
            this.roomsTableDataGridView.Size = new System.Drawing.Size(542, 310);
            this.roomsTableDataGridView.TabIndex = 30;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Building_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Building_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Room_Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room_Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RoomType";
            this.dataGridViewTextBoxColumn4.HeaderText = "RoomType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // roomsTableTableAdapter
            // 
            this.roomsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoomsTableTableAdapter = this.roomsTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsTableBindingSource, "RoomType", true));
            this.roomTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Lecture Hall",
            "Lab"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(16, 253);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.roomTypeComboBox.TabIndex = 31;
            // 
            // locationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(roomTypeLabel1);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.roomsTableDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(building_NameLabel);
            this.Controls.Add(this.building_NameTextBox);
            this.Controls.Add(room_NumberLabel);
            this.Controls.Add(this.room_NumberTextBox);
            this.Controls.Add(capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Name = "locationManagement";
            this.Text = "locationManagement";
            this.Load += new System.EventHandler(this.locationManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource roomsTableBindingSource;
        private ABC_databaseDataSetTableAdapters.RoomsTableTableAdapter roomsTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox building_NameTextBox;
        private System.Windows.Forms.TextBox room_NumberTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.DataGridView roomsTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
    }
}