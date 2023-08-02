namespace WorkingTDD.Domain.Test.Model
{
    public class Curso
    {
        public string Nome { get; private set; } = string.Empty;
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double Valor { get; private set; }

        public Curso(string Nome, double CargaHoraria, PublicoAlvo PublicoAlvo, double Valor)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                throw new ArgumentNullException("Nome inválido!");
            }

            this.Nome = Nome;
            this.CargaHoraria = CargaHoraria;
            this.PublicoAlvo = PublicoAlvo;
            this.Valor = Valor;
        }
    }
}
