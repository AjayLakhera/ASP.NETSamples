using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleApp2
{
    public partial class EditStudent : System.Web.UI.Page
    {
        int studentId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["Id"]!=null)
            {
                studentId = int.Parse(Request["Id"]);
            }
        }
    }
}