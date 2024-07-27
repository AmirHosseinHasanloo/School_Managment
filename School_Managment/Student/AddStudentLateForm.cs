using DataLayer.Context;
using DataLayer.Models;
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
    public partial class AddStudentLateForm : Form
    {
        public int _studentId = 0;
        public AddStudentLateForm()
        {
            InitializeComponent();
        }

        private async void AddStudentLateForm_Load(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.Student student =
                 await context.studentRepository.GetStudent(_studentId);

                this.Text = "ثبت تاخیر و یا غیبت برای :" + " " + student.FirstName + " " + student.LastName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                context.StudentLate.Add(new DataLayer.Models.StudentLate()
                {
                    StudentId = _studentId,
                    LateDate = txtLate.Text,
                });

                context.Save();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
