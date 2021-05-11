using ApiCrudDepartamentosAWS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudDepartamentosAWS.Data
{
    public class DepartamentosContext : DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext> options)
              : base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
    }

}
