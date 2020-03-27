using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppLecture3.DAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppLecture3
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase //contains many useful helper methods that we will use
    {

        private readonly IDbService dbService;
     
        public StudentsController(IDbService dbService)
        {
            this.dbService = dbService;
        }
        //[HttpGet]
        //public string GetStudent()
        //{
        //    return "Kowalski, Andrzejewski";
        //}

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }
            return NotFound("student with given Id not found");
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(dbService.getStudents());
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            return Ok("Update complete");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Delete Complete");
        }
    }


}
