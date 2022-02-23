using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myAspDotnet
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string data = Environment.GetEnvironmentVariable("EMAIL_PASSWORD");
            if (data == null) {
                Label1.Text = "null"; 
            } else { 
                Label1.Text = data; 
            }
        }
    }
}