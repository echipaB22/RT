using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // afiseaza pentru fiecare postare (titlul, descrierea, imaginea, comentariul)
        
        SqlConnection conexiune1 = new SqlConnection();
        conexiune1.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Caius Buhatel\Documents\Visual Studio 2010\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
        conexiune1.Open();
        string cerere1 = "select titlu, descriere, poza, comentariu from [Postare]";
        SqlCommand cmd1 = new SqlCommand(cerere1, conexiune1);
        SqlDataReader reader = cmd1.ExecuteReader();

        while (reader.Read())
        {
            titlul.InnerHtml = reader[0].ToString();
            descrierea.InnerHtml = reader[1].ToString();
            imaginea.InnerHtml = "<img src=\"." + reader[2].ToString() + "\" height = \"300\">";
            comentariul.InnerHtml = reader[3].ToString();
        }
        conexiune1.Close();



    }
}