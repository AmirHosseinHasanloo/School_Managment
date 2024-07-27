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
    public partial class ShowLatesForm : Form
    {
        public int studentId = 0;
        public ShowLatesForm()
        {
            InitializeComponent();
        }

        private void ShowLatesForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }


        async void bindGrid()
        {
            using (StudentContext context = new StudentContext())
            {
                dgLate.DataSource = context.studentLateRepository.GetAll()
                    .Where(l => l.StudentId == studentId).ToList();

                DataLayer.Models.Student student =
                    await context.studentRepository.GetStudent(studentId);

                string studentName = student.FirstName + " " + student.LastName;

                this.Text = "تاخیر ها و غیبت های هنرجو" + " " + studentName;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get crime id for deleting
            int lateId = int.Parse(dgLate.CurrentRow.Cells[0].Value.ToString());

            if (MessageBox.Show("آیا از حذف این مورد مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (StudentContext context = new StudentContext())
                {
                    context.studentLateRepository.Delete(lateId);

                    context.Save();
                }
            }
            bindGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get crime id for editing
            int lateId = int.Parse(dgLate.CurrentRow.Cells[0].Value.ToString());

            EditLateForm frmEditlate = new EditLateForm();
            frmEditlate.lateId = lateId;

            if (frmEditlate.ShowDialog() == DialogResult.OK)
            {
                bindGrid();
            }
        }
    }
}
