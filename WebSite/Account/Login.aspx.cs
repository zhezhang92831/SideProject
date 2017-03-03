using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;

public partial class Account_Login : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void LogIn(object sender, EventArgs e)
    {
        if (IsValid)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string commTxtParent = "select count(*) from Parent where Name='" + UserName.Text + "' and Password='" + Password.Text + "'";
                string commTxtCareGiver = "select count(*) from CareGiver where Name='" + UserName.Text + "' and Password='" + Password.Text + "'";
                SqlCommand comm = new SqlCommand();
                try
                {
                    conn.Open();
                    comm.Connection = conn;

                    comm.CommandText = commTxtParent;
                    int cntParent = Convert.ToInt32(comm.ExecuteScalar().ToString());

                    comm.CommandText = commTxtCareGiver;
                    int cntCareGiver = Convert.ToInt32(comm.ExecuteScalar().ToString());

                    conn.Close();

                    if (cntParent > 0)
                        Response.Write("Parent Login");
                    else if (cntCareGiver > 0)
                        Response.Write("CareGiver Login");
                    else
                    {
                        UserName.Text = "";
                        Password.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}