using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar
{
    public class MinimoDaTemporadaValidador : IValidacao<DB.Model.JogoPlacar>
    {
        public ResultadoValidacao Validar(DB.Model.JogoPlacar model)
        {
            var minimo = model.MinimoDaTemporada;

            if (minimo < 0 || minimo > 999)
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
                Mensagem = "Houve inválides no mínimo da temporada."
            };
        }
    }
}
