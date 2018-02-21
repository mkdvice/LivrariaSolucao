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
        MySqlConnection con = new MySqlConnection(server = localhost; user id = root; database = cadastro; allowuservariables = True");
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = connectionstring.CreateCommand();            
            MySqlDataAdapter da = new MySqlDataAdapter("select * from livraria_pessoa", connectionstring);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            if dt.Rows.Count(0){
                MessageBox.Show("Usuário ou Senha incorretos");
            }

            
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(server = localhost; user id = root; database = cadastro; allowuservariables = True");
            con.Open()
        }
    }
}
