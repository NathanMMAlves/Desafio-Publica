using DesafioCore.DB.Model;
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
                // aqui ficaram as validações
            };

            return validacoes;
        }
    }
}
