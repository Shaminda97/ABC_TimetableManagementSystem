
namespace ABC_TimetableManagementSystem
{
    partial class Form2
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
            System.Windows.Forms.Label acadamic_Year___SemLabel;
            System.Windows.Forms.Label programmeLabel;
            System.Windows.Forms.Label group_NoLabel;
            System.Windows.Forms.Label group_IDLabel;
            System.Windows.Forms.Label subGroupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.StudentTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.acadamic_Year___SemNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.programmeTextBox = new System.Windows.Forms.TextBox();
            this.group_NoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.group_IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.subGroupNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            acadamic_Year___SemLabel = new System.Windows.Forms.Label();
            programmeLabel = new System.Windows.Forms.Label();
            group_NoLabel = new System.Windows.Forms.Label();
            group_IDLabel = new System.Windows.Forms.Label();
            subGroupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acadamic_Year___SemNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_NoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subGroupNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableTableAdapter = null;
            this.tableAdapterManager.RoomsTableTableAdapter = null;
            this.tableAdapterManager.StudentTableTableAdapter = this.studentTableTableAdapter;
            this.tableAdapterManager.SubjectTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(244, 139);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(393, 136);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(243, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // acadamic_Year___SemLabel
            // 
            acadamic_Year___SemLabel.AutoSize = true;
            acadamic_Year___SemLabel.Location = new System.Drawing.Point(244, 164);
            acadamic_Year___SemLabel.Name = "acadamic_Year___SemLabel";
            acadamic_Year___SemLabel.Size = new System.Drawing.Size(143, 17);
            acadamic_Year___SemLabel.TabIndex = 3;
            acadamic_Year___SemLabel.Text = "Acadamic Year & Sem:";
            // 
            // acadamic_Year___SemNumericUpDown
            // 
            this.acadamic_Year___SemNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentTableBindingSource, "Acadamic Year & Sem", true));
            this.acadamic_Year___SemNumericUpDown.Location = new System.Drawing.Point(393, 164);
            this.acadamic_Year___SemNumericUpDown.Name = "acadamic_Year___SemNumericUpDown";
            this.acadamic_Year___SemNumericUpDown.Size = new System.Drawing.Size(243, 22);
            this.acadamic_Year___SemNumericUpDown.TabIndex = 4;
            // 
            // programmeLabel
            // 
            programmeLabel.AutoSize = true;
            programmeLabel.Location = new System.Drawing.Point(244, 195);
            programmeLabel.Name = "programmeLabel";
            programmeLabel.Size = new System.Drawing.Size(84, 17);
            programmeLabel.TabIndex = 5;
            programmeLabel.Text = "programme:";
            // 
            // programmeTextBox
            // 
            this.programmeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "programme", true));
            this.programmeTextBox.Location = new System.Drawing.Point(393, 192);
            this.programmeTextBox.Name = "programmeTextBox";
            this.programmeTextBox.Size = new System.Drawing.Size(243, 22);
            this.programmeTextBox.TabIndex = 6;
            // 
            // group_NoLabel
            // 
            group_NoLabel.AutoSize = true;
            group_NoLabel.Location = new System.Drawing.Point(244, 220);
            group_NoLabel.Name = "group_NoLabel";
            group_NoLabel.Size = new System.Drawing.Size(74, 17);
            group_NoLabel.TabIndex = 7;
            group_NoLabel.Text = "Group No:";
            // 
            // group_NoNumericUpDown
            // 
            this.group_NoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentTableBindingSource, "Group No", true));
            this.group_NoNumericUpDown.Location = new System.Drawing.Point(393, 220);
            this.group_NoNumericUpDown.Name = "group_NoNumericUpDown";
            this.group_NoNumericUpDown.Size = new System.Drawing.Size(243, 22);
            this.group_NoNumericUpDown.TabIndex = 8;
            // 
            // group_IDLabel
            // 
            group_IDLabel.AutoSize = true;
            group_IDLabel.Location = new System.Drawing.Point(244, 248);
            group_IDLabel.Name = "group_IDLabel";
            group_IDLabel.Size = new System.Drawing.Size(69, 17);
            group_IDLabel.TabIndex = 9;
            group_IDLabel.Text = "Group ID:";
            // 
            // group_IDNumericUpDown
            // 
            this.group_IDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentTableBindingSource, "Group ID", true));
            this.group_IDNumericUpDown.Location = new System.Drawing.Point(393, 248);
            this.group_IDNumericUpDown.Name = "group_IDNumericUpDown";
            this.group_IDNumericUpDown.Size = new System.Drawing.Size(243, 22);
            this.group_IDNumericUpDown.TabIndex = 10;
            // 
            // subGroupLabel
            // 
            subGroupLabel.AutoSize = true;
            subGroupLabel.Location = new System.Drawing.Point(244, 276);
            subGroupLabel.Name = "subGroupLabel";
            subGroupLabel.Size = new System.Drawing.Size(81, 17);
            subGroupLabel.TabIndex = 11;
            subGroupLabel.Text = "Sub Group:";
            // 
            // subGroupNumericUpDown
            // 
            this.subGroupNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentTableBindingSource, "SubGroup", true));
            this.subGroupNumericUpDown.Location = new System.Drawing.Point(393, 276);
            this.subGroupNumericUpDown.Name = "subGroupNumericUpDown";
            this.subGroupNumericUpDown.Size = new System.Drawing.Size(243, 22);
            this.subGroupNumericUpDown.TabIndex = 12;
            // 
            // studentTableDataGridView
            // 
            this.studentTableDataGridView.AutoGenerateColumns = false;
            this.studentTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.studentTableDataGridView.DataSource = this.studentTableBindingSource;
            this.studentTableDataGridView.Location = new System.Drawing.Point(664, 136);
            this.studentTableDataGridView.Name = "studentTableDataGridView";
            this.studentTableDataGridView.RowHeadersWidth = 51;
            this.studentTableDataGridView.RowTemplate.Height = 24;
            this.studentTableDataGridView.Size = new System.Drawing.Size(791, 557);
            this.studentTableDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Acadamic Year & Sem";
            this.dataGridViewTextBoxColumn2.HeaderText = "Acadamic Year & Sem";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "programme";
            this.dataGridViewTextBoxColumn3.HeaderText = "programme";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Group No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Group No";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Group ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Group ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SubGroup";
            this.dataGridViewTextBoxColumn6.HeaderText = "SubGroup";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 65);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Group Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentTableDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(acadamic_Year___SemLabel);
            this.Controls.Add(this.acadamic_Year___SemNumericUpDown);
            this.Controls.Add(programmeLabel);
            this.Controls.Add(this.programmeTextBox);
            this.Controls.Add(group_NoLabel);
            this.Controls.Add(this.group_NoNumericUpDown);
            this.Controls.Add(group_IDLabel);
            this.Controls.Add(this.group_IDNumericUpDown);
            this.Controls.Add(subGroupLabel);
            this.Controls.Add(this.subGroupNumericUpDown);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acadamic_Year___SemNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_NoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subGroupNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private ABC_databaseDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.NumericUpDown acadamic_Year___SemNumericUpDown;
        private System.Windows.Forms.TextBox programmeTextBox;
        private System.Windows.Forms.NumericUpDown group_NoNumericUpDown;
        private System.Windows.Forms.NumericUpDown group_IDNumericUpDown;
        private System.Windows.Forms.NumericUpDown subGroupNumericUpDown;
        private System.Windows.Forms.DataGridView studentTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}