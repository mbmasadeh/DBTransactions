using AutoMapper;
using DBTransactions.DataBase;
using DBTransactions.Models;
using DBTransactions.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public bool StudentsMatchCourse (RootObjectViewModel coursesList, int id)
        {
            List<StudentCourse> Addnew = new List<StudentCourse>();
            var match = new StudentCourse();
            foreach (var item in coursesList.CourseID)
            {
                match.StrudentID = id;
                match.CourseID = item.ID;
                _context.StudentCourse.Add(match);
            }
           
            _context.SaveChanges();
            return true;
        }
        //public async List<StudentInfoViewModel> GetStudentInfo(int id)
        //{
        //    var studentId = new SqlParameter("id", id);
        //    var info = _context.Database.ExecuteSqlCommand("select c.CourseName, s.StudentName from c.Courses, s.Students sc.StudentCourse where"
        //                                                 + " s innerjoin sc on s.id=sc.StrudentID"
        //                                                 + "");
        //    return null;
        //}

    }
}
