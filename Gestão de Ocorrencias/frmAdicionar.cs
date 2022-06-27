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
        public int Id { get; set; }
        private void btnGravar_Click(object sender, EventArgs e)
        {



            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.Date).Value = dtmData.Value;
                    sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.DateTime2).Value = hHora.Value;
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo.Text;
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text;
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text;
                    sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text;
                    sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text;
                    sqlCommand.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Id;

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