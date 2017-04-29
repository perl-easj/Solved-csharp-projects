using System.Collections.Generic;
using System.Linq;

namespace SchoolAdministrationV10
{
    public class StudentCatalog
    {
        private Dictionary<int, Student> _students;

        public StudentCatalog()
        {
            _students = new Dictionary<int, Student>();
        }

        /// <summary>
        /// Return the number of students in the catalog.
        /// </summary>
        public int Count
        {
            get
            {
                return _students.Count;
            }
        }

        /// <summary>
        /// Add a single student to the catalog.
        /// </summary>
        public void AddStudent(Student aStudent)
        {
            _students.Add(aStudent.ID,aStudent);
        }

        /// <summary>
        /// Given an id, return the student with that id.
        /// If no student exists with the given id, return null.
        /// </summary>
        public Student GetStudent(int id)
        {
            if (_students.ContainsKey(id))
            {
                return _students[id];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        public int GetAverageForStudent(int id)
        {
            if (_students.ContainsKey(id))
            {
                return _students[id].ScoreAverage;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Returns the total test score average for ALL students in the catalog.
        /// </summary>
        public int TotalAverage
        {
            get
            {
                if (_students.Count == 0)
                {
                    return -1;
                }
                else
                {
                    int sum = 0;

                    foreach (var student in _students.Values)
                    {
                        sum = sum + student.ScoreAverage;
                    }

                    return (sum / Count);
                }
            }
        }
    }
}