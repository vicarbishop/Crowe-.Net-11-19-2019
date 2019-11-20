using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CHWebAPI.Models;

namespace CHWebAPI.Controllers
{
    public class AEventDetailsController : ApiController
    {
        // GET api/eventdetails
        // http://localhost:51474/api/EventDetails
        public IEnumerable<AEvent> GetAlleventDetails()
        {
            AEvent AE = new AEvent();
            AEvent AE1 = new AEvent();
            List<AEvent> li = new List<AEvent>();

            AE.EventName = "Event 1";
            AE.EventSummary = "This is event 1";
            AE.EventLocation = "Naperville";
            AE.EventURL = "http://www.google.com";

            AE1.EventName = "Event 2";
            AE1.EventSummary = "This is event 2";
            AE1.EventLocation = "Oakbrook";
            AE1.EventURL = "http://www.bing.com";

            li.Add(AE);
            li.Add(AE1);
            return li;

        }

        // GET api/eventdetails/5
        //public IEnumerable<AEvent> Get(int id)
        public AEvent Get(int id)
        {
            AEvent AE = new AEvent();
            AEvent AE1 = new AEvent();
            List<AEvent> li = new List<AEvent>();
            if (id == 1)
            {
                AE.EventName = "Event 1";
                AE.EventSummary = "This is event 1";
                AE.EventLocation = "Naperville";
                AE.EventURL = "http://www.google.com";

            }
            else if( id == 2 )
            {
                AE.EventName = "Event 2";
                AE.EventSummary = "This is event 2";
                AE.EventLocation = "Oakbrook";
                AE.EventURL = "http://www.bing.com";
            }
            return AE;
        }

        // POST api/eventdetails
        public void Post([FromBody]string value)
        {
        }

        // PUT api/eventdetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/eventdetails/5
        public void Delete(int id)
        {
        }
    }
}
