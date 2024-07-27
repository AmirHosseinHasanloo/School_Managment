namespace School_Managment.Student
{
    partial class AddCrimeForm
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
            groupBox1 = new GroupBox();
            txtCrime = new RichTextBox();
            btnAddCrime = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCrime);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 313);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جزئیات را وارد کنید";
            // 
            // txtCrime
            // 
            txtCrime.Dock = DockStyle.Fill;
            txtCrime.Location = new Point(3, 19);
            txtCrime.Name = "txtCrime";
            txtCrime.Size = new Size(419, 291);
            txtCrime.TabIndex = 0;
            txtCrime.Text = "";
            // 
            // btnAddCrime
            // 
            btnAddCrime.Location = new Point(15, 328);
            btnAddCrime.Name = "btnAddCrime";
            btnAddCrime.Size = new Size(419, 23);
            btnAddCrime.TabIndex = 1;
            btnAddCrime.Text = "ثبت تخلف";
            btnAddCrime.UseVisualStyleBackColor = true;
            btnAddCrime.Click += btnAddCrime_Click;
            // 
            // AddCrimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 359);
            Controls.Add(btnAddCrime);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddCrimeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت تخلف برای هنرجو";
            Load += AddCrimeForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox txtCrime;
        private Button btnAddCrime;
    }
}