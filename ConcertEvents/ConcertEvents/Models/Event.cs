using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConcertEvents.Models
{
    public class Event
    {
        public int Id { get; set; }

        [DisplayName("Event Name")]
        public string Name { get; set; }
       

        public virtual List<Comment> Comments { get; set; }

       

      //  public virtual ApplicationUser ApplicationUser { get; set; }
    }
}