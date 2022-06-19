using System;
using System.Collections.Generic;
using System.IO;

namespace Inlämningsuppgift_2_Console_Application
{
    class Program
    {

        private static List<Person> persons;
        static void Main(string[] args)
        {
            // instantiate list
            persons = new List<Person>();

            // populate list with fake people 
            persons.Add(new Person("Simon", "0005132702", "Lund", 90));
            persons.Add(new Person("Pelle Jansson", "0105131980", "Ystad", 105));
            persons.Add(new Person("Anders Manör", "8005127755", "Stockanäs", 62));
            persons.Add(new Person("Karl Bertil Johnson", "6704308844", "Sankt Petersburg", 340));

            // main application loop
            while (true)
            {
                Console.WriteLine("Press A to add a person.");
                Console.WriteLine("Press V to view the list.");
                string response = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.WriteLine();
                switch (response)
                {
                    case "a":
                        AddPerson();
                        break;
                    case "v":
                        ViewList();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        /**
         * Handles user input while adding a person to the list
         */
        private static void AddPerson()
        {
            // take input from user
            Console.WriteLine("=== New Person ===");
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("\nssn: ");
            string ssn = Console.ReadLine();
            if (!SsnCheck(ssn))
            {
                Console.WriteLine("Invalid SSN. Try again.");
                AddPerson();
                return;
            }
            Console.Write("\ndistrict: ");
            string district = Console.ReadLine();
            Console.Write("\nproducts sold: ");
            string nbrSold = Console.ReadLine();
            int nbr;
            try
            {
                nbr = int.Parse(nbrSold);
            }
            catch
            {
                Console.WriteLine("Invalid input. Try again.");
                AddPerson();
                return;
            }

            // create person and add to list.
            Person person = new Person(name, ssn, district, nbr);
            persons.Add(person);
        }

        /**
         * Returns true if the social security number is valid. 
         */
        private static Boolean SsnCheck(string _ssn)
        {
            int sum = 0;
            char[] ssn = _ssn.ToCharArray();
            try
            {
                for (int i = 0; i < ssn.Length; i++)
                {
                    int factor = 1;
                    if (i % 2 == 0)
                    {
                        factor = 2;
                    }
                    int parsed = int.Parse(ssn[i].ToString()) * factor;
                    int dig1 = parsed % 10;
                    int dig2 = parsed / 10;
                    sum += dig1 + dig2; 
                }
                if (sum % 10 == 0)
                {
                    return true;
                }
            }
            catch
            {
                
            }
            return false;
        }

        /**
         * Formats the list to write it to console and file.
         */
        private static void ViewList()
        {
            // clear file
            File.Delete("output.txt");
            File.Create("output.txt").Close();
            // sort the list of persons
            persons.Sort((a, b) => b.NbrSold - a.NbrSold);
            // write header
            WriteAndPrint(String.Format("{0,25}\t{1,12}\t{2,20}\t{3,10}\n", "Name", "SSN", "District", "Amount"));
            // keep track of the tier of the previous person
            int prevTier = 4;
            // number of people per tier
            int[] ppt = PeoplePerTier();

            foreach (var person in persons)
            {
                if(person.Tier() < prevTier)
                {
                    int countInTier = ppt[4 - prevTier];
                    WriteAndPrint($"{countInTier} säljare har nått nivå {prevTier}.\n");
                    prevTier -= 1;
                }
                WritePersonLine(person);
                
            }
            WriteAndPrint($"{ppt[4-prevTier]} säljare har nått nivå {prevTier}.\n");
        }

        /**
         * Takes a person and prints the infomation
         */
        private static void WritePersonLine(Person person)
        {
            // create a formatted string so that all lines get the same alignment.
            string line = String.Format("{0,25}\t{1,12}\t{2,20}\t{3,10}", person.Name, person.Ssn, person.District, person.NbrSold);
            WriteAndPrint(line);

        }

        /**
         * Writes a given string to both console and file
         */
        private static void WriteAndPrint(string line)
        {
            using (StreamWriter writer = new StreamWriter("output.txt",append: true)) {
                writer.WriteLine(line);
            }
            Console.WriteLine(line);
        }

        /**
         * Returns a count of the people that have reached each tier. Tier 4 = index 0.
         */
        private static int[] PeoplePerTier()
        {
            int[] count = { 0, 0, 0, 0 };
            foreach (var person in persons)
            {
                if (person.NbrSold > 199) count[0]++;
                else if (person.NbrSold > 99) count[1]++;
                else if (person.NbrSold > 50) count[2]++;
                else count[3]++;
            }
            return count;
        }


    }

    /**
     * A person
     */
    class Person
    {
        private string name;
        public string Name { get { return name; } }

        private string ssn;
        public string Ssn { get { return ssn; } }

        private string district;
        public string District { get { return district; } }

        private int nbrSold;
        public int NbrSold { get { return nbrSold; } }

        public Person(string name, string ssn, string district, int nbrSold)
        {
            this.name = name;
            this.ssn = ssn;
            this.district = district;
            this.nbrSold = nbrSold;
        }

        public int Tier()
        {
            if (NbrSold > 199) return 4;
            else if (NbrSold > 99) return 3;
            else if (NbrSold > 50) return 2;
            else return 1;
        }

    }
}
