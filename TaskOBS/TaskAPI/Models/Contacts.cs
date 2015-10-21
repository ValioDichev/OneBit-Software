using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
namespace TaskAPI.Models
{
    public class Contacts
    {
        public Contacts(tblContacts _contacts)
        {
            ID = _contacts.ID;
            FName = _contacts.FirstName;
            LName = _contacts.LastName;
            Sex = _contacts.Sex;
            Phone = _contacts.Telephone;
            PhotoURL = _contacts.PhotoURL;
            Status = _contacts.Status;
        }

        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Sex { get; set; }
        public int Phone { get; set; }
        public string PhotoURL { get; set; }
        public int Status { get; set; }
    }
}