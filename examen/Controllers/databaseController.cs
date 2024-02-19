using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using examen.Data;

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class databaseController: ControllerBase
	{
        private readonly clasaContext _clasaContext;

        public databaseController(clasaContext clasaContext)
        {
            _clasaContext = clasaContext;
        }
    }
}

