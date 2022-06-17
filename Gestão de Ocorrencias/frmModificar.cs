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
                MessageBox.Show("Can not open connection: ! " + ex.ToString()); ;
                return; // Retorna o valor
            }

            DataSet ds = new DataSet();

            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome

            // do produto e a conexão com o banco de dados

            SqlDataAdapter CmdCab = new SqlDataAdapter("SELECT * FROM gestao where ID = " + codigoreg, cnn);
            CmdCab.Fill(ds, "gestao");

            // 3. preenche o dataset

            if (ds.Tables["gestao"].Rows.Count > 0)
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
                MessageBox.Show("Can not open connection: ! " + ex.ToString());
                this.Close(); // Retorna o valor
            }

            SqlCommand CmdCab = new SqlCommand("UPDATE gestao SET  dtmData = @dtmData, hHora = @hHora, txtTitulo = @txtTitulo, " +
            "txtDescricao = @txtDescricao, cboGravidade = @cboGravidade, cboOperador = @cboOperador, txtTurno = @txtTurno, " +
            " where ID = " + codigoreg, cnn);

            // Adicionando parametros baseado no Sql
            CmdCab.Parameters.Add("@dtmData", SqlDbType.DateTime).Value = dtmData.Text;
            CmdCab.Parameters.Add("@hHora", SqlDbType.DateTime).Value = mskHora.ToString();
            CmdCab.Parameters.Add("@txtTitulo", SqlDbType.Text).Value = txtTitulo.ToString();
            CmdCab.Parameters.Add("@txtDescricao", SqlDbType.Text).Value = txtDescricao.Text.Trim();
            CmdCab.Parameters.Add("@cboGravidade", SqlDbType.Text).Value = cboGravidade.Text.Trim();
            CmdCab.Parameters.Add("@cboOperador", SqlDbType.Text).Value = cboOperador.Text.Trim();
            CmdCab.Parameters.Add("@txtTurno", SqlDbType.Text).Value = txtTurno.Text.Trim();
            
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
