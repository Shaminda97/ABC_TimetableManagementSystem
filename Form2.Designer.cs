
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label acadamic_Year_Label;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label programLabel;
            System.Windows.Forms.Label group_NoLabel1;
            System.Windows.Forms.Label sub_Group_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.studentTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.StudentTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            this.studentTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.acadamic_Year_TextBox = new System.Windows.Forms.TextBox();
            this.semesterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.programTextBox = new System.Windows.Forms.TextBox();
            this.group_NoTextBox = new System.Windows.Forms.TextBox();
            this.sub_Group_NoTextBox = new System.Windows.Forms.TextBox();
            idLabel1 = new System.Windows.Forms.Label();
            acadamic_Year_Label = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            programLabel = new System.Windows.Forms.Label();
            group_NoLabel1 = new System.Windows.Forms.Label();
            sub_Group_NoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(338, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(435, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(239, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 51);
            this.button4.TabIndex = 18;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.studentTableDataGridView.Location = new System.Drawing.Point(678, 109);
            this.studentTableDataGridView.Name = "studentTableDataGridView";
            this.studentTableDataGridView.RowHeadersWidth = 51;
            this.studentTableDataGridView.RowTemplate.Height = 24;
            this.studentTableDataGridView.Size = new System.Drawing.Size(793, 593);
            this.studentTableDataGridView.TabIndex = 18;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Acadamic Year ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Acadamic Year ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Semester";
            this.dataGridViewTextBoxColumn3.HeaderText = "Semester";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn4.HeaderText = "Program";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Group No";
            this.dataGridViewTextBoxColumn5.HeaderText = "Group No";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sub Group No";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sub Group No";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(260, 112);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 18;
            idLabel1.Text = "Id:";
            // 
            // IDTb
            // 
            this.IDTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Id", true));
            this.IDTb.Location = new System.Drawing.Point(377, 109);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(212, 22);
            this.IDTb.TabIndex = 19;
            // 
            // acadamic_Year_Label
            // 
            acadamic_Year_Label.AutoSize = true;
            acadamic_Year_Label.Location = new System.Drawing.Point(260, 140);
            acadamic_Year_Label.Name = "acadamic_Year_Label";
            acadamic_Year_Label.Size = new System.Drawing.Size(111, 17);
            acadamic_Year_Label.TabIndex = 20;
            acadamic_Year_Label.Text = "Acadamic Year :";
            // 
            // acadamic_Year_TextBox
            // 
            this.acadamic_Year_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Acadamic Year ", true));
            this.acadamic_Year_TextBox.Location = new System.Drawing.Point(377, 137);
            this.acadamic_Year_TextBox.Name = "acadamic_Year_TextBox";
            this.acadamic_Year_TextBox.Size = new System.Drawing.Size(212, 22);
            this.acadamic_Year_TextBox.TabIndex = 21;
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Location = new System.Drawing.Point(260, 165);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(72, 17);
            semesterLabel.TabIndex = 22;
            semesterLabel.Text = "Semester:";
            // 
            // semesterNumericUpDown
            // 
            this.semesterNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentTableBindingSource, "Semester", true));
            this.semesterNumericUpDown.Location = new System.Drawing.Point(377, 165);
            this.semesterNumericUpDown.Name = "semesterNumericUpDown";
            this.semesterNumericUpDown.Size = new System.Drawing.Size(212, 22);
            this.semesterNumericUpDown.TabIndex = 23;
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.Location = new System.Drawing.Point(260, 196);
            programLabel.Name = "programLabel";
            programLabel.Size = new System.Drawing.Size(66, 17);
            programLabel.TabIndex = 24;
            programLabel.Text = "Program:";
            // 
            // programTextBox
            // 
            this.programTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Program", true));
            this.programTextBox.Location = new System.Drawing.Point(377, 193);
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.Size = new System.Drawing.Size(212, 22);
            this.programTextBox.TabIndex = 25;
            // 
            // group_NoLabel1
            // 
            group_NoLabel1.AutoSize = true;
            group_NoLabel1.Location = new System.Drawing.Point(260, 224);
            group_NoLabel1.Name = "group_NoLabel1";
            group_NoLabel1.Size = new System.Drawing.Size(74, 17);
            group_NoLabel1.TabIndex = 26;
            group_NoLabel1.Text = "Group No:";
            // 
            // group_NoTextBox
            // 
            this.group_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Group No", true));
            this.group_NoTextBox.Location = new System.Drawing.Point(377, 221);
            this.group_NoTextBox.Name = "group_NoTextBox";
            this.group_NoTextBox.Size = new System.Drawing.Size(212, 22);
            this.group_NoTextBox.TabIndex = 27;
            // 
            // sub_Group_NoLabel
            // 
            sub_Group_NoLabel.AutoSize = true;
            sub_Group_NoLabel.Location = new System.Drawing.Point(260, 252);
            sub_Group_NoLabel.Name = "sub_Group_NoLabel";
            sub_Group_NoLabel.Size = new System.Drawing.Size(103, 17);
            sub_Group_NoLabel.TabIndex = 28;
            sub_Group_NoLabel.Text = "Sub Group No:";
            // 
            // sub_Group_NoTextBox
            // 
            this.sub_Group_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Sub Group No", true));
            this.sub_Group_NoTextBox.Location = new System.Drawing.Point(377, 249);
            this.sub_Group_NoTextBox.Name = "sub_Group_NoTextBox";
            this.sub_Group_NoTextBox.Size = new System.Drawing.Size(212, 22);
            this.sub_Group_NoTextBox.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1491, 739);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.IDTb);
            this.Controls.Add(acadamic_Year_Label);
            this.Controls.Add(this.acadamic_Year_TextBox);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterNumericUpDown);
            this.Controls.Add(programLabel);
            this.Controls.Add(this.programTextBox);
            this.Controls.Add(group_NoLabel1);
            this.Controls.Add(this.group_NoTextBox);
            this.Controls.Add(sub_Group_NoLabel);
            this.Controls.Add(this.sub_Group_NoTextBox);
            this.Controls.Add(this.studentTableDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private ABC_databaseDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView studentTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.TextBox acadamic_Year_TextBox;
        private System.Windows.Forms.NumericUpDown semesterNumericUpDown;
        private System.Windows.Forms.TextBox programTextBox;
        private System.Windows.Forms.TextBox group_NoTextBox;
        private System.Windows.Forms.TextBox sub_Group_NoTextBox;
    }
}