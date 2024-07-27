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
    public partial class AddCrimeForm : Form
    {
        public int studentId = 0;
        public AddCrimeForm()
        {
            InitializeComponent();
        }

        private async void AddCrimeForm_Load(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.Student student =
                    await context.studentRepository.GetStudent(studentId);

                this.Text = "ثبت تخلف برای :" + " " + student.FirstName + " " + student.LastName;
            }
        }

        private void btnAddCrime_Click(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                context.studentCrimeRepository.Insert(new DataLayer.Models.StudentCrime
                {
                    StudentId = studentId,
                    Crime = txtCrime.Text,
                });

                context.Save();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
