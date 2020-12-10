using EvaluacionEcotec.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaEcotec
{
    public class ContactoDbContext : DbContext
    {
        public ContactoDbContext(DbContextOptions<ContactoDbContext> options) : base(options)
        {

        }
        public DbSet<Contacto> Contacto { get; set; }
    }
}
