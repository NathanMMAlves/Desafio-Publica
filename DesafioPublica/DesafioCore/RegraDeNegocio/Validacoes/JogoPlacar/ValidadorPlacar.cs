using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar
{
    public class ValidadorPlacar : IValidacao<DB.Model.JogoPlacar>
    {
        public ResultadoValidacao Validar(DB.Model.JogoPlacar model)
        {
            var placar = model.Placar;

            if (placar < 0 || placar > 1000)
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
                Mensagem = "Esse placar é inválido!"
            };
        }
    }
}
