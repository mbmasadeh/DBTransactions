using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly ServiceManager _serviceManager;
        public DefaultController(Context context, ServiceManager serviceManager)
        {
            _context = context;
            _serviceManager = serviceManager;
        }
        [HttpPost]
        public IActionResult Post ([FromBody] StudentsViewModel students)
        {
            var service = _serviceManager.NewService<TransactionsService>();
            var addStudent = service.AddStudent(students);
            return Ok(addStudent);
        }
    }
}