using Db.Datos;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace ApiJuguetesV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class RepositoryJuguetesController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public RepositoryJuguetesController(TRepository repository)
        {
            this.repository = repository;
        }
        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var juguete = await repository.Get(id);
            if (juguete == null)
            {
                return NotFound();
            }
            return juguete;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity juguete)
        {
            if (id != juguete.Id)
            {
                return BadRequest();
            }
            await repository.Update(juguete);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity juguete)
        {
            await repository.Add(juguete);
            return CreatedAtAction("Get", new { id = juguete.Id }, juguete);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var juguete = await repository.Delete(id);
            if (juguete == null)
            {
                return NotFound();
            }
            return juguete;
        }

    }
}
