using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Week_7_Tutorial
{
    class Employee
    {
        public string name;
        public int id;
        public Gender gender;

        public override string ToString()
        {
            string s = "Name: " + name + ", ID: " + id + ", Gender: " + gender;
            return s;
        }
    }
}
