using System;
using System.Collections.Generic;
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


        SqlConnection sqlConnection = new SqlConnection(connectionString);
        SqlConnection cmd = new SqlConnection();
        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";

        public string ConnetionString { get; internal set; }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Adiciona a USStates a uma nova lista 
            List<string> USStates = new List<string>();
            USStates.Add("Alta");
            USStates.Add("Média");
            USStates.Add("Baixa");

            // Adiciona um novo operador a lista
            List<string> Operadores = new List<string>();
            Operadores.Add("Elisio Pereira");

        }
        private object SettingsPage { get; set; }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            TabPage newPage = new TabPage("Turno");
            tabControl1.TabPages.Add(newPage);
            btnAdicionar.Controls.Add(btnAdicionar);
        }

        private void btnAdicionar_ControlAdded(object sender, ControlEventArgs e)
        {
            tabPage1.Controls.Add(btnModificar);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(btnAdicionar);
            tabPage1.Controls.Add(btnRemover);

        }
    }
}
