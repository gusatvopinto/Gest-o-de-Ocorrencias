using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestão_de_Ocorrencias
{
    public partial class Adicionar_Gravidade_ : Form
    {
        public Adicionar_Gravidade_()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
        SqlConnection connection = new SqlConnection(connectionString);
        int currentid;

        private void Adicionar_Gravidade__Load(object sender, EventArgs e)
        {
            connection.Open();
            string comand = "SELECT MAX (ID) FROM gravidade";
            SqlCommand command = new SqlCommand(comand, connection);
            int maxid = (int)command.ExecuteScalar();
            currentid = maxid + 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string querry = @"INSERT INTO gravidade (Gravidade, ID) Values (@cboGravidade, @ID)";
            SqlCommand a = new SqlCommand(querry, connection);
            a.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = textBox1.Text;
            a.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = currentid;
            try
            {
                a.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            this.Close();
        }
    }
}
