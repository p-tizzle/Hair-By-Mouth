using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hairByMouth2
{
    public partial class WebUserForm : System.Web.UI.Page
    {
        public object Labell { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text + " " + TextBox4.Text + " ,Thank you for using Hair By Mouth and helping " + TextBox3.Text + 
             " make the world a more beautiful place!";
        }
    }
}