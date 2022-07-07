using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Gestão_de_Ocorrencias
{
    public partial class frmTabelasAdicionais : Form
    {
        private TabControl tabControl;
        private TabPage tabPage;
        public frmTabelasAdicionais()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(connectionString);
        SqlConnection cmd = new SqlConnection();
        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";

        public string ConnetionString { get; internal set; }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Text = tabPage1.Text;
            tabPage1.Text = textbox.Text;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
