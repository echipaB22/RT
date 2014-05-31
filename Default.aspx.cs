using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["username"] = "CaiusAndrei"; 

        //Se verifica daca Session["username"] este diferit de null, altfel redirect pe prima pagina
        if (Session["username"] == null)
            Response.Redirect(""); // alegeti o pagina
    }

    protected void Button1_Click(object sender, EventArgs e) // adauga in baza de date in tabelul Postare (titlu, descriere, fotografii);
    {
        bool ok = true;

        if (titlul.Text == "")
        {
            MesajTitlu.InnerText = "Titlul trebuie completat!";
            ok = false;
        }
        else 
        {
            MesajTitlu.InnerText = "";
        }

        if (descrierea.Text == "")
        {
            MesajDescriere.InnerHtml = "Trebuie sa existe o descriere!";
            ok = false;
        }
        else
        {
            MesajDescriere.InnerHtml = "";
        }

        if (poza.HasFile)
        {
            if (ok == true)
            {

                string fileName = Path.GetFileName(poza.PostedFile.FileName);
                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Caius Buhatel\Documents\Visual Studio 2010\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
                con2.Open(); string query2 = "SELECT IDENT_CURRENT('Imagini')";
                SqlCommand cmd2 = new SqlCommand(query2, con2);
                int id = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                con2.Close();

                string cale = null;
                string cale2 = null;
                bool corect = false;
                if (fileName.IndexOf(".jpg", 0) > -1)
                {
                    corect = true;
                    cale = Server.MapPath("~/Imagini/") + (id + 1).ToString() + ".jpg";
                    cale2 = "/Imagini/" + (id + 1).ToString() + ".jpg";
                }

                if (fileName.IndexOf(".jpeg", 0) > -1)
                {
                    corect = true;
                    cale = Server.MapPath("~/Imagini/") + (id + 1).ToString() + ".jpeg";
                    cale2 = "/Imagini/" + (id + 1).ToString() + ".jpeg";
                }

                if (fileName.IndexOf(".gif", 0) > -1)
                {
                    corect = true;
                    cale = Server.MapPath("~/Imagini/") + (id + 1).ToString() + ".gif";
                    cale2 = "/Imagini/" + (id + 1).ToString() + ".gif";
                }

                if (corect == true)
                {
                    SqlConnection conexiune1 = new SqlConnection();
                    conexiune1.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Caius Buhatel\Documents\Visual Studio 2010\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
                    conexiune1.Open();
                    string cerere1 = "select id_utilizator from [Utilizator] where nume ='"+Session["username"]+"'";
                    SqlCommand cmd1 = new SqlCommand(cerere1, conexiune1);
                    int id_ut = (int)cmd1.ExecuteScalar();
                    conexiune1.Close();



                    MesajFotografie.InnerHtml = "";
                    poza.PostedFile.SaveAs(cale);

                    SqlConnection conexiune = new SqlConnection();
                    conexiune.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Caius Buhatel\Documents\Visual Studio 2010\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
                    conexiune.Open();
                    String cerere = "INSERT INTO [Postare] (nume_utilizator,comentariu,poza,id_utilizator,titlu,descriere) VALUES (@nume_u,@coment,@img,@id_u,@titlul,@descrierea)";
                    SqlCommand cmd = new SqlCommand(cerere, conexiune);
                    cmd.Parameters.Add(new SqlParameter("@nume_u", Session["username"]));
                    cmd.Parameters.Add(new SqlParameter("@coment", ""));
                    cmd.Parameters.Add(new SqlParameter("@img", cale2));
                    cmd.Parameters.Add(new SqlParameter("@id_u", id_ut));
                    cmd.Parameters.Add(new SqlParameter("@titlul", titlul.Text));
                    cmd.Parameters.Add(new SqlParameter("@descrierea", descrierea.Text));
                    cmd.ExecuteNonQuery();
                    conexiune.Close();
                }
                else
                {
                    MesajFotografie.InnerHtml = "Trebuie incarcat un thumbnail in format .jpg, .jpeg sau .gif!";
                }

            }
        }
    }
}