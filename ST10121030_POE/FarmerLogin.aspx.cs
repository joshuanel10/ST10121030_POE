using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ST10121030_POE
{
    public partial class FarmerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFarmerLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "frm_login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userEmail", txtFarmerEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@userPassword", txtFarmerPassword.Text.ToString());
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    

                    Session["userEmail"] = txtFarmerEmail.Text.ToString();
                    lblLoginSuccess.Text = "Login Succesful!";


                    SqlCommand id = new SqlCommand("SELECT FarmerID FROM [dbo].[Farmers] WHERE userEmail= '" + Session["userEmail"] + "']");
                    Session["FarmerID"] = id.ToString();

                    reader.Close();
                    con.Close();

                    Response.Redirect("~/FarmerDashboard.aspx");


                }
                else
                {
                    reader.Close();
                    con.Close();
                    lblLoginSuccess.Text = "Invalid Credentials";
                }

            }
            catch(Exception ex)
            {

            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            Session["userEmail"] = "";
        }
    }
}