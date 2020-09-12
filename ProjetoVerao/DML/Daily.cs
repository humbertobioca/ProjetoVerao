using System;
namespace ProjetoVerao.DML
{
    public class Daily
    {
        public int CodigoDaily { get; set; }
        public string Nome { get; set; }
        public string Extensao { get; set; }
        public string Caminho { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataManutencao { get; set; }
    }
}
