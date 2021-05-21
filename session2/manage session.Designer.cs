
namespace ABC_TimetableManagementSystem
{
    partial class manage_session
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
            System.Windows.Forms.Label lecture1Label;
            System.Windows.Forms.Label lecture2Label;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label groupIDLabel;
            System.Windows.Forms.Label noOfStudentsLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label durationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_session));
            this.aBC_databaseDataSet1 = new ABC_TimetableManagementSystem.ABC_databaseDataSet1();
            this.manageSessionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageSessionTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSet1TableAdapters.ManageSessionTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSet1TableAdapters.TableAdapterManager();
            this.manageSessionTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manageSessionTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manageSessionTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lecture1ComboBox = new System.Windows.Forms.ComboBox();
            this.lecture2ComboBox = new System.Windows.Forms.ComboBox();
            this.tagComboBox = new System.Windows.Forms.ComboBox();
            this.groupIDComboBox = new System.Windows.Forms.ComboBox();
            this.noOfStudentsTextBox = new System.Windows.Forms.TextBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            lecture1Label = new System.Windows.Forms.Label();
            lecture2Label = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            groupIDLabel = new System.Windows.Forms.Label();
            noOfStudentsLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionTableBindingNavigator)).BeginInit();
            this.manageSessionTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(79, 100);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(24, 16);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // lecture1Label
            // 
            lecture1Label.AutoSize = true;
            lecture1Label.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lecture1Label.Location = new System.Drawing.Point(79, 143);
            lecture1Label.Name = "lecture1Label";
            lecture1Label.Size = new System.Drawing.Size(64, 16);
            lecture1Label.TabIndex = 4;
            lecture1Label.Text = "Lecture1:";
            // 
            // lecture2Label
            // 
            lecture2Label.AutoSize = true;
            lecture2Label.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lecture2Label.Location = new System.Drawing.Point(79, 185);
            lecture2Label.Name = "lecture2Label";
            lecture2Label.Size = new System.Drawing.Size(64, 16);
            lecture2Label.TabIndex = 6;
            lecture2Label.Text = "Lecture2:";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagLabel.Location = new System.Drawing.Point(79, 226);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(35, 16);
            tagLabel.TabIndex = 8;
            tagLabel.Text = "Tag:";
            // 
            // groupIDLabel
            // 
            groupIDLabel.AutoSize = true;
            groupIDLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupIDLabel.Location = new System.Drawing.Point(479, 100);
            groupIDLabel.Name = "groupIDLabel";
            groupIDLabel.Size = new System.Drawing.Size(68, 16);
            groupIDLabel.TabIndex = 10;
            groupIDLabel.Text = "Group ID:";
            // 
            // noOfStudentsLabel
            // 
            noOfStudentsLabel.AutoSize = true;
            noOfStudentsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noOfStudentsLabel.Location = new System.Drawing.Point(479, 143);
            noOfStudentsLabel.Name = "noOfStudentsLabel";
            noOfStudentsLabel.Size = new System.Drawing.Size(107, 16);
            noOfStudentsLabel.TabIndex = 12;
            noOfStudentsLabel.Text = "No Of Students:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectLabel.Location = new System.Drawing.Point(479, 185);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(57, 16);
            subjectLabel.TabIndex = 14;
            subjectLabel.Text = "Subject:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            durationLabel.Location = new System.Drawing.Point(479, 226);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(67, 16);
            durationLabel.TabIndex = 16;
            durationLabel.Text = "Duration:";
            // 
            // aBC_databaseDataSet1
            // 
            this.aBC_databaseDataSet1.DataSetName = "ABC_databaseDataSet1";
            this.aBC_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageSessionTableBindingSource
            // 
            this.manageSessionTableBindingSource.DataMember = "ManageSessionTable";
            this.manageSessionTableBindingSource.DataSource = this.aBC_databaseDataSet1;
            // 
            // manageSessionTableTableAdapter
            // 
            this.manageSessionTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddaSessionTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableTableAdapter = null;
            this.tableAdapterManager.LecturesDetailsTableAdapter = null;
            this.tableAdapterManager.ManageSessionTableTableAdapter = this.manageSessionTableTableAdapter;
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
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkingDaysandHoursTableTableAdapter = null;
            // 
            // manageSessionTableBindingNavigator
            // 
            this.manageSessionTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manageSessionTableBindingNavigator.BindingSource = this.manageSessionTableBindingSource;
            this.manageSessionTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manageSessionTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manageSessionTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.manageSessionTableBindingNavigatorSaveItem});
            this.manageSessionTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manageSessionTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manageSessionTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manageSessionTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manageSessionTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manageSessionTableBindingNavigator.Name = "manageSessionTableBindingNavigator";
            this.manageSessionTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manageSessionTableBindingNavigator.Size = new System.Drawing.Size(1028, 25);
            this.manageSessionTableBindingNavigator.TabIndex = 0;
            this.manageSessionTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // manageSessionTableBindingNavigatorSaveItem
            // 
            this.manageSessionTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageSessionTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manageSessionTableBindingNavigatorSaveItem.Image")));
            this.manageSessionTableBindingNavigatorSaveItem.Name = "manageSessionTableBindingNavigatorSaveItem";
            this.manageSessionTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.manageSessionTableBindingNavigatorSaveItem.Text = "Save Data";
            this.manageSessionTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.manageSessionTableBindingNavigatorSaveItem_Click);
            // 
            // manageSessionTableDataGridView
            // 
            this.manageSessionTableDataGridView.AutoGenerateColumns = false;
            this.manageSessionTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageSessionTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.manageSessionTableDataGridView.DataSource = this.manageSessionTableBindingSource;
            this.manageSessionTableDataGridView.Location = new System.Drawing.Point(125, 335);
            this.manageSessionTableDataGridView.Name = "manageSessionTableDataGridView";
            this.manageSessionTableDataGridView.Size = new System.Drawing.Size(843, 220);
            this.manageSessionTableDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lecture1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Lecture1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lecture2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lecture2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GroupID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GroupID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoOfStudents";
            this.dataGridViewTextBoxColumn6.HeaderText = "NoOfStudents";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn7.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn8.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(219, 92);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 24);
            this.idTextBox.TabIndex = 3;
            // 
            // lecture1ComboBox
            // 
            this.lecture1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "Lecture1", true));
            this.lecture1ComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture1ComboBox.FormattingEnabled = true;
            this.lecture1ComboBox.Items.AddRange(new object[] {
            "Dr.Saman Kodagoda",
            "Dr.Nimal jayathilaka",
            "Dr.Erandaga Rathnayaka",
            "Dr.Nimal Aberathna",
            "Dr.Amila Sadaruwan"});
            this.lecture1ComboBox.Location = new System.Drawing.Point(219, 135);
            this.lecture1ComboBox.Name = "lecture1ComboBox";
            this.lecture1ComboBox.Size = new System.Drawing.Size(121, 24);
            this.lecture1ComboBox.TabIndex = 5;
            // 
            // lecture2ComboBox
            // 
            this.lecture2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "Lecture2", true));
            this.lecture2ComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture2ComboBox.FormattingEnabled = true;
            this.lecture2ComboBox.Items.AddRange(new object[] {
            "Mr. Senura Diwantha",
            "Ms.Kavindi Jayathilaka",
            "Ms.Saduni Aberathna",
            "Mr.Amila Sadaruwan"});
            this.lecture2ComboBox.Location = new System.Drawing.Point(219, 177);
            this.lecture2ComboBox.Name = "lecture2ComboBox";
            this.lecture2ComboBox.Size = new System.Drawing.Size(121, 24);
            this.lecture2ComboBox.TabIndex = 7;
            // 
            // tagComboBox
            // 
            this.tagComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "Tag", true));
            this.tagComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagComboBox.FormattingEnabled = true;
            this.tagComboBox.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.tagComboBox.Location = new System.Drawing.Point(219, 218);
            this.tagComboBox.Name = "tagComboBox";
            this.tagComboBox.Size = new System.Drawing.Size(121, 24);
            this.tagComboBox.TabIndex = 9;
            // 
            // groupIDComboBox
            // 
            this.groupIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "GroupID", true));
            this.groupIDComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIDComboBox.FormattingEnabled = true;
            this.groupIDComboBox.Items.AddRange(new object[] {
            "Y1.S1.IT.01",
            "Y1.S1.IT.02",
            "Y1.S1.IT.03",
            "Y1.S1.IT.04",
            "Y1.S1.IT.05",
            "Y1.S1.IT.06",
            "Y1.S1.IT.07",
            "Y1.S1.IT.08",
            "Y1.S1.IT.09",
            "Y1.S1.IT.10"});
            this.groupIDComboBox.Location = new System.Drawing.Point(679, 92);
            this.groupIDComboBox.Name = "groupIDComboBox";
            this.groupIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.groupIDComboBox.TabIndex = 11;
            // 
            // noOfStudentsTextBox
            // 
            this.noOfStudentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "NoOfStudents", true));
            this.noOfStudentsTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfStudentsTextBox.Location = new System.Drawing.Point(679, 135);
            this.noOfStudentsTextBox.Name = "noOfStudentsTextBox";
            this.noOfStudentsTextBox.Size = new System.Drawing.Size(121, 24);
            this.noOfStudentsTextBox.TabIndex = 13;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "Subject", true));
            this.subjectComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Items.AddRange(new object[] {
            "OOC",
            "MC",
            "IWT",
            "ITPM",
            "EAP",
            "CS"});
            this.subjectComboBox.Location = new System.Drawing.Point(679, 177);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(121, 24);
            this.subjectComboBox.TabIndex = 15;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageSessionTableBindingSource, "Duration", true));
            this.durationTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTextBox.Location = new System.Drawing.Point(679, 218);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(121, 24);
            this.durationTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search by Lecture name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_TimetableManagementSystem.Properties.Resources.WhatsApp_Image_2021_03_28_at_14_27_27;
            this.pictureBox1.Location = new System.Drawing.Point(866, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(753, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ABC_TimetableManagementSystem.Properties.Resources.WhatsApp_Image_2021_03_28_at_14_27_27__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manage Session";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(900, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = " ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(900, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 39);
            this.button3.TabIndex = 25;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(902, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 26;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // manage_session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 589);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(lecture1Label);
            this.Controls.Add(this.lecture1ComboBox);
            this.Controls.Add(lecture2Label);
            this.Controls.Add(this.lecture2ComboBox);
            this.Controls.Add(tagLabel);
            this.Controls.Add(this.tagComboBox);
            this.Controls.Add(groupIDLabel);
            this.Controls.Add(this.groupIDComboBox);
            this.Controls.Add(noOfStudentsLabel);
            this.Controls.Add(this.noOfStudentsTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.manageSessionTableDataGridView);
            this.Controls.Add(this.manageSessionTableBindingNavigator);
            this.Name = "manage_session";
            this.Text = "manage_session";
            this.Load += new System.EventHandler(this.manage_session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionTableBindingNavigator)).EndInit();
            this.manageSessionTableBindingNavigator.ResumeLayout(false);
            this.manageSessionTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ABC_databaseDataSet1 aBC_databaseDataSet1;
        private System.Windows.Forms.BindingSource manageSessionTableBindingSource;
        private ABC_databaseDataSet1TableAdapters.ManageSessionTableTableAdapter manageSessionTableTableAdapter;
        private ABC_databaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manageSessionTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton manageSessionTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView manageSessionTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox lecture1ComboBox;
        private System.Windows.Forms.ComboBox lecture2ComboBox;
        private System.Windows.Forms.ComboBox tagComboBox;
        private System.Windows.Forms.ComboBox groupIDComboBox;
        private System.Windows.Forms.TextBox noOfStudentsTextBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}