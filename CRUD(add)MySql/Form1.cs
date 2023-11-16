


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD_add_MySql
{
    public partial class Form1 : Form
    {
        MySqlConnection ConexaoComMySql;
       
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
                string BDMySql = "datasource=localhost;username=root;password = 123456789; database = db_agenda";
                ConexaoComMySql = new MySqlConnection(BDMySql);

                string ComandInsert = "INSERT INTO contato(nome, email, telefone) " +
                    "VALUES('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "')";
                MySqlCommand comandMysql = new MySqlCommand(ComandInsert, ConexaoComMySql);

                ConexaoComMySql.Open();
                comandMysql.ExecuteReader();

                MessageBox.Show("Sucesso");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexaoComMySql.Close();
            }
        }
    }
}
