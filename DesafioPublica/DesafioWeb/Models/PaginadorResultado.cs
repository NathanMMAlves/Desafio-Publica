using DesafioCore.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioWeb.Models
{
    public class PaginadorResultado
    {
        public IList<JogoPlacar> JogoPlacares { get; set; }
        public int TotalRegistros { get; set; }
    }
}
