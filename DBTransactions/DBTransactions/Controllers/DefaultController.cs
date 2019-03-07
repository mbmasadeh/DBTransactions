using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DBTransactions.DataBase;
using DBTransactions.Services;
using DBTransactions.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBTransactions.Controllers
{
    [Area("api")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly ServiceManager _serviceManager;
        public DefaultController(Context context, ServiceManager serviceManager, IMapper mapper)
        {
            _context = context;
            _serviceManager = serviceManager;
            _mapper = mapper;
        }

        [HttpPost("PostStudent")]
        public IActionResult PostStudent([FromBody] StudentsViewModel students)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var addStudent = service.AddStudent(students);
            return Ok(addStudent);
        }
 
        [HttpPost("PostCourse")]
        public IActionResult PostCourse([FromBody] CoursesViewModel courses)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var addCourse = service.AddCourse(courses);
            return Ok(addCourse);
        }
        
        [HttpPost("Connect/{studentID}")]
        public IActionResult Connect([FromBody] RootObjectViewModel coursesList, int studentID)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var addCourses = service.StudentsMatchCourse(coursesList, studentID);
            return Ok("Done");
        }
        [HttpGet]
        public IActionResult Get(int studentID)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            //var getInfo=service.
            return Ok();
        }
    }
}