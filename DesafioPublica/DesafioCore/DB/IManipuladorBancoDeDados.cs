using DesafioCore.DB.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.DB
{
    //Interface para o Manipulação do BD
    public interface IManipuladorBancoDeDados
    {
        void CriarNovo();
        void AdicionarPlacar(JogoPlacar jogoPlacar);
    }
}
