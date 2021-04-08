
namespace ABC_TimetableManagementSystem
{
    partial class Form3
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
            System.Windows.Forms.Label tag_NameLabel;
            System.Windows.Forms.Label tag_CodeLabel;
            System.Windows.Forms.Label related_TagLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.aBC_databaseDataSet = new ABC_TimetableManagementSystem.ABC_databaseDataSet();
            this.tagTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag_NameTextBox = new System.Windows.Forms.TextBox();
            this.tag_CodeTextBox = new System.Windows.Forms.TextBox();
            this.related_TagTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            tag_NameLabel = new System.Windows.Forms.Label();
            tag_CodeLabel = new System.Windows.Forms.Label();
            related_TagLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 82);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tags Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aBC_databaseDataSet
            // 
            this.aBC_databaseDataSet.DataSetName = "ABC_databaseDataSet";
            this.aBC_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTableBindingSource
            // 
            this.tagTableBindingSource.DataMember = "TagTable";
            this.tagTableBindingSource.DataSource = this.aBC_databaseDataSet;
            // 
            // tagTableDataGridView
            // 
            this.tagTableDataGridView.AutoGenerateColumns = false;
            this.tagTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tagTableDataGridView.DataSource = this.tagTableBindingSource;
            this.tagTableDataGridView.Location = new System.Drawing.Point(930, 133);
            this.tagTableDataGridView.Name = "tagTableDataGridView";
            this.tagTableDataGridView.RowHeadersWidth = 51;
            this.tagTableDataGridView.RowTemplate.Height = 24;
            this.tagTableDataGridView.Size = new System.Drawing.Size(422, 496);
            this.tagTableDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tag Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tag Code";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Related Tag";
            this.dataGridViewTextBoxColumn3.HeaderText = "Related Tag";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // tag_NameLabel
            // 
            tag_NameLabel.AutoSize = true;
            tag_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tag_NameLabel.Location = new System.Drawing.Point(283, 170);
            tag_NameLabel.Name = "tag_NameLabel";
            tag_NameLabel.Size = new System.Drawing.Size(104, 24);
            tag_NameLabel.TabIndex = 16;
            tag_NameLabel.Text = "Tag Name:";
            // 
            // tag_NameTextBox
            // 
            this.tag_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagTableBindingSource, "Tag Name", true));
            this.tag_NameTextBox.Location = new System.Drawing.Point(408, 167);
            this.tag_NameTextBox.Name = "tag_NameTextBox";
            this.tag_NameTextBox.Size = new System.Drawing.Size(261, 22);
            this.tag_NameTextBox.TabIndex = 17;
            // 
            // tag_CodeLabel
            // 
            tag_CodeLabel.AutoSize = true;
            tag_CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tag_CodeLabel.Location = new System.Drawing.Point(283, 198);
            tag_CodeLabel.Name = "tag_CodeLabel";
            tag_CodeLabel.Size = new System.Drawing.Size(99, 24);
            tag_CodeLabel.TabIndex = 18;
            tag_CodeLabel.Text = "Tag Code:";
            // 
            // tag_CodeTextBox
            // 
            this.tag_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagTableBindingSource, "Tag Code", true));
            this.tag_CodeTextBox.Location = new System.Drawing.Point(408, 197);
            this.tag_CodeTextBox.Name = "tag_CodeTextBox";
            this.tag_CodeTextBox.Size = new System.Drawing.Size(261, 22);
            this.tag_CodeTextBox.TabIndex = 19;
            // 
            // related_TagLabel
            // 
            related_TagLabel.AutoSize = true;
            related_TagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            related_TagLabel.Location = new System.Drawing.Point(283, 226);
            related_TagLabel.Name = "related_TagLabel";
            related_TagLabel.Size = new System.Drawing.Size(117, 24);
            related_TagLabel.TabIndex = 20;
            related_TagLabel.Text = "Related Tag:";
            // 
            // related_TagTextBox
            // 
            this.related_TagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagTableBindingSource, "Related Tag", true));
            this.related_TagTextBox.Location = new System.Drawing.Point(408, 228);
            this.related_TagTextBox.Name = "related_TagTextBox";
            this.related_TagTextBox.Size = new System.Drawing.Size(261, 22);
            this.related_TagTextBox.TabIndex = 21;
            this.related_TagTextBox.TextChanged += new System.EventHandler(this.related_TagTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(448, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(13, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 48);
            this.button2.TabIndex = 23;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(591, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 46);
            this.button3.TabIndex = 24;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(299, 470);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 46);
            this.button4.TabIndex = 25;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1488, 744);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(tag_NameLabel);
            this.Controls.Add(this.tag_NameTextBox);
            this.Controls.Add(tag_CodeLabel);
            this.Controls.Add(this.tag_CodeTextBox);
            this.Controls.Add(related_TagLabel);
            this.Controls.Add(this.related_TagTextBox);
            this.Controls.Add(this.tagTableDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ABC_databaseDataSet aBC_databaseDataSet;
        private System.Windows.Forms.BindingSource tagTableBindingSource;
        private System.Windows.Forms.DataGridView tagTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tag_NameTextBox;
        private System.Windows.Forms.TextBox tag_CodeTextBox;
        private System.Windows.Forms.TextBox related_TagTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}