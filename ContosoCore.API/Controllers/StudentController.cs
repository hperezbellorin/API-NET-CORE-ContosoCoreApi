using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCore.DAL.Repos.Interface;
using ContosoCore.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _student;
        public StudentController(IStudentRepo _student)
        {
            this._student = _student;
        }
        // GET: api/Student
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_student.GetAll());
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var student = _student.Find(id);
            if(student != null)
            {
                return Ok(student);
            }
            else
            {
                return NotFound();
            }
            
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult Post([FromBody] Student estudiante)
        {
            if (estudiante!=null)
            {
                _student.Add(estudiante);
            }

            return Created(HttpContext.Request.Host + Request.Path + " /" + estudiante.Id, estudiante);

        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student estudiante)
        {
            if (id > 0 && estudiante != null)
            {
                var student = _student.Find(id);
                student.FisrtMidName = estudiante.FisrtMidName;
                student.LastName = estudiante.LastName;
                student.UsuarioModificacion = estudiante.UsuarioModificacion;
                student.FechaModificacion = DateTime.Now;
                
                _student.Update(student);

                return Created(HttpContext.Request.Host + Request.Path + " /" + student.Id, student);
            }

            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _student.Find(id); ;
            if (student!=null)
            {
                _student.Delete(student);
                return NoContent();
            }

            return BadRequest();
        }
    }
}
