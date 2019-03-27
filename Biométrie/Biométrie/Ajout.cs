using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biométrie
{
    public partial class Ajout : Form
    {
        int id = varGlobals.ID;
        public Ajout()
        {
            InitializeComponent();
        }
        DateTime today = DateTime.Today;
        

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = new MySqlConnection(inscription.connectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "INSERT INTO website (login, pass, url, ID_finger) VALUES (@login, @pass, @url, @ID_finger)";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@login", identTXT.Text);
            cmd.Parameters.AddWithValue("@pass", passTXT.Text);
            cmd.Parameters.AddWithValue("@url", URLTXT.Text);
            cmd.Parameters.AddWithValue("@ID_finger", id);

            cmd.ExecuteNonQuery();

            string date = today.ToShortDateString();
            string histo = "Des identifiants ont été ajouté pour le site : " + URLTXT.Text + " le " + date + "\r\n" + varGlobals.historique;
            cmd.CommandText = "UPDATE Identite SET historique = @historique WHERE ID_finger=@id_finger";
            cmd.Parameters.AddWithValue("@historique", histo);

            cmd.ExecuteNonQuery();

            connection.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
