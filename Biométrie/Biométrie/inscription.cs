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
using System.IO.Ports;

namespace Biométrie
{
    public partial class inscription : Form
    {
        public static string connectionString = "SERVER=127.0.0.1; DATABASE=logs; UID=root; PASSWORD=";
        public inscription()
        {
            InitializeComponent();
        }
        int id = 99;

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                String[] ports = SerialPort.GetPortNames();
                combousb.Items.AddRange(ports);
                combousb.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Problème pour la détection usb, verifié votre branchement USB et réésayer"); }
            try
            {
                serialPort1.PortName = combousb.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
       

        private void valider_Click(object sender, EventArgs e)
        {
            if (id == 99)
            {
                MessageBox.Show("Aucune empreinte n'a été corectement enregisté");
            }

            else if (nom.Text == "" || prenom.Text == "")
            {
                MessageBox.Show("Le nom ou le prenom n'a pas été rempli correctement");
            }

            else
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO identite (ID_finger, Nom, Prenom) VALUES (@id, @nom, @prenom)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nom", nom.Text);

                cmd.Parameters.AddWithValue("@prenom", prenom.Text);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Inscription reussi ! ");
                this.Close();


            }
            
        }

        private void bt_ouvrir_Click(object sender, EventArgs e)
        {
            bt_ouvrir.Enabled = false;
            try
            {
                serialPort1.PortName = combousb.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Le port est ouvert");
                try
                {
                    serialPort1.WriteLine("1");

                    for (int i = 0; i < 7; i++)
                    {
                        textBox1.Text = serialPort1.ReadLine();
                    }

                    try {id = int.Parse(textBox1.Text);}
                    catch (System.FormatException) { textBox1.Text = serialPort1.ReadLine(); }
                    textBox1.Text = serialPort1.ReadLine();
                    if (!serialPort1.IsOpen)
                    {
                        try
                        {
                            serialPort1.Close();
                            bt_ouvrir.Enabled = true;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Problème fermeture du port");
                        }
                    }
                }
                catch (TimeoutException)
                {
                    textBox1.Text = "Timeout";
                }

            }
        }

    }
        
}
