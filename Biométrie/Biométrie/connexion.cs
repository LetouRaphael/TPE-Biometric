using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biométrie
{
    public partial class connexion : Form
    {
        public int id = 99;
       


        public connexion()
        {
            InitializeComponent();
        }

        private void connexion_Load(object sender, EventArgs e)
        {
            try
            {
                String[] ports = SerialPort.GetPortNames();
                combousb.Items.AddRange(ports);
                combousb.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Problème pour la détection usb, verifié votre branchement USB et réésayer"); this.Close(); }
            
        }

        private void bt_ouvrir_Click(object sender, EventArgs e)
        {

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
                    serialPort1.WriteLine("2");
                    serialPort1.WriteLine("2");

                    for (int i = 0; i < 2; i++)
                    {
                        textBox1.Text = serialPort1.ReadLine();
                    }
                    id = int.Parse(textBox1.Text);
                    varGlobals.ID = id;
                    textBox1.Text = "Connexion en cours";
                    


                    var connection = new MySqlConnection(inscription.connectionString);
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT COUNT(*) FROM identite where ID_finger=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    var result = cmd.ExecuteScalar();
                    if (result.ToString() == "1")
                    {
                        Form1 main_page = new Form1();
                        main_page.Show();
                        main_page.TopLevel = true;
                        
                    }
                    bt_ouvrir.Enabled = true;
                    serialPort1.Close();
                    connection.Close();
                }
                catch (TimeoutException)
                {
                    textBox1.Text = "Timeout";
                }
                
            }
        }

        private void bt_inscription_Click(object sender, EventArgs e)
        {
            inscription fen_inscription = new inscription();
            fen_inscription.Show();
            fen_inscription.TopLevel = true;
        }
    }

    public static class varGlobals
    {
        public static int ID;
        public static string URLelement;
        public static string LOGINelement;
        public static string ligne;
        public static string historique;
    }

}
