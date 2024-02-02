using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ST10121030_POE
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdminLoginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ad_login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", AdminEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", AdminPass.Text.ToString());
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session["Email"] = AdminEmail.Text.ToString();
                    txtInfo.Text = "Login Successful!";

                    reader.Close();
                    con.Close();

                    Response.Redirect("~/AdminDashboard.aspx");
                }
                else
                {
                    reader.Close();
                    con.Close();
                    txtInfo.Text = "Invalid Credentials";
                }

            }
            catch(Exception ex) 
            {

            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            Session["Email"] = "";
        }
    }
}