namespace School_Managment.Student
{
    partial class ShowCrimesForm
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
            dgCrime = new DataGridView();
            studentCrimeBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            btnEdit = new Button();
            btnDelete = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            crimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCrime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCrimeBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgCrime);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "مشاهده";
            // 
            // dgCrime
            // 
            dgCrime.AllowUserToAddRows = false;
            dgCrime.AllowUserToDeleteRows = false;
            dgCrime.AutoGenerateColumns = false;
            dgCrime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCrime.Columns.AddRange(new DataGridViewColumn[] { Column1, crimeDataGridViewTextBoxColumn });
            dgCrime.DataSource = studentCrimeBindingSource;
            dgCrime.Dock = DockStyle.Fill;
            dgCrime.Location = new Point(3, 19);
            dgCrime.Name = "dgCrime";
            dgCrime.ReadOnly = true;
            dgCrime.Size = new Size(631, 286);
            dgCrime.TabIndex = 0;
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
            groupBox2.TabIndex = 1;
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
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // crimeDataGridViewTextBoxColumn
            // 
            crimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            crimeDataGridViewTextBoxColumn.DataPropertyName = "Crime";
            crimeDataGridViewTextBoxColumn.HeaderText = "تخلف";
            crimeDataGridViewTextBoxColumn.Name = "crimeDataGridViewTextBoxColumn";
            crimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShowCrimesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 380);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ShowCrimesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "نمایش تخلفات";
            Load += ShowCrimesForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCrime).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCrimeBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgCrime;
        private GroupBox groupBox2;
        private Button btnEdit;
        private Button btnDelete;
        private BindingSource studentCrimeBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn crimeDataGridViewTextBoxColumn;
    }
}