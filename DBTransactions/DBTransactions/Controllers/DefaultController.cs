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

        [HttpPost]
        public IActionResult PostStudent([FromBody] StudentsViewModel students)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var addStudent = service.AddStudent(students);
            return Ok(addStudent);
        }
        [HttpPost]
        public IActionResult PostCourse([FromBody] CoursesViewModel courses)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var addCourse = service.AddCourse(courses);
            return Ok(addCourse);
        }
        
        [HttpPost("Connect/{id}")]
        public IActionResult Connect([FromBody] CoursesListViewModel coursesList, int id)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            return Ok();
        }
    }
}