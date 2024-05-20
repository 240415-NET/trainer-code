using School.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public interface IRepository
    {

        // we only list Method signature, not the behavior of the method.

        public Student GetStudent(int ID);
        public void GetStudents();
    }
}
