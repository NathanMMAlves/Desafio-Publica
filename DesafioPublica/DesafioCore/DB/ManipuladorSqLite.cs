using DesafioCore.DB.Map;
using DesafioCore.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.DB
{

    //É aqui que sera feito o registro no BD de todos os jogos cadastrados
    public class ManipuladorSqLite : DbContext, IManipuladorBancoDeDados
    {
        private DbSet<JogoPlacar> JogosPlacares { get; set; }
        public void AdicionarPlacar(JogoPlacar jogoPlacar)
        {
            JogosPlacares.Add(jogoPlacar);
            SaveChanges();
        }

        public void CriarNovo()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=" + Constantes.NomeArquivoBanco);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new JogoPlacarMap().Map(modelBuilder);
        }

        public IPaginador<JogoPlacar> Paginar()
        {
            return new Paginador<JogoPlacar>(JogosPlacares);
        }
    }
}
