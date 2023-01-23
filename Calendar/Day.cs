using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Day
    {
        private string _name;
        private DateTime _startDate;
        private DateTime _endDate;
        public Day(string name, DateTime startDate, DateTime endDate) { 
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
        }
    }
}
