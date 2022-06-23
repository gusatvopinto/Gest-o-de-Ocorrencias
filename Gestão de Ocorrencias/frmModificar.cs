using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Gestão_de_Ocorrencias
{
    public partial class adcModificar : Form
    {
        public adcModificar()
        {
            InitializeComponent();
        }

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

            dtmData.Culture = System.Globalization.CultureInfo.CurrentCulture;
            Carrega();
        }

        void Carrega()
        {

            // Inicia a conexão connetionString da base de dados
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS; Initial Catalog=testes; Integrated Security=true; User ID=testes ; Password=testes";
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

            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome
            // do produto e a conexão com o banco de dados
            DataSet ds = new DataSet();
            SqlDataAdapter CmdCab = new SqlDataAdapter("SELECT * FROM Gestao WHERE (ID) = " + codigoreg, cnn);
            CmdCab.Fill(ds, "Gestao");

            // 3. preenche o dataset

            if (ds.Tables["Gestao"].Rows.Count > 0)
            {
                dtmData.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtmData"].ToString());
                mskHora.Text = ds.Tables[0].Rows[0]["hHora"].ToString();
                txtTitulo.Text = ds.Tables[0].Rows[0]["txtTitulo"].ToString();
                txtDescricao.Text = ds.Tables[0].Rows[0]["txtDescricao"].ToString();
                cboGravidade.Text = ds.Tables[0].Rows[0]["cboGravidade"].ToString();
                cboOperador.Text = ds.Tables[0].Rows[0]["cboOperador"].ToString();
                txtTurno.Text = ds.Tables[0].Rows[0]["txtTurno"].ToString();
            }

            cnn.Close(); // Fecha a conexão
            MessageBox.Show("Ocorrência modificada com sucesso!", "Ocorrencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha a mensagem

        }

        public int Id { get; }


        private void btnGravar_Click(object sender, EventArgs e)
        {

            // Inicia a conexão connetionString a base de dados
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS; Initial Catalog=testes; Integrated Security=true; User ID=testes; Password=testes";
            cnn = new SqlConnection(connetionString);
            int rowsaffected = 0;
            try
            {
                cnn.Open();// Abre a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: ! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Retorna o valor
            }

            SqlCommand CmdCab = new SqlCommand("UPDATE Gestao SET  dtmData = @dtmData, hHora = @hHora, txtTitulo = @txtTitulo, " +
            "txtDescricao = @txtDescricao, cboGravidade = @cboGravidade, cboOperador = @cboOperador, txtTurno = @txtTurno, " +
            " where ID = " + codigoreg, cnn);

            // Adicionando parametros baseado no Sql
            CmdCab.Parameters.AddWithValue("@dtmData", SqlDbType.DateTime).Value = dtmData.Value;
            CmdCab.Parameters.AddWithValue("@hHora", SqlDbType.DateTime).Value = mskHora;
            CmdCab.Parameters.AddWithValue("@txtTitulo", SqlDbType.Text).Value = txtTitulo.ToString();
            CmdCab.Parameters.AddWithValue("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text.ToString();
            CmdCab.Parameters.AddWithValue("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text.ToString();
            CmdCab.Parameters.AddWithValue("@cboOperador", SqlDbType.Text).Value = cboOperador.Text.ToString();
            CmdCab.Parameters.AddWithValue("@txtTurno", SqlDbType.Text).Value = txtTurno.Text.ToString();
            CmdCab.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = (char)Id;


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
            this.Close(); // Fecha a mensagem
        }
    }
}
