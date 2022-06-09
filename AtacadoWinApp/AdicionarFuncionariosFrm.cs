using Atacado.POCO.RH;
using Atacado.Service.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoWinApp
{
    public partial class AdicionarFuncionariosFrm : Form
    {
        public AdicionarFuncionariosFrm()
        {
            InitializeComponent();
            this.PreencherSexoCmb();
        }

        private void AdicionarFuncionariosFrm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmalLbl_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            {
                
                FuncionarioPOCO poco = new FuncionarioPOCO()
                {
                    Cpf = CpfTxt.Text,
                    Nome = NomeTxt.Text,
                    SobreNome = SobrenomeTxt.Text,
                    Endereco = EnderecoTxt.Text,
                    Telefone = TelefoneTxt.Text,
                    Email = EmailTxt.Text,
                    Nacionalidade = NacionalidadeTxt.Text,
                    Naturalidade = NaturalidadeTxt.Text,
                    Rg = RgTxt.Text,
                    DtNascimento = DtNascimentoDtPicker.Value,
                    Sexo  = SexoCmb.SelectedValue.ToString()
                
                };

                FuncionarioService srv = new FuncionarioService();
                if (srv.Validar(poco) == false)
                {
                    string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mensagem = "CPF V�lido.";
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }

        private void DtNascimentoDtPicker_ValueChanged(object sender, EventArgs e)
        {
          
        }
        private void PreencherSexoCmb()
        {
            SexoCmb.Items.Clear();

            SexoCmb.DisplayMember = "Value";
            SexoCmb.ValueMember = "Key";

            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("M", "Masculino");
            items.Add("F", "Feminino");

            SexoCmb.DataSource = new BindingSource(items, null);
            SexoCmb.SelectedIndex = 0;
        }
    
    
    }
}
