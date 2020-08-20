using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula11ConsultaBancodeDados.Models
{
    public class Contexto: DbContext
    {
        public DbSet<UsuarioDB> UsuarioDB { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
