using System;

namespace StudentNameSpace
{
    public class StudentInfo
    {
        private string _firstName;
        private string _lastName;
        private string _studentID;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public StudentInfo(string firstName, string lastName, string studentID)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentID = studentID;
        }

        public StudentInfo()
        {
        }
    }
}
