using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;

namespace ST10121030_POE
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txtAdminEmail.Text = "Welcome " + Session["Email"].ToString();
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnFarmerCreate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Farmers]
           ([userFirstName]
           ,[userLastName]
           ,[userEmail]
           ,[PhoneNumber]
           ,[Address]
           ,[userPass])
           
     VALUES
           ('" + txtfrmName.Text + "', '" + txtfrmSurname.Text + "', '" + txtfrmEmail.Text + "', '" + txtfrmPhone.Text + "', '" + txtAddress.Text + "', '" + txtfrmPassword.Text + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Farmer Added Succesfully");
            connection.Close(); 
        }

        protected void btnFarmerSearch_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");

            string farmer = txtFarmerSearch.Text;

            SqlCommand productSearch = new SqlCommand("SELECT\r\n    P.ProductID,\r\n    P.ProductName,\r\n    P.Description,\r\n    P.Price,\r\n    P.Quantity\r\nFROM\r\n    Farmers F\r\nJOIN\r\n    Products P ON F.FarmerID = P.FarmerID\r\nWHERE\r\n    F.userEmail = @farmerEmail;", connection);
            productSearch.Parameters.Add("@farmerEmail", System.Data.SqlDbType.VarChar).Value = farmer;
            SqlDataAdapter adapter = new SqlDataAdapter(productSearch);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ProductView.DataSource = dt;
            ProductView.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            Session["Email"] = "";
        }
    }
}