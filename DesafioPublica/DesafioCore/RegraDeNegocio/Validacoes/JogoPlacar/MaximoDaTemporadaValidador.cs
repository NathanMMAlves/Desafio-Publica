using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar
{
    public class MaximoDaTemporadaValidador : IValidacao<DB.Model.JogoPlacar>
    {
        public ResultadoValidacao Validar(DB.Model.JogoPlacar model)
        {
            var maximo = model.MaximoDaTemporada;

            if (maximo < 0 || maximo > 999)
                return Invalido();
            else
                return Valido();
        }
        private ResultadoValidacao Valido()
        {
            return new ResultadoValidacao { Valido = true };
        }

        private ResultadoValidacao Invalido()
        {
            return new ResultadoValidacao
            {
                Valido = false,
                Mensagem = "Houve inválides no máximo da temporada."
            };
        }
    }
}
