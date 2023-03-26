using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the user entered valid credentials
            if (IsValidUser(username, password))
            {
                // Redirect the user to the main page
                Response.Redirect("Main.aspx");
            }
            else
            {
                // Display an error message
                lblError.Text = "Invalid username or password.";
            }
        }
        private bool IsValidUser(string username, string password)
        {
            // TODO: Check if the user is valid using your authentication logic
            // For example, you could check if the username and password match a user in the database
            // or authenticate against an external identity provider.
            // Return true if the user is valid, false otherwise.
        }
    }
}
