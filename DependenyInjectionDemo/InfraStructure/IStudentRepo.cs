using DependenyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenyInjectionDemo.InfraStructure
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
        Student GetById(int id);
        
    }
}
