using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vingadores.Telas
{
    public partial class frmVingadores : Form
    {
        public frmVingadores()
        {
            InitializeComponent();
            this.Buscar();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.tb_heroi heroi = new Database.tb_heroi();

                heroi.nm_heroi = txtCodinome.Text;
                heroi.nm_nome = txtNome.Text;
                heroi.ds_sexo = cboSexo.Text;
                heroi.vl_forca = Convert.ToInt32(nudForca.Value);
                heroi.vl_poder = Convert.ToInt32(nudPoder.Value);
                heroi.ds_status = cboStatus.Text;

                Business.vingadorBusiness business = new Business.vingadorBusiness();
                business.Inserir(heroi);

                MessageBox.Show("Cadastrado com sucesso.");

                this.Buscar();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(nudID.Value == 0)
                {
                    MessageBox.Show("Você não escolheu o vingador!");
                }
                else
                {
                    Database.tb_heroi heroi = dgvLista.CurrentRow.DataBoundItem as Database.tb_heroi;

                    heroi.nm_heroi = txtCodinome.Text;
                    heroi.nm_nome = txtNome.Text;
                    heroi.ds_sexo = cboSexo.Text;
                    heroi.vl_forca = Convert.ToInt32(nudForca.Value);
                    heroi.vl_poder = Convert.ToInt32(nudPoder.Value);
                    heroi.ds_status = cboStatus.Text;

                    Business.vingadorBusiness business = new Business.vingadorBusiness();
                    business.Alterar(heroi);

                    MessageBox.Show("Alterado com sucesso.");

                    this.Buscar();
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                Database.tb_heroi heroi = dgvLista.CurrentRow.DataBoundItem as Database.tb_heroi;

                nudID.Value = heroi.id_heroi;
                txtCodinome.Text = heroi.nm_heroi;
                txtNome.Text = heroi.nm_nome;
                cboSexo.Text = heroi.ds_sexo;
                nudForca.Value = Convert.ToInt32(heroi.vl_forca);
                nudPoder.Value = Convert.ToInt32(heroi.vl_poder);
                cboStatus.Text = heroi.ds_status;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(nudID.Value);

                if (ID == 0)
                {
                    MessageBox.Show("Você não escolheu o vingador!");
                }
                else
                {
                    Business.vingadorBusiness business = new Business.vingadorBusiness();
                    business.Deletar(ID);

                    MessageBox.Show("Removido com sucesso.");

                    this.Buscar();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void txtVingador_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void cboStatusBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void Buscar()
        {
            try
            {
                string vingador = txtVingador.Text;
                string status = cboStatusBuscar.Text;

                Business.vingadorBusiness business = new Business.vingadorBusiness();
                List<Database.tb_heroi> herois = business.Listar(vingador, status);

                dgvLista.DataSource = herois;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }
    }
    }

