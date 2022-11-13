using System;
using System.Linq;
using System.Collections.Generic;

namespace T07.OrderByAge
{
    class Human
    {
        public Human(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Human> people = new List<Human>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] @params = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = @params[0];
                string id = @params[1];
                int age = int.Parse(@params[2]);

                bool isDone = false;
                foreach (Human human in people)
                {
                    if (human.ID == id)
                    {
                        human.Name = name;
                        human.Age = age;
                        isDone = true;
                        break;
                    }
                }
                if (isDone)
                {
                    continue;
                }

                Human newHuman = new Human(name, id, age);
                people.Add(newHuman);
            }

            List<Human> orderedPeople = people.OrderBy(t => t.Age).ToList();
            foreach (Human human in orderedPeople)
            {
                Console.WriteLine($"{human.Name} with ID: {human.ID} is {human.Age} years old.");
            }
        }
    }
}
