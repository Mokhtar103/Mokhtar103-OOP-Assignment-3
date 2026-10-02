using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    public class StudentStore
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public Student? GetById(int id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public IReadOnlyList<Student> GetAll()
        {
            return _students;
        }

        public void Remove(int id)
        {
            var student = GetById(id);

            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
