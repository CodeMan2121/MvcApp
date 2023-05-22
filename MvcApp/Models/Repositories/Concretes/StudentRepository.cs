using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;
using System.Linq;

namespace MvcApp.Models.Repositories.Concretes
{
    public class StudentRepository : IStudentRepository
    {
        protected DbContext Context { get; set; }
        public StudentRepository(DbContext context)
        {
            Context = context;
            
        }
        public Student Add(Student student)
        {
            Context.Entry(student).State = EntityState.Added;
            Context.SaveChanges();
            return student;


        }

        public Student Delete(Student student)
        {
            Context.Entry(student).State = EntityState.Deleted;
            Context.SaveChanges();
            return student;
        }

        

        public Student Update(Student student)
        {
            Context.Entry(student).State = EntityState.Modified;
            Context.SaveChanges();
            return student;
        }

        public Student Get(string id)
        {
            return Context.Set<Student>().FirstOrDefault(c => c.Id == Guid.Parse(id));

        }
    }
}
