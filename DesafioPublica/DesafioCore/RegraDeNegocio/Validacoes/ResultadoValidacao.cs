using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.RegraDeNegocio.Validacoes
{
    // Estrutura para guardar se uma validação é valida e a mensagem de erro
    public struct ResultadoValidacao
    {
        public bool Valido { get; set; }
        public string Mensagem { get; set; }
    }
}
