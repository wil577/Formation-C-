using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class BusinessSchedule
    {
        private SortedDictionary<DateTime, DateTime> _emploiTemps;
        private DateTime _endDate;
        private DateTime _beginDate;

        public BusinessSchedule()
        {
            _emploiTemps = new SortedDictionary<DateTime, DateTime>();
            _beginDate = new DateTime(2020, 01, 01);
            _endDate = new DateTime(2020, 12, 31);

        }

        public bool IsEmpty()
        {
            return (_emploiTemps.Count == 0);
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            if (IsEmpty() && begin < end)
            {
                _beginDate = begin;
                _endDate = end;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private KeyValuePair<DateTime, DateTime> ClosestElements(DateTime beginMeeting)
        {
            DateTime datemin = DateTime.MinValue;
            DateTime datemax = DateTime.MaxValue;

            foreach (DateTime meeting in _emploiTemps.Keys)
            {
                if (meeting > datemin && beginMeeting > datemin)
                {
                    datemin = meeting;
                }
                else if (meeting <= datemax && beginMeeting < datemax)
                {
                    datemax = meeting;
                    break;
                }
            }

            return new KeyValuePair<DateTime, DateTime>(datemin, datemax);
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            KeyValuePair<DateTime, DateTime> res = ClosestElements(date);

            if ((res.Key == DateTime.MinValue || _emploiTemps[res.Key] < _beginDate) && res.Value > _endDate)
            {
                _emploiTemps.Add(date, date + duration);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            return false;
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            //TODO
            return -1;
        }

        public void DisplayMeetings()
        {
            Console.WriteLine("Emploi du temps : " + _beginDate + " - " + _endDate);
            Console.WriteLine("------------------------------------------------");
            int i = 0;
            foreach (KeyValuePair<DateTime, DateTime> item in _emploiTemps)
            {
                i++;
                Console.WriteLine("Réunion " + i + "   :" + item.Key + "-" + item.Value);

            }
            Console.WriteLine("------------------------------------------------");
        }
    }
}
