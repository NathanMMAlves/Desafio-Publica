using DesafioCore.RegraDeNegocio.Validacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio
{
    // Interface para validar
    public interface IValidacao<T>
    {
        ResultadoValidacao Validar(T model);
    }
}
