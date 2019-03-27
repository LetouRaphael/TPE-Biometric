using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text.RegularExpressions;

namespace Biométrie
{
    public partial class password : Form
    {
        DateTime today = DateTime.Today;

        public password()
        {
            InitializeComponent();
        }


        private void password_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Appuyer sur le bouton pour valider votre identité !";
            
        }

        void pass()
        {
            int id_temp = 999999999;

            try
            {
                String[] ports = SerialPort.GetPortNames();
                comboBox1.Items.AddRange(ports);
                comboBox1.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Problème pour la détection usb, verifié votre branchement USB et réésayer"); }
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine("2");

                    for (int i = 0; i < 2; i++)
                    {
                        textBox1.Text = serialPort1.ReadLine();
                    }
                    id_temp = int.Parse(textBox1.Text);
                    serialPort1.Close();
                }
                catch (TimeoutException)
                {
                    textBox1.Text = "Timeout";
                }

            }

            if (varGlobals.ID == id_temp)
            {


                var connection = new MySqlConnection(inscription.connectionString);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT pass FROM website WHERE url=@urlelement AND login=@loginelement AND ID_finger=@id";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@urlelement", varGlobals.URLelement);
                cmd.Parameters.AddWithValue("@loginelement", varGlobals.LOGINelement);
                cmd.Parameters.AddWithValue("@id", varGlobals.ID);

                var passwd = cmd.ExecuteScalar();

                connection.Close();
                textBox1.Text = passwd.ToString();
                Verifier.Enabled = false;
                Verifier.Visible = false;
            }
            else if (varGlobals.ID != id_temp && id_temp != 999999999)
            {
                string histo = "";
                
                string ip = getExternalIp();
                DateTime today = DateTime.Today;
                string date = today.ToLongDateString();
                
                var connection = new MySqlConnection(inscription.connectionString);
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Nom, Prenom from identite where ID_finger=@id";
                cmd.Parameters.AddWithValue("@id", id_temp);

                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string Nom = Lire["Nom"].ToString();
                        string Prenom = Lire["Prenom"].ToString();
                        histo = Prenom + " " + Nom + " a essaye de consulter vos mots de passes le " + date + " depuis l'adresse IP : " + ip;
                        textBox1.Text = "Desoler " + Prenom + " vous n'avez pas acces a ces mots de passes";
                    }
                }
                
                cmd.CommandText = "UPDATE Identite SET historique = @historique WHERE ID_finger=@id_finger";
                cmd.Parameters.AddWithValue("@historique", histo);
                cmd.Parameters.AddWithValue("@id_finger", varGlobals.ID);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Mauvaise empreinte !");
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void enregistrer_Click(object sender, EventArgs e)
        {
            var connection = new MySqlConnection(inscription.connectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE website SET pass = @pass WHERE ID_finger=@id_finger AND url=@url AND login=@login";
            cmd.Parameters.AddWithValue("@pass", textBox1.Text);
            cmd.Parameters.AddWithValue("@login", varGlobals.LOGINelement);
            cmd.Parameters.AddWithValue("@url", varGlobals.URLelement);
            cmd.Parameters.AddWithValue("@id_finger", varGlobals.ID);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Succes !");
            string date = today.ToShortDateString();
            string histo = "Les identifiants du site " + varGlobals.URLelement + " ont été modifié le " + date + "\r\n" + varGlobals.historique;
            cmd.CommandText = "UPDATE Identite SET historique = @historique WHERE ID_finger=@id_finger";
            cmd.Parameters.AddWithValue("@historique", histo);
            cmd.Parameters.AddWithValue("@id_finger", varGlobals.ID);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void copier_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void verifier_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Posez vote doigt pour valider votre identité";
            pass();
        }

        public static string getExternalIp()
        {
            try
            {
                string externalIP;
                externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                             .Matches(externalIP)[0].ToString();
                return externalIP;
            }
            catch { return null; }
        }
    }
}
