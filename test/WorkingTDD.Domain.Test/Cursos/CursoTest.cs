using ExpectedObjects;
using WorkingTDD.Domain.Test.Model;
using Xunit;

namespace WorkingTDD.Domain.Test.Cursos
{
    public class CursoTest
    {
        [Fact(DisplayName = "CriacaoDoCurso")]
        public void Curso_CriarCurso_RetornaCurso()
        {
            var cursoEsperado = new Curso("Computação", 40, PublicoAlvo.Estudante, 50);

            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Curso_NomeVazioOuNulo_RetornaArgumentException(string nomeInvalido)
        {
            var cursoEsperado = new Curso("Computação", 40, PublicoAlvo.Estudante, 50);

            Assert.Throws<ArgumentNullException>(() => new Curso(nomeInvalido, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor));
        }

        [Theory]
        [InlineData(null, "test")]
        [InlineData("test", null)]
        public void TestChecker<T>(T valueA, T valueB)
        {
            var checker = new Checker();

            Assert.True(checker.Check((dynamic)valueA, (dynamic)valueB));
        }


    }
}
