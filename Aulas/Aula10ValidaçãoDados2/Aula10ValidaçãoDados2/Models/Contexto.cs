using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10ValidaçãoDados2.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> usuario { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
