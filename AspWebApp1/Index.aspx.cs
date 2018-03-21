using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebApp1
{
    public partial class Index : System.Web.UI.Page
    {
        //Dictionary<string, string> mimagelist = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // DDFavList1.Items.Add("Agnipath");
            // DDFavList1.Items.Add("Shole");
            /// DDFavList1.Items.Add("xyz");
            /// 

            //mimagelist.Add("Agnipath", "https://images.pexels.com/photos/120049/pexels-photo-120049.jpeg");
            //mimagelist.Add("Agnipath", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;

            string favsongs = "";
            
            foreach(ListItem li in LBSongs.Items)
            {
                if(li.Selected)
                {
                    favsongs +="</br>" + li.Text; 
                }
            }

            if (!string.IsNullOrEmpty(name))
            {
                if (DDFavList1.SelectedIndex > 0)
                {
                    Display.ForeColor = Color.Blue;
                    string moviename = DDFavList1.SelectedValue;
                    Display.Text = $"Hello, {name}, you choose {moviename} as your choice"+
                        $"And your fav songs are </br> {favsongs}";
                }
                else
                {
                    Display.ForeColor = Color.Red;
                    Display.Text = $"Hello, {name}, Please select a movie from list";

                    
                }
            }
            else
            {
                Display.ForeColor = Color.Red;
                Display.Text = "Please Enter a name";

            }

            

        }

        protected void DDFavList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           // throw new Exception("Something went wrong!!");
        }
    }
}