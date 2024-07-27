using DataLayer.Context;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Web.WebView2.Core;
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
    public partial class AddStudentForm : Form
    {
        private StudentContext _context = new StudentContext();
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            DataLayer.Models.Student student = new DataLayer.Models.Student()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ClassNumber = txtClassCode.Text,
                CourseField = txtField.Text,
                FatherName = txtDadName.Text,
                FatherPhone = txtDadPhone.Text,
                HousePhone = txtHomePhone.Text,
                HowMuchPaid = txtHomePhone.Text,
                Level = txtLevel.Text,
                MotherPhone = txtMotherPhone.Text,
                NationalityCode = txtNationalityCode.Text,
                StudentPhone = txtStudentPhone.Text,
            };

            _context.studentRepository.AddStudent(student);

            DialogResult = DialogResult.OK;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
