using Db.Datos.EFCore;
using Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.EFCore
{
    public class EfCoreJuguetesRepository : EfCoreRepository<Juguete, JugueteContext>
    {
        public EfCoreJuguetesRepository(JugueteContext context) : base(context)
        {
        }
    }
}
