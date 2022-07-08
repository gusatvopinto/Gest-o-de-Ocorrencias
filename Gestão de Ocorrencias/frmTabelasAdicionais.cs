using System;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

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
        public string Turno { get; set; }
        public System.Collections.IEnumerable ItemsSource { get; set; }

        SqlConnection cmd = new SqlConnection();
        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public string ConnetionString { get; internal set; }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void frmTabelasAdicionais_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnetionString);

        }

        string querry = (@"INSERT INTO turno (Turno, ID) Values (@txtTurno, @ID)");

        void update()
        {
            // Inicia o dataset
            DataSet ds = new DataSet();
            string table = "SELECT Turno, [ID] FROM turno";
            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome
            // do produto e a conexão com o banco de dados
            SqlDataAdapter da = new SqlDataAdapter(table, cmd);
            da.Fill(ds);
            MessageBox.Show(listView1.Text);
        }
       
        private void tabPage1_Click(object sender, EventArgs e)
        {
            DataSet dset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            querry = "SELECT [Turno], [ID] FROM turno" ;
            adapter = new SqlDataAdapter(querry, connectionString);
            adapter.Fill(dset, "tabled");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPage1.Text = tabControl1.SelectedIndex.ToString();
        }

    }
}