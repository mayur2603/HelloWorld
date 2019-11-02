namespace BasicCrudOperations
{
    partial class ShowEmpData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgEmpDetails = new System.Windows.Forms.DataGridView();
            this.empDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHeading = new System.Windows.Forms.Label();
            this.ddlEmpId = new System.Windows.Forms.ComboBox();
            this.empDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblDeleteEmployee = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.LblDeleteMsg = new System.Windows.Forms.Label();
            this.empDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnModify = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmpDetails
            // 
            this.dtgEmpDetails.AllowUserToAddRows = false;
            this.dtgEmpDetails.AllowUserToDeleteRows = false;
            this.dtgEmpDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpDetails.Location = new System.Drawing.Point(108, 120);
            this.dtgEmpDetails.Name = "dtgEmpDetails";
            this.dtgEmpDetails.ReadOnly = true;
            this.dtgEmpDetails.Size = new System.Drawing.Size(543, 179);
            this.dtgEmpDetails.TabIndex = 0;
            // 
            // empDataBindingSource
            // 
            this.empDataBindingSource.DataMember = "EmpData";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(257, 50);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(241, 31);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Employee Details";
            // 
            // ddlEmpId
            // 
            this.ddlEmpId.FormattingEnabled = true;
            this.ddlEmpId.Location = new System.Drawing.Point(441, 332);
            this.ddlEmpId.Name = "ddlEmpId";
            this.ddlEmpId.Size = new System.Drawing.Size(121, 21);
            this.ddlEmpId.TabIndex = 2;
            // 
            // empDataBindingSource1
            // 
            this.empDataBindingSource1.DataMember = "EmpData";
            // 
            // lblDeleteEmployee
            // 
            this.lblDeleteEmployee.AutoSize = true;
            this.lblDeleteEmployee.Location = new System.Drawing.Point(117, 340);
            this.lblDeleteEmployee.Name = "lblDeleteEmployee";
            this.lblDeleteEmployee.Size = new System.Drawing.Size(204, 13);
            this.lblDeleteEmployee.TabIndex = 3;
            this.lblDeleteEmployee.Text = "Select Employee Id To Delete  or  Update";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(441, 417);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click_1);
            // 
            // LblDeleteMsg
            // 
            this.LblDeleteMsg.AutoSize = true;
            this.LblDeleteMsg.Location = new System.Drawing.Point(347, 445);
            this.LblDeleteMsg.Name = "LblDeleteMsg";
            this.LblDeleteMsg.Size = new System.Drawing.Size(0, 13);
            this.LblDeleteMsg.TabIndex = 6;
            // 
            // empDataBindingSource2
            // 
            this.empDataBindingSource2.DataMember = "EmpData";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(266, 417);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(169, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(108, 418);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 23);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ShowEmpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 467);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.LblDeleteMsg);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.lblDeleteEmployee);
            this.Controls.Add(this.ddlEmpId);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dtgEmpDetails);
            this.Name = "ShowEmpData";
            this.Text = "ShowEmpData";
            this.Load += new System.EventHandler(this.ShowEmpData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmpDetails;
     
        private System.Windows.Forms.BindingSource empDataBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox ddlEmpId;
        private System.Windows.Forms.Label lblDeleteEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label LblDeleteMsg;
        private System.Windows.Forms.BindingSource empDataBindingSource1;
     
        private System.Windows.Forms.BindingSource empDataBindingSource2;
      
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnHome;
    }
}