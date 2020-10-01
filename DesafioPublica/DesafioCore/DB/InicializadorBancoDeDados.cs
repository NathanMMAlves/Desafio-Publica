using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioCore.DB
{

    //É por aqui que o BD sera inicializado.
    //Caso não haja banco criado, ele irá criar um automaticamente.
    public class InicializadorBancoDeDados
    {
        private IManipuladorBancoDeDados manipuladorBancoDeDados;

        public InicializadorBancoDeDados(IManipuladorBancoDeDados manipuladorBancoDeDados)
        {
            this.manipuladorBancoDeDados = manipuladorBancoDeDados;
        }

        public void Iniciar()
        {
            if (!File.Exists(Constantes.NomeArquivoBanco))
                manipuladorBancoDeDados.CriarNovo();
        }
    }
}
