using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultorio
{

    public partial class Form1 : Form
    {
        string veículo, opa, hora, teste, atuall;
        double pop, fun, atual, sub;
        int i;
       

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnInicio.Height;
            pnlInicio.BringToFront();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            pnlInicio.BringToFront();
        }



        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnCadastrar.Height;
            SidePanel.Top = btnCadastrar.Top;
            pnlCadastro.BringToFront();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLocalizar.Height;
            SidePanel.Top = btnLocalizar.Top;
            pnlLocalizar.BringToFront();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnUsuario.Height;
            SidePanel.Top = btnUsuario.Top;
            pnlUsuario.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 167)
            {
                MenuVertical.Width = 48;
            }
            else
                MenuVertical.Width = 167;
        }
        private void ptbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbAmpliar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbReduzir.Visible = true;
            ptbAmpliar.Visible = false;
        }

        private void ptbReduzir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbReduzir.Visible = false;
            ptbAmpliar.Visible = true;
        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void rbtMoto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtCarro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txbDataHora.Text = DateTime.Now.ToString("f");
           
        }

        private void txbDataHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void mktPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
            if (rbtCarro.Checked == true)
            {
                veículo = "Carro";
            }
            if (rbtMoto.Checked == true)
            {
               veículo = "Moto";
            }
            lstGeral.Items.Add("Placa- " + mktPlaca.Text + "  Veículo- " + veículo + "  Data e hora- " + txbDataHora.Text);
        }

        

       

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCobrança_Click_1(object sender, EventArgs e)
        {
            teste = lstGeral.SelectedItem.ToString();
            i = teste.IndexOf(":");
            hora = teste.Substring((i - 2));
            hora = hora.Replace(":", "");
            pop = Convert.ToDouble(hora);
            fun = pop / 100;

            atuall = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            atual = Convert.ToDouble(atuall);
            atual = atual / 100;


            sub = atual - fun;
            MessageBox.Show("" + sub * 2);
        }

        private void mkbUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

                if (mkbUser.Text == "Teste" && mkbPassword.Text == "12345")
                {

                    MessageBox.Show("Seja bem vindo");
                    btnLimpar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usuario não existe");
                    btnLimpar.Enabled = false;
                }

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();
                    lstGeral.Items.Clear();
                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            lstGeral.SelectedItems.Clear();
            for (int j = lstGeral.Items.Count - 1; j >= 0; j--)
            {
                if (lstGeral.Items[j].ToString().ToLower().Contains(mktPlaca1.Text.ToLower()))
                {
                    lstGeral.SetSelected(i, true);
                }
            }
            lblStatus.Text = lstGeral.SelectedItems.Count.ToString() + "items encontrados";
        }

              

        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {
            btnLimpar.Enabled = false;
        }

        private void lblFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
