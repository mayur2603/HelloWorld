using System;
using System.Windows.Forms;

namespace BasicCrudOperations
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationForm er = new EmployeeRegistrationForm();
            this.Hide();
            er.ShowDialog();
            this.Show();
        }

        private void BtnViewEmp_Click(object sender, EventArgs e)
        {
            ShowEmpData show = new ShowEmpData();
            this.Hide();
            show.ShowDialog();
            this.Show();
        }
    }
}
