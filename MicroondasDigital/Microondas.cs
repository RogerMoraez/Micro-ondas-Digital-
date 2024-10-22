using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace MicroondasDigital
{
    public class Microondas
    {
        public int TempoEmSegundos { get; set; }
        public int Potencia { get; set; } = 10;
        public bool EmAquecimento { get; set; } = false;
        public bool Pausado { get; set; } = false;

        public ProgramaAquecimento ProgramaAquecimentoAtual { get; private set; }
        public List<ProgramaAquecimento> ProgramasAquecimento { get; private set; }
        public event Action<string, string> AtualizarDisplay;
        public delegate void AtualizarProgressoEventHandler(string progresso);
        public event AtualizarProgressoEventHandler AtualizarProgresso;


        public void IniciarAquecimento(int tempo, int potencia, ProgramaAquecimento programa = null, bool ignorarValidacao = false)
        {
            if ((programa == null || programa.IsCustomizado) && !ignorarValidacao && (tempo < 1 || tempo > 120))
            {
                throw new ArgumentException("O tempo deve ser entre 1 segundo e 2 minutos.");
            }

            if (potencia < 1 || potencia > 10)
            {
                throw new ArgumentException("A potência deve ser entre 1 e 10.");
            }

            ProgramaAquecimentoAtual = programa;
            TempoEmSegundos = tempo;
            Potencia = potencia;
            EmAquecimento = true;
            Pausado = false;

            string progresso;

            if (programa != null && !programa.IsCustomizado)
            {
                progresso = programa.StringAquecimento;
            }
            else
            {
                progresso = GerarProgresso();
            }

            AtualizarProgresso?.Invoke(progresso);
        }
        public void InicioRapido()
        {
            IniciarAquecimento(30, 10, ignorarValidacao: true);
        }
        public void ProcessarAquecimento()
        {
            if (EmAquecimento && TempoEmSegundos > 0)
            {
                TempoEmSegundos--;
                string progresso = GerarProgresso();
                AtualizarProgresso?.Invoke(progresso);
            }

            if (TempoEmSegundos <= 0)
            {
                EmAquecimento = false;
                AtualizarProgresso?.Invoke("Aquecimento concluído.");
            }
        }
        public void AdicionarTempo()
        {
            if (EmAquecimento)
            {
                TempoEmSegundos = Math.Min(TempoEmSegundos + 30, 120);
            }
        }
        public void PausarAquecimento()
        {
            if (EmAquecimento)
            {
                Pausado = true;
                EmAquecimento = false;
            }
        }
        public void RetomarAquecimento()
        {
            if (Pausado)
            {
                Pausado = false;
                EmAquecimento = true;
            }
        }
        public void CancelarAquecimento()
        {
            EmAquecimento = false;
            Pausado = false;
            TempoEmSegundos = 0;
            Potencia = 10;
        }
        public string GerarProgresso()
        {
            int totalPontos = TempoEmSegundos;
            StringBuilder progresso = new StringBuilder();

            for (int i = 0; i < totalPontos; i++)
            {
                if (i > 0 && i % Potencia == 0)
                {
                    progresso.Append(" ");
                }
                progresso.Append(".");
            }
            return progresso.ToString();
        }
        public string FormatarTempo(int tempo)
        {
            int minutos = tempo / 60;
            int segundos = tempo % 60;
            return $"{minutos}:{segundos:D2}";
        }

        public class ProgramaAquecimento
        {
            public string Nome { get; set; }
            public string Alimento { get; set; }
            public int Tempo { get; set; }
            public int Potencia { get; set; }
            public string StringAquecimento { get; set; }
            public string Instrucoes { get; set; }
            public bool IsCustomizado { get; set; }

            public ProgramaAquecimento(string nome, string alimento, int tempo, int potencia, string stringAquecimento, string instrucoes, bool isCustomizado = false)
            {
                Nome = nome;
                Alimento = alimento;
                Tempo = tempo;
                Potencia = potencia;
                StringAquecimento = stringAquecimento;
                Instrucoes = instrucoes;
                IsCustomizado = isCustomizado;
            }
        }
        public Microondas()
        {
            ProgramasAquecimento = new List<ProgramaAquecimento>
        {
            new ProgramaAquecimento(
                isCustomizado: false,
                nome: "Pipoca",
                alimento: "Pipoca (de micro-ondas)",
                tempo: 180,
                potencia: 7,
                stringAquecimento: "Pop...Pop...Pop",
                instrucoes: "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento."
            ),
            new ProgramaAquecimento(
                isCustomizado: false,
                nome: "Leite",
                alimento: "Leite",
                tempo: 300,
                potencia: 5,
                stringAquecimento: "Bzzz...Bzzz",
                instrucoes: "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras."
            ),
            new ProgramaAquecimento(
                isCustomizado: false,
                nome: "Carnes de boi",
                alimento: "Carne em pedaço ou fatias",
                tempo: 840,
                potencia: 4,
                stringAquecimento: "Sizzle...Sizzle...",
                instrucoes: "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme."
            ),
            new ProgramaAquecimento(
                isCustomizado : false,
                nome: "Frango",
                alimento: "Frango (qualquer corte)",
                tempo: 480,
                potencia: 7,
                stringAquecimento: "Grill...Grill...",
                instrucoes: "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme."
            ),
            new ProgramaAquecimento(
                isCustomizado : false,
                nome: "Feijão",
                alimento: "Feijão congelado",
                tempo: 480,
                potencia: 9,
                stringAquecimento: "Boil...Boil...",
                instrucoes: "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas."
            )
        };
        }
        public void SalvarProgramas(List<ProgramaAquecimento> programas, string caminho)
        {
            var json = JsonConvert.SerializeObject(programas);
            File.WriteAllText(caminho, json);
        }
        public List<ProgramaAquecimento> CarregarProgramas(string caminho)
        {
            if (File.Exists(caminho))
            {
                var json = File.ReadAllText(caminho);
                return JsonConvert.DeserializeObject<List<ProgramaAquecimento>>(json);
            }
            return new List<ProgramaAquecimento>();
        }
    }
}

