using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorSeguro
{
    public partial class Form1 : Form
    {
        double resultadof;
        double valorFranquia;
        double valor_imovel;
        string nome, email, logradouro, cidade, estado, telefone;


        public Form1()
        {
            InitializeComponent();
            txtVImovel.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlConfirmaSaida.Location = new Point(2000, 2000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtLogradouro.Text = "";
            txtTelefone.Text = "";
            txtVImovel.Text = "0";
            cbbCidade.Text = "";
            cbbEstado.Text = "";
            cbxCoberturaNatural.Checked = false;
            cbxCoberturaRoubo.Checked = false;
            radAlarmeSim.Checked = false;
            radAlarmeNao.Checked = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar.Visible = false;
            btnLimpar.Visible = true;
            Calculo.Enabled = true;
            pnlResultado.Location = new Point(2000, 2000);
        }

        private void cbxCoberturaRoubo_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxCoberturaRoubo.Checked == true)
            {
                radAlarmeSim.Enabled = true;
                radAlarmeNao.Enabled = true;
            }
            else
            {
                radAlarmeSim.Enabled = false;
                radAlarmeNao.Enabled = false;
                radAlarmeSim.Checked = false;
                radAlarmeNao.Checked = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlConfirmaSaida.Location = new Point(0, 0);
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEstado.SelectedIndex == 0)
            {
                cbbCidade.Items.Clear();
                cbbCidade.Items.Add("Cidade 1");
                cbbCidade.Items.Add("Cidade 2");

            }
            else if (cbbEstado.SelectedIndex == 1)
            {
                cbbCidade.Items.Clear();
                cbbCidade.Items.Add("Cidade 3");
                cbbCidade.Items.Add("Cidade 4");

            }
        }

        private void Calculo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtEmail.Text == "" && txtLogradouro.Text == "" && txtTelefone.Text == "" && txtVImovel.Text == "0" && cbbCidade.Text == "" && cbbEstado.Text == "")
            {
                MessageBox.Show("Há campos vazios!!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                valor_imovel = double.Parse(txtVImovel.Text);
                if (cbbEstado.SelectedIndex == 0)
                {
                    if (cbbCidade.Text == "Cidade 1")
                    {
                        resultadof = valor_imovel / 12;

                        resultadof = resultadof * 0.0052;


                        if (cbxCoberturaNatural.Checked == true)
                        {
                            resultadof = resultadof * 1.05;
                        }


                        if (cbxCoberturaRoubo.Checked == true)
                        {

                            if (radAlarmeSim.Checked == true)
                            {
                                resultadof = resultadof * 1.01;
                            }

                            if (radAlarmeNao.Checked == true)
                            {
                                resultadof = resultadof * 1.02;
                            }
                        }

                        lblResultadoVM.Text = resultadof.ToString();

                    }
                    if (cbbCidade.Text == "Cidade 2")
                    {
                        resultadof = valor_imovel / 12;

                        resultadof = resultadof * 0.0046;


                        if (cbxCoberturaNatural.Checked == true)
                        {
                            resultadof = resultadof * 1.05;
                        }



                        if (cbxCoberturaRoubo.Checked == true)
                        {

                            if (radAlarmeSim.Checked == true)
                            {
                                resultadof = resultadof * 1.01;
                            }

                            if (radAlarmeNao.Checked == true)
                            {
                                resultadof = resultadof * 1.02;
                            }
                        }

                        lblResultadoVM.Text = resultadof.ToString();

                    }
                }


                if (cbbEstado.SelectedIndex == 1)
                {
                    if (cbbCidade.Text == "Cidade 3")
                    {
                        resultadof = valor_imovel / 12;

                        resultadof = resultadof * 0.0058;


                        if (cbxCoberturaNatural.Checked == true)
                        {
                            resultadof = resultadof * 1.05;
                        }


                        if (cbxCoberturaRoubo.Checked == true)
                        {

                            if (radAlarmeSim.Checked == true)
                            {
                                resultadof += resultadof * 1.01;
                            }

                            if (radAlarmeNao.Checked == true)
                            {
                                resultadof += resultadof * 1.02;
                            }
                        }

                        lblResultadoVM.Text = resultadof.ToString();

                    }
                    if (cbbCidade.Text == "Cidade 4")
                    {
                        resultadof = valor_imovel / 12;

                        resultadof = resultadof * 0.0051;


                        if (cbxCoberturaNatural.Checked == true)
                        {
                            resultadof = resultadof * 1.05;
                        }


                        if (cbxCoberturaRoubo.Checked == true)
                        {

                            if (radAlarmeSim.Checked == true)
                            {
                                resultadof += resultadof * 1.01;
                            }

                            if (radAlarmeNao.Checked == true)
                            {
                                resultadof += resultadof * 1.02;
                            }
                        }

                        lblResultadoVM.Text = resultadof.ToString();

                    }
                }

                valorFranquia = resultadof * 10;
                nome = txtNome.Text;
                email = txtEmail.Text;
                telefone = txtTelefone.Text;
                cidade = cbbCidade.Text;
                estado = cbbEstado.Text;
                logradouro = txtLogradouro.Text;
                lblResultadoVF.Text = valorFranquia.ToString();

                lblNome.Text = nome;
                lblEmail.Text = email;
                lblTelefone.Text = telefone;
                lblCidade.Text = cidade;
                lblEstado.Text = estado;
                lblLogradouro.Text = logradouro;
                lblVImovel.Text = valor_imovel.ToString();

                pnlResultado.Location = new Point(24, 50);
                btnVoltar.Visible = true;
                btnLimpar.Visible = false;
                Calculo.Enabled = false;
            }
        }

        private void txtVImovel_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
