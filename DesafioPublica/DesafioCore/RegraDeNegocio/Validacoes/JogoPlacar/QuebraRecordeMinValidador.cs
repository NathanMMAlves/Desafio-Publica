using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes.JogoPlacar
{
    public class QuebraRecordeMinValidador : IValidacao<DB.Model.JogoPlacar>
    {
        public ResultadoValidacao Validar(DB.Model.JogoPlacar model)
        {
            if(model.QuebraRecordeMin >= 0)
            {
                return new ResultadoValidacao { Valido = true };
            }
            return new ResultadoValidacao
            {
                Valido = false,
                Mensagem = "Ocorreu algum erro ao calcular Quebra Recorde Min."
            };
        }
    }
}
