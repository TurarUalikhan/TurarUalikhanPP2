using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Student 
    {

        private string name; 
        private string id;
        private int yos; 

        public Student(string name, string id)
        {
            this.name = name; 
            this.id = id; 
            
        }
        public string getName() 
        {
            return this.name;
        }
        public string getId() 
        {
            return this.id; 

        }
        public int inc() 
        {
            return ++yos; 
        }

    }
}
