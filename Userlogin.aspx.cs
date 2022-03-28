using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Userlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = " ";
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label2.Text = "Please enter your username and password.";
                return;
            }
            DBConnection dbcon = new DBConnection();
            string sqlstr = "select Password, Name, Name from student where Name='" + TextBox1.Text + "' and Password = "+TextBox2.Text;
            DataSet ds = new DataSet();
            ds = dbcon.getSelect(sqlstr);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Session["id"] = ds.Tables[0].Rows[0]["Password"].ToString();
                Session["name"] = ds.Tables[0].Rows[0]["Name"].ToString();
                Response.Redirect("User.aspx");
            }
            
            if (ds.Tables[0].Rows.Count != 0)
            {
                Session["id"] = ds.Tables[0].Rows[0]["Password"].ToString();
                Session["name"] = ds.Tables[0].Rows[0]["Name"].ToString();
                Response.Redirect("User.aspx");
            }
            Label1.Text = "Wrong username or password! Please try again.";
        }
    }
}