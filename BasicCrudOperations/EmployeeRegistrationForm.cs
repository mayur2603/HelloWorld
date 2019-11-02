using System;
using System.Windows.Forms;

namespace BasicCrudOperations
{
    public partial class EmployeeRegistrationForm : Form
    {
        private bool _isValid = true;

        public EmployeeRegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtName.Text;
            emp.Email = txtEmail.Text;
            
            if (rdoFemale.Checked)
            {
                emp.Gender = "Female";
            }
            else
            {
                emp.Gender = "Male";
            }
            
            emp.BirthDate = clndrBirthDate.SelectionEnd;
            DbConnection dbCon = new DbConnection();
            if (_isValid)
            {
                bool isInserted = dbCon.Insert(emp);
                if (isInserted)
                {
                    lblMsg.Text = "Registered Successfully";
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                        {
                            c.Text = String.Empty;
                        }
                    }
                }
            }
            
           

        }

        private void BtnShowEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowEmpData showForm=new ShowEmpData();
            showForm.ShowDialog();
            this.Show(); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        

        private void EmailValidation(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Please Enter Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isValid = false;
                }

            }
            else
            {
                MessageBox.Show("Email can not be left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isValid = false;
            }
        }

        private void NameValidation(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rName = new System.Text.RegularExpressions.Regex("[a-zA-Z]+\\.?");
            if (txtName.Text.Length > 0)
            {
                if (!rName.IsMatch(txtName.Text))
                {
                    MessageBox.Show("Please Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isValid = false;
                }
                else
                {
                    _isValid = true;
                }
            }
            else
            {
                MessageBox.Show("Name can not be left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isValid = false;
            }
        }
      
    }
}
