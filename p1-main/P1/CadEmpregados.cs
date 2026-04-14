using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P1
{
    public partial class CadEmpregados : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblsetores;
        private SqlCommand comando;
        private string strsql, strconex;

        public CadEmpregados()
        {
            InitializeComponent();
        }

        private void CadEmpregados_Load(object sender, EventArgs e)
        {
            strconex = "Data Source=localhost;Initial Catalog=Empresa;Integrated Security=True";
            conexao = new SqlConnection(strconex);
            
            try
            {
                conexao.Open();
                tblsetores = new DataTable();
                strsql = "select * from setores";
                adapter = new SqlDataAdapter(strsql, conexao);
                adapter.Fill(tblsetores);

                cboCodSetor.DataSource = tblsetores;
                cboCodSetor.DisplayMember = "NomeSetor";
                cboCodSetor.ValueMember = "CodSetor";
                if(cboCodSetor.SelectedValue != null)
                {
                    lblcodsetor.Text = cboCodSetor.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os setores: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void CboCodSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCodSetor.SelectedValue != null && !(cboCodSetor.SelectedValue is DataRowView))
            {
                lblcodsetor.Text = cboCodSetor.SelectedValue.ToString();
            }
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpregado.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtBairro.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Salário inválido. Informe um valor numérico.", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            try
            {
                strconex = "Data Source=localhost;Initial Catalog=Empresa;Integrated Security=True";
                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = "INSERT INTO Empregados (Nome, Endereco, Bairro, Cidade, Cargo, Salario, CodSetor) " +
                         "VALUES (@nome, @endereco, @bairro, @cidade, @cargo, @salario, @codsetor)";

                comando = new SqlCommand(strsql, conexao);
                comando.Parameters.AddWithValue("@nome", txtEmpregado.Text);
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("@cargo", txtCargo.Text);
                comando.Parameters.AddWithValue("@salario", salario);
                comando.Parameters.AddWithValue("@codsetor", cboCodSetor.SelectedValue);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso.", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro ao gravar: " + er.Message, "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void BtSetores_Click(object sender, EventArgs e)
        {
            Form1 formSetores = new Form1();
            formSetores.Show();
            this.Hide();
        }
    }
}
