using Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IJugueteRepository
    {
        Task<List<Juguete>> GetJuguetes();
        Task AddJuguete(Juguete jug);
        Task UpdateJuguete(Juguete jug);
        void DeleteJuguete(int Id);
    }
}
