using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Gestão_de_Ocorrencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        adcModificar mod = new adcModificar();
        public Int32 codigoreg;
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Gravidade { get; set; }
        public string Operador { get; set; }
        public string Turno { get; set; }
        public int ID { get; set; }



        SqlConnection cmd = new SqlConnection();
        static string connectionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

       
        private void Form1_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnRemover.Enabled = false;
            cmd.ConnectionString = connectionString;

            try
            {
                cmd.Open(); // Abre a base de dados
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: ! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Retorna o valor
            }
            update();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adcAdicionar adc = new adcAdicionar();
            adc.ConnetionString = connectionString;
            adc.ShowDialog();
            update();
            Refresh();
        }

        void update()
        {
            // Inicia o dataset
            DataSet ds = new DataSet();
            string table = "SELECT [Data], Titulo, CAST (Hora AS TIME) AS Hora, [Descricao], Gravidade, Operador, Turno, [ID] FROM Gestao";
            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome
            // do produto e a conexão com o banco de dados
            SqlDataAdapter da = new SqlDataAdapter(table, cmd);
            da.Fill(ds, "Gestao");
            sfDataGrid1.DataSource = ds.Tables["Gestao"];
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            mod.ConnetionString = connectionString;
            mod.ShowDialog();
            update();
            Refresh();

            btnRemover.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var selectedItem = sfDataGrid1.CurrentItem as DataRowView;
            if (selectedItem != null)
            {
                var dataRow = (selectedItem as DataRowView).Row; // Seleciona a coluna do item 
                if (MessageBox.Show("Tem a certeza que deseja remover esta ocorrência?", "Remover Ocorrência", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Inicia uma conexao
                    string connetionString = null;
                    connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS;Initial Catalog=testes;User ID=testes;Password=ogednom";
                    SqlConnection cnn = new SqlConnection(connetionString);
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
                    SqlCommand CmdCab = new SqlCommand("Delete From Gestao WHERE ID = " + ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[7].ToString(), cnn);

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

                    update();
                }
            }
            btnRemover.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void sfButton1_Click(object sender, EventArgs e)
        {
            // Exporta para o Excel 
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                // Salva os ficheiros do Excel
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {

                    // Salva os ficheiros no Excel
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }
                //Message box confirmation to view the created workbook.
                if (MessageBox.Show(this.sfDataGrid1, "Quer guardar esta exportação?", "Exportação Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }


        private void sfDataGrid1_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            btnModificar.Enabled = true;
            btnRemover.Enabled = true;

            mod.ID = int.Parse(((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[7].ToString());
            string CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[0].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {
                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Data = DateTime.Parse(((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[0].ToString());
            }


            CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[1].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {
                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Titulo = (string)((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[1];
            }


            CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[2].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {

                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Hora = DateTime.Parse(((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[2].ToString());
            }


            CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[3].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {
                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Descricao = (string)((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[3];
            }


            CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[4].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {
                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Gravidade = (string)((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[4];
            }


            CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[5].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {
                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Operador = (string)((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[5];
            }


            CheckNull = ((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[6].GetType().ToString();
            if (CheckNull != "System.DBNull")
            {
                // If not null, gets vallue of all said Entries
                // And so it goes on down to the last condition
                mod.Turno = (string)((DataRowView)sfDataGrid1.SelectedItem).Row.ItemArray[6];
            }
        }
        public string ConnetionString { get; set; }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            frmTabelasAdicionais frm = new frmTabelasAdicionais();
            frm.ConnetionString = connectionString;
            frm.ShowDialog();
            update();
            Refresh();

        }
    }
}
