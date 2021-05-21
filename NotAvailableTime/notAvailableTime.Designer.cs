
namespace ABC_TimetableManagementSystem.NotAvailableTime
{
    partial class notAvailableTime
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
            System.Windows.Forms.Label lecturerLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label subGroupLabel;
            System.Windows.Forms.Label sesionIDLabel;
            System.Windows.Forms.Label timeDurationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notAvailableTime));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lecturerComboBox = new System.Windows.Forms.ComboBox();
            this.notAvailableTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.subGroupComboBox = new System.Windows.Forms.ComboBox();
            this.sesionIDComboBox = new System.Windows.Forms.ComboBox();
            this.timeDurationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notAvailableTimesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notAvailableTimesTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.NotAvailableTimesTableAdapter();
            this.addaSessionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addaSessionTableTableAdapter = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.AddaSessionTableTableAdapter();
            this.tableAdapterManager = new ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager();
            lecturerLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            subGroupLabel = new System.Windows.Forms.Label();
            sesionIDLabel = new System.Windows.Forms.Label();
            timeDurationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAvailableTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAvailableTimesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addaSessionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lecturerLabel
            // 
            lecturerLabel.AutoSize = true;
            lecturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lecturerLabel.Location = new System.Drawing.Point(12, 56);
            lecturerLabel.Name = "lecturerLabel";
            lecturerLabel.Size = new System.Drawing.Size(68, 15);
            lecturerLabel.TabIndex = 7;
            lecturerLabel.Text = "Lecturer :";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupLabel.Location = new System.Drawing.Point(12, 109);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(72, 15);
            groupLabel.TabIndex = 9;
            groupLabel.Text = "Group ID :";
            // 
            // subGroupLabel
            // 
            subGroupLabel.AutoSize = true;
            subGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subGroupLabel.Location = new System.Drawing.Point(12, 162);
            subGroupLabel.Name = "subGroupLabel";
            subGroupLabel.Size = new System.Drawing.Size(83, 15);
            subGroupLabel.TabIndex = 11;
            subGroupLabel.Text = "Sub Group :";
            // 
            // sesionIDLabel
            // 
            sesionIDLabel.AutoSize = true;
            sesionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sesionIDLabel.Location = new System.Drawing.Point(13, 215);
            sesionIDLabel.Name = "sesionIDLabel";
            sesionIDLabel.Size = new System.Drawing.Size(77, 15);
            sesionIDLabel.TabIndex = 13;
            sesionIDLabel.Text = "Sesion ID :";
            // 
            // timeDurationLabel
            // 
            timeDurationLabel.AutoSize = true;
            timeDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeDurationLabel.Location = new System.Drawing.Point(12, 268);
            timeDurationLabel.Name = "timeDurationLabel";
            timeDurationLabel.Size = new System.Drawing.Size(106, 15);
            timeDurationLabel.TabIndex = 15;
            timeDurationLabel.Text = "Time Duration :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 90);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(28, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 44);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(386, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timetable Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(455, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institute";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(lecturerLabel);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.lecturerComboBox);
            this.panel2.Controls.Add(groupLabel);
            this.panel2.Controls.Add(this.groupComboBox);
            this.panel2.Controls.Add(subGroupLabel);
            this.panel2.Controls.Add(this.subGroupComboBox);
            this.panel2.Controls.Add(sesionIDLabel);
            this.panel2.Controls.Add(this.sesionIDComboBox);
            this.panel2.Controls.Add(timeDurationLabel);
            this.panel2.Controls.Add(this.timeDurationTextBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 460);
            this.panel2.TabIndex = 2;
            // 
            // lecturerComboBox
            // 
            this.lecturerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notAvailableTimesBindingSource, "Lecturer", true));
            this.lecturerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerComboBox.FormattingEnabled = true;
            this.lecturerComboBox.Items.AddRange(new object[] {
            "Mr.Manjula Sirisena",
            "Ms.Kavindi Gunasinghe",
            "Mr.Senura Diwantha",
            "Mr.Kavinda Yapa",
            "Dr.Achala Rupasinghe",
            "Ms.Shamali Kodithuwakku",
            "Mr.Noel Perera",
            "Ms.W.P.Liyanage",
            "Ms.Sara Nuhman",
            "Mr.K.D.Selvaraj"});
            this.lecturerComboBox.Location = new System.Drawing.Point(166, 53);
            this.lecturerComboBox.Name = "lecturerComboBox";
            this.lecturerComboBox.Size = new System.Drawing.Size(200, 23);
            this.lecturerComboBox.TabIndex = 8;
            // 
            // notAvailableTimesBindingSource
            // 
            this.notAvailableTimesBindingSource.DataMember = "NotAvailableTimes";
            this.notAvailableTimesBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notAvailableTimesBindingSource, "Group", true));
            this.groupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B"});
            this.groupComboBox.Location = new System.Drawing.Point(166, 101);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(200, 23);
            this.groupComboBox.TabIndex = 10;
            // 
            // subGroupComboBox
            // 
            this.subGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notAvailableTimesBindingSource, "SubGroup", true));
            this.subGroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroupComboBox.FormattingEnabled = true;
            this.subGroupComboBox.Items.AddRange(new object[] {
            "1A.a",
            "1A.b",
            "1B.a",
            "1B.b",
            "2A.a",
            "2A.b",
            "2B.a",
            "2B.b",
            "3A.a",
            "3A.b",
            "3B.a",
            "3B.b"});
            this.subGroupComboBox.Location = new System.Drawing.Point(166, 154);
            this.subGroupComboBox.Name = "subGroupComboBox";
            this.subGroupComboBox.Size = new System.Drawing.Size(200, 23);
            this.subGroupComboBox.TabIndex = 12;
            // 
            // sesionIDComboBox
            // 
            this.sesionIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notAvailableTimesBindingSource, "SesionID", true));
            this.sesionIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesionIDComboBox.FormattingEnabled = true;
            this.sesionIDComboBox.Items.AddRange(new object[] {
            "IT3030(IC)",
            "IT2015(MC)",
            "IT1014(EAP)",
            "BM3012(BC)",
            "BM2223(KC)",
            "IT4001(PAF)",
            "BM3276(GA)"});
            this.sesionIDComboBox.Location = new System.Drawing.Point(166, 207);
            this.sesionIDComboBox.Name = "sesionIDComboBox";
            this.sesionIDComboBox.Size = new System.Drawing.Size(200, 23);
            this.sesionIDComboBox.TabIndex = 14;
            // 
            // timeDurationTextBox
            // 
            this.timeDurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notAvailableTimesBindingSource, "TimeDuration", true));
            this.timeDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDurationTextBox.Location = new System.Drawing.Point(166, 262);
            this.timeDurationTextBox.Name = "timeDurationTextBox";
            this.timeDurationTextBox.Size = new System.Drawing.Size(200, 21);
            this.timeDurationTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Not Available Times";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(276, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(310, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.notAvailableTimesDataGridView);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(459, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 460);
            this.panel3.TabIndex = 3;
            // 
            // notAvailableTimesDataGridView
            // 
            this.notAvailableTimesDataGridView.AutoGenerateColumns = false;
            this.notAvailableTimesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notAvailableTimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAvailableTimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.notAvailableTimesDataGridView.DataSource = this.notAvailableTimesBindingSource;
            this.notAvailableTimesDataGridView.Location = new System.Drawing.Point(20, 53);
            this.notAvailableTimesDataGridView.Name = "notAvailableTimesDataGridView";
            this.notAvailableTimesDataGridView.Size = new System.Drawing.Size(620, 220);
            this.notAvailableTimesDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lecturer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Lecturer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Group";
            this.dataGridViewTextBoxColumn3.HeaderText = "Group";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubGroup";
            this.dataGridViewTextBoxColumn4.HeaderText = "SubGroup";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SesionID";
            this.dataGridViewTextBoxColumn5.HeaderText = "SesionID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TimeDuration";
            this.dataGridViewTextBoxColumn6.HeaderText = "TimeDuration";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // notAvailableTimesTableAdapter
            // 
            this.notAvailableTimesTableAdapter.ClearBeforeFill = true;
            // 
            // addaSessionTableBindingSource
            // 
            this.addaSessionTableBindingSource.DataMember = "AddaSessionTable";
            this.addaSessionTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // addaSessionTableTableAdapter
            // 
            this.addaSessionTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddaSessionTableTableAdapter = this.addaSessionTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerTableTableAdapter = null;
            this.tableAdapterManager.LecturesDrtailsTableAdapter = null;
            this.tableAdapterManager.NonAvaiableTimesTableTableAdapter = null;
            this.tableAdapterManager.NonOverLappingTableTableAdapter = null;
            this.tableAdapterManager.NotAvailableTimesTableAdapter = this.notAvailableTimesTableAdapter;
            this.tableAdapterManager.NotAvailabliTimesTableAdapter = null;
            this.tableAdapterManager.ParallelSessionTableTableAdapter = null;
            this.tableAdapterManager.ReservedHallArrangementTableTableAdapter = null;
            this.tableAdapterManager.RoomsTableTableAdapter = null;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.SubjectTableTableAdapter = null;
            this.tableAdapterManager.SuitableTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_TimetableManagementSystem.ABC_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkingDaysandHoursTableTableAdapter = null;
            // 
            // notAvailableTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1111, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "notAvailableTime";
            this.Text = "notAvailableTime";
            this.Load += new System.EventHandler(this.notAvailableTime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAvailableTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notAvailableTimesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addaSessionTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBack;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource notAvailableTimesBindingSource;
        private ABC_databaseDataSetTableAdapters.NotAvailableTimesTableAdapter notAvailableTimesTableAdapter;
        private System.Windows.Forms.BindingSource addaSessionTableBindingSource;
        private ABC_databaseDataSetTableAdapters.AddaSessionTableTableAdapter addaSessionTableTableAdapter;
        private ABC_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox lecturerComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox subGroupComboBox;
        private System.Windows.Forms.ComboBox sesionIDComboBox;
        private System.Windows.Forms.TextBox timeDurationTextBox;
        private System.Windows.Forms.DataGridView notAvailableTimesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}