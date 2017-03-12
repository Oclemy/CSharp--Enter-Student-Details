using System;

namespace Enter_Student_Details
{
    class Student
    {
        private string firstname, middlename, lastname;
        private DateTime dob;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
    }
}
