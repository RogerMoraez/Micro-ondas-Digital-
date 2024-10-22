using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MicroondasDigital;
using static MicroondasDigital.Microondas;

namespace MicroondasInterface
{
    public partial class Form1 : Form
    {
        private Microondas microondas;
        private Timer timer;
        private List<Button> botoesDePrograma;

        public Form1()
        {
            InitializeComponent();
            microondas = new Microondas();
            microondas.AtualizarDisplay += AtualizarInterface;
            microondas.AtualizarProgresso += AtualizarProgressoNaInterface;
            botoesDePrograma = new List<Button>
    {
        bntLeite,
        bntPipoca,
        bntFeijao,
        bntFrango,
        bntCarneDeBoi,
        bntIniciorapidoAcrecentartempo,
        btnCadastrarPrograma1,
        btnCadastrarPrograma2,
        btnCadastrarPrograma3,
        btnCadastrarPrograma4,
        btnCadastrarPrograma5
        };

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick; 
        }


        private void IniciarTimer()
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            string tempoFormatado = " ";
            string progresso = " ";

            if (microondas.EmAquecimento && microondas.TempoEmSegundos > 0)
            {
                microondas.ProcessarAquecimento();
                tempoFormatado = microondas.FormatarTempo(microondas.TempoEmSegundos);

                if (microondas.ProgramaAquecimentoAtual != null && !microondas.ProgramaAquecimentoAtual.IsCustomizado)
                {
                    progresso = microondas.ProgramaAquecimentoAtual.StringAquecimento;
                }
                else
                {
                    progresso = microondas.GerarProgresso();
                }

                AtualizarInterface(tempoFormatado, progresso);
            }

            if (microondas.TempoEmSegundos <= 0)
            {
                progresso += " Aquecimento concluído.";
                AtualizarInterface(tempoFormatado, progresso);
                timer.Stop();
            }
        }

