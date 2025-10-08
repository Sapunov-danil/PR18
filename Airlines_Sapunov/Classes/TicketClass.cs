using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Sapunov.Classes
{
    public class TicketClass
    {
        public string price { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string time_start { get; set; }
        public string time_end { get; set; }
        public string time_way { get; set; }

        public string TimeStartTime 
        {
            get 
            {
                DateTime dt;
                if (DateTime.TryParse(time_start, out dt))
                    return dt.ToString("HH:mm");
                return time_start;
            }
        }
        public string TimeStartDate
        {
            get 
            {
                DateTime dt;
                if (DateTime.TryParse(time_start, out dt))
                    return dt.ToString("dd:MMMM:yyyy");
                return "";
            }
        }
        public string TimeEndTime
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(time_end, out dt))
                    return dt.ToString("HH:mm");
                return time_end;
            }
        }
        public string TimeEndDate
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(time_end, out dt))
                    return dt.ToString("dd:MMMM:yyyy");
                return "";
            }
        }

        public TicketClass(string price, string from, string to, string time_start, string time_end, string time_way)
        {
            this.price = price;
            this.from = from;
            this.to = to;
            this.time_start = time_start;
            this.time_end = time_end;
            this.time_way = time_way;
        }
    }
}
