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

        public Int32 codigoreg;

        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Gravidade { get; set; }
        public string Operador { get; set; }
        public string Turno { get; set; }
        public int ID { get; set; }
        string idnow;

        private void adcModificar_Load(object sender, EventArgs e)
        {
            // Adiciona a USStates a uma nova lista 
            List<string> USStates = new List<string>();
            USStates.Add("Alta");
            USStates.Add("Média");
            USStates.Add("Baixa");
            idnow = ID.ToString();

            // Adiciona um novo operador a lista
            List<string> Operadores = new List<string>();
            Operadores.Add("Elisio Pereira");

            cboGravidade.DataSource = USStates;
            cboOperador.DataSource = Operadores;
            dtmData.Culture = CultureInfo.CurrentCulture;

            hHora.Text = Hora.ToString();
            dtmData.Text = Data.ToString();
            txtTitulo.Text = Titulo.ToString();
            txtDescricao.Text = Descricao.ToString();
            cboGravidade.Text = Gravidade.ToString();
            cboOperador.Text = Operador.ToString();
            txtTurno.Text = Turno.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string querry = (@"UPDATE Gestao SET Data=@dtmData, Hora=@hHora, Titulo=@txtTitulo, Descricao=@txtDescricao, Gravidade=@cboGravidade, Operador=@cboOperador, Turno=@txtTurno  where ID = " + idnow);

            using (SqlConnection connection = new SqlConnection(ConnetionString))
            {
                TimeSpan dt = DateTime.Parse(hHora.Value.ToString()).TimeOfDay;
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(querry, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@dtmData", SqlDbType.Date).Value = dtmData.Value;
                    sqlCommand.Parameters.AddWithValue("@hHora", SqlDbType.Text).Value = dt.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo.Text;
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text;
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text;
                    sqlCommand.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text;
                    sqlCommand.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text;

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Informação Adicionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A Informação Não Foi Adicionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                connection.Close();
            }
            this.Close();
        }
    }
}
