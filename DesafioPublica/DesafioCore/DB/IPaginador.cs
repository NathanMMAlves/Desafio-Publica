using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.DB
{
    public interface IPaginador<T> where T:class
    {
        IPaginador<T> Propriedade(Func<T, bool> condicao);
        int Contar();
        IList<T> Executar();
        IPaginador<T> Pular(int pular);
        IPaginador<T> Pegar(int quantidade);
    }
}
}
