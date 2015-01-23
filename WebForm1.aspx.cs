using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection cn;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Server=4885d5d6-69ef-4025-905e-a429009c850d.sqlserver.sequelizer.com;Database=db4885d5d669ef4025905ea429009c850d;User ID=fbistyiiwhigoiui;Password=NVzam2RZay8WuMiEMjeapoa4KGvsLhFNYPrtWfcstBQu8D8ojWJwpWezVDxLExo2;");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into userinfo values(@a,@b)", cn);
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
        
            cn.Open();
          int i=  cmd.ExecuteNonQuery();
          if (i > 0)
          {
              Label1.Text = "record inserted succfully";
          }
          else
          {
              Label1.Text = "sorry shktiman..!!!";
          }
            cn.Close();
            Label1.Text = "record inserted succfully";
        }
    }
}