        private void AdicionarNumeroAoCampo(int numero)
        {
            if (txtTempo.Focused)
            {
                txtTempo.Text += numero.ToString();
            }
            else if (txtPotencia.Focused)
            {
                txtPotencia.Text += numero.ToString();
            }
        }
        private void AtualizarProgressoNaInterface(string progresso)
        {
                lblProgresso.Text = progresso;
        }
        private void AtualizarInterface(string tempo, string progresso)
        {
            lblProgresso.Text = progresso; 
            lblTempo.Text = tempo;
        }
        private void AtualizarPotencia()
        {
            lblPotencia.Text = microondas.Potencia.ToString();
        }
        private void AtualizarBotoes(bool habilitar)
        {
            foreach (var botao in botoesDePrograma)
            {
                botao.Enabled = habilitar;
            }
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

        private void bntIniciarRetomar_Click(object sender, EventArgs e)
        {
            try
            {
                int tempo;

                if (microondas.Pausado)
                {
                    microondas.RetomarAquecimento();
                    IniciarTimer();
                    return;
                }

                if (!microondas.EmAquecimento)
                {
                    if (string.IsNullOrWhiteSpace(txtTempo.Text) || !int.TryParse(txtTempo.Text, out tempo))
                    {
                        MessageBox.Show("Por favor, insira um tempo válido entre 1 e 120 segundos.");
                        return;
                    }

                    if (tempo < 1 || tempo > 120)
                    {
                        MessageBox.Show("Por favor, insira um tempo válido entre 1 e 120 segundos.");
                        return;
                    }

                    int potencia = string.IsNullOrWhiteSpace(txtPotencia.Text) ? 10 : int.Parse(txtPotencia.Text);

                    if (potencia < 1 || potencia > 10)
                    {
                        MessageBox.Show("A potência deve ser entre 1 e 10.");
                        return;
                    }

                    microondas.IniciarAquecimento(tempo, potencia);
                    IniciarTimer();
                    AtualizarPotencia();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bntIniciorapidoAcrecentartempo_Click(object sender, EventArgs e)
        {
            if (microondas.EmAquecimento)
            {
                microondas.AdicionarTempo();
            }
            else
            {
                microondas.InicioRapido();
                IniciarTimer();

                string tempoFormatado = microondas.FormatarTempo(microondas.TempoEmSegundos);
                string progresso = microondas.GerarProgresso();

                AtualizarInterface(tempoFormatado, progresso);
                AtualizarPotencia();
            }
        }
        private void bntPauseCancelar_Click(object sender, EventArgs e)
        {
            if (microondas.EmAquecimento)
            {
                microondas.PausarAquecimento();
                timer.Stop();
            }
            else
            {
                microondas.CancelarAquecimento();
                timer.Stop();

                lblTempo.Text = "0:00";
                lblPotencia.Text = "10";
                AtualizarInterface(microondas.FormatarTempo(0), "");
                AtualizarBotoes(true);
            }
            if (!microondas.EmAquecimento && !microondas.Pausado)
            {
                lblTempo.Text = "0:00";  
                lblProgresso.Text = "";   
                lblPotencia.Text = "10";
                txtTempo.Text = "";
                txtPotencia.Text = "";
            }
        }

        private void bntLeite_Click(object sender, EventArgs e)
        {
            IniciarPrograma("Leite");
        }
        private void bntPipoca_Click(object sender, EventArgs e)
        {
            IniciarPrograma("Pipoca");
        }
        private void bntFeijao_Click(object sender, EventArgs e)
        {
            IniciarPrograma("Feijão");
        }
        private void bntFrango_Click(object sender, EventArgs e)
        {
            IniciarPrograma("Frango");
        }
        private void bntCarneDeBoi_Click(object sender, EventArgs e)
        {
            IniciarPrograma("Carnes de boi");
        }

        private void IniciarPrograma(string nomePrograma)
        {
            ProgramaAquecimento programa = microondas.ProgramasAquecimento
                .FirstOrDefault(p => p.Nome == nomePrograma);

            if (programa != null)
            {
                Debug.WriteLine($"Tempo: {programa.Tempo}, Potência: {programa.Potencia}");
                txtTempo.Text = programa.Tempo.ToString();
                txtPotencia.Text = programa.Potencia.ToString();

                AtualizarBotoes(false);

                microondas.IniciarAquecimento(programa.Tempo, programa.Potencia, programa, true);
                AtualizarPotencia();
                IniciarTimer();
            }
            else
            {
                MessageBox.Show("Programa de aquecimento não encontrado.");
            }
        }
        private void CadastrarOuIniciarPrograma(Button btnPrograma, Button btnInstrucoes)
        {
            if (microondas.ProgramasAquecimento.Any(p => p.Nome == btnPrograma.Text))
            {
                var programa = microondas.ProgramasAquecimento.First(p => p.Nome == btnPrograma.Text);
                microondas.IniciarAquecimento(programa.Tempo, programa.Potencia, programa);
                IniciarTimer();

                btnInstrucoes.Click -= (sender, e) => ExibirInstrucoes(programa.Instrucoes); 
                btnInstrucoes.Click += (sender, e) => ExibirInstrucoes(programa.Instrucoes);
            }
            else
            {
                using (var cadastroForm = new CadastroProgramaForm(microondas))
                {
                    if (cadastroForm.ShowDialog() == DialogResult.OK)
                    {
                        microondas.ProgramasAquecimento.Add(cadastroForm.Programa);
                        btnPrograma.Text = cadastroForm.Programa.Nome;

                        btnInstrucoes.Click -= (sender, e) => ExibirInstrucoes(cadastroForm.Programa.Instrucoes); 
                        btnInstrucoes.Click += (sender, e) => ExibirInstrucoes(cadastroForm.Programa.Instrucoes); 
                    }
                }
            }
        }
        private void ExibirInstrucoes(string instrucoes)
        {
            if (!string.IsNullOrWhiteSpace(instrucoes))
            {
                MessageBox.Show(instrucoes, "Instruções do Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma instrução foi fornecida para este programa.", "Instruções do Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCadastrarPrograma1_Click(object sender, EventArgs e)
        {
            CadastrarOuIniciarPrograma(btnCadastrarPrograma1, bntIntrucoesProgramaCadastrado1);
            AtualizarBotoes(false);
        }
        private void btnCadastrarPrograma2_Click(object sender, EventArgs e)
        {
            CadastrarOuIniciarPrograma(btnCadastrarPrograma2, bntIntrucoesProgramaCadastrado2);
            AtualizarBotoes(false);
        } 
        private void btnCadastrarPrograma3_Click(object sender, EventArgs e)
        {
            CadastrarOuIniciarPrograma(btnCadastrarPrograma3, bntIntrucoesProgramaCadastrado3);
        }
        private void btnCadastrarPrograma4_Click(object sender, EventArgs e)
        {
            CadastrarOuIniciarPrograma(btnCadastrarPrograma4, bntIntrucoesProgramaCadastrado4);
        }
        private void btnCadastrarPrograma5_Click(object sender, EventArgs e)
        {
            CadastrarOuIniciarPrograma(btnCadastrarPrograma5, bntIntrucoesProgramaCadastrado5);
        }

        private void btnInstrucoesLeite_Click(object sender, EventArgs e)
        {
            var programa = microondas.ProgramasAquecimento.FirstOrDefault(p => p.Nome == "Leite");
            if (programa != null)
            {
                MessageBox.Show(programa.Instrucoes, "Instruções para Leite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Programa 'Leite' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntIntrucoesPipoca_Click(object sender, EventArgs e)
        {
            var programa = microondas.ProgramasAquecimento.FirstOrDefault(p => p.Nome == "Pipoca");
            if (programa != null)
            {
                MessageBox.Show(programa.Instrucoes, "Instruções para Pipoca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Programa 'Pipoca' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntIntrucoesFeijao_Click(object sender, EventArgs e)
        {
            var programa = microondas.ProgramasAquecimento.FirstOrDefault(p => p.Nome == "Feijão");
            if (programa != null)
            {
                MessageBox.Show(programa.Instrucoes, "Instruções para Feijão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Programa 'Feijão' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntIntrucoesFrango_Click(object sender, EventArgs e)
        {
            var programa = microondas.ProgramasAquecimento.FirstOrDefault(p => p.Nome == "Frango");
            if (programa != null)
            {
                MessageBox.Show(programa.Instrucoes, "Instruções para Frango", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Programa 'Frango' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntIntrucoesCarneDeBoi_Click(object sender, EventArgs e)
        {
            var programa = microondas.ProgramasAquecimento.FirstOrDefault(p => p.Nome == "Carnes de boi");
            if (programa != null)
            {
                MessageBox.Show(programa.Instrucoes, "Instruções para Carne de Boi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Programa 'Carnes de Boi' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
  