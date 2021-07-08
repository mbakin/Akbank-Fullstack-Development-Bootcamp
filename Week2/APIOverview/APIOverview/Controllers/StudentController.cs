using APIOverview.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIOverview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // returns all students

        List<Student> students = new List<Student>
            {
                new Student {Id=1, Name="Mehmet ", LastName="Akin", Address="Izmir"},
                new Student {Id=2, Name="Burak", LastName="Konakay", Address="Istanbul"},
                new Student {Id=3, Name="Furkan", LastName="Ercel", Address="Istanbul"},
                new Student {Id=4, Name="Mehmet ", LastName="Akin", Address="Canakkale"}
            };
        [HttpGet]
        public IActionResult GetStudents()
        {

            return Ok(students);
        }
        [HttpGet("{ogrID:int}")]
        public IActionResult GetStudent(int ogrID)
        {
            var student = students.FirstOrDefault(stu => stu.Id == ogrID);
            if (student ==null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpGet("{city}")]
        public IActionResult GetStudentsByCity(string city) 
        {
            var findingStudents = students.Where(x => x.Address.Contains(city));
            if (findingStudents ==null)
            {
                return NotFound();
            }
            return Ok(findingStudents);
        }

    }
}
