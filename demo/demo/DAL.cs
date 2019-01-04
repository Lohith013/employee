using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace demo
{
    public class DAL
    {
        public void InsertEmployee(Employee employee)
        {
            SqlConnection cn = new SqlConnection("Data Source=DELL-PC;initial catalog=AdventureWorks2008R2 ; User ID=sa;Password=sqlpass;Integrated Security=SSPI;");

            string sqlquery = "insert into EmployeeDetails (Name,Id) values('"+employee.name+"','"+employee.id+"')";
            SqlCommand cmd = new SqlCommand(sqlquery);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable getdata()
        {
            SqlConnection cn = new SqlConnection("Data Source=DELL-PC;initial catalog=AdventureWorks2008R2 ; User ID=sa;Password=sqlpass;Integrated Security=SSPI;");

            cn.Open();
            string sqlquery = "seelct * from employee";
            SqlCommand cmd2 = new SqlCommand( sqlquery);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, cn);

            DataTable employees = new DataTable();
            adapter.Fill(employees);
            return employees;
        }
    }
}