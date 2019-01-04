using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.id = Convert.ToInt32(IDTextBox.Text);
            employee.name = Nametextbox.Text;
            DAL dAL = new DAL();
            dAL.InsertEmployee(employee);
        }
        protected void ViewEmployeesProc(object sender, EventArgs e)
        {
            DAL dAL = new DAL();
            DataTable employeetable = new DataTable();
            employeetable= dAL.getdata();

            GridView1.DataSource = employeetable;
            
        }
    }
}