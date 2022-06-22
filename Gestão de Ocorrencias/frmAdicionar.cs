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
        string connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS; Initial Catalog=testes; Integrated Security=true; User ID=testes; Password=testes";

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

        string newID;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Inicia a conexão connetionString da base de dados

            string querry = @"INSERT INTO Gestao (dtmData, hHora, txtTitulo, txtDescricao, strGravidade, strOperador, strTurno, ID)" +
            "Values (@dtmData, @hHora, @txtTitulo, @txtDescricao, @cboGravidade, @cboOperador, @txtTurno, @ID)";

            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(querry, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.DateTime).Value = dtmData.Value;
                    sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.DateTime).Value = mskHora.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text.ToString();
                    sqlCommand.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = newID;

                    SqlCommand command = new SqlCommand(sqlCommand.ToString(), conn);

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
                conn.Close();
            }
            MessageBox.Show("Ocorrência inserida com sucesso: !", "Ocorrências", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close(); // Fecha a mensagem
        }
    }
}