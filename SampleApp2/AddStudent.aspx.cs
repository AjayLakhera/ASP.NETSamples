using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleApp2
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.RegisterdNumber = NumberBox.Text;
            st.Name = NameBox.Text;
            st.StudentCategory = DropDownList1.SelectedValue;
            if (st.AddStudent() == true)
            {
                LabelAddStudent.Text = "Student Added Successfully.";
            }
            else
            {
                LabelAddStudent.Text = "Student has not added";
            }


        }
    }
}