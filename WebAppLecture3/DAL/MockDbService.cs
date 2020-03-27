using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLecture3.DAL
{
    public class MockDbService : IDbService
    {

        private static IEnumerable<Student> students;

        static MockDbService()
        {
            students = new List<Student>
            {
                new Student{Id=1, FirstName="Peter", LastName="Jackson" },
                new Student{Id=2, FirstName="Jason", LastName="Brown" },
                new Student{Id=3, FirstName="Kyle", LastName="Kowalski" }
            };

        }
        public IEnumerable<Student> getStudents()
        {
            return students;
        }
    }
}
