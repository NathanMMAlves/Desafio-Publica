using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCore.DB.Map
{
    public interface IDataBaseMap
    {
        //Interface para Map da Data Base
        void Map(ModelBuilder modelBuilder);
    }
}
