using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Gestão_de_Ocorrencias
{
    public partial class adcAdicionar : Form
    {
        public adcAdicionar()
        {
            InitializeComponent();
        }

        private string connetionString = (@"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=testes");
        SqlConnection Connection = new SqlConnection();

        public string tipo { get; set; }

        private void adcAdicionar_Load(object sender, EventArgs e)
        {
            // Adiciona a USStates a uma nova lista 
            List<string> USStates = new List<string>();
            USStates.Add("Alta");
            USStates.Add("Média");
            USStates.Add("Baixa");

            // Adiciona um novo operador a lista
            List<string> Operadores = new List<string>();
            Operadores.Add("Elisio Pereira");

            cboGravidade.DataSource = USStates;
            cboOperador.DataSource = Operadores;

            dtmData.Culture = CultureInfo.CurrentCulture;

        }

        string querry = @"INSERT INTO Gestao (dtmData, hHora, txtTitulo, txtDescricao, cboGravidade, cboOperador, strTurno, ID) Values (@dtmData, @hHora, @txtTitulo, @txtDescricao, @cboGravidade, @cboOperador, @txtTurno, @ID)";
        int Id;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Inicia a conexão connetionString da base de dados

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.Time).Value = dtmData.Value;
                    sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.Time).Value = mskHora.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = ((char)Id);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    SqlCommand command = new SqlCommand(sqlCommand.ToString(), connection);

                    string sql = sqlCommand.ToString();
                    try
                    {
                        TimeSpan durtime = TimeSpan.Parse(querry.ToString());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Informação Adicionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
            MessageBox.Show("Ocorrência inserida com sucesso: !", "Ocorrência", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close(); // Fecha a mensagem
        }
    }
}