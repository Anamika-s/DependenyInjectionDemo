using DependenyInjectionDemo.DataContext;
using DependenyInjectionDemo.InfraStructure;
using DependenyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenyInjectionDemo.Repository
{
    public class StudentRepository : IStudentRepo
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
