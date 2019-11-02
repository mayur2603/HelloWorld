using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCrudOperations
{
    public partial class ShowEmpData : Form
    {
        public ShowEmpData()
        {
            InitializeComponent();
        }

        private void ShowEmpData_Load(object sender, EventArgs e)
        {
                DbConnection dbCon = new DbConnection();
                DataTable empTable = dbCon.Display();
                dtgEmpDetails.DataSource = empTable;
                ddlEmpId.DataSource = empTable;
                ddlEmpId.DisplayMember = "Id";
                ddlEmpId.ValueMember = "Id";
                
        }


        private void BtnModify_Click(object sender, EventArgs e)
        {
            string id = ddlEmpId.SelectedValue.ToString();
            Update ud = new Update(id);
            this.Close();
            ud.ShowDialog();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDeleteEmployee_Click_1(object sender, EventArgs e)
        {
            DbConnection dbCon = new DbConnection();
            string id = ddlEmpId.SelectedValue.ToString();
            if (dbCon.DeleteEmployee(id))
            {
                LblDeleteMsg.Text = "Deleted SucessFully";
                dtgEmpDetails.DataSource = new BindingSource(dbCon.Display(), null);
                ddlEmpId.DataSource = new BindingSource(dbCon.DisplayId(), null);
            }
        }

    }

        
}