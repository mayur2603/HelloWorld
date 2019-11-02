using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCrudOperations
{
    public partial class Update : Form
    {
        static string id;
        public Update()
        {
            InitializeComponent();
        }
        public Update(string identity)
        {
            id = identity;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = textBoxName.Text;
            emp.Email = textBoxEmail.Text;
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (textBoxEmail.Text.Length > 0)
            {

                if (!rEMail.IsMatch(textBoxEmail.Text))
                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxEmail.SelectAll();

                    return;

                }

            }
            else
            {
                return;
            }
            if (rdoFemale.Checked)
            {
                emp.Gender = "Female";
            }
            else
            {
                emp.Gender = "Male";
            }
            emp.BirthDate = ClndrBirthDate.SelectionEnd;
            DbConnection dbCon = new DbConnection();
            bool status = dbCon.Update(emp, id);
            if (status)
                lblMsg.Text = "Updated Successfully";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            txtEmpId.Text = id;
            new Employee =
        }

       
    }
}
