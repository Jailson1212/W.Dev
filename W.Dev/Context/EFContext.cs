using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using W.Dev.Models;

namespace W.Dev.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }
        public DbSet<Sessão> Sessões { get; set; }
    }
}