using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    public class StatusController : ApiController
    {
        
        [NonAction]
        private async Task<bool> UpdateStatusesAsync(dynamic data, int status)
        {
            using (dbTaskEntities entities = new dbTaskEntities())
            {
                int dataID = data.Id;
                tblContacts entity = entities.tblContacts.FirstOrDefault(l => l.ID == dataID);

                if (entity != null)
                {
                    entity.Status = status;
                    await entities.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        [HttpPost]
        [ActionName("UpdateStatus")]
        [ResponseType(typeof(Contacts))]
        public async Task<IHttpActionResult> UpdateStatus([FromBody]dynamic data, int status)
        {
            try
            {
                if (!ModelState.IsValid || data == null)
                {
                    return this.BadRequest(this.ModelState);
                }
                return this.Ok<bool>(await UpdateStatus(data, status));
            }
            catch (Exception ex)
            {
                return ResponseMessage(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }
    }
}
