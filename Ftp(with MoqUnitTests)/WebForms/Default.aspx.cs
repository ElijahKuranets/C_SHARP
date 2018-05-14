using System;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        //Server.Transfer("Result.aspx", true);
        SqlConnection con = new SqlConnection(@"DataSource=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FTP_REGISTER_DATABASE.mdf; Initial Catalog = AspApplication");
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into USER values(@name,@password)", con);
            cmd.Parameters.AddWithValue("name", TextBox1.Text);
            cmd.Parameters.AddWithValue("password", TextBox2.Text);
            cmd.ExecuteNonQuery();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
    }

    //C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FTP_REGISTER_DATABASE.mdf
}