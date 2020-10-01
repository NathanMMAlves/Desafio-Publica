using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.DB.Model
{
    public class JogoPlacar
    {
        public int Id { get; set; }
        public int Placar { get; set; }
        public int MaximoDaTemporada { get; set; }
        public int MinimoDaTemporada { get; set; }
        public int QuebraRecordeMin { get; set; }
        public int QuebreRecordeMax { get; set; }
    }
}
