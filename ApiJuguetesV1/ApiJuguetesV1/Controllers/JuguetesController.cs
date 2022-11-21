using Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.EFCore;

namespace ApiJuguetesV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuguetesController :RepositoryJuguetesController<Juguete, EfCoreJuguetesRepository>
    {
        public JuguetesController(EfCoreJuguetesRepository repository) : base(repository)
        {

        }
    }
}
