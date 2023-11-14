using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class DataAccess
    {
        private static string textfilepath = "PersonText.txt";

        public static void AddNewPerson(PersonModel person)
        {
            List<PersonModel> personModels = new List<PersonModel>();
            List<string> lines = new List<string>();
            personModels = getAllPeople();
            personModels.Add(person);

            foreach (PersonModel user in personModels)
            {
                lines.Add( $"{user.FirstName}|{user.LastName}");

            }

            File.WriteAllLines(textfilepath, lines);



        }


        public static List<PersonModel> getAllPeople()
        { 
            List<PersonModel> people = new List<PersonModel>();

            string[] lines = File.ReadAllLines(textfilepath);

            foreach (string line in lines)
            {
                PersonModel person = new PersonModel();

                person.FirstName = line.Split('|').GetValue(0).ToString().Trim();
                person.LastName = line.Split('|').GetValue(1).ToString().Trim();

                people.Add(person);

            }


            return people;


        }


    }
}
