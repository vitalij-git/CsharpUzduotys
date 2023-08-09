using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._YieldAndIEnumerable.Models
{
    internal class PeopleCollection : IEnumerable<Person>
    {
        public PeopleCollection(string filePath)
        {
            FilePath = filePath;
        }

        private string FilePath { get; set; }
        public List<Person> Peoples { get; set; }= new List<Person>();
        public void AddPerson(string name, string surname, int age)
        {
            Peoples.Add(new Person(name, surname, age));
            
        }
        public IEnumerator<Person> GetEnumerator()
        {

            using (var streamReader = new StreamReader(FilePath))
            {
                string? line;
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        yield return new Person()
                        {
                            Name = parts[0].Trim(),
                            Surname = parts[1].Trim(),
                            Age = int.Parse(parts[2])
                        };
                    }
                }
            }
        }

        public void WriterToFile()
        {
            using(var streamWriter = new StreamWriter(FilePath))
            {
                foreach(var person in Peoples)
                {
                    streamWriter.WriteLine($"{person.Name.Trim()},     {person.Surname.Trim()},{person.Age}");
                }
            }
        }

       
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
