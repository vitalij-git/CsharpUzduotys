using System;


namespace _1.OOP_Pradzia.models
{
    internal class School
    {
        public School()
        {

        }

        public School(string name, string city)
        {
            Name = name;
            City = city;
        }

        public string Name { get; set; }
        public string City { get; set; }
    }
}