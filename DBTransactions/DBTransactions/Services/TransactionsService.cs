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

        public ResultsViewModel ReadAllStudent()
        {
            var all = _context.Students.ToList();
            return new ResultsViewModel { status = true, data = all };
        }
        public ResultsViewModel ReadSingleStudent(int id)
        {
            //Check availability
            var student = _context.Students.FirstOrDefault(x => x.ID == id);
            if (student == null)
                return new ResultsViewModel { status = false, message = "No students found" };
            return new ResultsViewModel { status = true, data = student };
        }
        public ResultsViewModel AddStudent(StudentsViewModel students)
        {
            //Check for dublication
            var dublication = _context.Students.Any(x => x.Email == students.Email);
            if (dublication == true)
            {
                return new ResultsViewModel { status = false, message = "Duplicated recored" };
            }
            else
            {
                var mapping = _mapper.Map<Students>(students);
                _context.Add(mapping);
                _context.SaveChanges();
                return new ResultsViewModel { status = true, data = mapping }; ;
            }
        }

        public ResultsViewModel AddCourse(CoursesViewModel course)
        {
            //check for dublication
            var check = _context.Courses.Any(x => x.CourseName == course.CourseName);
            if (check == true)
            {
                return new ResultsViewModel { status = false, message = "Duplicated recored" };
            }
            else
            {
                var mapping = _mapper.Map<Courses>(course);
                _context.Add(mapping);
                _context.SaveChanges();
                return new ResultsViewModel { status = true, data = mapping };
            }
        }

        public bool StudentsMatchCourse(RootObjectViewModel coursesList, int id)
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
