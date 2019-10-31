using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HPIT.Three.BookStore.Bll;
using HPIT.Three.BookStore.Model;

namespace HPIT.Three.BookStore.UI
{
    public partial class Login : System.Web.UI.Page
    {
        private UsersBll bll = new UsersBll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Users user = bll.Sel(TextBox1.Text, TextBox2.Text).FirstOrDefault(u => u.UsersAccount == TextBox1.Text);


            if (user != null && user.UsersPassword == TextBox2.Text)
            {
                Response.Write("<script>alert('s')</script>");
            }
            else 
            {
                Response.Write("<script>alert('!!!')</script>");
                return;
            }
        }
    }
}