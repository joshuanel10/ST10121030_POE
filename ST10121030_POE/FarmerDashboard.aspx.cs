using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ST10121030_POE
{
    public partial class FarmerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lbluserEmail.Text = Session["userEmail"].ToString();
                
            }
            catch (Exception ex)
            {
            }

           

        }

        protected void btnProdAdd_Click(object sender, EventArgs e)
        {
            string email = lbluserEmail.Text;
            string ID = "";


            SqlConnection con;
            SqlCommand getID;

            con = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");
            getID = new SqlCommand("select FarmerID\r\nfrom Farmers\r\nwhere userEmail = @farmerEmail", con);
            getID.Parameters.Add("@farmerEmail", System.Data.SqlDbType.VarChar).Value = email;
            con.Open();
            SqlDataReader reader1;
            reader1 = getID.ExecuteReader();
            if (reader1.Read())
            {
                ID = reader1.GetValue(0).ToString();
            }

            con.Close();
            reader1.Close();

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Products]
           ([FarmerID]
           ,[ProductName]
           ,[Description]
           ,[Price]
           ,[Quantity])
           
     VALUES
           ('" + Int32.Parse(ID) + "', '" + txtProdName.Text + "', '" + txtDesc.Text + "', '" + Int32.Parse(txtPrice.Text) + "', '"+ Int32.Parse(txtQuantity.Text) +"')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Product Added Succesfully");
            connection.Close();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            Session["userEmail"] = "";
        }
    }
}