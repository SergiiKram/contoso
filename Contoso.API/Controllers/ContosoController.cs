using Contoso.API.Data;
using Contoso.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContosoController : ControllerBase
    {
        private ContosoContext _contosoContext;

        public ContosoController(ContosoContext contosoContext)
        {
            _contosoContext = contosoContext;
        }

        [HttpGet]
        public async Task<IEnumerable<ContosoData>> Get()
        {
            return await _contosoContext.ContosoData.ToListAsync();
        }
    }
}
