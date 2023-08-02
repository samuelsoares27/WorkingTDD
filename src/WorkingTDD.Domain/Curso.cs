namespace WorkingTDD.Domain
{
    public class Curso
    {
        public string Nome { get; private set; } = string.Empty;
        public double CargaHoraria { get; private set; }
        public string PublicoAlvo { get; private set; } = string.Empty;
        public double Valor { get; private set; }

        public Curso(string Nome, double CargaHoraria, string PublicoAlvo, double Valor) { 
        
            this.Nome = Nome;
            this.CargaHoraria = CargaHoraria;
            this.PublicoAlvo = PublicoAlvo;
            this.Valor = Valor;
        }
    }
}
