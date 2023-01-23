using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Calenda : Event
    {
        private List<Event> filter;
        private List<Event> Events = new List<Event>();

        public List<Event> FilterDay(int month, int year)
        {
            filter = new List<Event>();
            foreach (Event e in Events)
            {
                if (e.StartDate.Month == month && e.StartDate.Year == year)
                {
                    filter.Add(e);
                }
            }
            return filter;
        }

        public void AddEvent(Calenda Event)
        {
            Events.Add(Event);
        }
        public List<Event> ShowEvent()
        {
            return Events;
        }
        public Calenda(string name, DateTime startDate, DateTime endDate) : base (name, startDate, endDate)
        {
        }

        public Calenda()
        {
        }
    }
}
