using Atacado.POCO.RH;
using Atacado.Service.RH;

namespace AtacadoWinApp
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void OiMundoBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Oi Mundo!!!");
            //MessageBox.Show("Oi Mundo!!!", "Mensagem");
            //MessageBox.Show("Oi Mundo!!!", "Mensagem", MessageBoxButtons.OK);
            MessageBox.Show("Oi Mundo!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarFuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionariosFrm frm = new AdicionarFuncionariosFrm();
            frm.ShowDialog();
        } 
    }
}