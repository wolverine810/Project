using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_SignUp : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoptronixConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        
    }

    protected void Register_Click(object sender, EventArgs e)
    {

        InsertINTODW();

    }

    private void InsertINTODW()
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string query = "INSERT INTO [dbo].[Register]([Firstname],[Lastname],[Emailid],[Mobileno],[Homeno],[State],[Address],[PinCode],[Password])VALUES (@Firstname,@Lastname,@Emailid,@Mobileno,@Homeno,@State,@Address,@PinCode,@Password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
            cmd.Parameters.AddWithValue("@Lastname", lastname.Text);
            cmd.Parameters.AddWithValue("@Emailid", email.Text);
            cmd.Parameters.AddWithValue("@Mobileno", mobileno.Text);
            cmd.Parameters.AddWithValue("@Homeno", homeno.Text);
            cmd.Parameters.AddWithValue("@State", state.Text);
            cmd.Parameters.AddWithValue("@Address", address.Text);
            cmd.Parameters.AddWithValue("@PinCode", pincode.Text);
            cmd.Parameters.AddWithValue("@Password", password.Text);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}