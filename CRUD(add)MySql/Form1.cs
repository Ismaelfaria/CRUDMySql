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

namespace CRUD_add_MySql
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "datasource=localhost;username=root;password = 123456789; database = db_agenda";
                conn = new MySqlConnection(sql);

                string comandSql = "INSERT INTO contato(nome, email, telefone) " +
                    "VALUES('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "')";
                MySqlCommand comand = new MySqlCommand(comandSql, conn);

                conn.Open();
                comand.ExecuteReader();

                MessageBox.Show("Sucesso");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                conn.Close();
            }

            
          
        }
    }
}
