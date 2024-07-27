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
    public partial class EditCrimesForm : Form
    {
        public int crimeId = 0;
        public EditCrimesForm()
        {
            InitializeComponent();
        }

        private async void EditCrimesForm_Load(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.Student student =
                    await context.studentRepository.GetStudent(crimeId);

                this.Text = "ویرایش تخلف برای :" + " " + student.FirstName + " " + student.LastName;

                var crime = context.studentRepository.GetCrimeByStudentId(crimeId);

                txtCrime.Text = crime;
            }
        }

        private void btnEditCrime_Click(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                var crime = txtCrime.Text;

                context.studentRepository.EditCrime(crimeId, crime);

                context.Save();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
