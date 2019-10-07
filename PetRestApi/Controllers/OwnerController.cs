using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petshop.Core;
using Petshop.Core.Entity;

namespace PetRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet]
        public ActionResult<Owner> Get()
        {
            try
            {
                return Ok(_ownerService.FindAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}