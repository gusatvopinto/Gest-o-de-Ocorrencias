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
    public partial class Modificar_Turno_ : Form
    {
        public Modificar_Turno_()
        {
            InitializeComponent();
        }

        public int ID { get; set; }
        string idnow;

        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
        SqlConnection connection = new SqlConnection(connectionString);

        private void Modificar_Turno__Load(object sender, EventArgs e)
        {
            connection.Open();
            idnow = ID.ToString();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE turno SET Turno = @txtTurno WHERE ID = " + idnow;
            SqlCommand a = new SqlCommand(querry, connection);
            a.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = textBox1.Text;
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
