using System;
using System.Collections.Generic;

namespace SchoolAdministrationV10
{
    public class Student
    {
        private int _id;
        private string _name;
        private Dictionary<string, int> _testScores;

        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Student(int id, string name)
        {
            _id = id;
            _name = name;
            _testScores = new Dictionary<string, int>();
        }

        /// <summary>
        /// Insert a single test result
        /// </summary>
        public void AddTestResult(string courseName, int score)
        {
            _testScores.Add(courseName, score);
        }

        /// <summary>
        /// Returns the average of the test scores for the student.
        /// If no scores are present, an average of -1 is returned.
        /// </summary>
        public int ScoreAverage
        {
            get
            {
                if (_testScores.Count == 0)
                {
                    return -1;
                }
                else
                {
                    int sum = 0;

                    foreach (var testScore in _testScores.Values)
                    {
                        sum = sum + testScore;
                    }

                    return (sum / _testScores.Count);
                }
            }
        }
    }
}