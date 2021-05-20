
using System ;

namespace TimeTable_Management_System_ABC_Institute
{
    partial class ManageStudents
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.acedemicyearTb = new System.Windows.Forms.MaskedTextBox();
            this.programTb = new System.Windows.Forms.MaskedTextBox();
            this.semesterTb = new System.Windows.Forms.MaskedTextBox();
            this.groupidTb = new System.Windows.Forms.MaskedTextBox();
            this.subgroupidTb = new System.Windows.Forms.MaskedTextBox();
            this.groupnoTb = new System.Windows.Forms.MaskedTextBox();
            this.subgroupnoTb = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(472, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // acedemicyearTb
            // 
            this.acedemicyearTb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.acedemicyearTb.Location = new System.Drawing.Point(21, 86);
            this.acedemicyearTb.Name = "acedemicyearTb";
            this.acedemicyearTb.Size = new System.Drawing.Size(399, 27);
            this.acedemicyearTb.TabIndex = 1;
            this.acedemicyearTb.Text = "Academic Year";
            this.acedemicyearTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.acedemicyearTb_MaskInputRejected);
            // 
            // programTb
            // 
            this.programTb.Location = new System.Drawing.Point(21, 183);
            this.programTb.Name = "programTb";
            this.programTb.Size = new System.Drawing.Size(399, 27);
            this.programTb.TabIndex = 2;
            this.programTb.Text = "Program";
            // 
            // semesterTb
            // 
            this.semesterTb.Location = new System.Drawing.Point(21, 133);
            this.semesterTb.Name = "semesterTb";
            this.semesterTb.Size = new System.Drawing.Size(399, 27);
            this.semesterTb.TabIndex = 3;
            this.semesterTb.Text = "Semester";
            // 
            // groupidTb
            // 
            this.groupidTb.Location = new System.Drawing.Point(21, 335);
            this.groupidTb.Name = "groupidTb";
            this.groupidTb.Size = new System.Drawing.Size(399, 27);
            this.groupidTb.TabIndex = 4;
            this.groupidTb.Text = "Group Id";
            // 
            // subgroupidTb
            // 
            this.subgroupidTb.Location = new System.Drawing.Point(21, 385);
            this.subgroupidTb.Name = "subgroupidTb";
            this.subgroupidTb.Size = new System.Drawing.Size(399, 27);
            this.subgroupidTb.TabIndex = 5;
            this.subgroupidTb.Text = "Sub Group ID";
            // 
            // groupnoTb
            // 
            this.groupnoTb.Location = new System.Drawing.Point(21, 236);
            this.groupnoTb.Name = "groupnoTb";
            this.groupnoTb.Size = new System.Drawing.Size(399, 27);
            this.groupnoTb.TabIndex = 6;
            this.groupnoTb.Text = "Group Number";
            this.groupnoTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // subgroupnoTb
            // 
            this.subgroupnoTb.Location = new System.Drawing.Point(21, 285);
            this.subgroupnoTb.Name = "subgroupnoTb";
            this.subgroupnoTb.Size = new System.Drawing.Size(399, 27);
            this.subgroupnoTb.TabIndex = 7;
            this.subgroupnoTb.Text = "Sub Group Number";
            this.subgroupnoTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox7_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(170, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(170, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(326, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 478);
            this.dataGridView1.TabIndex = 12;
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subgroupnoTb);
            this.Controls.Add(this.groupnoTb);
            this.Controls.Add(this.subgroupidTb);
            this.Controls.Add(this.groupidTb);
            this.Controls.Add(this.semesterTb);
            this.Controls.Add(this.programTb);
            this.Controls.Add(this.acedemicyearTb);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudents";
            this.Text = "Manage Students";
            this.Load = new System.EventHandler(this.ManageStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox acedemicyearTb;
        private System.Windows.Forms.MaskedTextBox programTb;
        private System.Windows.Forms.MaskedTextBox semesterTb;
        private System.Windows.Forms.MaskedTextBox groupidTb;
        private System.Windows.Forms.MaskedTextBox subgroupidTb;
        private System.Windows.Forms.MaskedTextBox groupnoTb;
        private System.Windows.Forms.MaskedTextBox subgroupnoTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EventHandler ManageStudents_Load;
    }
}

