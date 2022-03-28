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
    public partial class Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

       
            if (IsPostBack == false)
            {
                DBConnection dbcon = new DBConnection();
                DataSet ds = new DataSet();
                ds = dbcon.getSelect("select Name +' '+Lastname as name,ID from student ORDER BY Name,Lastname");
                DropDownList2.DataTextField = ds.Tables[0].Columns["name"].ToString();

               // DropDownList2.DataValueField = ds.Tables[0].Columns[" ID"].ToString();
                DropDownList2.DataSource = ds.Tables[0]; 
                DropDownList2.DataBind(); 
                DropDownList2.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                DropDownList2.SelectedIndex = 0;

                PopulateCheckList();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DBConnection dbcon = new DBConnection();
            DataSet ds = new DataSet();
            string sqlstr;
            sqlstr = "select Name +' '+ Lastname as Name, Projects from student where ID =191805067"; //+DropDownList2.SelectedItem.Value; 
            ds = dbcon.getSelect(sqlstr);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            
          
        }


        private void PopulateCheckList()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager
                .ConnectionStrings["conStr"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT Lecturers from lectures ";
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = sdr["Lecturers"].ToString();
                           // item.Value = sdr["cCode"].ToString();
                            item.Selected = false;

                            CheckBoxList1.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = " ";
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                    Label2.Text = " Your lecturer is : " + item.Text + Label2.Text;
            }
        }
    }
}














