using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace DummyData
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Are you sure you want to fill the db ? y/n");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.KeyChar == 'y')
            {
                DbFiller filler = new DbFiller();
                int status = filler.Fill();

                if (status > 0) //Success
                {
                    Console.WriteLine("Successfully added dummy data to db");
                }
                else
                {
                    Console.WriteLine("There was problem adding the dummy data to db");
                }

            }
            else if (info.KeyChar == 'n') Environment.Exit(0);
            else
            {
                Console.WriteLine("Please enter y for fill and n to aboard");
            }
            Console.ReadKey();
        }
    }

    public class DbFiller
    {
        private dbTaskEntities entities;
        public dbTaskEntities Entities
        {
            get
            {
                if (entities == null)
                {
                    return entities = new dbTaskEntities();
                }
                return entities;
            }
        }

        public int Fill()
        {
            List<tblContacts> contactsTbleHere = new List<tblContacts>()
            {
                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },

                new tblContacts()
                {
                    FirstName = "Random",
                    LastName = "Test",
                    Telephone = 1234657890,
                    PhotoURL = "https://www.google.bg/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png",
                    Status = 1,
                    Sex = "Male"
                },
            };

            contactsTbleHere.ForEach(n => Entities.tblContacts.Add(n));
            return Entities.SaveChanges();
        }
    }
}
