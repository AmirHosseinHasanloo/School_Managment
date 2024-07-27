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
using static System.Net.Mime.MediaTypeNames;

namespace School_Managment.Student
{
    public partial class EditStudentForm : Form
    {
        public int _studentId = 0;
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private async void EditStudentForm_Load(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.Student student =
                await context.studentRepository.GetStudent(_studentId);

                txtClassCode.Text = student.ClassNumber;
                txtDadName.Text = student.FatherName;
                txtDadPhone.Text = student.FatherPhone;
                txtField.Text = student.CourseField;
                txtFirstName.Text = student.FirstName;
                txtHomePhone.Text = student.HousePhone;
                txtHowMuchPaid.Text = student.HowMuchPaid;
                txtLastName.Text = student.LastName;
                txtLevel.Text = student.Level;
                txtMotherPhone.Text = student.MotherPhone;
                txtNationalityCode.Text = student.NationalityCode;
                txtStudentPhone.Text = student.StudentPhone;
            }
        }
        private async void Edit_Click(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.Student student =
                    await context.studentRepository.GetStudent(_studentId);

                student.LastName = txtLastName.Text;
                student.FirstName = txtFirstName.Text;
                student.Level = txtLevel.Text;
                student.StudentPhone = txtMotherPhone.Text;
                student.MotherPhone = txtMotherPhone.Text;
                student.FatherPhone = txtDadPhone.Text;
                student.CourseField = txtField.Text;
                student.NationalityCode = txtNationalityCode.Text;
                student.ClassNumber = txtClassCode.Text;
                student.FatherName = txtDadName.Text;
                student.HousePhone = txtHomePhone.Text;
                student.HowMuchPaid = txtHowMuchPaid.Text;


                context.studentRepository.EditStudent(student);
                context.Save();
            }

            DialogResult = DialogResult.OK;
        }


    }
}
