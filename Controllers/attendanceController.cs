using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class attendanceController : ControllerBase
    {
        // GET: api/attendance
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/attendance/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/attendance
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Attendance value)
        {
            value.Save.CreateAttendance(value);
        }

        // PUT: api/attendance/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/attendance/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
