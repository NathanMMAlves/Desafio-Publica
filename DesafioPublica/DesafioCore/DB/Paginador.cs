using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioCore.DB
{
    public class Paginador<T> : IPaginador<T> where T : class
    {
        private IEnumerable<T> colecao;

        public Paginador(IEnumerable<T> colecao)
        {
            this.colecao = colecao;
        }

        public int Contar()
        {
            return colecao.Count();
        }

        public IList<T> Executar()
        {
            return colecao.ToList();
        }

        public IPaginador<T> Pegar(int quantidade)
        {
            colecao = colecao.Take(quantidade);
            return this;
        }

        public IPaginador<T> Propriedade(Func<T, bool> condicao)
        {
            colecao = colecao.Where(condicao);
            return this;
        }

        public IPaginador<T> Pular(int pular)
        {
            colecao = colecao.Skip(pular);
            return this;
        }
    }
}
