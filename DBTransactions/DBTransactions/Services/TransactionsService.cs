using AutoMapper;
using DBTransactions.DataBase;
using DBTransactions.Models;
using DBTransactions.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Services
{
    public class TransactionsService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public TransactionsService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Students AddStudent(StudentsViewModel students)
        {
            var mapping = _mapper.Map<Students>(students);
            _context.Add(mapping);
            _context.SaveChanges();
            return mapping;          
        }

        public Courses AddCourse(CoursesViewModel course)
        {
            var mapping = _mapper.Map<Courses>(course);
            _context.Add(mapping);
            _context.SaveChanges();
            return mapping;
        }

    }
}
