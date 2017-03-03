using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using WebSite;
using System.Data.SqlClient;
using System.Configuration;

public partial class Account_Register : Page
{
    Int16 parentOrCaregiver = 0; // 0: Parent, 1: CareGiver
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        try
        {
            if (parentOrCaregiver == 0)
            {
                InsertData("Parent");
            }
            else
            {
                InsertData("CareGiver");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void Parent_CheckedChanged(object sender, EventArgs e)
    {
        parentOrCaregiver = 0;
    }

    protected void CareGiver_CheckedChanged(object sender, EventArgs e)
    {
        parentOrCaregiver = 1;
    }

    private void InsertData(String tableName)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand comm = new SqlCommand();
        conn.Open();
        comm.Connection = conn;
        comm.CommandText = "select count(*) from " + tableName + " where Name='" + UserName.Text + "' and Password='" + Password.Text + "'";
        if (Convert.ToInt32(comm.ExecuteScalar().ToString()) > 0)
            Response.Write("username already exists!");
        else
        {
            comm.CommandText = "insert into " + tableName +" (Name, Password, gender) values ('" + UserName.Text + "', '" + Password.Text + "', 0)";
            int cntParent = comm.ExecuteNonQuery();

            if (cntParent > 0)
                Response.Write(tableName + " added");
        }
        conn.Close();
    }
}