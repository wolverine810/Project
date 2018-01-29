using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_MasterPage : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoptronixConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login_Click(object sender, EventArgs e)
    {
        try
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "SELECT [id],[Emailid],[Password] FROM [dbo].[Register] where EmailId=@EmailId and password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmailId", email.Text);
            cmd.Parameters.AddWithValue("@password", psw.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (email.Text == dr["Emailid"].ToString() && psw.Text == dr["Password"].ToString())
                    {

                        //Session["username"] = dr["Emailid"].ToString();
                        //Session["Name"] = dr["Name"].ToString();
                        Response.Redirect("User_SignUp.aspx");

                    }
                    else
                    {
                        string display = "Invalid Username and Password";
                        conn.Close();
                    }
                }
            }
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
