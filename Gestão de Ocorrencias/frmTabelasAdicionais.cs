using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestão_de_Ocorrencias
{
    public partial class frmTabelasAdicionais : Form
    {
        public frmTabelasAdicionais()
        {
            InitializeComponent();
        }
        public class TabControl : Control
        {

        }

        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
        SqlConnection connection = new SqlConnection(connectionString);
        int currentid;

        private void frmTabelasAdicionais_Load(object sender, EventArgs e)
        {
            connection.Open();
            updatepage();
        }

        string querry = (@"INSERT INTO turno (Turno, ID) Values (@txtTurno, @ID)");
        string querr = (@"INSERT INTO operador (Operador, ID) Values (@cboOperador, @ID)");
        string con = (@"INSERT INTO gravidade (Gravidade, ID) Values (@cboGravidade, @ID)");

        void update()
        {
            DataSet ds = new DataSet();
            string table = "SELECT Turno, [ID] FROM turno";
            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome
            // do produto e a conexão com o banco de dados
            SqlDataAdapter da = new SqlDataAdapter(table, connection);
            da.Fill(ds);
        }

        void updatepage()
        {
            DataSet dset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            querry = "SELECT * FROM turno";
            adapter = new SqlDataAdapter(querry, connectionString);
            adapter.Fill(dset, "a");
            dataGridView1.DataSource = dset.Tables["a"];
            dset = new DataSet();
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            querr = "SELECT * FROM operador";
            adapter2 = new SqlDataAdapter(querr, connectionString);
            adapter2.Fill(dset, "b");
            dataGridView2.DataSource = dset.Tables["b"];
            dset = new DataSet();
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            con = "SELECT * FROM gravidade";
            adapter3 = new SqlDataAdapter(con, connectionString);
            adapter3.Fill(dset, "c");
            dataGridView3.DataSource = dset.Tables["c"];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatepage();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel connectar á base de dados\n" + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (tabControl1.SelectedTab == tabPage1)
            {
                string comand = "SELECT MAX (ID) FROM turno";
                SqlCommand command = new SqlCommand(comand, connection);
                int maxid = (int)command.ExecuteScalar();
                currentid = maxid + 1;

            }

            else if (tabControl1.SelectedTab == tabPage2)
            {
                string conand = "SELECT MAX (ID) FROM operador";
                SqlCommand command = new SqlCommand(conand, connection);
                int maxid = (int)command.ExecuteScalar();
                currentid = maxid + 1;

            }

            else if (tabControl1.SelectedTab == tabPage3)
            {
                string Comand = "SELECT MAX (ID) FROM gravidade";
                SqlCommand command = new SqlCommand(Comand, connection);
                int maxid = (int)command.ExecuteScalar();
                currentid = maxid + 1;

            }

            if (tabControl1.SelectedTab == tabPage1)
            {
                string querry = (@"INSERT INTO turno (Turno, ID) Values (@txtTurno, @ID)");
                SqlCommand a = new SqlCommand(querry, connection);
                a.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = maskedTextBox1.Text;
                a.Parameters.AddWithValue("ID", SqlDbType.Int).Value = currentid;
                try
                {
                    a.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (tabControl1.SelectedTab == tabPage2)
            {
                string querr = (@"INSERT INTO operador (Operador, ID) Values (@cboOperador, @ID)");
                SqlCommand b = new SqlCommand(querr, connection);
                b.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = maskedTextBox1.Text;
                b.Parameters.AddWithValue("ID", SqlDbType.Int).Value = currentid;
                try
                {
                    b.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (tabControl1.SelectedTab == tabPage3)
            { 
                string con = (@"INSERT INTO gravidade (Gravidade, ID) Values (@cboGravidade, @ID)");
                SqlCommand c = new SqlCommand(con, connection);
                c.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = maskedTextBox1.Text;
                c.Parameters.AddWithValue("ID", SqlDbType.Int).Value = currentid;
                try
                {
                    c.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            updatepage();
            connection.Close();
        }
    }
}