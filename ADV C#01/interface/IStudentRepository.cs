using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_C_01.@interface
{
    class StudentRepository : IRepository<Student>
    {
        private List<Student> students = new List<Student>();

        public void Add(Student item)
        {
            students.Add(item);
        }

        public void Remove(Student item)
        {
            students.Remove(item);
        }

        public Student Get(int index)
        {
            return students[index];
        }

        public Student GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
