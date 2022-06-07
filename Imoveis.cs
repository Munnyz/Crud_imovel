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
    public partial class Imoveis : Form
    {
        public Imoveis()
        {
            InitializeComponent();
            ShowImoveis();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Desktop\Programação\projetos\Imovel\Netimovel.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowImoveis()
        {
            Con.Open();
            string Query = "Select * from imovel";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ImoveisDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            vvimovel.Text = "";
            timovel.SelectedIndex = -1;
            vlimovel.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (vvimovel.Text == "" || timovel.SelectedIndex == -1 || vlimovel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into imovel(timovel,vvimovel,vlimovel)values(@TI,@VV,@VL)", Con);
                    cmd.Parameters.AddWithValue("@TI", timovel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VV", vvimovel.Text);
                    cmd.Parameters.AddWithValue("@VL", vlimovel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imovel Adicionado!");
                    Con.Close();
                    ResetData();
                    ShowImoveis();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (vvimovel.Text == "" || timovel.SelectedIndex == -1 || vlimovel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update imovel set timovel=@TI,vvimovel=@VV,vlimovel=@VL where Id=@Key", Con);
                    cmd.Parameters.AddWithValue("@TI", timovel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VV", vvimovel.Text);
                    cmd.Parameters.AddWithValue("@VL", vlimovel.Text);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imovel Atualizado!");
                    Con.Close();
                    ResetData();
                    ShowImoveis();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (vvimovel.Text == "" || timovel.SelectedIndex == -1 || vlimovel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from imovel where Id=@Key", Con);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imovel Excluido");
                    Con.Close();
                    ResetData();
                    ShowImoveis();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void ImoveisDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timovel.Text = ImoveisDGV.SelectedRows[0].Cells[1].Value.ToString();
            vvimovel.Text = ImoveisDGV.SelectedRows[0].Cells[2].Value.ToString();
            vlimovel.Text = ImoveisDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (timovel.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ImoveisDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        private void Tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CadEnderecos end = new CadEnderecos();
            end.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timovel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void vvimovel_TextChanged(object sender, EventArgs e)
        {

        }

        private void imoveisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tenantTblBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
