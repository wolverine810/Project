using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Reset_Password_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoptronixConnectionString"].ConnectionString);
        try
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "SELECT [id],[Emailid],[Mobileno] FROM [dbo].[Register] where Mobileno=@Mobileno";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Mobileno", mobileno.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Random random = new Random();
                int value = random.Next(1001, 9999);
                string destinationaddr = "91" + mobileno.Text;
                string message = "Your OTP Number is " + value + " ( Sent By : Hariti Study Hub )";
                //Label3.Text = message;
                String message1 = HttpUtility.UrlEncode(message);

                using (var wb = new WebClient())
                {
                    byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                {
                {"apikey" , "rvBOljHv1Gg-cnhm39eZo26sq7oMq4yf2RxtNvmBea"},
                {"numbers" , destinationaddr},
                {"message" , message1},
                {"sender" , "TXTLCL"}
                });
                    string result = System.Text.Encoding.UTF8.GetString(response);
                    Session["otp"] = value;


                }
                Response.Redirect("Home.aspx");

                   
            }
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}