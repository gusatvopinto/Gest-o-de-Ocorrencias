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
        SqlConnection cnn = new SqlConnection();

        int currentid;
        int newid;
        int rowsaffected = 0;
            
        public string tipo { get; set; }

        private void adcAdicionar_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = connetionString;
            if (cnn.State == ConnectionState.Closed)
            {
                try
                {
                    cnn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection: ! " + ex.ToString());
                    return; // Retorna o valor
                }
            }
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

            

            string querry = "SELECT MAX ID FROM gestao";
            SqlCommand cmd = new SqlCommand(querry, cnn);
            currentid = (int)cmd.ExecuteScalar();
            newid = currentid + 1;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Inicia a conexão connetionString da base de dados
           

            string querry = "INSERT INTO gestao (dtmData, hHora, txtTitulo, txtDescricao, strGravidade, strOperador, strTurno, ID)" +
            "Values (@dtmData, @hHora, @txtTitulo, @txtDescricao, @cboGravidade, @cboOperador, @txtTurno, @ID)";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    sqlCommand.Parameters.Add("@dtmData", SqlDbType.DateTime).Value = dtmData.Value;
                    sqlCommand.Parameters.Add("@hHora", SqlDbType.DateTime).Value = mskHora.ToString();
                    sqlCommand.Parameters.Add("@txtTitulo", SqlDbType.Text).Value = txtTitulo.ToString();
                    sqlCommand.Parameters.Add("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text.ToString();
                    sqlCommand.Parameters.Add("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text.ToString();
                    sqlCommand.Parameters.Add("@cboOperador", SqlDbType.Text).Value = cboOperador.Text.ToString();
                    sqlCommand.Parameters.Add("@txtTurno", SqlDbType.Text).Value = txtTurno.Text.ToString();
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = newid;

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

                    try
                    {
                        rowsaffected = (int)sqlCommand.ExecuteScalar(); // Executando o comando
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Inserir DocCab: " + ex.ToString());
                        return; // Retorna o valor
                    }
                }

                cnn.Close();
            }
            MessageBox.Show("Ocorrência inserida com sucesso!", "Ocorrencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close(); // Fecha a mensagem
        }
    }
}
