using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment.Student
{
    public partial class ShowCrimesForm : Form
    {
        public int studentId = 0;
        public ShowCrimesForm()
        {
            InitializeComponent();
        }

        private void ShowCrimesForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get crime id for deleting
            int crimeId = int.Parse(dgCrime.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("آیا از حذف این تخلف مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (StudentContext context = new StudentContext())
                {
                    context.studentCrimeRepository.Delete(crimeId);

                    context.Save();
                }
            }
            bindGrid();
        }

        private async void bindGrid()
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.Student student =
                    await context.studentRepository.GetStudent(studentId);

                this.Text = "تخلفات هنرجو: " + " " + student.FirstName;

                dgCrime.DataSource =
                    await context.studentRepository.getCrimesByStudentId(studentId);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get crime id for editing
            int crimeId = int.Parse(dgCrime.CurrentRow.Cells[0].Value.ToString());

            EditCrimesForm frmEditCrime = new EditCrimesForm();
            frmEditCrime.crimeId = crimeId;

            if (frmEditCrime.ShowDialog() == DialogResult.OK)
            {
                bindGrid();
            }

        }
    }
}
