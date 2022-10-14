using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using pim.project.persistence;
using pim.project.domain;

namespace pim.project.controller
{
    [ApiController]
    [Route("pim/project")]
    public class PimProjectController : ControllerBase
    {
        private readonly PersistenceContext _context;

        public PimProjectController(PersistenceContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("phone/type/list")]
        public async Task<IActionResult> GetPhoneType()
        {
            var types = await _context.PeoplePhoneType
                                 .ToListAsync();

            return Ok(types);
        }

        [HttpPost]
        [Route("phone/type/add")]
        public async Task<IActionResult> PostPhoneType([FromBody] PeoplePhoneType type)
        {
            _context.PeoplePhoneType
                .Add(type);
                                
            _context.SaveChanges();

            return Ok(type);
        }
    }
}
