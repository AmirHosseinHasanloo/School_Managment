namespace School_Managment.Student
{
    partial class AddStudentLateForm
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
            label1 = new Label();
            txtLate = new TextBox();
            btnSubmit = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLate);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت اطلاعات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 34);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "ثبت تاریخ تاخیر هنر جو :";
            // 
            // txtLate
            // 
            txtLate.Location = new Point(6, 52);
            txtLate.Name = "txtLate";
            txtLate.Size = new Size(269, 23);
            txtLate.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 114);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(281, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 2;
            label2.Text = "راهنما : در صورت موجه بودن از (موجه) استفاده کنید";
            // 
            // AddStudentLateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 142);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddStudentLateForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت تاخیر برای دانش آموز";
            Load += AddStudentLateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtLate;
        private Button btnSubmit;
        private Label label2;
    }
}