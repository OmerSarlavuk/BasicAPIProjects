using Holding.Business.Interfaces;
using Holding.DataAccess.EF.Interfaces;
using Holding.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding.Business.Implementations
{
    public class HoldingManager : IHoldingService
    {
        private readonly IStudentRepository _repository;

        public HoldingManager(IStudentRepository repository)
        {
            _repository = repository;
        }
        public Student Create(Student student)
        {
            return _repository.Create(student); 
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Student> GetAll()
        {
            return _repository.GetAll();
        }

        public Student GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Student Update(Student student)
        {
            return _repository.Update(student);
        }
    }
}
