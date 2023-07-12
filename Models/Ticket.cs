using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticketIt.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public int Status_id { get; set; }

        public int Priority_id { get; set; }

        public int User_id { get; set; }

        public int Agent_id { get; set; }

        public int Category_id { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }

        public DateTime Completed_at { get; set; }

    }
}