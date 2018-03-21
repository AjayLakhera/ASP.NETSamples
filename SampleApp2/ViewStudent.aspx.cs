using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SampleApp2
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Student st = new Student();
            //st.GetStudent();

            //string namelist="";
            //foreach(Student s in Student.list)
            //{
            //    namelist += s.Name + "</br>";
            //}
            ////GetStudentList.Controls.Add(namelist);

            StudentDataGrid.DataSource = Student.GetDataList();
            StudentDataGrid.DataBind();
        }
    }
}