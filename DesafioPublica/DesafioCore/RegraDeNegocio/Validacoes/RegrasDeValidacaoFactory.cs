using DesafioCore.DB.Model;
using DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes
{
    public class RegrasDeValidacaoFactory
    {
        public IList<IValidacao<DB.Model.JogoPlacar>> ObterValidadoresJogoPlacar()
        {
            var validacoes = new List<IValidacao<DB.Model.JogoPlacar>>
            {
                new PlacarValidador(),
                new MinimoDaTemporadaValidador(),
                new MaximoDaTemporadaValidador(),
                new QuebraRecordeMinValidador(),
                new QuebreRecordeMaxValidador()                                        
            };
            return validacoes;
        }
    }
}
