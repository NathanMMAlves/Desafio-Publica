using DesafioCore.RegraDeNegocio.Validacoes;
using DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestDesafio.Core.RegraDeNegocio.Validacao
{
    [TestClass]
    public class RegraDeValidacaoFactoryTeste
    {
        [TestMethod]
        public void iniciado_o_programa_deve_ter_os_validadores_para_cadastro()
        {
            var factory = new RegrasDeValidacaoFactory();
            var validadores = factory.ObterValidadoresJogoPlacar();
            Assert.AreEqual(validadores.Count(v => v.GetType() == typeof(PlacarValidador)), 1);
            Assert.AreEqual(validadores.Count(v => v.GetType() == typeof(MinimoDaTemporadaValidador)), 1);
            Assert.AreEqual(validadores.Count(v => v.GetType() == typeof(MaximoDaTemporadaValidador)), 1);
            Assert.AreEqual(validadores.Count(v => v.GetType() == typeof(QuebraRecordeMinValidador)), 1);
            Assert.AreEqual(validadores.Count(v => v.GetType() == typeof(QuebreRecordeMaxValidador)), 1);
        }
    }
}
