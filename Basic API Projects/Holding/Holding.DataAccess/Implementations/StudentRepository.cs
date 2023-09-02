using Holding.DataAccess.EF.Context;
using Holding.DataAccess.EF.Interfaces;
using Holding.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding.DataAccess.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public Student Create(Student student)
        {
            using (HoldingContext context = new HoldingContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
                return student;
            }
        }

        public void Delete(int id)
        {
            using (HoldingContext context = new HoldingContext())
            {
                var result = context.Students.Find(id);

                if (result != null) 
                {
                    context.Students.Remove(result);
                }
                context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            using (HoldingContext context = new HoldingContext())
            {
                return context.Students.ToList();
            }
        }

        public Student GetById(int id)
        {
            using (HoldingContext context = new HoldingContext())
            {
                var result = context.Students.Find(id);
                return result!;
            }
        }

        public Student Update(Student student)
        {
            using (HoldingContext context = new HoldingContext())
            {
                context.Students.Update(student);
                context.SaveChanges ();
                return student;
            }
        }
    }
}
