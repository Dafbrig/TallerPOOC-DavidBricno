using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Day : Event
    {
        private List<Event> Events;
        private DateTime today;
        public List<Event> showEvents(List<Event> Lista)
        {
            Events = new List<Event>();
            today = DateTime.Now;
            foreach (Event e in Lista)
            {
                if (e.StartDate.DayOfYear == today.DayOfYear && e.StartDate.Year == today.Year)
                {
                    Events.Add(e);
                }
            }
            return Events;
        }
        public Day (string name, DateTime startDate, DateTime endDate) : base (name, startDate, endDate)
        {

        }

        public Day()
        {
        }
    }
}
