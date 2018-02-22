using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LivrariaSolucao
{
    public partial class Form1 : Form
    {
        private string conn;
        private MySqlConnection connect;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void db_connection()
        {
            try
            {
                conn = "User Id=root;Host=localhost;Pooling=False;Character Set=utf8";
                connect = new MySqlConnection(conn);
                connect.Open();
            }

            catch (MySqlException e)
            {
                throw;
            }
        }

        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from livraria_pessoa where nomepessoa=@user and senha=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Campos vazios! Por favor preencha todos os campos");
                return;
            }

            bool r = validate_login(user, pass);
            if (r)
                MessageBox.Show("Login efetuado com sucesso");
            else
                MessageBox.Show("Usuário ou senha incorretos");

            
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

