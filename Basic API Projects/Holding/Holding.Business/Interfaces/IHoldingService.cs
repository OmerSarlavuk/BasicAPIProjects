using Holding.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding.Business.Interfaces
{
    public interface IHoldingService
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student Create(Student student);
        Student Update(Student student);
        void Delete(int id);
    }
}
