using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imovel
{
    public partial class CadEnderecos : Form
    {
        public CadEnderecos()
        {
            InitializeComponent();
            ShowEnderecos();
            GetImoveis();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Desktop\Programação\projetos\Imovel\Netimovel.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetImoveis()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Id from imovel", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Load(Rdr);
            timovel.ValueMember = "Id";
            timovel.DataSource = dt;
            Con.Close();
        }
        private void ShowEnderecos()
        {
            Con.Open();
            string Query = "Select * from EnderecoTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ApartDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            timovel.SelectedIndex = -1;
            end.Text = "";
            num.Text = "";
            ba.Text = "";
            cd.Text = "";
            cep.Text = "";
            es.Text = "";
            comp.Text = "";
        }
        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (end.Text == "" || comp.Text == "" || timovel.SelectedIndex == -1 || num.Text == "" || ba.Text == "" || cd.Text == "" || es.Text == "" || cep.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EnderecoTbl(Eimovel,endereco,comp,num,bairro,cidade,estado,cep)values(@EI,@EN,@CO,@NU,@BA,@CD,@ES,@CEP)", Con);
                    cmd.Parameters.AddWithValue("@EI", timovel.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", end.Text);
                    cmd.Parameters.AddWithValue("@CO", comp.Text);
                    cmd.Parameters.AddWithValue("@NU", num.Text);
                    cmd.Parameters.AddWithValue("@BA", ba.Text);
                    cmd.Parameters.AddWithValue("@CD", cd.Text);
                    cmd.Parameters.AddWithValue("@ES", es.Text);
                    cmd.Parameters.AddWithValue("@CEP", cep.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Endereço adicionado no imóvel com sucesso!");
                    Con.Close();
                    ResetData();
                    ShowEnderecos();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (end.Text == "" || comp.Text == "" || timovel.SelectedIndex == -1 || num.Text == "" || ba.Text == "" || cd.Text == "" || es.Text == "" || cep.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update EnderecoTbl set Eimovel=@EI,endereco=@EN,comp=@CO,num=@NU,bairro=@BA,cidade=@CD,estado=@ES,cep=@CEP where Id=@Key", Con);
                    cmd.Parameters.AddWithValue("@EI", timovel.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", end.Text);
                    cmd.Parameters.AddWithValue("@CO", comp.Text);
                    cmd.Parameters.AddWithValue("@NU", num.Text);
                    cmd.Parameters.AddWithValue("@BA", ba.Text);
                    cmd.Parameters.AddWithValue("@CD", cd.Text);
                    cmd.Parameters.AddWithValue("@ES", es.Text);
                    cmd.Parameters.AddWithValue("@CEP", cep.Text);
                    
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Endereço Atualizado com sucesso!");
                    Con.Close();
                    ResetData();
                    ShowEnderecos();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (end.Text == "" || comp.Text == "" || timovel.SelectedIndex == -1 || num.Text == "" || ba.Text == "" || cd.Text == "" || es.Text == "" || cep.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EnderecoTbl where Id=@Key", Con);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excluido com sucesso!");
                    Con.Close();
                    ResetData();
                    ShowEnderecos();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Imoveis  i = new Imoveis();
            i.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
           
        }
        int Key = 0;
        private void ApartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timovel.Text = ApartDGV.SelectedRows[0].Cells[1].Value.ToString();

            end.Text = ApartDGV.SelectedRows[0].Cells[2].Value.ToString();

            comp.Text = ApartDGV.SelectedRows[0].Cells[3].Value.ToString();

            num.Text = ApartDGV.SelectedRows[0].Cells[4].Value.ToString();

            ba.Text = ApartDGV.SelectedRows[0].Cells[5].Value.ToString();

            cd.Text = ApartDGV.SelectedRows[0].Cells[6].Value.ToString();

            es.Text = ApartDGV.SelectedRows[0].Cells[7].Value.ToString();

            cep.Text = ApartDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (timovel.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ApartDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CadEnderecos_Load(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
