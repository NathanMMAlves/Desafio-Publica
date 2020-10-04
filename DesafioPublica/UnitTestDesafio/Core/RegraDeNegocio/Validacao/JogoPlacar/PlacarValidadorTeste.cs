using DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDesafio.Core.RegraDeNegocio.Validacao.JogoPlacar
{
    [TestClass]
    public class PlacarValidadorTeste
    {
        [TestMethod]
        public void dado_um_placar_vazio_deve_retornar_valido()
        {
            var jogoPlacar = new DesafioCore.DB.Model.JogoPlacar();
            jogoPlacar.Placar = 0;
            var validador = new PlacarValidador();
            var resultado = validador.Validar(jogoPlacar);
            Assert.IsTrue(resultado.Valido);
            Assert.IsNull(resultado.Mensagem);
        }

        [TestMethod]
        [DataRow(999)]
        [DataRow(100)]
        [DataRow(50)]
        public void dado_um_placar_valido_deve_retornar_valido(int placarValido)
        {
            var jogoPlacar = new DesafioCore.DB.Model.JogoPlacar();
            jogoPlacar.Placar = placarValido;
            var validador = new PlacarValidador();
            var resultado = validador.Validar(jogoPlacar);
            Assert.IsTrue(resultado.Valido);
            Assert.IsNull(resultado.Mensagem);
        }

        [TestMethod]
        [DataRow(1000)]
        [DataRow(2500)]
        [DataRow(-100)]
        [DataRow(-1)]
        [DataRow(-1,5)]
        [DataRow(3,5)]
        [DataRow(-5.5)]
        [DataRow(6.5)]
        public void dado_um_placar_invalido_deve_retornar_invalido(int placarInvalido)
        {
            var jogoPlacar = new DesafioCore.DB.Model.JogoPlacar();
            jogoPlacar.Placar = placarInvalido;
            var validador = new PlacarValidador();
            var resultado = validador.Validar(jogoPlacar);
            Assert.IsFalse(resultado.Valido);
            StringAssert.Contains(resultado.Mensagem, "Placar");
            StringAssert.Contains(resultado.Mensagem, "inválido");
        }
    }
}
