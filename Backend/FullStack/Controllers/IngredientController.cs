using DataLaag;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private MyDatabaseContext _dbContext;

        public IngredientController(MyDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/<IngredientController>
        [HttpGet]
        public List<Ingredient> Get()
        {
            return this._dbContext.Ingredients.ToList();
        }

        // GET api/<IngredientController>/12
        [HttpGet("{id}")]
        public Ingredient? Get(int id)
        {
            return this._dbContext.Ingredients.Find(id); 
        }

        // POST api/<IngredientController>
        [HttpPost]
        public Ingredient Post([FromBody] Ingredient i)
        {
            this._dbContext.Ingredients.Add(i);
            this._dbContext.SaveChanges();

            return i;
        }

        // PUT api/<IngredientController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Ingredient newIngredient)
        {
            // Openen
            Ingredient dbIngredient = this._dbContext.Ingredients.Find(id);
            if (dbIngredient == null)
                return false;

            // Aanpassen
            dbIngredient.Name = newIngredient.Name;
            dbIngredient.Vegan = newIngredient.Vegan;
            dbIngredient.Amount = newIngredient.Amount;

            // Opslaan
            this._dbContext.Ingredients.Update(dbIngredient);
            this._dbContext.SaveChanges();

            return true;
        }


        // DELETE api/<IngredientController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            // eerst de ingredient zoeken
            Ingredient dbIngredient = this._dbContext.Ingredients.Find(id);
            if (dbIngredient == null)
                return false;

            this._dbContext.Ingredients.Remove(dbIngredient);
            this._dbContext.SaveChanges();
            return true;
        }
    }
}
