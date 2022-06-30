using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;


namespace Gestão_de_Ocorrencias
{
    public partial class adcModificar : Form
    {
        public adcModificar()
        {
            InitializeComponent();
        }
        public string ConnetionString { get; set; }
        public string tipo { get; set; }

        public Int32 codigoreg;

        private void adcModificar_Load(object sender, EventArgs e)
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

            DateTime time = DateTime.Now;

            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=testes";
            cnn = new SqlConnection(connetionString);
            int rowsaffected = 0;
            try
            {
                cnn.Open();// Abre a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: ! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TimeSpan dt = DateTime.Parse(hHora.Value.ToString()).TimeOfDay;
            SqlCommand sqlCommand = new SqlCommand("UPDATE ocorrencia SET  Data = @dtmData, Hora = @hHora, Titulo = @txtTitulo, " +
            "Descricao = @txtDescricao, Gravidade = @cboGravidade, Operador = @cboOperador, Turno = @txtTurno, where ID = " + codigoreg, cnn);

            sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.Date).Value = dtmData.Value;
            sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.Text).Value = dt.ToString();
            sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo.Text;
            sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text;
            sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text;
            sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text;
            sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text;
            sqlCommand.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Id;

            try
            {
                rowsaffected = sqlCommand.ExecuteNonQuery(); // Executando o comando
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inserir DocCab: " + ex.ToString());
                return; // Retorna o valor
            }

            cnn.Close(); // Fecha a conexão
            MessageBox.Show("Ocorrência modificada com sucesso!", "Ocorrencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Carrega();
            Update();
        }

        void Carrega()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=testes";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open(); // Abre a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: ! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Retorna o valor
            }

            MessageBox.Show("Ocorrência modificada com sucesso!", "Ocorrencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cnn.Close(); // Fecha a mensagem
        }

        string querry = @"INSERT INTO ocorrencia (Data, Hora, Titulo, Descricao, Gravidade, Operador, Turno, ID) Values (@dtmData, @hHora, @txtTitulo, @txtDescricao, @cboGravidade, @cboOperador, @txtTurno, @ID)";

        public int Id { get; }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnetionString))
            {
                connection.Open(); 
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    DateTime dateTime = DateTime.Now;
                    sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.Date).Value = dtmData.Value;
                    sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.DateTime).Value = string.Format("{0:t}", dateTime);
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo;
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text;
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text;
                    sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text;
                    sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text;
                    sqlCommand.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Id;
                    sqlCommand.ExecuteNonQuery();   
                }
                connection.Close();
            }

            // Inicia a conexão connetionString a base de dados
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=testes";
            cnn = new SqlConnection(connetionString);
            int rowsaffected = 0;
            try
            {
                cnn.Open();// Abre a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: ! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand CmdCab = new SqlCommand("UPDATE ocorrencia SET  Data = @dtmData, Hora = @hHora, Titulo = @txtTitulo, " +
            "Descricao = @txtDescricao, Gravidade = @cboGravidade, Operador = @cboOperador, Turno = @txtTurno, where ID =" + codigoreg, cnn);

            try
            {
                rowsaffected = CmdCab.ExecuteNonQuery(); // Executando o comando
            }

            catch (Exception ex)
            {
                MessageBox.Show("Inserir DocCab: " + ex.ToString());
                return; // Retorna o valor
            }
            cnn.Close(); // Fecha a conexão

            MessageBox.Show("Ocorrência modificada com sucesso!", "Ocorrencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
