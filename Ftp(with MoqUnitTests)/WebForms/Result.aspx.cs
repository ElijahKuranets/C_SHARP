using System;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.Params["TextBox1"];
        
        Response.Write(Request.Params["TextBox1"]);
    }
}