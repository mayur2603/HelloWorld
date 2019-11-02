using System;
using System.Data.SqlClient;
using System.Data;
using DataBaseConstraints;
namespace BasicCrudOperations
{
    class DbConnection
    {
        string _conStr = (new DbConstraints()).ConnectionString;
       
        public bool Insert(Employee e)
        {
            
            string cmdStr = "insert into EmpData(Name,Email,BirthDate,Gender) values (@Name,@Email,@BirthDate,@Gender) ";
            bool status = false;
            try
            {
                SqlConnection con = new SqlConnection(_conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.Add(new SqlParameter("@Name", e.Name));
                cmd.Parameters.Add(new SqlParameter("@Email", e.Email));
                cmd.Parameters.Add(new SqlParameter("@BirthDate", e.BirthDate));
                cmd.Parameters.Add(new SqlParameter("@Gender", e.Gender));

                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                status = true;
                return status;

            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);
            }

            return status;
        }

        public DataTable Display()
        {
           

            using (SqlConnection sqlConn = new SqlConnection(_conStr))
            {
                string sqlQuery = @"SELECT * from EmpData";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
        public bool DeleteEmployee(string id)
        {


            using (SqlConnection Con = new SqlConnection(_conStr))
            {
                bool isDeleted=false;
                string sqlQuery = @"delete from EmpData where id=@id";
                SqlCommand cmd = new SqlCommand(sqlQuery, Con);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                Con.Open();
                if (cmd.ExecuteNonQuery() != 0)
                    isDeleted=true;
                Con.Close();
                return isDeleted;
                
            }
        }
        public bool Update(Employee e,string id)
        {

            string cmdStr = "Update EmpData set Name=@Name,Email=@Email,BirthDate=@BirthDate,Gender=@Gender where id=@id";
            bool status = false;
            try
            {
                SqlConnection con = new SqlConnection(_conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.Add(new SqlParameter("@Name", e.Name));
                cmd.Parameters.Add(new SqlParameter("@Email", e.Email));
                cmd.Parameters.Add(new SqlParameter("@BirthDate", e.BirthDate));
                cmd.Parameters.Add(new SqlParameter("@Gender", e.Gender));
                cmd.Parameters.Add(new SqlParameter("@id", id));

                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                status = true;
                return status;

            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);
            }

            return status;
        }
        public Employee DisplayId(string id)
        {


            using (SqlConnection sqlConn = new SqlConnection(_conStr))
            {
                string sqlQuery = @"SELECT Name,Email,BirthDate,Gender from EmpData where id=@id";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                cmd.Parameters.Add(new SqlParameter("id", id));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                Employee emp;
                emp.
            }
        }
    }
}
