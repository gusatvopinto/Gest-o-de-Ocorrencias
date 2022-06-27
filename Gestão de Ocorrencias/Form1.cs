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
        SqlConnection cmd = new SqlConnection();
        string connetionString;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adcAdicionar adc = new adcAdicionar();
            adc.ShowDialog();
            update();
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS; Initial Catalog=testes; User ID=testes; Password=testes";
            cmd.ConnectionString = connetionString;

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

        void update()
        {
            // Inicia o dataset
            DataSet ds = new DataSet();
            string table = "SELECT * FROM Gestao";
            // 2. inicia o SqlDataAdapte passando o comando SQL para selecionar codigo e nome
            // do produto e a conexão com o banco de dados

            SqlDataAdapter da = new SqlDataAdapter(table, cmd);
            da.Fill(ds, "Gestao");
            sfDataGrid1.DataSource = ds.Tables["Gestao"];            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var selectedItem = sfDataGrid1.CurrentItem as DataRowView;

            if (selectedItem != null)
            {
                // Seleciona os items do DataGridView 
                var dataRow = (selectedItem as DataRowView).Row;

                adcModificar adc = new adcModificar();
                adc.codigoreg = Convert.ToInt32(dataRow[0].ToString());
                adc.ShowDialog();
                update();
                Refresh();
            }
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
                    connetionString = @"Data Source=ASUS-PORTATIL\SQLEXPRESS.testes.dbo; Initial Catalog=testes; Persist Security Info=True; User ID=testes; Password=testes";
                    SqlConnection cnn = new SqlConnection(connetionString);
                    int rowsaffected = 0;
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
                    SqlCommand CmdCab = new SqlCommand("UPDATE Gestao SET ID=1 WHERE intCodigo = " + dataRow[0].ToString(), cnn);

                    try
                    {
                        rowsaffected = CmdCab.ExecuteNonQuery(); // Executando o comando
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

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
    }
}
