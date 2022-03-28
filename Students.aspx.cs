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
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            sqlstr = "select ID,Name,Lastname,Department from student";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, connectionString);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
    }
}