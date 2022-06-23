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

        string querry = @"INSERT INTO Gestao (dtmData, hHora, txtTitulo, txtDescricao, cboGravidade, cboOperador, txtTurno, ID) Values (@dtmData, @hHora, @txtTitulo, @txtDescricao, @cboGravidade, @cboOperador, @txtTurno, @ID)";

        public int Id { get; }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            DateTime Dat = (DateTime)dtmData.Value;
            DateTime Time = DateTime.ParseExact(mskHora.ToString(),"h:m", System.Globalization.CultureInfo.CurrentCulture);

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.Date).Value = Dat.Date.ToShortDateString();
                    sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.Time).Value = Time.ToShortTimeString();
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.NVarChar).Value = txtTitulo;
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.NVarChar).Value = txtDescricao.Text;
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.NVarChar).Value = cboGravidade.Text;
                    sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.NVarChar).Value = cboOperador.Text;
                    sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.NVarChar).Value = txtTurno.Text;
                    sqlCommand.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = (char)Id;

                    string sql = sqlCommand.ToString();
                    try
                    {
                        sqlCommand.ExecuteNonQuery();

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