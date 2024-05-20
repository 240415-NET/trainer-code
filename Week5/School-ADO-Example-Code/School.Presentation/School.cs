using School.Data;
using School.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.App
{
    public class School
    {
        // Fields
        IRepository repo;

   

        // Costructor
        public School(IRepository repo)
        {
            this.repo = repo;
        }


        // Methods
        public Student GetStudent(int ID)
        {
            return this.repo.GetStudent(ID);
        }

        //repo.Insert(st2);
        //repo.GetStudents();
    
        
    }
}
