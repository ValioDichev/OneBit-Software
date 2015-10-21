using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using System.Collections;
using System.Web.Http.Description;
using TaskOBS.Models;
using Newtonsoft.Json;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;


namespace TaskOBS.Controllers
{
    public class ContactsController : Controller
    {
        protected dbTaskEntities entites;
        public dbTaskEntities _entites
        {
            get
            {
                if (entites == null)
                {
                    return entites = new dbTaskEntities();
                }
                return entites;
            }
        }

        //// GET: Contacts
        //private async Task<List<tblContacts>> GetAllContactsAsync()
        //{

        //    return await this._entites.tblContacts.ToListAsync();
        //}

        //public async Task<ActionResult> GetAllContacts()
        //{
        //    try
        //    {
        //        List<tblContacts> GetAllContacts = await this.GetAllContactsAsync();

        //        if (GetAllContacts == null)
        //        {
        //            return this.HttpNotFound();
        //        }

        //        return Content(GetAllContacts.ToString(), "application/json");
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}\
        public ActionResult getContacts()
        {
            List<Contacts> contactsItems = new List<Contacts>();
            foreach (tblContacts item in _entites.tblContacts)
            {
                contactsItems.Add(new Contacts(item));
            }
            return View(contactsItems);
        }
    }
}