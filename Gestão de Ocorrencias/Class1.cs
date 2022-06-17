using System;
using System.Data;
using System.Data.SqlClient;


namespace Gestão_de_Ocorrencias
{

    internal class Class1
    {

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string connectionString = null;
            SqlConnection con = new SqlConnection(@"Data Source =asus-portatil\sqlexpress.testes.dbo; Initial Catalog = testes; Integrated Security=true; User ID=testes ; Password=testes");
            con.Open();

            DataSet dat = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT * FROM gestao", con);
            dt.Fill(dat, "gestao");

            SqlCommand sqlcommand = new SqlCommand("INSERT INTO gestao (dtmData, hHora, txtTitulo, txtDescricao, cboGravidade, cboOperador, txtTurno, ID)" + "VALUES (@dtmData, @hHora, @txtTitulo, @txtDescricao, @cboGravidade, @cboOperador, @txtTurno, @ID)", con);

            SqlCommand dtmData = new SqlCommand();
            SqlCommand hHora = new SqlCommand();
            SqlCommand txtTiTulo = new SqlCommand();
            SqlCommand txtDescricao = new SqlCommand();
            SqlCommand cboGravidade = new SqlCommand();
            SqlCommand cboOperador = new SqlCommand();
            SqlCommand txtTurno = new SqlCommand();

            int cmd = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(connectionString))
                {
                    sqlCommand.Parameters.AddWithValue("@dtmData", cmd).Value = dtmData.ToString();
                    sqlCommand.Parameters.AddWithValue("@hHora", cmd).Value = hHora.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTitulo", cmd).Value = txtTiTulo.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtDescricao", cmd).Value = txtDescricao.ToString();
                    sqlCommand.Parameters.AddWithValue("@cboGravidade", cmd).Value = cboGravidade.ToString();
                    sqlCommand.Parameters.AddWithValue("@cboOperador", cmd).Value = cboOperador.ToString();
                    sqlCommand.Parameters.AddWithValue("@txtTurno", cmd).Value = txtTurno.ToString();
                    sqlcommand.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
