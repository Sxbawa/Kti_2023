using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Students> _student = new List<Students>
        {
            new Students { StudentId = 1, Name = "Made", Email = "made@gmail.com", BirthDate = new DateOnly(1991, 1, 1) },
            new Students { StudentId = 2, Name = "lexi", Email = "lexi@gmail,com", BirthDate = new DateOnly(1992,2,2) },
            new Students { StudentId = 3, Name = "jon Tor", Email = "jonthor@gmail.com", BirthDate = new DateOnly(1993,3,3) },
            new Students { StudentId = 4, Name = "budi O", Email = "budio@gmail.com", BirthDate = new DateOnly(1994,4,4) },
            new Students { StudentId = 5, Name = "JhoMblo", Email = "jhonmblo@gmail.com", BirthDate = new DateOnly(1995,5,5) },
        };
        public IEnumerable<Students> GetAll()
        {
            return _student;
        }

        public Students GetById(int id)
        {
            return _student.First(s => s.StudentId == id);
        }
    }
}