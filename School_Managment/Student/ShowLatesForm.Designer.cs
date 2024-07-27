namespace School_Managment.Student
{
    partial class ShowLatesForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dgLate = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lateDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentLateBindingSource = new BindingSource(components);
            studentCrimeBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            btnEdit = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentLateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCrimeBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgLate);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 308);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "مشاهده";
            // 
            // dgLate
            // 
            dgLate.AllowUserToAddRows = false;
            dgLate.AllowUserToDeleteRows = false;
            dgLate.AutoGenerateColumns = false;
            dgLate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLate.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, lateDateDataGridViewTextBoxColumn });
            dgLate.DataSource = studentLateBindingSource;
            dgLate.Dock = DockStyle.Fill;
            dgLate.Location = new Point(3, 19);
            dgLate.Name = "dgLate";
            dgLate.ReadOnly = true;
            dgLate.Size = new Size(631, 286);
            dgLate.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // lateDateDataGridViewTextBoxColumn
            // 
            lateDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lateDateDataGridViewTextBoxColumn.DataPropertyName = "LateDate";
            lateDateDataGridViewTextBoxColumn.HeaderText = "تاریخ تاخیر و یا غیبت هنرجو";
            lateDateDataGridViewTextBoxColumn.Name = "lateDateDataGridViewTextBoxColumn";
            lateDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLateBindingSource
            // 
            studentLateBindingSource.DataSource = typeof(DataLayer.Models.StudentLate);
            // 
            // studentCrimeBindingSource
            // 
            studentCrimeBindingSource.DataSource = typeof(DataLayer.Models.StudentCrime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(637, 52);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "دستورات";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(318, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(193, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(119, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ShowLatesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 380);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ShowLatesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "نمایش تاخیر و غیبت های هنرجو";
            Load += ShowLatesForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLate).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentLateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCrimeBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgLate;
        private BindingSource studentLateBindingSource;
        private BindingSource studentCrimeBindingSource;
        private GroupBox groupBox2;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lateDateDataGridViewTextBoxColumn;
    }
}