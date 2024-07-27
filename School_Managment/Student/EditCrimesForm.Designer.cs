namespace School_Managment.Student
{
    partial class EditCrimesForm
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
            btnEditCrime = new Button();
            txtCrime = new RichTextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditCrime
            // 
            btnEditCrime.Location = new Point(15, 326);
            btnEditCrime.Name = "btnEditCrime";
            btnEditCrime.Size = new Size(419, 23);
            btnEditCrime.TabIndex = 3;
            btnEditCrime.Text = "ویرایش تخلف";
            btnEditCrime.UseVisualStyleBackColor = true;
            btnEditCrime.Click += btnEditCrime_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCrime);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 313);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جزئیات را ویرایش کنید";
            // 
            // EditCrimesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 359);
            Controls.Add(btnEditCrime);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditCrimesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ویرایش تخلف";
            Load += EditCrimesForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditCrime;
        private RichTextBox txtCrime;
        private GroupBox groupBox1;
    }
}