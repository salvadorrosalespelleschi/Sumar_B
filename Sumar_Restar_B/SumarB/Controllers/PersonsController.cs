using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumarB.Models;

namespace SumarB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public Person listar() {
            Person person = new Person {PersonID=1,Name="Salvador Rosales" };
            return person;
        }
    }
}
