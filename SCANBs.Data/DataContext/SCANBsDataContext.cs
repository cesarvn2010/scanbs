using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCANBs.Data.DataContext
{
    public class SCANBsDataContext : DbContext 
    {
        public SCANBsDataContext() : base("SCANBsEntities") { }
    }
}
