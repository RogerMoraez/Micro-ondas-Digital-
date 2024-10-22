using MicroondasDigital;
using System;
using System.Linq;
using System.Windows.Forms;
using static MicroondasDigital.Microondas;

namespace MicroondasInterface
{
    public partial class CadastroProgramaForm : Form
    {
        private Microondas microondas;
        public ProgramaAquecimento Programa { get; private set; }
        public CadastroProgramaForm(Microondas microondas)
        {
            InitializeComponent();
            this.microondas = microondas;
        }
        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string alimento = txtAlimento.Text;
            int tempo = int.Parse(txtTempo.Text);
            int potencia = int.Parse(txtPotencia.Text);
            string stringAquecimento = txtStringAquecimento.Text;
            string instrucoes = txtInstrucoes.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome do programa é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(alimento))
            {
                MessageBox.Show("O alimento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (potencia < 1 || potencia > 10)
            {
                MessageBox.Show("A potência deve estar entre 1 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (microondas.ProgramasAquecimento.Any(p => p.StringAquecimento == stringAquecimento || stringAquecimento == "." || string.IsNullOrWhiteSpace(stringAquecimento)))
            {
                MessageBox.Show("Caractere de aquecimento já utilizado ou inválido.");
                return;
            }

            Programa = new ProgramaAquecimento(nome, alimento, tempo, potencia, stringAquecimento, instrucoes, false)
            {
                Nome = nome,
                Alimento = alimento,
                Potencia = potencia,
                StringAquecimento = stringAquecimento,
                Tempo = tempo,
                Instrucoes = instrucoes,
                IsCustomizado = false,
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

