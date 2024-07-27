namespace School_Managment
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            label1 = new Label();
            SearchBox = new TextBox();
            menuStrip1 = new MenuStrip();
            btnReload = new ToolStripMenuItem();
            افزودنهنرجوToolStripMenuItem = new ToolStripMenuItem();
            AddStudentBtn = new ToolStripMenuItem();
            btnEditStudent = new ToolStripMenuItem();
            btnDeleteStudent = new ToolStripMenuItem();
            btnAddCrime = new ToolStripMenuItem();
            btnAddLate = new ToolStripMenuItem();
            btnBestStudents = new ToolStripMenuItem();
            btnBadStudents = new ToolStripMenuItem();
            btnShowCrimes = new ToolStripMenuItem();
            btnShowLates = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            StudentGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fatherNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nationalityCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fatherPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motherPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            housePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            classNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            levelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            courseFieldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            howMuchPaidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SearchBox);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1160, 64);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "فیلتر و جستجو بر اساس نام خانوادگی یا کد ملی";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(202, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(896, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 1;
            label1.Text = "وارد کنید :";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(283, 24);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(607, 25);
            SearchBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnReload, افزودنهنرجوToolStripMenuItem, AddStudentBtn, btnEditStudent, btnDeleteStudent, btnAddCrime, btnAddLate, btnBestStudents, btnBadStudents, btnShowCrimes, btnShowLates });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 63);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources._1371476394_refresh_red1;
            btnReload.ImageScaling = ToolStripItemImageScaling.None;
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(72, 59);
            btnReload.Text = "بروز رسانی";
            btnReload.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReload.Click += btnReload_Click;
            // 
            // افزودنهنرجوToolStripMenuItem
            // 
            افزودنهنرجوToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            افزودنهنرجوToolStripMenuItem.Name = "افزودنهنرجوToolStripMenuItem";
            افزودنهنرجوToolStripMenuItem.Size = new Size(12, 59);
            افزودنهنرجوToolStripMenuItem.Text = "افزودن هنرجو";
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.Image = Properties.Resources.Users;
            AddStudentBtn.ImageScaling = ToolStripItemImageScaling.None;
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(85, 59);
            AddStudentBtn.Text = "افزودن هنرجو";
            AddStudentBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AddStudentBtn.Click += AddStudentBtn_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Image = Properties.Resources._1371475973_document_edit;
            btnEditStudent.ImageScaling = ToolStripItemImageScaling.None;
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(132, 59);
            btnEditStudent.Text = "ویرایش اطلاعات هنرجو";
            btnEditStudent.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Image = Properties.Resources._1371476007_Close_Box_Red;
            btnDeleteStudent.ImageScaling = ToolStripItemImageScaling.None;
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(77, 59);
            btnDeleteStudent.Text = "حذف هنرجو";
            btnDeleteStudent.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnAddCrime
            // 
            btnAddCrime.Image = (Image)resources.GetObject("btnAddCrime.Image");
            btnAddCrime.ImageScaling = ToolStripItemImageScaling.None;
            btnAddCrime.Name = "btnAddCrime";
            btnAddCrime.Size = new Size(68, 59);
            btnAddCrime.Text = "ثبت تخلف";
            btnAddCrime.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddCrime.Click += btnAddCrime_Click;
            // 
            // btnAddLate
            // 
            btnAddLate.Image = (Image)resources.GetObject("btnAddLate.Image");
            btnAddLate.ImageScaling = ToolStripItemImageScaling.None;
            btnAddLate.Name = "btnAddLate";
            btnAddLate.Size = new Size(102, 59);
            btnAddLate.Text = "ثبت تاخیر و غیبت";
            btnAddLate.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddLate.Click += btnAddLate_Click;
            // 
            // btnBestStudents
            // 
            btnBestStudents.Image = (Image)resources.GetObject("btnBestStudents.Image");
            btnBestStudents.ImageScaling = ToolStripItemImageScaling.None;
            btnBestStudents.Name = "btnBestStudents";
            btnBestStudents.Size = new Size(99, 59);
            btnBestStudents.Text = "هنرجویان با نظم";
            btnBestStudents.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBestStudents.Click += btnBestStudents_Click;
            // 
            // btnBadStudents
            // 
            btnBadStudents.Image = (Image)resources.GetObject("btnBadStudents.Image");
            btnBadStudents.ImageScaling = ToolStripItemImageScaling.None;
            btnBadStudents.Name = "btnBadStudents";
            btnBadStudents.Size = new Size(102, 59);
            btnBadStudents.Text = "هنرجویان متخلف";
            btnBadStudents.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBadStudents.Click += btnBadStudents_Click;
            // 
            // btnShowCrimes
            // 
            btnShowCrimes.Image = Properties.Resources._1371476276_Print;
            btnShowCrimes.ImageScaling = ToolStripItemImageScaling.None;
            btnShowCrimes.Name = "btnShowCrimes";
            btnShowCrimes.Size = new Size(122, 59);
            btnShowCrimes.Text = "مشاهده تخلف هنرجو";
            btnShowCrimes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnShowCrimes.Click += btnShowCrimes_Click;
            // 
            // btnShowLates
            // 
            btnShowLates.Image = Properties.Resources._1371476120_fingerprint_reader;
            btnShowLates.ImageScaling = ToolStripItemImageScaling.None;
            btnShowLates.Name = "btnShowLates";
            btnShowLates.Size = new Size(141, 59);
            btnShowLates.Text = "مشاهده تاخیر های هنرجو";
            btnShowLates.TextImageRelation = TextImageRelation.ImageAboveText;
            btnShowLates.Click += btnShowLates_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(StudentGridView);
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1160, 602);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "لیست هنرجویان";
            // 
            // StudentGridView
            // 
            StudentGridView.AllowUserToAddRows = false;
            StudentGridView.AllowUserToDeleteRows = false;
            StudentGridView.AutoGenerateColumns = false;
            StudentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGridView.Columns.AddRange(new DataGridViewColumn[] { Id, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, fatherNameDataGridViewTextBoxColumn, nationalityCodeDataGridViewTextBoxColumn, fatherPhoneDataGridViewTextBoxColumn, motherPhoneDataGridViewTextBoxColumn, studentPhoneDataGridViewTextBoxColumn, housePhoneDataGridViewTextBoxColumn, classNumberDataGridViewTextBoxColumn, levelDataGridViewTextBoxColumn, courseFieldDataGridViewTextBoxColumn, howMuchPaidDataGridViewTextBoxColumn });
            StudentGridView.DataSource = studentBindingSource;
            StudentGridView.Dock = DockStyle.Fill;
            StudentGridView.Location = new Point(3, 21);
            StudentGridView.Name = "StudentGridView";
            StudentGridView.ReadOnly = true;
            StudentGridView.Size = new Size(1154, 578);
            StudentGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "نام";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            fatherNameDataGridViewTextBoxColumn.HeaderText = "نام ولی";
            fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            fatherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityCodeDataGridViewTextBoxColumn
            // 
            nationalityCodeDataGridViewTextBoxColumn.DataPropertyName = "NationalityCode";
            nationalityCodeDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            nationalityCodeDataGridViewTextBoxColumn.Name = "nationalityCodeDataGridViewTextBoxColumn";
            nationalityCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatherPhoneDataGridViewTextBoxColumn
            // 
            fatherPhoneDataGridViewTextBoxColumn.DataPropertyName = "FatherPhone";
            fatherPhoneDataGridViewTextBoxColumn.HeaderText = "تماس ولی";
            fatherPhoneDataGridViewTextBoxColumn.Name = "fatherPhoneDataGridViewTextBoxColumn";
            fatherPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motherPhoneDataGridViewTextBoxColumn
            // 
            motherPhoneDataGridViewTextBoxColumn.DataPropertyName = "MotherPhone";
            motherPhoneDataGridViewTextBoxColumn.HeaderText = "تماس مادر";
            motherPhoneDataGridViewTextBoxColumn.Name = "motherPhoneDataGridViewTextBoxColumn";
            motherPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentPhone";
            studentPhoneDataGridViewTextBoxColumn.HeaderText = "تماس هنرجو";
            studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            studentPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // housePhoneDataGridViewTextBoxColumn
            // 
            housePhoneDataGridViewTextBoxColumn.DataPropertyName = "HousePhone";
            housePhoneDataGridViewTextBoxColumn.HeaderText = "تلفن منزل";
            housePhoneDataGridViewTextBoxColumn.Name = "housePhoneDataGridViewTextBoxColumn";
            housePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNumberDataGridViewTextBoxColumn
            // 
            classNumberDataGridViewTextBoxColumn.DataPropertyName = "ClassNumber";
            classNumberDataGridViewTextBoxColumn.HeaderText = "شماره کلاس";
            classNumberDataGridViewTextBoxColumn.Name = "classNumberDataGridViewTextBoxColumn";
            classNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            levelDataGridViewTextBoxColumn.HeaderText = "پایه";
            levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseFieldDataGridViewTextBoxColumn
            // 
            courseFieldDataGridViewTextBoxColumn.DataPropertyName = "CourseField";
            courseFieldDataGridViewTextBoxColumn.HeaderText = "رشته";
            courseFieldDataGridViewTextBoxColumn.Name = "courseFieldDataGridViewTextBoxColumn";
            courseFieldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // howMuchPaidDataGridViewTextBoxColumn
            // 
            howMuchPaidDataGridViewTextBoxColumn.DataPropertyName = "HowMuchPaid";
            howMuchPaidDataGridViewTextBoxColumn.HeaderText = "پرداختی";
            howMuchPaidDataGridViewTextBoxColumn.Name = "howMuchPaidDataGridViewTextBoxColumn";
            howMuchPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(DataLayer.Models.Student);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 741);
            label2.Name = "label2";
            label2.Size = new Size(233, 17);
            label2.TabIndex = 3;
            label2.Text = "توسعه داده شده توسط امیرحسین حسنلو";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1002, 741);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 4;
            label3.Text = "تاریخ امروز :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1079, 741);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1184, 761);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت هنرجویان";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem افزودنهنرجوToolStripMenuItem;
        private ToolStripMenuItem AddStudentBtn;
        private ToolStripMenuItem btnBestStudents;
        private TextBox SearchBox;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private DataGridView StudentGridView;
        private BindingSource studentBindingSource;
        private ToolStripMenuItem btnBadStudents;
        private ToolStripMenuItem btnEditStudent;
        private ToolStripMenuItem btnAddCrime;
        private ToolStripMenuItem btnAddLate;
        private ToolStripMenuItem btnDeleteStudent;
        private ToolStripMenuItem btnReload;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationalityCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fatherPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motherPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn housePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn courseFieldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn howMuchPaidDataGridViewTextBoxColumn;
        private ToolStripMenuItem btnShowCrimes;
        private ToolStripMenuItem btnShowLates;
    }
}
