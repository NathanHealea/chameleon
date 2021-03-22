using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathaHealea.Chameleon.Library.Contexts
{
    public class ChameleonDbContext: DbContext
    {
        public ChameleonDbContext(DbContextOptions<ChameleonDbContext> options) : base(options) { }

        // Entitie Tables
        
    }
}
