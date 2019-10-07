using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Petshop.Core.Appservice;
using Petshop.Core.Entity;

namespace PetRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }
        // GET api/pets
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            try
            {
                return Ok(_petService.GetAllPets());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // GET api/pets/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            try
            {
                return Ok(_petService.GetByIdPet(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // POST api/pets
        [HttpPost]
        public ActionResult <Pet> Post([FromBody] Pet pet)
        {
            try
            {
                return Ok(_petService.CreatePet(pet));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/pets/5
        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] Pet petupdate)
        {
            if (id < 1 || id != petupdate.Id)
            {
                return BadRequest("Parameter Id and product ID must be the same");
            }

            return Ok(_petService.UpdatePet(petupdate));
        }

        // DELETE api/pets/5
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            return Ok($"pet with Id: {id} has been deleted");
        }
    }
}
 