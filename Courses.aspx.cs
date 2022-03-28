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
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            DataSet ds = new DataSet();
            string sqlstr;
            sqlstr = "Select * from Courses";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, connectionString);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection con;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            String sqlstr = "Insert into Courses(Credits,Course,Coursecode) values('" + TextBox3.Text +
            "','" + TextBox1.Text + "'," + TextBox2.Text  + ")";
            try
            {
                SqlCommand exec = new SqlCommand(sqlstr, con);
                exec.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception) { throw; }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection con;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            String sqlstr = "Delete from Courses where Coursecode='" + TextBox2.Text + "'";
            try
            {
                SqlCommand exec = new SqlCommand(sqlstr, con);
                exec.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }










        protected void Button4_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            DataSet ds = new DataSet();
            string sqlstr;
            sqlstr = "Select * from Courses";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, connectionString);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
    }
}