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
    public partial class EditLateForm : Form
    {
        public int lateId;
        public EditLateForm()
        {
            InitializeComponent();
        }

        private void EditLateForm_Load(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                this.Text = "ویرایش اطلاعات";
                txtLate.Text = context.studentLateRepository.GetById(lateId).LateDate;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Models.StudentLate late =
                    context.studentLateRepository.GetById(lateId);

                late.LateDate = txtLate.Text;

                context.Save();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
