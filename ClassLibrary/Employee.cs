using System;

namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;

        public string Name
        { 
            get {return _name;}
            set
            {
                if (AllIsLetter(value)&& char.IsUpper (value[0]))
                    _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (AllIsLetter(value) && char.IsUpper(value[0]))
                    _surname = value;
            }
        }

        public int Salary 
        {
            get { return _salary ; }
            set
            {
                if (value >= 250)
                    _salary = value;
            }
        }
        public bool AllIsLetter(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (!string.IsNullOrWhiteSpace(str)  &&  char.IsLetter(item))
                {
                    count ++;
                }
            }
            if (count == str.Length)
            {
                return true;
            }
            return false;
        }

    
    }
}
