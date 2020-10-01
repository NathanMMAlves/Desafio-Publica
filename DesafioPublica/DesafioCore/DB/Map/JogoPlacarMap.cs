using DesafioCore.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.DB.Map
{
    public class JogoPlacarMap : IDataBaseMap
    {
        //Mapeação das informações para o BD
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogoPlacar>().HasKey(x => x.Id);
            modelBuilder.Entity<JogoPlacar>().Property(x => x.Placar).IsRequired();
            modelBuilder.Entity<JogoPlacar>().Property(x => x.MaximoDaTemporada).IsRequired();
            modelBuilder.Entity<JogoPlacar>().Property(x => x.MinimoDaTemporada).IsRequired();
            modelBuilder.Entity<JogoPlacar>().Property(x => x.QuebraRecordeMin).IsRequired();
            modelBuilder.Entity<JogoPlacar>().Property(x => x.QuebreRecordeMax).IsRequired();
        }
    }
}
