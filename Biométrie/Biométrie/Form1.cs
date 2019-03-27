///Ligne 115 a Verifier

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Biométrie
{
   
    public partial class Form1 : Form
    {
        DateTime today = DateTime.Today;
        
        int id = varGlobals.ID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qui();
            
            afficher();
        }
        private void afficher()
        {
            var connection = new MySqlConnection(inscription.connectionString);
            connection.Open();
            listView1.Items.Clear();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM website where ID_finger=@id";
            cmd.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string url = Lire["url"].ToString();
                    string login = Lire["login"].ToString();
                    string pass = Lire["pass"].ToString();
                    string mask = "";
                    long pwdCount = pass.LongCount();
                    for (int i = 0; i < pass.LongCount(); i++){mask = mask + "*";}
                    
                    listView1.Items.Add(new ListViewItem(new[] { url, login, mask }));
                }
            }
            connection.Close();
        }

        private void qui()
        {
            var connection = new MySqlConnection(inscription.connectionString);
            connection.Open();
            listView1.Items.Clear();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Memo, historique, Prenom from identite where ID_finger=@id";
            cmd.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string memo = Lire["Memo"].ToString();
                    string historique = Lire["historique"].ToString();
                    string Prenom = Lire["Prenom"].ToString();
                    textBox1.Text = memo;
                    historiquetxt.Text = historique;
                    lb_prenom.Text = Prenom;
                }
            }
            connection.Close();
        }

        #region Menu
        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ligne();
            var connection = new MySqlConnection(inscription.connectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "DELETE FROM website WHERE url=@url AND login=@login AND ID_finger=@idf";


            cmd.Parameters.AddWithValue("@idf", id);
            cmd.Parameters.AddWithValue("@url", varGlobals.URLelement);
            cmd.Parameters.AddWithValue("@login", varGlobals.LOGINelement);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Suppression reussi ! ");
            afficher();

            // HiSTORIQUE
            string date = today.ToShortDateString();
            string histo = "Les identifiants du site " + varGlobals.URLelement + " ont été supprimé le " + date + "\r\n" + historiquetxt.Text;
            cmd.CommandText = "UPDATE Identite SET historique = @historique WHERE ID_finger=@id_finger";
            cmd.Parameters.AddWithValue("@historique", histo);
            cmd.Parameters.AddWithValue("@id_finger", varGlobals.ID);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varGlobals.historique = historiquetxt.Text;
            Ajout fen_ajout = new Ajout();
            fen_ajout.Show();
            fen_ajout.TopLevel = true;
            
        }

        private void ligne()
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem element = listView1.SelectedItems[0];
                varGlobals.URLelement = element.SubItems[0].Text;
                varGlobals.LOGINelement = element.SubItems[1].Text;
                varGlobals.ligne = "true";

            }
            else
            {
                MessageBox.Show("Aucune ligne selectionner !");
                varGlobals.ligne = "false";
            }
        }

        private void motDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ligne();
            varGlobals.historique = historiquetxt.Text;
            if (varGlobals.ligne == "true")
            {
                password fen_pass = new password();
                fen_pass.Show();
                fen_pass.TopMost = true;
            }
            else if (varGlobals.ligne == "false")
            {
                MessageBox.Show("Aucune ligne selectionner !");
            }
            else
            {
                MessageBox.Show("BUG !");
            }
        }

        private void allerAuSiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem element = listView1.SelectedItems[0];
                string URLelement = element.SubItems[0].Text;

                Process p = new Process();
                p.StartInfo.FileName = URLelement;
                try { p.Start();}
                catch (Exception)
                {
                    MessageBox.Show("Problème ouverture du lien");
                }
            }
            else
            {
                MessageBox.Show("Aucune ligne selectionner !");
            }
        }
        #endregion
        
        private void bt_enregistrer_Click_1(object sender, EventArgs e)
        {
            var connection = new MySqlConnection(inscription.connectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Identite SET Memo = @memo WHERE ID_finger=@id_finger";
            cmd.Parameters.AddWithValue("@memo", textBox1.Text);
            cmd.Parameters.AddWithValue("@id_finger", varGlobals.ID);

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Succes");
        }

        private void vider_Click(object sender, EventArgs e)
        {
                string date = today.ToShortDateString();

                var connection = new MySqlConnection(inscription.connectionString);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE Identite SET historique = @histo WHERE ID_finger=@id_finger";
                cmd.Parameters.AddWithValue("@histo", "Historique vidé le " + date);
                cmd.Parameters.AddWithValue("@id_finger", varGlobals.ID);

                cmd.ExecuteNonQuery();
                connection.Close();

                qui();
                afficher();
        }

        private void actualiserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qui();
        }
    }

}
