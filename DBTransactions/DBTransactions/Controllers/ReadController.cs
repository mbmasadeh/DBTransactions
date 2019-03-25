using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using DBTransactions.DataBase;
using System.Threading.Tasks;
using DBTransactions.Services;
using AutoMapper;

namespace DBTransactions.Controllers
{
    [Area("api")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ReadController : Controller
    {
        private readonly Context _context;
        private readonly ServiceManager _serviceManager;
        private readonly IMapper _mapper;
        public ReadController(Context context, ServiceManager serviceManager, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _serviceManager = serviceManager;
        }
        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var allStudents = service.ReadAllStudent();
            return Ok(allStudents);
        }
        [HttpGet("GetStudent/{id}")]
        public IActionResult GetStudent (int id)
        {
            var service = _serviceManager.NewService<TransactionsService>(_context, _mapper);
            var singleStudent = service.ReadSingleStudent(id);
            return Ok(singleStudent);
        }
    }
}
