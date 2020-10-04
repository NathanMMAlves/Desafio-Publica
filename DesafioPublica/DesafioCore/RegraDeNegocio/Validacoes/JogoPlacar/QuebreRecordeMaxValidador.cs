using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar
{
    public class QuebreRecordeMaxValidador : IValidacao<DB.Model.JogoPlacar>
    {
        public ResultadoValidacao Validar(DB.Model.JogoPlacar model)
        {
            if(model.QuebraRecordeMax >= 0)
            {
                return new ResultadoValidacao { Valido = true };
            }
            return new ResultadoValidacao
            {
                Valido = false,
                Mensagem = "Ocorreu algum erro ao calcular Quebra Recorde Máx."
            };
        }
    }
}
