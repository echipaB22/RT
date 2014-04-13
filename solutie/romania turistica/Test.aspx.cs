using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class romania_turistica_Test : System.Web.UI.Page
{
    static int scor = 0;
    static int nr = 0;
    Random rnd = new Random();
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = rnd.Next(1,20);
        Label1.Visible = true;
        RadioButton1.Visible = true;
        RadioButton2.Visible = true;
        RadioButton3.Visible = true;
        RadioButton4.Visible = true;
        ButtonIntrebareaUrmatoare.Visible = true;
        
        SqlConnection conn;
        SqlCommand comanda;
        string query;
        SqlDataReader reader;
        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETDB"].ConnectionString);
        comanda = new SqlCommand();
        comanda.Connection = conn;
        //   comanda.Connection.Open();

            comanda.Connection.Open();
            query = "select Intrebare, Raspuns1, Raspuns2, Raspuns3, Raspuns4 from aspnet_Intrebari where Id = '" + i + "'";
            comanda.CommandText = query;
            reader = comanda.ExecuteReader();
            string p1 = null;
            string r1 = null;
            string r2 = null;
            string r3 = null;
            string r4 = null;
            while (reader.Read())
            {
                try
                {
                    p1 = reader.GetValue(0).ToString();
                    Label1.Text = p1;
                    r1 = reader.GetValue(1).ToString();
                    RadioButton1.Text = r1;
                    r2 = reader.GetValue(2).ToString();
                    RadioButton2.Text = r2;
                    r3 = reader.GetValue(3).ToString();
                    RadioButton3.Text = r3;
                    r4 = reader.GetValue(4).ToString();
                    RadioButton4.Text = r4;
                }
                catch (Exception err)
                {
                    Response.Write("EROARE PARSARE SQL");
                }
            }
            conn.Close();
            if (RadioButton1.Checked == true) scor = scor + 1;
            else if (RadioButton2.Checked == true) scor = scor + 2;
            else if (RadioButton3.Checked == true) scor = scor + 3;
            else if (RadioButton4.Checked == true) scor = scor + 4;
            nr++;
        }
    protected void ButtonIntrebareaUrmatoare_Click(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
        int i = rnd.Next(nr + 1, 20);
        SqlConnection conn;
        SqlCommand comanda;
        string query;
        SqlDataReader reader;
        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPNETDB"].ConnectionString);
        comanda = new SqlCommand();
        comanda.Connection = conn;
        //   comanda.Connection.Open();

        comanda.Connection.Open();
        query = "select Intrebare, Raspuns1, Raspuns2, Raspuns3, Raspuns4 from aspnet_Intrebari where Id = '" + i + "'";
        comanda.CommandText = query;
        reader = comanda.ExecuteReader();
        string p1 = null;
        string r1 = null;
        string r2 = null;
        string r3 = null;
        string r4 = null;
        while (reader.Read())
        {
            try
            {
                p1 = reader.GetValue(0).ToString();
                Label1.Text = p1;
                r1 = reader.GetValue(1).ToString();
                RadioButton1.Text = r1;
                r2 = reader.GetValue(2).ToString();
                RadioButton2.Text = r2;
                r3 = reader.GetValue(3).ToString();
                RadioButton3.Text = r3;
                r4 = reader.GetValue(4).ToString();
                RadioButton4.Text = r4;
            }
            catch (Exception err)
            {
                Response.Write("EROARE PARSARE SQL");
            }
        }
        conn.Close();
        if (RadioButton1.Checked == true) scor = scor + 1;
        else if (RadioButton2.Checked == true) scor = scor + 2;
        else if (RadioButton3.Checked == true) scor = scor + 3;
        else if (RadioButton4.Checked == true) scor = scor + 4;
        if (nr >= 5)
        {
            ButtonIntrebareaUrmatoare.Visible = false;
            ButtonTerminaTest.Visible = true;

        }
    }
    protected void ButtonTerminaTest_Click(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Label3.Visible = false;
        ButtonTerminaTest.Visible = false;
        ButtonIntrebareaUrmatoare.Visible = false;
        Label1.Visible = false;
        RadioButton1.Visible = false;
        RadioButton2.Visible = false;
        RadioButton3.Visible = false;
        RadioButton4.Visible = false;
        ButtonIntrebareaUrmatoare.Visible = false;
        if (scor <= 7)
        {
            Label2.Text = "Esti	 o persoana romantica si calma, care iubeste linistea si natura. Potrivit caracteristicilor tale iti sugeram sa descoperi statiunea Paltinis, Laguna Albastra din Judetul Cluj sau statiunea Costinesti, unde poti vedea cel mai frumos rasarit de soare.";
        }
        else if (scor > 7 && scor <= 12)
        {
            Label2.Text = "Esti o persoana vesela si prietenoasa, iubesti aventura si plimbarile in natura. Iti recomandam sa vizitezi cea mai inalta sosea din tara, Transalpina, minunatul Transfagarasan si Poiana Brasov. Defileul Dunarii s-ar putea, de asemenea, sa te fascineze.";
        }
        else if (scor > 12 && scor <= 16)
        {
            Label2.Text = "Esti o persoana creativa si sociabila. Iti place confortul dar asta nu inseamna ca refuzi categoric o excursie spontana. Nu ar trebui sa ratezi ocazia de a vizita Platoul Bucegi sau statiunea Neptun. Gradina Zoologica din Sibiu este, de asemenea, un loc superb pe care l-ai putea vizita.";
        }
        else
        {
            Label2.Text = "Esti o persoana cocheta, nonconformista si careia ii place sa se distreze. Iti recomandam sa vizitezi orasul Brasov, statiunea Mamaia si, in mod special, capitala Romaniei, Bucuresti!";
        }
    }
    }
