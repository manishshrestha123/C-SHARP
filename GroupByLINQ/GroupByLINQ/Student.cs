using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByLINQ
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
        public static List<Student> GetDetail()
        {
            return new()
        {
            new Student {ID= 1, FirstName="Manish", LastName= "Shrestha", Age= 22, Faculty = "Bsc CSIT"  },
            new Student {ID= 2, FirstName= "Sabina", LastName= "Shrestha", Age = 21, Faculty = "BCA"},
            new Student {ID= 3, FirstName="Mijash", LastName ="Rajthala", Age =23, Faculty = "Bsc CSIT"},
            new Student {ID= 4, FirstName= "Samir", LastName= "Shrestha", Age = 22, Faculty = "Bsc CSIT" },
            new Student {ID= 5, FirstName="Nikita", LastName ="Shrestha", Age =21 ,Faculty = "BIT"},
            new Student {ID= 6, FirstName= "Roshan", LastName ="Thapamagar", Age = 20, Faculty ="BIT" },
            new Student {ID= 7, FirstName= "Bipin", LastName = "Adhikari", Age = 23, Faculty="BIM"},
            new Student {ID= 8, FirstName= "Rahul", LastName = "Sharma", Age=21 , Faculty = "BCA"},
            new Student {ID= 9, FirstName= "Kriti", LastName = "Malla", Age =23, Faculty = "BIM"},
            new Student {ID= 10, FirstName= "Manisha", LastName= "Rajthala", Age= 21, Faculty= "Bsc CSIT"}

        };
        }
    }

}

   
