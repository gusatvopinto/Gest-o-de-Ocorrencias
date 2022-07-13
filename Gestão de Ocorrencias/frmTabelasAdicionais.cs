using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestão_de_Ocorrencias
{
    public partial class TabelasAdicionais : Form
    {
        public TabelasAdicionais()
        {
            InitializeComponent();
        }
        public class TabControl : Control
        {

        }
        Adicionar_Turno_ mod = new Adicionar_Turno_();
        Adicionar_Operador_ Mod = new Adicionar_Operador_();
        Adicionar_Gravidade_ Md = new Adicionar_Gravidade_();
        Modificar_Turno_ md = new Modificar_Turno_();
        Modificar_Operador_ modd = new Modificar_Operador_();
        Modificar_Gravidade_ mD = new Modificar_Gravidade_();

        public string ConnetionString { get; set; }
        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
        SqlConnection connection = new SqlConnection(connectionString);

        private void frmTabelasAdicionais_Load(object sender, EventArgs e)
        {
            connection.Open();
            updatepage();
        }

        string querry = (@"INSERT INTO turno (Turno, ID) Values (@txtTurno, @ID)");
        string querr = (@"INSERT INTO operador (Operador, ID) Values (@cboOperador, @ID)");
        string con = (@"INSERT INTO gravidade (Gravidade, ID) Values (@cboGravidade, @ID)");

        void update()
        {
            DataSet ds = new DataSet();
            string table = "SELECT [ID], Turno FROM turno";
            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome
            // do produto e a conexão com o banco de dados
            SqlDataAdapter da = new SqlDataAdapter(table, connection);
            da.Fill(ds);
        }

        void updatepage()
        {
            DataSet dset = new DataSet(); //Cria um dateset
            SqlDataAdapter adapter = new SqlDataAdapter(); //Cria um adaptador
            querry = "SELECT * FROM turno";
            adapter = new SqlDataAdapter(querry, connectionString);
            adapter.Fill(dset, "a");
            dataGridView1.DataSource = dset.Tables["a"];

            dset = new DataSet();
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            querr = "SELECT * FROM operador";
            adapter2 = new SqlDataAdapter(querr, connectionString);
            adapter2.Fill(dset, "b");
            dataGridView2.DataSource = dset.Tables["b"];

            dset = new DataSet();
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            con = "SELECT * FROM gravidade";
            adapter3 = new SqlDataAdapter(con, connectionString);
            adapter3.Fill(dset, "c");
            dataGridView3.DataSource = dset.Tables["c"];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatepage();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                Adicionar_Turno_ com = new Adicionar_Turno_();
                com.ShowDialog();
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                Adicionar_Operador_ Com = new Adicionar_Operador_();
                Com.ShowDialog();
            }

            if (tabControl1.SelectedTab == tabPage3)
            {
                Adicionar_Gravidade_ Commm = new Adicionar_Gravidade_();
                Commm.ShowDialog();
            }
            updatepage();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                Modificar_Turno_ comm = new Modificar_Turno_();
                comm.ID = (int)((DataRowView)dataGridView1.SelectedItem).Row.ItemArray[1];
                comm.ShowDialog();
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                Modificar_Operador_ Comm = new Modificar_Operador_();
                Comm.ID = (int)((DataRowView)dataGridView2.SelectedItem).Row.ItemArray[1];
                Comm.ShowDialog();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                Modificar_Gravidade_ modOp = new Modificar_Gravidade_();
                modOp.ID = (int)((DataRowView)dataGridView3.SelectedItem).Row.ItemArray[1];
                modOp.ShowDialog();
            }
            updatepage();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentItem as DataRowView; 
            if (tabControl1.SelectedTab == tabPage1)
            {
                 selectedItem = dataGridView1.CurrentItem as DataRowView;
                 querry = "Delete From turno WHERE ID = " + ((DataRowView)dataGridView1.SelectedItem).Row.ItemArray[1].ToString();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                selectedItem = dataGridView2.CurrentItem as DataRowView;
                querry = "Delete From operador WHERE ID = " + ((DataRowView)dataGridView2.SelectedItem).Row.ItemArray[1].ToString();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                selectedItem = dataGridView3.CurrentItem as DataRowView;
                querry = "Delete From gravidade Where ID = " + ((DataRowView)dataGridView3.SelectedItem).Row.ItemArray[1].ToString();
            }
                
            if (selectedItem != null)
            {
                var dataRow = (selectedItem as DataRowView).Row;
                if (MessageBox.Show("Tem a certeza que deseja remover esta ocorrência?", "Remover Ocorrência", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    
                    SqlConnection cnn = new SqlConnection(connectionString);
                    try
                    {
                        cnn.Open(); // Abre a base de dados
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection: ! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insere os dados dentro do Sql
                    SqlCommand CmdCab = new SqlCommand(querry, cnn);

                    try
                    {
                        CmdCab.ExecuteNonQuery(); // Executando o comando
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Inserir DocCab: " + ex.ToString());
                        return; // Retorna o valor
                    }
                    cnn.Close(); // Fecha a conexão com a base de dados
                    MessageBox.Show("Ocorrência removida com sucesso!", "Ocorrência", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updatepage();
                }
            }
        }
    }
}