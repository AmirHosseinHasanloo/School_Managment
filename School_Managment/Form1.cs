using Core.ExtentionClass;
using DataLayer.Context;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using School_Managment.Student;
using System.Windows.Forms;

namespace School_Managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            StudentContext context = new StudentContext();
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
            label4.Text = DateTime.Now.ToShamsi().ToString();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            using (StudentContext _context = new StudentContext())
            {
                StudentGridView.DataSource = await _context.studentRepository.Filter(SearchBox.Text);
            }
        }

        private async void btnBadStudents_Click(object sender, EventArgs e)
        {
            using (StudentContext _context = new StudentContext())
            {
                StudentGridView.DataSource = await _context.studentRepository.BadStudents();
            }
        }

        private async void btnBestStudents_Click(object sender, EventArgs e)
        {
            using (StudentContext _context = new StudentContext())
            {
                StudentGridView.DataSource = await _context.studentRepository.BestStudents();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            //get user id for editing
            int studentId = int.Parse(StudentGridView.CurrentRow.Cells[0].Value.ToString());

            if (studentId > 0)
            {
                EditStudentForm editStudentForm = new EditStudentForm();
                editStudentForm._studentId = studentId;

                if (editStudentForm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnAddCrime_Click(object sender, EventArgs e)
        {
            AddCrimeForm addCrimeForm = new AddCrimeForm();

            //get user id for editing
            int studentId = int.Parse(StudentGridView.CurrentRow.Cells[0].Value.ToString());
            addCrimeForm.studentId = studentId;

            if (addCrimeForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShamsi();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public async void BindGrid()
        {
            using (StudentContext _context = new StudentContext())
            {
                StudentGridView.DataSource = await _context.studentRepository.getAll();
            }
        }

        private void btnAddLate_Click(object sender, EventArgs e)
        {
            AddStudentLateForm frmLate = new AddStudentLateForm();
            //get user id for editing
            int studentId = int.Parse(StudentGridView.CurrentRow.Cells[0].Value.ToString());

            frmLate._studentId = studentId;

            if (frmLate.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            //get user id for editing
            int studentId = int.Parse(StudentGridView.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("آِیا از حذف کردن این هنرجو مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (StudentContext _context = new StudentContext())
                {
                    _context.studentRepository.Delete(id: studentId);

                    _context.Save();
                }
            }
            BindGrid();
        }

        private void btnShowCrimes_Click(object sender, EventArgs e)
        {
            //get user id for editing
            int studentId = int.Parse(StudentGridView.CurrentRow.Cells[0].Value.ToString());

            ShowCrimesForm frmCrimes = new ShowCrimesForm();
            frmCrimes.studentId = studentId;
            frmCrimes.ShowDialog();
        }

        private void btnShowLates_Click(object sender, EventArgs e)
        {

        }
    }
}
